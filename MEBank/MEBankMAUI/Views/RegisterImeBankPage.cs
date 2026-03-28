using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class RegisterImeBankPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _currentAccountType;
    private readonly string _loggedInId;
    private string _selectedAccountType = string.Empty;

    private readonly Entry _txtUserId = new() { Placeholder = "User ID" };
    private readonly Entry _txtPassword = new() { Placeholder = "Password", IsPassword = true };
    private readonly Entry _txtCustomerId = new() { Placeholder = "Customer ID" };
    private readonly VerticalStackLayout _accountTypeOptions = new() { Spacing = 8 };

    public RegisterImeBankPage(BankingService bankingService, string accountType, string customerId, string loggedInId)
    {
        _bankingService = bankingService;
        _currentAccountType = accountType;
        _loggedInId = loggedInId;
        Title = "Register IMEBank";

        var isAdmin = string.Equals(accountType?.Trim(), "Admin", StringComparison.OrdinalIgnoreCase);
        var isBank = string.Equals(accountType?.Trim(), "Bank", StringComparison.OrdinalIgnoreCase);

        if (isAdmin)
        {
            AddAccountTypeOption("Admin");
            AddAccountTypeOption("Bank");
            AddAccountTypeOption("Bank Teller");
            _txtCustomerId.IsEnabled = false;
            _txtCustomerId.Text = $"I{DateTime.UtcNow.Ticks.ToString()[^5..]}";
        }
        else if (isBank)
        {
            AddAccountTypeOption("Customer");
            AddAccountTypeOption("Business");
            _txtCustomerId.Text = customerId;
        }
        else
        {
            AddAccountTypeOption("Customer");
        }

        var btnRegister = new Button { Text = "Register" };
        btnRegister.Clicked += OnRegisterClicked;

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 12,
                Children =
                {
                    _txtUserId,
                    _txtPassword,
                    _txtCustomerId,
                    new Label { Text = "Account Type", FontAttributes = FontAttributes.Bold },
                    _accountTypeOptions,
                    btnRegister
                }
            }
        };
    }

    private void AddAccountTypeOption(string accountType)
    {
        var option = new RadioButton
        {
            Content = accountType,
            Value = accountType,
            GroupName = "register-account-type"
        };

        option.CheckedChanged += (_, args) =>
        {
            if (args.Value)
            {
                _selectedAccountType = accountType;
            }
        };

        if (_accountTypeOptions.Children.Count == 0)
        {
            option.IsChecked = true;
            _selectedAccountType = accountType;
        }

        _accountTypeOptions.Children.Add(option);
    }

    private async void OnRegisterClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_txtUserId.Text))
        {
            await DisplayAlert("Error", "Please enter User ID", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_txtPassword.Text))
        {
            await DisplayAlert("Error", "Please enter password", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_txtCustomerId.Text))
        {
            await DisplayAlert("Error", "Please enter Customer ID", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_selectedAccountType))
        {
            await DisplayAlert("Error", "Please select account type", "OK");
            return;
        }

        var result = _bankingService.RegisterImeBank(
            _txtUserId.Text.Trim(),
            _txtPassword.Text,
            _txtCustomerId.Text.Trim(),
            _selectedAccountType);

        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", $"Successfully created. ID is {result.id}", "OK");

        if (_currentAccountType == "New")
        {
            await Navigation.PopToRootAsync();
        }
        else
        {
            await Navigation.PopAsync();
        }
    }
}