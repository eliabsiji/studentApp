using StudentClearanceApp.ViewModels.Dashboard;

namespace StudentClearanceApp.Views.Dashboard;

public partial class BioDataPage : ContentPage
{
	public BioDataPage(BioDataPageViewModel bioDataPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = bioDataPageViewModel;
	}
}