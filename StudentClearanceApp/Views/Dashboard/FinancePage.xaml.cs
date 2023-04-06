using StudentClearanceApp.ViewModels.Dashboard;

namespace StudentClearanceApp.Views.Dashboard;

public partial class FinancePage : ContentPage
{
	public FinancePage(FinancePageViewModel financePageViewModel)
	{
		InitializeComponent();
		this.BindingContext = financePageViewModel;	
	}
}