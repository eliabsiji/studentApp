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
    public partial class FinancePageViewModel : BaseViewModel
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

        

        private readonly IFinanceService _financeService;
        public FinancePageViewModel(IFinanceService financeService) {

            Title = "Finance Clearance";

           _financeService = financeService;
        }


        [RelayCommand]
        async public void Submitfinancedata()
        {
            await Shell.Current.DisplayAlert("Message", $"Finance Data has been Captured", "ok");
         
            
            //call api


            var response = await _financeService.Submit(new FinanceRequest
            {
                user_id = App.UserDetails.User.Id.ToString(),
                name = Name,
                dept = Dept,
                matricno = Matricno,
                receipt = Receipt,
               
            });

            if (response != null)
            {
                await Shell.Current.DisplayAlert("Message", "finance Data has been registered successfully", "ok");
            }
            else
            {
                await Shell.Current.DisplayAlert("Message", "something went wrong", "ok");

            }
        }
    }
}
