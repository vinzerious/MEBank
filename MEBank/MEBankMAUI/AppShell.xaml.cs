using System.Diagnostics;

using Microsoft.Maui.Controls.Compatibility;

namespace MEBankMAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

#if IOS || MACCATALYST
        // Register handler for show/hide flyout on iOS
        FlyoutBehaviorShowed += OnFlyoutBehaviorShowed;
#endif
	}

#if IOS || MACCATALYST
    private void OnFlyoutBehaviorShowed(object sender, FlyoutBehaviorEventArgs e)
	{
        Debug.WriteLine($"Flyout shown: {e.Behavior}");
    }
#endif
}
