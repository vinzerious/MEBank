using MEBankMAUI.Services;

namespace MEBankMAUI.Views;

public class TransferPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _loggedInId;

    private readonly Picker _cmbFromAccount = new() { Title = "Transfer from" };
    private readonly CheckBox _chkOwnAccountTransfer = new();
    private readonly Picker _cmbToOwnAccount = new() { Title = "Transfer to my account", IsVisible = false };
    private readonly Entry _txtRecipientUsername = new() { Placeholder = "Recipient username" };
    private readonly Label _lblRecipientFullName = new() { Text = "Recipient Full Name: -" };
    private readonly Picker _cmbRecipientAccount = new() { Title = "Recipient account" };
    private readonly Entry _txtAmount = new() { Placeholder = "Amount", Keyboard = Keyboard.Numeric };
    private readonly Label _lblBalance = new() { Text = "Balance: -" };

    public TransferPage(BankingService bankingService, string customerId, string loggedInId)
    {
        _bankingService = bankingService;
        _loggedInId = loggedInId;

        Title = "Transfer";

        var btnLoadAccounts = new Button { Text = "Load My Accounts" };
        btnLoadAccounts.Clicked += (_, _) => LoadAccounts();

        _cmbFromAccount.SelectedIndexChanged += (_, _) =>
        {
            ShowBalance();
            RefreshOwnDestinationAccounts();
        };

        var btnGetBalance = new Button { Text = "Get Balance" };
        btnGetBalance.Clicked += (_, _) => ShowBalance();

        _chkOwnAccountTransfer.CheckedChanged += (_, args) => ToggleDestinationMode(args.Value);
        _txtRecipientUsername.TextChanged += async (_, _) => await LoadRecipientFromUsername(false);

        var btnTransfer = new Button { Text = "Transfer" };
        btnTransfer.Clicked += OnTransferClicked;

        Content = new ScrollView
        {
            Content = new VerticalStackLayout
            {
                Padding = 24,
                Spacing = 12,
                Children =
                {
                    btnLoadAccounts,
                    _cmbFromAccount,
                    btnGetBalance,
                    _lblBalance,
                    new HorizontalStackLayout
                    {
                        Spacing = 10,
                        Children =
                        {
                            _chkOwnAccountTransfer,
                            new Label
                            {
                                Text = "Transfer to my own account",
                                VerticalTextAlignment = TextAlignment.Center
                            }
                        }
                    },
                    _cmbToOwnAccount,
                    _txtRecipientUsername,
                    _lblRecipientFullName,
                    _cmbRecipientAccount,
                    _txtAmount,
                    btnTransfer
                }
            }
        };

        LoadAccounts();
    }

    private void LoadAccounts()
    {
        _cmbFromAccount.Items.Clear();
        _lblBalance.Text = "Balance: -";

        var list = _bankingService.GetAccountListByUserId(_loggedInId);
        foreach (var item in list)
        {
            _cmbFromAccount.Items.Add(item);
        }

        if (_cmbFromAccount.Items.Count > 0)
        {
            _cmbFromAccount.SelectedIndex = 0;
            ShowBalance();
        }

        RefreshOwnDestinationAccounts();
    }

    private void ToggleDestinationMode(bool useOwnAccount)
    {
        _cmbToOwnAccount.IsVisible = useOwnAccount;
        _txtRecipientUsername.IsVisible = !useOwnAccount;
        _lblRecipientFullName.IsVisible = !useOwnAccount;
        _cmbRecipientAccount.IsVisible = !useOwnAccount;
    }

    private async Task<bool> LoadRecipientFromUsername(bool showErrors)
    {
        _cmbRecipientAccount.Items.Clear();
        _lblRecipientFullName.Text = "Recipient Full Name: -";

        var username = _txtRecipientUsername.Text?.Trim() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(username))
        {
            return false;
        }

        var info = _bankingService.GetRecipientInfoByUserId(username);
        if (!info.ok)
        {
            if (showErrors)
            {
                await DisplayAlert("Error", info.error, "OK");
            }
            return false;
        }

        _lblRecipientFullName.Text = $"Recipient Full Name: {info.fullName}";
        foreach (var iban in info.accounts)
        {
            _cmbRecipientAccount.Items.Add(iban);
        }

        if (_cmbRecipientAccount.Items.Count > 0)
        {
            _cmbRecipientAccount.SelectedIndex = 0;
        }

        return true;
    }

    private void RefreshOwnDestinationAccounts()
    {
        _cmbToOwnAccount.Items.Clear();

        if (_cmbFromAccount.SelectedIndex < 0)
        {
            return;
        }

        var selectedFromIban = _cmbFromAccount.Items[_cmbFromAccount.SelectedIndex];
        var ownAccounts = _bankingService.GetAccountListByUserId(_loggedInId);
        foreach (var iban in ownAccounts)
        {
            if (!string.Equals(iban, selectedFromIban, StringComparison.Ordinal))
            {
                _cmbToOwnAccount.Items.Add(iban);
            }
        }

        if (_cmbToOwnAccount.Items.Count > 0)
        {
            _cmbToOwnAccount.SelectedIndex = 0;
        }
    }

    private void ShowBalance()
    {
        if (_cmbFromAccount.SelectedIndex < 0) return;
        var iban = _cmbFromAccount.Items[_cmbFromAccount.SelectedIndex];
        var balance = _bankingService.GetBalance(iban);
        _lblBalance.Text = $"Balance: {balance:N2}";
    }

    private async void OnTransferClicked(object? sender, EventArgs e)
    {
        if (_cmbFromAccount.SelectedIndex < 0)
        {
            await DisplayAlert("Error", "Please select your account number", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(_txtRecipientUsername.Text))
        {
            if (!_chkOwnAccountTransfer.IsChecked)
            {
                await DisplayAlert("Error", "Please enter recipient username", "OK");
                return;
            }
        }

        if (string.IsNullOrWhiteSpace(_txtAmount.Text) || !decimal.TryParse(_txtAmount.Text, out var amount))
        {
            await DisplayAlert("Error", "Please enter transfer amount", "OK");
            return;
        }

        var fromIban = _cmbFromAccount.Items[_cmbFromAccount.SelectedIndex];
        string toIban;

        if (_chkOwnAccountTransfer.IsChecked)
        {
            if (_cmbToOwnAccount.SelectedIndex < 0)
            {
                await DisplayAlert("Error", "Please select your destination account", "OK");
                return;
            }

            toIban = _cmbToOwnAccount.Items[_cmbToOwnAccount.SelectedIndex];
        }
        else
        {
            if (!await LoadRecipientFromUsername(true))
            {
                return;
            }

            if (_cmbRecipientAccount.SelectedIndex < 0)
            {
                await DisplayAlert("Error", "Please select recipient account", "OK");
                return;
            }

            toIban = _cmbRecipientAccount.Items[_cmbRecipientAccount.SelectedIndex];
        }

        var result = _bankingService.Transfer(fromIban, toIban, amount, _loggedInId);
        if (!result.ok)
        {
            await DisplayAlert("Error", result.error, "OK");
            return;
        }

        await DisplayAlert("Success", "Transferred successfully", "OK");
        ShowBalance();
    }
}