using StudentClearanceApp.ViewModels.Startups;

namespace StudentClearanceApp.Views.Startups;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel loadingPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = loadingPageViewModel;
	}
}