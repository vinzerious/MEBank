using System.Data;
using Microsoft.Data.Sqlite;
using MEBankMAUI.Models;

namespace MEBankMAUI.Services;

public class BankingService
{
    private readonly string _dbPath;
    private readonly object _lock = new();

    public BankingService()
    {
        _dbPath = Path.Combine(FileSystem.AppDataDirectory, "mebank.db");
        InitializeDatabase();
        SeedAdminIfNeeded();
    }

    private SqliteConnection CreateConnection()
    {
        return new SqliteConnection($"Data Source={_dbPath}");
    }

    private void InitializeDatabase()
    {
        lock (_lock)
        {
            using var conn = CreateConnection();
            conn.Open();

            using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
CREATE TABLE IF NOT EXISTS IMEBank (
    UserID TEXT PRIMARY KEY,
    Password TEXT NOT NULL,
    CustomerID TEXT NOT NULL,
    AccountType TEXT NOT NULL,
    LastLogin TEXT NULL
);

CREATE TABLE IF NOT EXISTS Customer (
    CustomerID TEXT PRIMARY KEY,
    Name TEXT NOT NULL,
    MiddleName TEXT NULL,
    Surname TEXT NOT NULL,
    IDNo TEXT NOT NULL UNIQUE,
    Address TEXT NOT NULL,
    TelNo INTEGER NOT NULL,
    CreatedDate TEXT NOT NULL,
    CreatedUser TEXT NOT NULL,
    LastUpdatedDate TEXT NULL,
    LastUpdatedUser TEXT NULL
);

CREATE TABLE IF NOT EXISTS BankAccount (
    IBANNo TEXT PRIMARY KEY,
    CustomerID TEXT NOT NULL,
    AccountType TEXT NOT NULL,
    Amount REAL NOT NULL,
    CreatedDate TEXT NOT NULL,
    CreatedUser TEXT NOT NULL,
    LastUpdatedDate TEXT NULL,
    LastUpdatedUser TEXT NULL
);

CREATE TABLE IF NOT EXISTS [Transaction] (
    TransactionID TEXT PRIMARY KEY,
    SourceIBANNo TEXT NOT NULL,
    DestIBANNo TEXT NOT NULL,
    TransactionType TEXT NOT NULL,
    Amount REAL NOT NULL,
    Fee REAL NOT NULL,
    TransactionDate TEXT NOT NULL,
    TransactionUser TEXT NOT NULL
);
";
            cmd.ExecuteNonQuery();

            EnsureImeBankSchema(conn);
        }
    }

    private static void EnsureImeBankSchema(SqliteConnection conn)
    {
        if (HasColumn(conn, "IMEBank", "FullName"))
        {
            return;
        }

        using var alter = conn.CreateCommand();
        alter.CommandText = "ALTER TABLE IMEBank ADD COLUMN FullName TEXT NULL;";
        alter.ExecuteNonQuery();
    }

    private static bool HasColumn(SqliteConnection conn, string tableName, string columnName)
    {
        using var pragma = conn.CreateCommand();
        pragma.CommandText = $"PRAGMA table_info({tableName});";

        using var reader = pragma.ExecuteReader();
        while (reader.Read())
        {
            var existing = reader.GetString(1);
            if (string.Equals(existing, columnName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    private void SeedAdminIfNeeded()
    {
        using var conn = CreateConnection();
        conn.Open();

        using var check = conn.CreateCommand();
        check.CommandText = "SELECT COUNT(1) FROM IMEBank WHERE UserID = 'banksystemadmin';";
        var exists = Convert.ToInt32(check.ExecuteScalar());

        if (exists > 0) return;

        using var insert = conn.CreateCommand();
        insert.CommandText = @"
INSERT INTO IMEBank(UserID, Password, CustomerID, AccountType, LastLogin, FullName)
VALUES ('banksystemadmin', 'MEBank[00001]', 'I00001', 'Admin', @now, 'Bank System Admin');
";
        insert.Parameters.AddWithValue("@now", DateTime.UtcNow.ToString("o"));
        insert.ExecuteNonQuery();
    }

    public string GetFullNameByUserId(string userId)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var profile = conn.CreateCommand();
        profile.CommandText = @"
SELECT FullName, CustomerID
FROM IMEBank
WHERE UserID=@u
LIMIT 1;";
        profile.Parameters.AddWithValue("@u", userId);

        using var reader = profile.ExecuteReader();
        if (!reader.Read())
        {
            return string.Empty;
        }

        var fullName = reader.IsDBNull(0) ? string.Empty : reader.GetString(0).Trim();
        if (!string.IsNullOrWhiteSpace(fullName))
        {
            return fullName;
        }

        var customerId = reader.GetString(1);
        using var customer = conn.CreateCommand();
        customer.CommandText = @"
SELECT Name, MiddleName, Surname
FROM Customer
WHERE CustomerID=@c
LIMIT 1;";
        customer.Parameters.AddWithValue("@c", customerId);

        using var customerReader = customer.ExecuteReader();
        if (!customerReader.Read())
        {
            return string.Empty;
        }

        var first = customerReader.IsDBNull(0) ? string.Empty : customerReader.GetString(0).Trim();
        var middle = customerReader.IsDBNull(1) ? string.Empty : customerReader.GetString(1).Trim();
        var last = customerReader.IsDBNull(2) ? string.Empty : customerReader.GetString(2).Trim();

        var pieces = new List<string>();
        if (!string.IsNullOrWhiteSpace(first)) pieces.Add(first);
        if (!string.IsNullOrWhiteSpace(middle)) pieces.Add(middle);
        if (!string.IsNullOrWhiteSpace(last)) pieces.Add(last);

        return string.Join(" ", pieces);
    }

    public (bool ok, string error) UpdateFullName(string userId, string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName))
        {
            return (false, "Please enter full name");
        }

        using var conn = CreateConnection();
        conn.Open();

        using var update = conn.CreateCommand();
        update.CommandText = "UPDATE IMEBank SET FullName=@n WHERE UserID=@u;";
        update.Parameters.AddWithValue("@n", fullName.Trim());
        update.Parameters.AddWithValue("@u", userId);
        var rows = update.ExecuteNonQuery();

        return rows == 0 ? (false, "User not found") : (true, string.Empty);
    }

    public (bool ok, string error, string fullName, List<string> accounts) GetRecipientInfoByUserId(string userId)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var check = conn.CreateCommand();
        check.CommandText = "SELECT COUNT(1) FROM IMEBank WHERE UserID=@u;";
        check.Parameters.AddWithValue("@u", userId);
        var exists = Convert.ToInt32(check.ExecuteScalar());
        if (exists == 0)
        {
            return (false, "Username not found", string.Empty, new List<string>());
        }

        var fullName = GetFullNameByUserId(userId);
        if (string.IsNullOrWhiteSpace(fullName))
        {
            fullName = "Unknown User";
        }

        var accounts = GetAccountListByUserId(userId);
        if (accounts.Count == 0)
        {
            return (false, "No opened account for this username", fullName, accounts);
        }

        return (true, string.Empty, fullName, accounts);
    }

    public (bool ok, string error, string accountType, string customerId) Login(string userId, string password)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT AccountType, CustomerID
FROM IMEBank
WHERE UserID=@usr AND Password=@pwd
LIMIT 1;";
        cmd.Parameters.AddWithValue("@usr", userId);
        cmd.Parameters.AddWithValue("@pwd", password);

        using var reader = cmd.ExecuteReader();
        if (!reader.Read())
        {
            return (false, "Username or password is incorrect.", "", "");
        }

        var accountType = reader.GetString(0);
        var customerId = reader.GetString(1);

        using var update = conn.CreateCommand();
        update.CommandText = "UPDATE IMEBank SET LastLogin=@now WHERE UserID=@usr;";
        update.Parameters.AddWithValue("@now", DateTime.UtcNow.ToString("o"));
        update.Parameters.AddWithValue("@usr", userId);
        update.ExecuteNonQuery();

        return (true, "", accountType, customerId);
    }

    public (bool ok, string error, string customerId) RegisterCustomer(
        string name, string middleName, string surname, string idNo, string address, string telNo, string createdBy)
    {
        if (!long.TryParse(telNo, out _))
        {
            return (false, "Please input only numeric in telephone number", "");
        }

        using var conn = CreateConnection();
        conn.Open();

        using var check = conn.CreateCommand();
        check.CommandText = "SELECT COUNT(1) FROM Customer WHERE IDNo=@id;";
        check.Parameters.AddWithValue("@id", idNo);
        var idExists = Convert.ToInt32(check.ExecuteScalar());
        if (idExists > 0)
        {
            return (false, "ID already exists", "");
        }

        var customerId = "C" + DateTime.UtcNow.Ticks.ToString()[^8..];

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT INTO Customer(CustomerID, Name, MiddleName, Surname, IDNo, Address, TelNo, CreatedDate, CreatedUser)
VALUES (@cid, @n, @mn, @s, @id, @addr, @tel, @cd, @cu);";
        cmd.Parameters.AddWithValue("@cid", customerId);
        cmd.Parameters.AddWithValue("@n", name);
        cmd.Parameters.AddWithValue("@mn", middleName ?? "");
        cmd.Parameters.AddWithValue("@s", surname);
        cmd.Parameters.AddWithValue("@id", idNo);
        cmd.Parameters.AddWithValue("@addr", address);
        cmd.Parameters.AddWithValue("@tel", Convert.ToInt64(telNo));
        cmd.Parameters.AddWithValue("@cd", DateTime.UtcNow.ToString("o"));
        cmd.Parameters.AddWithValue("@cu", createdBy);
        cmd.ExecuteNonQuery();

        return (true, "", customerId);
    }

    public (bool ok, string error, string id) RegisterImeBank(
        string userId, string password, string customerId, string accountType)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var checkUser = conn.CreateCommand();
        checkUser.CommandText = "SELECT COUNT(1) FROM IMEBank WHERE UserID=@u;";
        checkUser.Parameters.AddWithValue("@u", userId);
        var userExists = Convert.ToInt32(checkUser.ExecuteScalar());
        if (userExists > 0)
        {
            return (false, "User ID already exists", "");
        }

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT INTO IMEBank(UserID, Password, CustomerID, AccountType, LastLogin)
VALUES (@u, @p, @c, @a, NULL);";
        cmd.Parameters.AddWithValue("@u", userId);
        cmd.Parameters.AddWithValue("@p", password);
        cmd.Parameters.AddWithValue("@c", customerId);
        cmd.Parameters.AddWithValue("@a", accountType);
        cmd.ExecuteNonQuery();

        return (true, "", customerId);
    }

    public (bool ok, string error) OpenAccount(
        string ibanNo, string customerId, string accountType, decimal amount, string createdBy)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var check = conn.CreateCommand();
        check.CommandText = "SELECT COUNT(1) FROM BankAccount WHERE IBANNo=@i;";
        check.Parameters.AddWithValue("@i", ibanNo);
        var exists = Convert.ToInt32(check.ExecuteScalar());
        if (exists > 0)
        {
            return (false, "IBAN already exists");
        }

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT INTO BankAccount(IBANNo, CustomerID, AccountType, Amount, CreatedDate, CreatedUser)
VALUES (@i, @c, @a, @amt, @cd, @cu);";
        cmd.Parameters.AddWithValue("@i", ibanNo);
        cmd.Parameters.AddWithValue("@c", customerId);
        cmd.Parameters.AddWithValue("@a", accountType);
        cmd.Parameters.AddWithValue("@amt", amount);
        cmd.Parameters.AddWithValue("@cd", DateTime.UtcNow.ToString("o"));
        cmd.Parameters.AddWithValue("@cu", createdBy);
        cmd.ExecuteNonQuery();

        return (true, "");
    }

    public List<string> GetAccountList(string customerId)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT IBANNo FROM BankAccount WHERE CustomerID=@c ORDER BY IBANNo;";
        cmd.Parameters.AddWithValue("@c", customerId);

        using var reader = cmd.ExecuteReader();
        var result = new List<string>();
        while (reader.Read())
        {
            result.Add(reader.GetString(0));
        }

        return result;
    }

    public List<string> GetAccountListByUserId(string userId)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT ba.IBANNo
FROM IMEBank ib
INNER JOIN BankAccount ba ON ba.CustomerID = ib.CustomerID
WHERE ib.UserID = @u
ORDER BY ba.IBANNo;";
        cmd.Parameters.AddWithValue("@u", userId);

        using var reader = cmd.ExecuteReader();
        var result = new List<string>();
        while (reader.Read())
        {
            result.Add(reader.GetString(0));
        }

        return result;
    }

    public decimal GetBalance(string ibanNo)
    {
        using var conn = CreateConnection();
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT Amount FROM BankAccount WHERE IBANNo=@i LIMIT 1;";
        cmd.Parameters.AddWithValue("@i", ibanNo);
        var val = cmd.ExecuteScalar();
        return val == null || val == DBNull.Value ? 0m : Convert.ToDecimal(val);
    }

    public (bool ok, string error) Deposit(string ibanNo, decimal amount, string user)
    {
        if (amount <= 0) return (false, "Amount must be greater than zero");

        using var conn = CreateConnection();
        conn.Open();
        using var tx = conn.BeginTransaction();

        var fee = Math.Round(amount * 0.001m, 2);
        var net = amount - fee;

        using (var update = conn.CreateCommand())
        {
            update.Transaction = tx;
            update.CommandText = @"
UPDATE BankAccount
SET Amount = Amount + @net, LastUpdatedDate=@d, LastUpdatedUser=@u
WHERE IBANNo=@i;";
            update.Parameters.AddWithValue("@net", net);
            update.Parameters.AddWithValue("@d", DateTime.UtcNow.ToString("o"));
            update.Parameters.AddWithValue("@u", user);
            update.Parameters.AddWithValue("@i", ibanNo);
            if (update.ExecuteNonQuery() == 0)
            {
                tx.Rollback();
                return (false, "IBAN not found");
            }
        }

        var txnId = NewTxnId("MBD");

        using (var txn = conn.CreateCommand())
        {
            txn.Transaction = tx;
            txn.CommandText = @"
INSERT INTO [Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
VALUES (@id, @s, @d, 'Deposit (Online)', @amt, @fee, @dt, @u);";
            txn.Parameters.AddWithValue("@id", txnId);
            txn.Parameters.AddWithValue("@s", ibanNo);
            txn.Parameters.AddWithValue("@d", ibanNo);
            txn.Parameters.AddWithValue("@amt", amount);
            txn.Parameters.AddWithValue("@fee", fee);
            txn.Parameters.AddWithValue("@dt", DateTime.UtcNow.ToString("o"));
            txn.Parameters.AddWithValue("@u", user);
            txn.ExecuteNonQuery();
        }

        tx.Commit();
        return (true, "");
    }

    public (bool ok, string error) Withdraw(string ibanNo, decimal amount, string user)
    {
        if (amount <= 0) return (false, "Amount must be greater than zero");

        using var conn = CreateConnection();
        conn.Open();
        using var tx = conn.BeginTransaction();

        decimal balance;
        using (var bal = conn.CreateCommand())
        {
            bal.Transaction = tx;
            bal.CommandText = "SELECT Amount FROM BankAccount WHERE IBANNo=@i LIMIT 1;";
            bal.Parameters.AddWithValue("@i", ibanNo);
            var val = bal.ExecuteScalar();
            if (val == null || val == DBNull.Value)
            {
                tx.Rollback();
                return (false, "IBAN not found");
            }

            balance = Convert.ToDecimal(val);
            if (balance < amount)
            {
                tx.Rollback();
                return (false, "Insufficient balance");
            }
        }

        using (var update = conn.CreateCommand())
        {
            update.Transaction = tx;
            update.CommandText = @"
UPDATE BankAccount
SET Amount = Amount - @amt, LastUpdatedDate=@d, LastUpdatedUser=@u
WHERE IBANNo=@i;";
            update.Parameters.AddWithValue("@amt", amount);
            update.Parameters.AddWithValue("@d", DateTime.UtcNow.ToString("o"));
            update.Parameters.AddWithValue("@u", user);
            update.Parameters.AddWithValue("@i", ibanNo);
            update.ExecuteNonQuery();
        }

        var txnId = NewTxnId("MBW");
        using (var txn = conn.CreateCommand())
        {
            txn.Transaction = tx;
            txn.CommandText = @"
INSERT INTO [Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
VALUES (@id, @s, @d, 'Withdraw', @amt, 0, @dt, @u);";
            txn.Parameters.AddWithValue("@id", txnId);
            txn.Parameters.AddWithValue("@s", ibanNo);
            txn.Parameters.AddWithValue("@d", ibanNo);
            txn.Parameters.AddWithValue("@amt", amount);
            txn.Parameters.AddWithValue("@dt", DateTime.UtcNow.ToString("o"));
            txn.Parameters.AddWithValue("@u", user);
            txn.ExecuteNonQuery();
        }

        tx.Commit();
        return (true, "");
    }

    public (bool ok, string error) Transfer(string fromIban, string toIban, decimal amount, string user)
    {
        if (amount <= 0) return (false, "Amount must be greater than zero");
        if (fromIban == toIban) return (false, "Please input different account number");

        using var conn = CreateConnection();
        conn.Open();
        using var tx = conn.BeginTransaction();

        decimal fromBalance;
        using (var fromCmd = conn.CreateCommand())
        {
            fromCmd.Transaction = tx;
            fromCmd.CommandText = "SELECT Amount FROM BankAccount WHERE IBANNo=@i LIMIT 1;";
            fromCmd.Parameters.AddWithValue("@i", fromIban);
            var fromVal = fromCmd.ExecuteScalar();
            if (fromVal == null || fromVal == DBNull.Value)
            {
                tx.Rollback();
                return (false, "Source IBAN not found");
            }

            fromBalance = Convert.ToDecimal(fromVal);
            if (fromBalance < amount)
            {
                tx.Rollback();
                return (false, "Insufficient balance");
            }
        }

        using (var toCmd = conn.CreateCommand())
        {
            toCmd.Transaction = tx;
            toCmd.CommandText = "SELECT COUNT(1) FROM BankAccount WHERE IBANNo=@i;";
            toCmd.Parameters.AddWithValue("@i", toIban);
            var toExists = Convert.ToInt32(toCmd.ExecuteScalar());
            if (toExists == 0)
            {
                tx.Rollback();
                return (false, "IBAN No of recipient is incorrect");
            }
        }

        using (var debit = conn.CreateCommand())
        {
            debit.Transaction = tx;
            debit.CommandText = @"
UPDATE BankAccount
SET Amount = Amount - @amt, LastUpdatedDate=@d, LastUpdatedUser=@u
WHERE IBANNo=@i;";
            debit.Parameters.AddWithValue("@amt", amount);
            debit.Parameters.AddWithValue("@d", DateTime.UtcNow.ToString("o"));
            debit.Parameters.AddWithValue("@u", user);
            debit.Parameters.AddWithValue("@i", fromIban);
            debit.ExecuteNonQuery();
        }

        using (var credit = conn.CreateCommand())
        {
            credit.Transaction = tx;
            credit.CommandText = @"
UPDATE BankAccount
SET Amount = Amount + @amt, LastUpdatedDate=@d, LastUpdatedUser=@u
WHERE IBANNo=@i;";
            credit.Parameters.AddWithValue("@amt", amount);
            credit.Parameters.AddWithValue("@d", DateTime.UtcNow.ToString("o"));
            credit.Parameters.AddWithValue("@u", user);
            credit.Parameters.AddWithValue("@i", toIban);
            credit.ExecuteNonQuery();
        }

        var txnId = NewTxnId("MBT");
        using (var txn = conn.CreateCommand())
        {
            txn.Transaction = tx;
            txn.CommandText = @"
INSERT INTO [Transaction](TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser)
VALUES (@id, @s, @d, 'Transfer In (Online)', @amt, 0, @dt, @u);";
            txn.Parameters.AddWithValue("@id", txnId);
            txn.Parameters.AddWithValue("@s", fromIban);
            txn.Parameters.AddWithValue("@d", toIban);
            txn.Parameters.AddWithValue("@amt", amount);
            txn.Parameters.AddWithValue("@dt", DateTime.UtcNow.ToString("o"));
            txn.Parameters.AddWithValue("@u", user);
            txn.ExecuteNonQuery();
        }

        tx.Commit();
        return (true, "");
    }

    public List<Transaction> GetTransactionLogs(string accountType, string customerId)
    {
        using var conn = CreateConnection();
        conn.Open();

        var role = accountType?.Trim() ?? string.Empty;
        var isCustomerScoped = string.Equals(role, "Customer", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(role, "Business", StringComparison.OrdinalIgnoreCase);

        using var cmd = conn.CreateCommand();
        if (isCustomerScoped)
        {
            cmd.CommandText = @"
SELECT DISTINCT t.TransactionID, t.SourceIBANNo, t.DestIBANNo, t.TransactionType, t.Amount, t.Fee, t.TransactionDate, t.TransactionUser
FROM [Transaction] t
INNER JOIN BankAccount ba ON ba.IBANNo = t.SourceIBANNo OR ba.IBANNo = t.DestIBANNo
WHERE ba.CustomerID = @customerId
ORDER BY t.TransactionDate DESC;";
            cmd.Parameters.AddWithValue("@customerId", customerId);
        }
        else
        {
            cmd.CommandText = @"
SELECT TransactionID, SourceIBANNo, DestIBANNo, TransactionType, Amount, Fee, TransactionDate, TransactionUser
FROM [Transaction]
ORDER BY TransactionDate DESC;";
        }

        using var reader = cmd.ExecuteReader();
        var result = new List<Transaction>();
        while (reader.Read())
        {
            result.Add(new Transaction
            {
                TransactionID = reader.GetString(0),
                SourceIBANNo = reader.GetString(1),
                DestIBANNo = reader.GetString(2),
                TransactionType = reader.GetString(3),
                Amount = reader.GetDecimal(4),
                Fee = reader.GetDecimal(5),
                TransactionDate = DateTime.TryParse(reader.GetString(6), out var transactionDate) ? transactionDate : DateTime.MinValue,
                TransactionUser = reader.GetString(7)
            });
        }

        return result;
    }

    private static string NewTxnId(string prefix)
    {
        return $"{prefix}{DateTime.UtcNow:yyyyMMddHHmmssfff}";
    }
}