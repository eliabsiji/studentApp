using StudentClearanceApp.Views.Dashboard;
using StudentClearanceApp.Views.Startups;
using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentClearanceApp.Controls;
using Newtonsoft.Json;

namespace StudentClearanceApp.ViewModels.Startups
{
    public partial class LoadingPageViewModel
    {
        public LoadingPageViewModel() {

            CheckUserLoginDetails();
        }   

        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails),"");
          //  await Shell.Current.DisplayAlert("message", $"{userDetailsStr}", "ok");
            if(string.IsNullOrEmpty(userDetailsStr) )
            {
                //navigate to login page...
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
            {
                var tokenDetails = await SecureStorage.GetAsync(nameof(App.Token));
                // we neede to deserialise userdetails here...
                var userInfo = JsonConvert.DeserializeObject<Userdata>(userDetailsStr);
                App.UserDetails = userInfo;
                App.Token = tokenDetails;
                //setting up the flyout...
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                //navigate to dashboard...
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
        }
    }
}
  