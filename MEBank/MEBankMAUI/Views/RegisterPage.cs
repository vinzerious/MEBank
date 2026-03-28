using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class RegisterPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _loggedInId;

    private readonly Entry _txtName = new() { Placeholder = "Name" };
    private readonly Entry _txtMiddleName = new() { Placeholder = "Middle Name" };
    private readonly Entry _txtSurname = new() { Placeholder = "Surname" };
    private readonly Entry _txtIdNo = new() { Placeholder = "ID No" };
    private readonly Entry _txtAddress = new() { Placeholder = "Address" };
    private readonly Entry _txtTelNo = new() { Placeholder = "Telephone No", Keyboard = Keyboard.Numeric };

    public RegisterPage(BankingService bankingService, string loggedInId)
    {
        _bankingService = bankingService;
        _loggedInId = loggedInId;
        Title = "Register Customer";

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
                    _txtName,
                    _txtMiddleName,
                    _txtSurname,
                    _txtIdNo,
                    _txtAddress,
                    _txtTelNo,
                    btnRegister
                }
            }
        };
    }

    private async void OnRegisterClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_txtName.Text) ||
            string.IsNullOrWhiteSpace(_txtSurname.Text) ||
            string.IsNullOrWhiteSpace(_txtIdNo.Text) ||
            string.IsNullOrWhiteSpace(_txtAddress.Text) ||
            string.IsNullOrWhiteSpace(_txtTelNo.Text))
        {
            await DisplayAlert("Error", "Please fill all required fields", "OK");
            return;
        }

        var result = _bankingService.RegisterCustomer(
            _txtName.Text.Trim(),
            _txtMiddleName.Text?.Trim() ?? "",
            _txtSurname.Text.Trim(),
            _txtIdNo.Text.Trim(),
            _txtAddress.Text.Trim(),
            _txtTelNo.Text.Trim(),
            _loggedInId);

        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", $"Customer register successfully: {result.customerId}", "OK");

        var open = await DisplayAlert("Register", "Do you want to create new bank account?", "Yes", "No");
        if (open)
        {
            await Navigation.PushAsync(new OpenAccountPage(_bankingService, "Bank", result.customerId, _loggedInId));
        }
    }
}