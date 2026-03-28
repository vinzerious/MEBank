namespace MEBankMAUI.Models;

public class BankAccount
{
    public string IBANNo { get; set; } = string.Empty;
    public string CustomerID { get; set; } = string.Empty;
    public string AccountType { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedUser { get; set; } = string.Empty;
    public DateTime? LastUpdatedDate { get; set; }
    public string? LastUpdatedUser { get; set; }
}