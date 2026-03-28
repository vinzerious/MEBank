using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class EditProfilePage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _loggedInId;
    private readonly Entry _txtFullName = new() { Placeholder = "Full Name" };

    public EditProfilePage(BankingService bankingService, string loggedInId)
    {
        _bankingService = bankingService;
        _loggedInId = loggedInId;

        Title = "Edit Profile";

        _txtFullName.Text = _bankingService.GetFullNameByUserId(_loggedInId);

        var btnSave = new Button { Text = "Save Full Name" };
        btnSave.Clicked += OnSaveClicked;

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 12,
                Children =
                {
                    new Label
                    {
                        Text = "Update Profile",
                        FontSize = 24,
                        FontAttributes = FontAttributes.Bold
                    },
                    new Label
                    {
                        Text = "Your full name is used as recipient confirmation in transfer.",
                        FontSize = 13,
                        TextColor = Color.FromArgb("#64748B")
                    },
                    _txtFullName,
                    btnSave
                }
            }
        };
    }

    private async void OnSaveClicked(object? sender, EventArgs e)
    {
        var result = _bankingService.UpdateFullName(_loggedInId, _txtFullName.Text ?? string.Empty);
        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", "Profile updated", "OK");
        await Navigation.PopAsync();
    }
}
