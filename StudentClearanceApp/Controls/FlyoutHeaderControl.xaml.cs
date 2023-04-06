namespace StudentClearanceApp.Controls;

public partial class FlyoutHeaderControl : VerticalStackLayout
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();

		if(App.UserDetails != null)
		{
			lblUserEmail.Text = App.UserDetails.User.Email;
			lblUserName.Text = App.UserDetails.User.Name;
        }
	}
}