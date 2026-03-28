using MEBankMAUI.Services;
using Microsoft.Maui.Controls.Shapes;

namespace MEBankMAUI.Views;

public class ProfilePage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _customerId;
    private readonly string _loggedInId;
    private readonly VerticalStackLayout _accountsContainer = new() { Spacing = 6 };
    private readonly Label _lblFullName = new()
    {
        FontSize = 20,
        FontAttributes = FontAttributes.Bold,
        TextColor = Colors.White
    };

    public ProfilePage(BankingService bankingService, string accountType, string customerId, string loggedInId)
    {
        _bankingService = bankingService;
        _customerId = customerId;
        _loggedInId = loggedInId;
        Title = "Profile";
        Background = new LinearGradientBrush(
            new GradientStopCollection
            {
                new GradientStop(Color.FromArgb("#F8FAFC"), 0.0f),
                new GradientStop(Color.FromArgb("#EEF2FF"), 0.55f),
                new GradientStop(Color.FromArgb("#E0F2FE"), 1.0f)
            },
            new Point(0, 0),
            new Point(1, 1));

        var role = accountType?.Trim() ?? string.Empty;
        var isAdmin = string.Equals(role, "Admin", StringComparison.OrdinalIgnoreCase);
        var isBank = string.Equals(role, "Bank", StringComparison.OrdinalIgnoreCase);
        var isCustomer = string.Equals(role, "Customer", StringComparison.OrdinalIgnoreCase);
        var isBankTeller = string.Equals(role, "Bank Teller", StringComparison.OrdinalIgnoreCase);

        var headerCard = new Border
        {
            StrokeThickness = 0,
            Padding = 20,
            Background = new LinearGradientBrush(
                new GradientStopCollection
                {
                    new GradientStop(Color.FromArgb("#0F172A"), 0.0f),
                    new GradientStop(Color.FromArgb("#1D4ED8"), 1.0f)
                },
                new Point(0, 0),
                new Point(1, 1)),
            StrokeShape = new RoundRectangle { CornerRadius = 28 },
            Shadow = new Shadow
            {
                Brush = Brush.Black,
                Offset = new Point(0, 12),
                Radius = 24,
                Opacity = 0.16f
            },
            Content = new VerticalStackLayout
            {
                Spacing = 10,
                Children =
                {
                    new Label
                    {
                        Text = "MEBank Profile",
                        FontSize = 28,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Colors.White
                    },
                    new Border
                    {
                        HorizontalOptions = LayoutOptions.Start,
                        StrokeThickness = 0,
                        BackgroundColor = Color.FromArgb("#38BDF8"),
                        StrokeShape = new RoundRectangle { CornerRadius = 16 },
                        Padding = new Thickness(12, 6),
                        Content = new Label
                        {
                            Text = role,
                            FontSize = 13,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.FromArgb("#082F49")
                        }
                    },
                    new Label
                    {
                        Text = $"Signed in as {loggedInId}",
                        FontSize = 15,
                        TextColor = Color.FromArgb("#DBEAFE")
                    },
                    _lblFullName
                }
            }
        };

        var sectionTitle = new Label
        {
            Text = "Quick Actions",
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#0F172A")
        };

        var sectionSubtitle = new Label
        {
            Text = "Use the shortcuts below to manage customers, accounts, and transactions.",
            FontSize = 13,
            TextColor = Color.FromArgb("#475569")
        };

        var btnOpenAccount = CreateActionButton("Open Account", "#0F766E", isBank || isCustomer);
        btnOpenAccount.Clicked += async (_, _) =>
            await Navigation.PushAsync(new OpenAccountPage(bankingService, role, customerId, loggedInId));

        var btnRegisterBankOfficer = CreateActionButton("Register Bank Officer", "#4338CA", isAdmin);
        btnRegisterBankOfficer.Clicked += async (_, _) =>
            await Navigation.PushAsync(new RegisterImeBankPage(bankingService, role, customerId, loggedInId));

        var btnRegisterCustomer = CreateActionButton("Register Customer", "#2563EB", isBank);
        btnRegisterCustomer.Clicked += async (_, _) =>
            await Navigation.PushAsync(new RegisterPage(bankingService, loggedInId));

        var btnTransfer = CreateActionButton("Transfer", "#7C3AED", isCustomer);
        btnTransfer.Clicked += async (_, _) =>
            await Navigation.PushAsync(new TransferPage(bankingService, customerId, loggedInId));

        var btnWithdraw = CreateActionButton("Withdraw", "#B45309", isCustomer);
        btnWithdraw.Clicked += async (_, _) =>
            await Navigation.PushAsync(new WithdrawPage(bankingService, customerId, loggedInId));

        var btnDeposit = CreateActionButton("Deposit", "#15803D", isBank || isBankTeller);
        btnDeposit.Clicked += async (_, _) =>
            await Navigation.PushAsync(new DepositPage(bankingService, string.Empty, loggedInId));

        var btnTransactionLogs = CreateActionButton("Transaction Logs", "#334155", true);
        btnTransactionLogs.Clicked += async (_, _) =>
            await Navigation.PushAsync(new TransactionLogsPage(bankingService, role, customerId));

        var btnEditProfile = CreateActionButton("Edit Profile", "#0369A1", true);
        btnEditProfile.Clicked += async (_, _) =>
            await Navigation.PushAsync(new EditProfilePage(_bankingService, _loggedInId));

        var btnThemeMode = CreateActionButton("Theme Mode", "#1E293B", true);
        btnThemeMode.Clicked += async (_, _) =>
        {
            var selected = await DisplayActionSheet(
                "Choose Appearance",
                "Cancel",
                null,
                "Light",
                "Dark",
                "System");

            if (selected is "Light" or "Dark" or "System")
            {
                App.SetTheme(selected);
            }
        };

        var btnLogout = new Button
        {
            Text = "Logout",
            CornerRadius = 18,
            HeightRequest = 54,
            BackgroundColor = Colors.Transparent,
            BorderColor = Color.FromArgb("#CBD5E1"),
            BorderWidth = 1,
            TextColor = Color.FromArgb("#0F172A"),
            FontAttributes = FontAttributes.Bold
        };
        btnLogout.Clicked += async (_, _) =>
        {
            await Navigation.PopToRootAsync();
        };

        var actionsContainer = new Border
        {
            StrokeThickness = 0,
            Padding = 18,
            BackgroundColor = Color.FromArgb("#FFFFFF"),
            StrokeShape = new RoundRectangle { CornerRadius = 24 },
            Shadow = new Shadow
            {
                Brush = Brush.Black,
                Offset = new Point(0, 10),
                Radius = 18,
                Opacity = 0.08f
            },
            Content = new VerticalStackLayout
            {
                Spacing = 12,
                Children =
                {
                    sectionTitle,
                    sectionSubtitle,
                    btnOpenAccount,
                    btnRegisterBankOfficer,
                    btnRegisterCustomer,
                    btnDeposit,
                    btnWithdraw,
                    btnTransfer,
                    btnTransactionLogs,
                    btnEditProfile,
                    btnThemeMode,
                    btnLogout
                }
            }
        };

        var lblAccountsTitle = new Label
        {
            Text = "Opened Accounts",
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#0F172A")
        };

        var lblAccountsSubtitle = new Label
        {
            Text = "Live balances for the accounts tied to this profile.",
            FontSize = 13,
            TextColor = Color.FromArgb("#475569")
        };

        var accountsSection = new Border
        {
            StrokeThickness = 0,
            Padding = 18,
            BackgroundColor = Color.FromArgb("#FFFFFF"),
            StrokeShape = new RoundRectangle { CornerRadius = 24 },
            Shadow = new Shadow
            {
                Brush = Brush.Black,
                Offset = new Point(0, 10),
                Radius = 18,
                Opacity = 0.08f
            },
            Content = new VerticalStackLayout
            {
                Spacing = 12,
                Children =
                {
                    lblAccountsTitle,
                    lblAccountsSubtitle,
                    _accountsContainer
                }
            }
        };

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 18,
                Children =
                {
                    headerCard,
                    actionsContainer,
                    accountsSection
                }
            }
        };

        RefreshProfileHeader();
        LoadOpenedAccounts();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RefreshProfileHeader();
        LoadOpenedAccounts();
    }

    private void RefreshProfileHeader()
    {
        var fullName = _bankingService.GetFullNameByUserId(_loggedInId);
        _lblFullName.Text = string.IsNullOrWhiteSpace(fullName)
            ? "Full Name: Not Set"
            : $"Full Name: {fullName}";
    }

    private void LoadOpenedAccounts()
    {
        _accountsContainer.Children.Clear();

        if (string.IsNullOrWhiteSpace(_customerId))
        {
            _accountsContainer.Children.Add(CreateEmptyStateLabel("No customer ID available."));
            return;
        }

        var accountList = _bankingService.GetAccountList(_customerId);
        if (accountList.Count == 0)
        {
            _accountsContainer.Children.Add(CreateEmptyStateLabel("No opened accounts yet."));
            return;
        }

        foreach (var iban in accountList)
        {
            var balance = _bankingService.GetBalance(iban);
            _accountsContainer.Children.Add(CreateAccountCard(iban, balance));
        }
    }

    private static Button CreateActionButton(string text, string backgroundHex, bool isVisible)
    {
        return new Button
        {
            Text = text,
            IsVisible = isVisible,
            HeightRequest = 52,
            CornerRadius = 18,
            BackgroundColor = Color.FromArgb(backgroundHex),
            TextColor = Colors.White,
            FontAttributes = FontAttributes.Bold
        };
    }

    private static Label CreateEmptyStateLabel(string text)
    {
        return new Label
        {
            Text = text,
            FontSize = 14,
            TextColor = Color.FromArgb("#64748B")
        };
    }

    private static Border CreateAccountCard(string iban, decimal balance)
    {
        var grid = new Grid
        {
            ColumnDefinitions = new ColumnDefinitionCollection
            {
                new ColumnDefinition(GridLength.Star),
                new ColumnDefinition(GridLength.Auto)
            },
            RowDefinitions = new RowDefinitionCollection
            {
                new RowDefinition(GridLength.Auto),
                new RowDefinition(GridLength.Auto)
            }
        };

        grid.Add(new Label
        {
            Text = "IBAN",
            FontSize = 12,
            TextColor = Color.FromArgb("#64748B")
        }, 0, 0);

        grid.Add(new Label
        {
            Text = iban,
            FontSize = 15,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#0F172A")
        }, 0, 1);

        grid.Add(new Label
        {
            Text = "Balance",
            FontSize = 12,
            TextColor = Color.FromArgb("#64748B"),
            HorizontalTextAlignment = TextAlignment.End
        }, 1, 0);

        grid.Add(new Label
        {
            Text = balance.ToString("N2"),
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#15803D"),
            HorizontalTextAlignment = TextAlignment.End
        }, 1, 1);

        return new Border
        {
            StrokeThickness = 1,
            Stroke = Color.FromArgb("#DBEAFE"),
            BackgroundColor = Color.FromArgb("#F8FAFC"),
            StrokeShape = new RoundRectangle { CornerRadius = 18 },
            Padding = 14,
            Content = grid
        };
    }
}