using StudentClearanceApp.ViewModels.Dashboard;

namespace StudentClearanceApp.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel dashboardPageViewModel )
	{
		InitializeComponent();
		this.BindingContext = dashboardPageViewModel;
	}
}