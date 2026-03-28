using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class OpenAccountPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _loggedInId;
    private readonly string _accountType;

    private readonly Entry _txtIban = new() { Placeholder = "IBAN" };
    private readonly Entry _txtCustomerId = new() { Placeholder = "Customer ID" };
    private readonly Entry _txtAmount = new() { Placeholder = "Amount", Keyboard = Keyboard.Numeric };
    private readonly Picker _cmbAccountType = new() { Title = "Account Type" };

    public OpenAccountPage(BankingService bankingService, string accountType, string customerId, string loggedInId)
    {
        _bankingService = bankingService;
        _loggedInId = loggedInId;
        _accountType = accountType;

        Title = "Open Account";

        _txtIban.Text = GenerateIban();
        _txtCustomerId.Text = customerId;

        _cmbAccountType.Items.Add("Saving");
        _cmbAccountType.Items.Add("Fixed Deposit");
        if (accountType == "Bank") _cmbAccountType.Items.Add("Business");

        if (accountType == "Customer")
        {
            _txtCustomerId.IsEnabled = false;
            _txtAmount.Text = "0";
            _txtAmount.IsEnabled = false;
        }

        var btnOpen = new Button { Text = "Open Account" };
        btnOpen.Clicked += OnOpenClicked;

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 12,
                Children =
                {
                    _txtIban,
                    _txtCustomerId,
                    _cmbAccountType,
                    _txtAmount,
                    btnOpen
                }
            }
        };
    }

    private async void OnOpenClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_txtCustomerId.Text))
        {
            await DisplayAlert("Error", "Please enter Customer ID", "OK");
            return;
        }

        if (_cmbAccountType.SelectedIndex < 0)
        {
            await DisplayAlert("Error", "Please select account type", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_txtAmount.Text) || !decimal.TryParse(_txtAmount.Text, out var amount))
        {
            await DisplayAlert("Error", "Please input only numeric in amount", "OK");
            return;
        }

        var result = _bankingService.OpenAccount(
            _txtIban.Text!.Trim(),
            _txtCustomerId.Text.Trim(),
            _cmbAccountType.Items[_cmbAccountType.SelectedIndex],
            amount,
            _loggedInId);

        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", $"Open account successfully: {_txtIban.Text}", "OK");
        _txtIban.Text = GenerateIban();
        if (_accountType != "Customer")
        {
            _txtCustomerId.Text = "";
            _txtAmount.Text = "";
        }
    }

    private static string GenerateIban()
    {
        var rnd = Random.Shared.Next(100000000, 999999999);
        return $"NL00MEBA{rnd}";
    }
}