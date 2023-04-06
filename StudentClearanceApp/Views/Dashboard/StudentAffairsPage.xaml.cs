using StudentClearanceApp.ViewModels.Dashboard;

namespace StudentClearanceApp.Views.Dashboard;

public partial class StudentAffairsPage : ContentPage
{
	public StudentAffairsPage(StudentAffairsViewModel studentAffairsViewModel)
	{
		InitializeComponent();
		this.BindingContext = studentAffairsViewModel;
	}
}