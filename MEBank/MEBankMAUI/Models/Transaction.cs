namespace MEBankMAUI.Models;

public class Transaction
{
    public string TransactionID { get; set; } = string.Empty;
    public string SourceIBANNo { get; set; } = string.Empty;
    public string DestIBANNo { get; set; } = string.Empty;
    public string TransactionType { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public decimal Fee { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionUser { get; set; } = string.Empty;
}