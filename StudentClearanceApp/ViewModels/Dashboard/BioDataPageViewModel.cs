using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using StudentClearanceApp.Models;
using StudentClearanceApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels.Dashboard
{
    public partial class BioDataPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        private string _userId;


        [ObservableProperty]
        private string _firstname;

        [ObservableProperty]
        private string _lastname;

        [ObservableProperty]
        private string _othername;

        [ObservableProperty]
        private string _phone;

        [ObservableProperty]
        private string _matricno;

        [ObservableProperty]
        private string _maritalstatus;

        [ObservableProperty]
        private string _state;

        [ObservableProperty]
        private string _school;

        [ObservableProperty]
        private string _dept;

        [ObservableProperty]
        private string _level;

        [ObservableProperty]
        private string _session;

        [ObservableProperty]
        private string _year;

        [ObservableProperty]
        private string _qualification;

        [ObservableProperty]
        private string _gender;

        [ObservableProperty]
        private string _religion;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _username;

        [ObservableProperty]
        private string _password;


        public static Profiledata UserDetails;

        private readonly IUserProfileService _userProfileService;
        public BioDataPageViewModel(IUserProfileService userProfileService)
        {

            Title = " Bio Data Details";
            _userProfileService = userProfileService;

            ShowUserProfile();
        }

       async void ShowUserProfile()
        {
          // await Shell.Current.DisplayAlert("testing profile", "user profile", "ok");

            var response = await _userProfileService.GetUserProfile(
                new UserProfileIdRequest{

                    id = App.UserDetails.User.Id    
                 });                                                   
                       
            if (response != null)
            {
                
              //  await Shell.Current.DisplayAlert("testing profile", $"{response.Profiledata.Userprofile}", "ok");

                Firstname = response.Profiledata.Userprofile.Firstname;
                Lastname = response.Profiledata.Userprofile.Lastname;
                Othername = response.Profiledata.Userprofile.Othername;
                Phone = response.Profiledata.Userprofile.Phone;
                Matricno = response.Profiledata.Userprofile.Matricno;
                Maritalstatus = response.Profiledata.Userprofile.Maritalstatus;
                Gender = response.Profiledata.Userprofile.Gender;
                State = response.Profiledata.Userprofile.State;
                School = response.Profiledata.Userprofile.School;
                Session = response.Profiledata.Userprofile.Session;
                Year = response.Profiledata.Userprofile.Year;
                Dept = response.Profiledata.Userprofile.Dept;
                Qualification = response.Profiledata.Userprofile.Qualification;
                Religion = response.Profiledata.Userprofile.Religion;
                Level = response.Profiledata.Userprofile.Level;



            }

        }


    }
}
