using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentClearanceApp.Models;
using StudentClearanceApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentClearanceApp.ViewModels.Dashboard
{
    public partial class LibraryPageViewModel : BaseViewModel
    {

        [ObservableProperty]
        private string _userId;


        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _matricno;

        [ObservableProperty]
        private string _dept;

        [ObservableProperty]
        private string _receipt;



        private readonly ILibraryService _libraryService;
        public  LibraryPageViewModel(ILibraryService libraryService) {

            Title = "Library Clearance";

            _libraryService = libraryService;
        }



        [RelayCommand]
        async public void Submitlibrarydata()
        {
            await Shell.Current.DisplayAlert("Message", $"Library Clearance Data has been Captured", "ok");

            //call api


            var response = await _libraryService.Submit( new LibraryRequest
            {
                user_id = App.UserDetails.User.Id.ToString(),
                name = Name,
                dept = Dept,
                matricno = Matricno,
                receipt = Receipt,

            });

            if (response != null)
            {
                await Shell.Current.DisplayAlert("Message", "Library Clearance Data done successfully", "ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("Message", "something went wrong", "ok");

            }
        }
    }
}
