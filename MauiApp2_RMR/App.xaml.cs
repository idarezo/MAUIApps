namespace MauiApp2_RMR;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

        var navPage = new NavigationPage(new MainPage());
        navPage.BarBackground = Colors.White;
        navPage.BarTextColor = Colors.Black;
       
        MainPage = navPage;
    }
}
