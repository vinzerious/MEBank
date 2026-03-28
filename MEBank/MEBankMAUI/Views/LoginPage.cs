using MEBankMAUI.Services;
using Microsoft.Maui.Controls.Shapes;

namespace MEBankMAUI.Views;

public class LoginPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly Entry _txtUser;
    private readonly Entry _txtPassword;

    public LoginPage(BankingService bankingService)
    {
        _bankingService = bankingService;

        Title = "MEBank Login";
        Background = new LinearGradientBrush(
            new GradientStopCollection
            {
                new GradientStop(Color.FromArgb("#F8FAFC"), 0.0f),
                new GradientStop(Color.FromArgb("#E0F2FE"), 1.0f)
            },
            new Point(0, 0),
            new Point(1, 1));

        _txtUser = new Entry { Placeholder = "User ID" };
        _txtPassword = new Entry { Placeholder = "Password", IsPassword = true };

        var btnLogin = new Button { Text = "Login" };
        btnLogin.Clicked += OnLoginClicked;

        var btnRegister = new Button
        {
            Text = "Register (New User)",
            BackgroundColor = Color.FromArgb("#0F766E")
        };
        btnRegister.Clicked += async (_, _) =>
        {
            await Navigation.PushAsync(new RegisterImeBankPage(_bankingService, "New", "", ""));
        };

        var leftPanel = new Border
        {
            StrokeThickness = 0,
            Background = new LinearGradientBrush(
                new GradientStopCollection
                {
                    new GradientStop(Color.FromArgb("#0F172A"), 0.0f),
                    new GradientStop(Color.FromArgb("#1E3A8A"), 1.0f)
                },
                new Point(0, 0),
                new Point(1, 1)),
            StrokeShape = new RoundRectangle { CornerRadius = 26 },
            Padding = 28,
            Content = new VerticalStackLayout
            {
                Spacing = 14,
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    new Label
                    {
                        Text = "MEBank for macOS",
                        FontSize = 34,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Colors.White
                    },
                    new Label
                    {
                        Text = "A desktop-first workspace for bank operations, customer profiles, and account actions.",
                        FontSize = 15,
                        TextColor = Color.FromArgb("#DBEAFE")
                    },
                    new Border
                    {
                        StrokeThickness = 0,
                        BackgroundColor = Color.FromArgb("#38BDF8"),
                        StrokeShape = new RoundRectangle { CornerRadius = 14 },
                        Padding = new Thickness(10, 6),
                        HorizontalOptions = LayoutOptions.Start,
                        Content = new Label
                        {
                            Text = "Fast login and role-based actions",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = 12,
                            TextColor = Color.FromArgb("#082F49")
                        }
                    }
                }
            }
        };

        var formCard = new Border
        {
            StrokeThickness = 0,
            BackgroundColor = Colors.White,
            StrokeShape = new RoundRectangle { CornerRadius = 24 },
            Padding = 24,
            Shadow = new Shadow
            {
                Brush = Brush.Black,
                Offset = new Point(0, 10),
                Radius = 20,
                Opacity = 0.1f
            },
            Content = new VerticalStackLayout
            {
                Spacing = 14,
                Children =
                {
                    new Label
                    {
                        Text = "Sign In",
                        FontSize = 26,
                        FontAttributes = FontAttributes.Bold
                    },
                    new Label
                    {
                        Text = "Access customer and transaction workflows.",
                        FontSize = 13,
                        TextColor = Color.FromArgb("#64748B")
                    },
                    _txtUser,
                    _txtPassword,
                    btnLogin,
                    btnRegister
                }
            }
        };

        leftPanel.WidthRequest = 620;
        formCard.WidthRequest = 460;

        var desktopLayout = new HorizontalStackLayout
        {
            Spacing = 20,
            Children =
            {
                leftPanel,
                formCard
            }
        };

        var mobileLayout = new VerticalStackLayout
        {
            Spacing = 16,
            Children =
            {
                leftPanel,
                formCard
            }
        };

        var host = new ContentView();
        SizeChanged += (_, _) =>
        {
            host.Content = Width >= 950 ? desktopLayout : mobileLayout;
        };

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 16,
                Children =
                {
                    host
                }
            }
        };
    }

    private async void OnLoginClicked(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(_txtUser.Text))
        {
            await DisplayAlert("Error", "Please enter username", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_txtPassword.Text))
        {
            await DisplayAlert("Error", "Please enter password", "OK");
            return;
        }

        var result = _bankingService.Login(_txtUser.Text.Trim(), _txtPassword.Text);
        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", "You have logged in", "OK");
        await Navigation.PushAsync(new ProfilePage(_bankingService, result.accountType, result.customerId, _txtUser.Text.Trim()));
    }
}