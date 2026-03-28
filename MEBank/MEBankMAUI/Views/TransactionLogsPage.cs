using MEBankMAUI.Services;
using Microsoft.Maui.Controls.Shapes;

namespace MEBankMAUI.Views;

public class TransactionLogsPage : ContentPage
{
    private readonly BankingService _bankingService;
    private readonly string _accountType;
    private readonly string _customerId;
    private readonly VerticalStackLayout _logsContainer = new() { Spacing = 10 };

    public TransactionLogsPage(BankingService bankingService, string accountType, string customerId)
    {
        _bankingService = bankingService;
        _accountType = accountType;
        _customerId = customerId;
        Title = "Transaction Logs";
        Background = new LinearGradientBrush(
            new GradientStopCollection
            {
                new GradientStop(Color.FromArgb("#F8FAFC"), 0.0f),
                new GradientStop(Color.FromArgb("#EFF6FF"), 0.6f),
                new GradientStop(Color.FromArgb("#E0F2FE"), 1.0f)
            },
            new Point(0, 0),
            new Point(1, 1));

        var role = accountType?.Trim() ?? string.Empty;

        var headerCard = new Border
        {
            StrokeThickness = 0,
            Padding = 20,
            Background = new LinearGradientBrush(
                new GradientStopCollection
                {
                    new GradientStop(Color.FromArgb("#111827"), 0.0f),
                    new GradientStop(Color.FromArgb("#0369A1"), 1.0f)
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
                        Text = "Transaction Timeline",
                        FontSize = 28,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Colors.White
                    },
                    new Border
                    {
                        HorizontalOptions = LayoutOptions.Start,
                        StrokeThickness = 0,
                        BackgroundColor = Color.FromArgb("#67E8F9"),
                        StrokeShape = new RoundRectangle { CornerRadius = 16 },
                        Padding = new Thickness(12, 6),
                        Content = new Label
                        {
                            Text = string.IsNullOrWhiteSpace(role) ? "All Roles" : role,
                            FontSize = 13,
                            FontAttributes = FontAttributes.Bold,
                            TextColor = Color.FromArgb("#164E63")
                        }
                    },
                    new Label
                    {
                        Text = "Review deposits, withdrawals, and transfers in one place.",
                        FontSize = 15,
                        TextColor = Color.FromArgb("#DBEAFE")
                    }
                }
            }
        };

        var logsSection = new Border
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
                    new Label
                    {
                        Text = "Recent Activity",
                        FontSize = 18,
                        FontAttributes = FontAttributes.Bold,
                        TextColor = Color.FromArgb("#0F172A")
                    },
                    new Label
                    {
                        Text = "Entries are ordered from newest to oldest.",
                        FontSize = 13,
                        TextColor = Color.FromArgb("#475569")
                    },
                    _logsContainer
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
                    logsSection
                }
            }
        };

        LoadTransactionLogs();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadTransactionLogs();
    }

    private void LoadTransactionLogs()
    {
        _logsContainer.Children.Clear();

        var logs = _bankingService.GetTransactionLogs(_accountType, _customerId);
        if (logs.Count == 0)
        {
            _logsContainer.Children.Add(new Border
            {
                StrokeThickness = 1,
                Stroke = Color.FromArgb("#DBEAFE"),
                BackgroundColor = Color.FromArgb("#F8FAFC"),
                StrokeShape = new RoundRectangle { CornerRadius = 18 },
                Padding = 16,
                Content = new Label
                {
                    Text = "No transaction logs found.",
                    FontSize = 14,
                    TextColor = Color.FromArgb("#64748B")
                }
            });
            return;
        }

        foreach (var log in logs)
        {
            _logsContainer.Children.Add(CreateTransactionCard(log));
        }
    }

    private static Border CreateTransactionCard(Models.Transaction log)
    {
        var accent = GetAccentColor(log.TransactionType);

        var amountGrid = new Grid
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

        amountGrid.Add(new Label
        {
            Text = "Amount",
            FontSize = 12,
            TextColor = Color.FromArgb("#64748B")
        }, 0, 0);

        amountGrid.Add(new Label
        {
            Text = log.Amount.ToString("N2"),
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            TextColor = accent
        }, 0, 1);

        amountGrid.Add(new Label
        {
            Text = "Fee",
            FontSize = 12,
            TextColor = Color.FromArgb("#64748B"),
            HorizontalTextAlignment = TextAlignment.End
        }, 1, 0);

        amountGrid.Add(new Label
        {
            Text = log.Fee.ToString("N2"),
            FontSize = 16,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#0F172A"),
            HorizontalTextAlignment = TextAlignment.End
        }, 1, 1);

        return new Border
        {
            StrokeThickness = 1,
            Stroke = Color.FromArgb("#DBEAFE"),
            BackgroundColor = Color.FromArgb("#F8FAFC"),
            StrokeShape = new RoundRectangle { CornerRadius = 20 },
            Padding = 16,
            Content = new VerticalStackLayout
            {
                Spacing = 10,
                Children =
                {
                    new HorizontalStackLayout
                    {
                        Spacing = 10,
                        Children =
                        {
                            new Border
                            {
                                StrokeThickness = 0,
                                BackgroundColor = accent,
                                StrokeShape = new RoundRectangle { CornerRadius = 14 },
                                Padding = new Thickness(10, 5),
                                Content = new Label
                                {
                                    Text = log.TransactionType,
                                    FontSize = 12,
                                    FontAttributes = FontAttributes.Bold,
                                    TextColor = Colors.White
                                }
                            },
                            new Label
                            {
                                Text = log.TransactionDate == DateTime.MinValue ? "Unknown date" : log.TransactionDate.ToString("yyyy-MM-dd HH:mm:ss"),
                                FontSize = 13,
                                TextColor = Color.FromArgb("#64748B"),
                                VerticalTextAlignment = TextAlignment.Center
                            }
                        }
                    },
                    amountGrid,
                    CreateInfoRow("Transaction ID", log.TransactionID),
                    CreateInfoRow("From", log.SourceIBANNo),
                    CreateInfoRow("To", log.DestIBANNo),
                    CreateInfoRow("Performed By", log.TransactionUser)
                }
            }
        };
    }

    private static HorizontalStackLayout CreateInfoRow(string label, string value)
    {
        return new HorizontalStackLayout
        {
            Spacing = 8,
            Children =
            {
                new Label
                {
                    Text = label + ":",
                    FontSize = 13,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromArgb("#334155"),
                    WidthRequest = 110
                },
                new Label
                {
                    Text = string.IsNullOrWhiteSpace(value) ? "-" : value,
                    FontSize = 13,
                    TextColor = Color.FromArgb("#0F172A"),
                    LineBreakMode = LineBreakMode.CharacterWrap,
                    HorizontalOptions = LayoutOptions.Fill,
                    VerticalTextAlignment = TextAlignment.Center
                }
            }
        };
    }

    private static Color GetAccentColor(string transactionType)
    {
        if (transactionType.Contains("Deposit", StringComparison.OrdinalIgnoreCase))
        {
            return Color.FromArgb("#15803D");
        }

        if (transactionType.Contains("Withdraw", StringComparison.OrdinalIgnoreCase))
        {
            return Color.FromArgb("#B45309");
        }

        if (transactionType.Contains("Transfer", StringComparison.OrdinalIgnoreCase))
        {
            return Color.FromArgb("#2563EB");
        }

        return Color.FromArgb("#475569");
    }
}
