using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels;

[INotifyPropertyChanged]
    public partial class BaseViewModel 
    {

        [ObservableProperty]
        string title;

        [ObservableProperty]
        string isBusy;

    }

