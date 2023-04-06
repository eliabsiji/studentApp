using Newtonsoft.Json;
using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Services
{
    public class UserProfileService : IUserProfileService
    {
      
        public UserProfileService() { 
        
        }

       async Task<UserProfileResponse> IUserProfileService.GetUserProfile(UserProfileIdRequest userProfileIdRequest)
        {

            using var client = new HttpClient();

            //string userprofileIdStr = userProfileIdRequest;
           // casting string to int...
            int id = userProfileIdRequest.id;
            // await Shell.Current.DisplayAlert("register request", $"{registerRequestStr}", "ok");
            var response = await client.GetAsync($"http://10.0.2.2:8000/api/userprofile/{id}");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();

                //await Shell.Current.DisplayAlert("checking resonse", $"{json}", "ok");

                return JsonConvert.DeserializeObject<UserProfileResponse>(json);
            }
            else
            {
                return null;
            }
        }
    }
}
