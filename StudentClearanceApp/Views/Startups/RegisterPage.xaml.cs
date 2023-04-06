using CommunityToolkit.Mvvm.Input;
using StudentClearanceApp.ViewModels.Startups;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Behaviors;

namespace StudentClearanceApp.Views.Startups;

public partial class RegisterPage : ContentPage
{
   

    public RegisterPage(RegisterPageViewModel registerPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = registerPageViewModel;
	}


}