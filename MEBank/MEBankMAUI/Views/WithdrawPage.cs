using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class WithdrawPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _loggedInId;

    private readonly Entry _txtCustomerId;
    private readonly Picker _cmbAccountList = new() { Title = "Select Account" };
    private readonly Entry _txtAmount = new() { Placeholder = "Amount", Keyboard = Keyboard.Numeric };
    private readonly Label _lblBalance = new() { Text = "Balance: -" };

    public WithdrawPage(BankingService bankingService, string customerId, string loggedInId)
    {
        _bankingService = bankingService;
        _loggedInId = loggedInId;
        Title = "Withdraw";

        _txtCustomerId = new Entry { Placeholder = "Customer ID", Text = customerId };

        var btnGetAccounts = new Button { Text = "Get Account List" };
        btnGetAccounts.Clicked += (_, _) => LoadAccounts();

        var btnGetBalance = new Button { Text = "Get Balance" };
        btnGetBalance.Clicked += (_, _) => ShowBalance();

        var btnWithdraw = new Button { Text = "Withdraw" };
        btnWithdraw.Clicked += OnWithdrawClicked;

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 12,
                Children =
                {
                    _txtCustomerId,
                    btnGetAccounts,
                    _cmbAccountList,
                    btnGetBalance,
                    _lblBalance,
                    _txtAmount,
                    btnWithdraw
                }
            }
        };
    }

    private void LoadAccounts()
    {
        _cmbAccountList.Items.Clear();
        if (string.IsNullOrWhiteSpace(_txtCustomerId.Text)) return;
        var list = _bankingService.GetAccountList(_txtCustomerId.Text.Trim());
        foreach (var item in list) _cmbAccountList.Items.Add(item);
    }

    private void ShowBalance()
    {
        if (_cmbAccountList.SelectedIndex < 0) return;
        var iban = _cmbAccountList.Items[_cmbAccountList.SelectedIndex];
        var balance = _bankingService.GetBalance(iban);
        _lblBalance.Text = $"Balance: {balance:N2}";
    }

    private async void OnWithdrawClicked(object? sender, EventArgs e)
    {
        if (_cmbAccountList.SelectedIndex < 0)
        {
            await DisplayAlert("Error", "Please select account number", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_txtAmount.Text) || !decimal.TryParse(_txtAmount.Text, out var amount))
        {
            await DisplayAlert("Error", "Please enter only numeric in amount", "OK");
            return;
        }

        var iban = _cmbAccountList.Items[_cmbAccountList.SelectedIndex];
        var result = _bankingService.Withdraw(iban, amount, _loggedInId);
        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", "Withdrawn successfully", "OK");
        ShowBalance();
    }
}