using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels.Dashboard
{
    public partial class ProfilePageViewModel : BaseViewModel
    {

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


        public ProfilePageViewModel() {

            Title = "Student Profile Page";
        }



    }
}
