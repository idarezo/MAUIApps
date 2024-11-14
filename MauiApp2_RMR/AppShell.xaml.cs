using MauiApp2_RMR.Views;

namespace MauiApp2_RMR;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(UcniNacrt), typeof(UcniNacrt));
        Routing.RegisterRoute(nameof(VizitikaStran), typeof(VizitikaStran));

        var navPage = new NavigationPage(new MainPage());
        navPage.BarBackground = Colors.White;  // Set the navigation bar background color
        navPage.BarTextColor = Colors.Blue;    // Set the navigation bar text color
      



    }
}
