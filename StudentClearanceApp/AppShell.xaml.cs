using StudentClearanceApp.ViewModels;
using StudentClearanceApp.Views.Dashboard;
using StudentClearanceApp.Views.Startups;

namespace StudentClearanceApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
		
        Routing.RegisterRoute(nameof(LoginDetailsPage), typeof(LoginDetailsPage));
        Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
        Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        Routing.RegisterRoute(nameof(BioDataPage), typeof(BioDataPage));
      
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
