using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class DepositPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _loggedInId;

    private readonly Entry _txtUserId;
    private readonly Picker _cmbAccountList = new() { Title = "Select Account" };
    private readonly Entry _txtAmount = new() { Placeholder = "Amount", Keyboard = Keyboard.Numeric };
    private readonly Label _lblBalance = new() { Text = "Balance: -" };

    public DepositPage(BankingService bankingService, string userId, string loggedInId)
    {
        _bankingService = bankingService;
        _loggedInId = loggedInId;
        Title = "Deposit";

        _txtUserId = new Entry { Placeholder = "Username", Text = userId };

        var btnGetAccounts = new Button { Text = "Get Account List" };
        btnGetAccounts.Clicked += OnGetAccountsClicked;

        var btnGetBalance = new Button { Text = "Get Balance" };
        btnGetBalance.Clicked += (_, _) => ShowBalance();

        var btnDeposit = new Button { Text = "Deposit" };
        btnDeposit.Clicked += OnDepositClicked;

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 12,
                Children =
                {
                    _txtUserId,
                    btnGetAccounts,
                    _cmbAccountList,
                    btnGetBalance,
                    _lblBalance,
                    _txtAmount,
                    btnDeposit
                }
            }
        };
    }

    private async void OnGetAccountsClicked(object? sender, EventArgs e)
    {
        _cmbAccountList.Items.Clear();
        _lblBalance.Text = "Balance: -";

        if (string.IsNullOrWhiteSpace(_txtUserId.Text))
        {
            await DisplayAlert("Error", "Please enter username", "OK");
            return;
        }

        var list = _bankingService.GetAccountListByUserId(_txtUserId.Text.Trim());
        if (list.Count == 0)
        {
            await DisplayAlert("Error", "No account found for this username", "OK");
            return;
        }

        foreach (var item in list) _cmbAccountList.Items.Add(item);
        _cmbAccountList.SelectedIndex = 0;
        ShowBalance();
    }

    private void ShowBalance()
    {
        if (_cmbAccountList.SelectedIndex < 0) return;
        var iban = _cmbAccountList.Items[_cmbAccountList.SelectedIndex];
        var balance = _bankingService.GetBalance(iban);
        _lblBalance.Text = $"Balance: {balance:N2}";
    }

    private async void OnDepositClicked(object? sender, EventArgs e)
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
        var result = _bankingService.Deposit(iban, amount, _loggedInId);
        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", "Deposited successfully", "OK");
        ShowBalance();
    }
}