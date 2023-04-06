using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;
using StudentClearanceApp.Controls;
using StudentClearanceApp.Models;
using StudentClearanceApp.Services;
using StudentClearanceApp.Views.Dashboard;
using StudentClearanceApp.Views.Startups;


namespace StudentClearanceApp.ViewModels.Startups
{


    public partial class LoginPageViewModel : BaseViewModel
    {


        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        private readonly ILoginService _loginService;
        private readonly IRegisterService _registerService;
        public LoginPageViewModel(ILoginService loginService, IRegisterService registerService = null)
        {

            _loginService = loginService;
            _registerService = registerService;
        }

        [RelayCommand]
        async void Login()
        {
            //validation here...
                    if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
                    {

                        //call api
                        var response = await _loginService.Authenticate(
                            new LoginRequest
                            {
                                email = Email,
                                password = Password
                            });

                        if (response != null)
                        {



                            if (response.Status == "Request was successful")
                            {
                              //   await AppShell.Current.DisplayAlert("Valid Authentication", $"{response}", "ok");

                                //preferences...
                                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                                {
                                    Preferences.Remove(nameof(App.UserDetails));
                                }

                        //var result = await _registerService.GetUserProfile();
                        // await AppShell.Current.DisplayAlert("get user progile", $"{result}", "ok");

                        //securing the token value...
                        await SecureStorage.SetAsync(nameof(App.Token), response.Userdata.Token);

                        // adding  preferences....
                        string userDetailsStr = JsonConvert.SerializeObject(response.Userdata);
                        Preferences.Set(nameof(App.UserDetails), userDetailsStr);
                        App.UserDetails = response.Userdata;
                        //setting up the flyout...
                        AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                        await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");

                            }
                            else if (response.Status == "Unsuccessful request")
                                {
                                    await AppShell.Current.DisplayAlert("Invalid Authentication", $"{response.Message}", "ok");
                                }

                            }
                            else
                            {
                                await AppShell.Current.DisplayAlert("Invalid", "Invalid Login Details", "ok");
                            }
              
                    }
                    else
                    {
                        //await Shell.Current.GoToAsync($".//{nameof(LoginPage)}");
                        await AppShell.Current.DisplayAlert("Caution", "Username or Password is empty", "ok");
                    }
           

        }


        [RelayCommand]
        async void Register()
        {
          
           // await Shell.Current.DisplayAlert("hello", "hello", "hello");  
            await Shell.Current.GoToAsync($"{nameof(RegisterPage)}");
        }

    }

    }

