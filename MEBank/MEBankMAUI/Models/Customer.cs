// Customer model for MEBank database

namespace MEBankMAUI.Models
{
    public class Customer
    {
        public string CustomerID { get; set; } = "";
        public string Name { get; set; } = "";
        public string MiddleName { get; set; } = "";
        public string Surname { get; set; } = "";
        public string IDNo { get; set; } = "";
        public string Address { get; set; } = "";
        public int TelNo { get; set; }

        // Navigation properties
        public List<BankAccount> Accounts { get; set; } = new();

        // MAUI navigation
        public string? ToStringPage() => "Profile";
    }
}