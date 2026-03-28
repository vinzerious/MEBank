using MEBankMAUI.Services;
using MEBankMAUI.Views;
using Microsoft.Extensions.Logging;

namespace MEBankMAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<BankingService>();

        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddTransient<ProfilePage>();
        builder.Services.AddTransient<RegisterPage>();
        builder.Services.AddTransient<RegisterImeBankPage>();
        builder.Services.AddTransient<OpenAccountPage>();
        builder.Services.AddTransient<DepositPage>();
        builder.Services.AddTransient<WithdrawPage>();
        builder.Services.AddTransient<TransferPage>();
        builder.Services.AddTransient<EditProfilePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}