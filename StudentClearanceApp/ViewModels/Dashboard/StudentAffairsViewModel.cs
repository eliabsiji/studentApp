using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentClearanceApp.Models;
using StudentClearanceApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels.Dashboard
{
    public partial class StudentAffairsViewModel : BaseViewModel
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

        private readonly IStudentaffairsService _studentaffairsService;

        public StudentAffairsViewModel(IStudentaffairsService studentaffairsService)
        {
            Title = "Student Affairs Clearance";

            _studentaffairsService = studentaffairsService;
           
         }

        [RelayCommand]
        async public void Submitdata()
        {
            await Shell.Current.DisplayAlert("Message", $" Data has been Captured", "ok");

            //call api


            var response = await _studentaffairsService.Submit(new StudentAffairsRequest
            {
                user_id = App.UserDetails.User.Id.ToString(),
                name = Name,
                dept = Dept,
                matricno = Matricno,
                receipt = Receipt,

            });

            if (response != null)
            {
                await Shell.Current.DisplayAlert("Message", "Student Affairs Clearance Data done successfully", "ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("Message", "something went wrong", "ok");

            }
        }

    }
}
