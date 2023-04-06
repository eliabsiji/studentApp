using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using StudentClearanceApp.Views.Startups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels;
public partial class AppShellViewModel : BaseViewModel
{


    [RelayCommand]
    async void Logout()
    {
        //preferences...
        if (Preferences.ContainsKey(nameof(App.UserDetails)))
        {
            Preferences.Remove(nameof(App.UserDetails));
        }

        await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
       // Shell.Current.DisplayAlert("ohds", "eoiuhiw", "kbks");


    }

}
