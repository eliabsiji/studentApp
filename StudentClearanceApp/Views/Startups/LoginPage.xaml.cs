using StudentClearanceApp.ViewModels.Startups;

namespace StudentClearanceApp.Views.Startups;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel	loginPageViewModel)
	{
		InitializeComponent();
		BindingContext = loginPageViewModel;
		
	}

}