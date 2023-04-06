using Microsoft.Extensions.Logging;
using StudentClearanceApp.Views.Startups;
using StudentClearanceApp.ViewModels.Startups;
using StudentClearanceApp.Views.Dashboard;
using StudentClearanceApp.ViewModels.Dashboard;
using StudentClearanceApp.ViewModels;
using StudentClearanceApp.Services;
using CommunityToolkit.Maui;

namespace StudentClearanceApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
       

        //registering services...
        builder.Services.AddSingleton<ILoginService, LoginService>();
        builder.Services.AddSingleton<IRegisterService,RegisterService>();
        builder.Services.AddSingleton<IUserProfileService, UserProfileService>();
        builder.Services.AddSingleton<IFinanceService, FinanceService>();
        builder.Services.AddSingleton<ILibraryService, LibraryService>();


        //registering views...
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoadingPage>();
        builder.Services.AddSingleton<RegisterPage>();

        //registering dashboard views...
        builder.Services.AddSingleton<DashboardPage>();
        builder.Services.AddSingleton<ProfilePage>();
        builder.Services.AddTransient<BioDataPage>();
        builder.Services.AddTransient<FinancePage>();
        builder.Services.AddTransient<LibraryPage>();




        //registering view models...
        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<RegisterPageViewModel>();
        builder.Services.AddSingleton<RegisterValidator>();

        //dashboards view model 
        builder.Services.AddSingleton<DashboardPageViewModel>();
        builder.Services.AddTransient<BioDataPageViewModel>();
        builder.Services.AddSingleton<ProfilePageViewModel>();
        builder.Services.AddSingleton<FinancePageViewModel>();
        builder.Services.AddSingleton<LibraryPageViewModel>();

        //loading pages
        builder.Services.AddSingleton<LoadingPageViewModel>();
      


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
