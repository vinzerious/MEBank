using MEBankMAUI.Services;
using MEBankMAUI.Views;
using Microsoft.Maui.Storage;

namespace MEBankMAUI;

public partial class App : Application
{
    private const string ThemePreferenceKey = "app_theme";

    public App()
    {
        InitializeComponent();
        ApplySavedTheme();
    }

    public static void SetTheme(string mode)
    {
        var normalized = (mode ?? "System").Trim();

        var app = Current;
        if (app == null)
        {
            Preferences.Default.Set(ThemePreferenceKey, normalized);
            return;
        }

        app.UserAppTheme = normalized.Equals("Dark", StringComparison.OrdinalIgnoreCase)
            ? AppTheme.Dark
            : normalized.Equals("Light", StringComparison.OrdinalIgnoreCase)
                ? AppTheme.Light
                : AppTheme.Unspecified;

        ApplyThemePalette(app);

        Preferences.Default.Set(ThemePreferenceKey, normalized);
    }

    public static string GetThemeMode()
    {
        return Preferences.Default.Get(ThemePreferenceKey, "System");
    }

    private static void ApplySavedTheme()
    {
        SetTheme(GetThemeMode());
    }

    private static void ApplyThemePalette(Application app)
    {
        var effectiveTheme = app.UserAppTheme == AppTheme.Unspecified ? app.RequestedTheme : app.UserAppTheme;
        var isDark = effectiveTheme == AppTheme.Dark;

        app.Resources["PageBackgroundColor"] = Color.FromArgb(isDark ? "#0B1220" : "#F8FAFC");
        app.Resources["CardBackgroundColor"] = Color.FromArgb(isDark ? "#111827" : "#FFFFFF");
        app.Resources["PrimaryTextColor"] = Color.FromArgb(isDark ? "#E5E7EB" : "#0F172A");
        app.Resources["SecondaryTextColor"] = Color.FromArgb(isDark ? "#9CA3AF" : "#64748B");
        app.Resources["InputBackgroundColor"] = Color.FromArgb(isDark ? "#1F2937" : "#FFFFFF");
        app.Resources["InputPlaceholderColor"] = Color.FromArgb(isDark ? "#9CA3AF" : "#64748B");
        app.Resources["PrimaryButtonColor"] = Color.FromArgb(isDark ? "#2563EB" : "#1D4ED8");
        app.Resources["SurfaceBorderColor"] = Color.FromArgb(isDark ? "#374151" : "#CBD5E1");
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var bankingService = new BankingService();
        var root = new NavigationPage(new LoginPage(bankingService));
        var window = new Window(root)
        {
            Title = "MEBank"
        };

#if MACCATALYST
        window.Width = 1280;
        window.Height = 820;
#endif

        return window;
    }
}