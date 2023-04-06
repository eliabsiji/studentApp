using StudentClearanceApp.ViewModels.Dashboard;

namespace StudentClearanceApp.Views.Dashboard;

public partial class LibraryPage : ContentPage
{
	public LibraryPage(LibraryPageViewModel libraryPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = libraryPageViewModel;

	}
}