using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Services
{
    public class LoginService : ILoginService
    {
        
        async Task<LoginResponse>ILoginService.Authenticate(LoginRequest loginRequest)
        {
             using var client = new HttpClient();
          
            string loginRequestStr = JsonConvert.SerializeObject(loginRequest);
          //  await AppShell.Current.DisplayAlert("valid user", $"{loginRequestStr}", "ok");
           var response = await client.PostAsync("http://10.0.2.2:8000/api/login",
               new StringContent(loginRequestStr, Encoding.UTF8, "application/json"));

           
        

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
             {
                 var json = await response.Content.ReadAsStringAsync();
              //  await Shell.Current.DisplayAlert("valid ppppp", $"{json}", "ok");
                return JsonConvert.DeserializeObject<LoginResponse>(json);
                    
             }
             else
             {
                 return null;
             }
        }

       
    }
}
