using StudentClearanceApp.Models;

namespace StudentClearanceApp;

public partial class App : Application
{
	public static Userdata  UserDetails;
	public static string Token;
	public App()
	{
		  InitializeComponent(); 
		  MainPage = new AppShell();

	}
}
