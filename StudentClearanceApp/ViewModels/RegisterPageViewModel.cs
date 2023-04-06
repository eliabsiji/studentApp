using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using StudentClearanceApp.Services;
using CommunityToolkit.Maui;
using StudentClearanceApp.Views.Dashboard;
using StudentClearanceApp.Models;
using Newtonsoft.Json;
using FluentValidation;
using Microsoft.Maui.Controls;
using DocuSign.eSign.Model;

namespace StudentClearanceApp.ViewModels.Startups;
public partial class RegisterPageViewModel : BaseViewModel 
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

    


    private readonly IRegisterService _registerService;
   private readonly RegisterValidator _validations;

    public RegisterPageViewModel(IRegisterService registerService /*,RegisterValidator validations*/)
    {
       
        Title = "Student Registraion";
       _registerService = registerService;
       // _validations = validations;
    }

   

    [RelayCommand]
   async public void SubmitRegistration()
    {/*
        var rr = new RegisterRequest
        {
            firstname = Firstname,
            lastname = Lastname,
            othername = Othername,
            phone = Phone,
            state = State,
            maritalstatus = Maritalstatus,
            matricno = Matricno,
            gender = Gender,
            religion = Religion,
            session = Session,
            dept = Dept,
            qualification = Qualification,
            level = Level,
            year = Year,
            school = School,
            username = Username,
            email = Email,
            password = Password
        };
       
        var results = _validations.Validate(rr);
        string allMessages = results.ToString(" \n \n");
        if (!results.IsValid)
        {
          await Shell.Current.DisplayAlert("Message", $"{allMessages}", "ok"); 
          return;
        }
*/
       await Shell.Current.DisplayAlert("Message", $"Data has been Captured", "ok");

        //call api


        var response = await _registerService.Register(new RegisterRequest
        {
            firstname = Firstname,
            lastname = Lastname,
            othername = Othername,
            phone = Phone,
            state = State,
            maritalstatus = Maritalstatus,
            matricno = Matricno,
            gender = Gender,
            religion = Religion,
            session = Session,
            dept = Dept,
            qualification = Qualification,
            level = Level,
            year = Year,
            school = School,
            username = Username,
            email = Email,
            password = Password
        });

        if (response != null )
        {
            await Shell.Current.DisplayAlert("Message", "Data has been registered successfully", "ok");
        }
        else
        {
            await Shell.Current.DisplayAlert("Message", "something went wrong", "ok");

        }
    }

}