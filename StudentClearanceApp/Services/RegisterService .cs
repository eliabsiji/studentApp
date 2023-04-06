
using Newtonsoft.Json;
using StudentClearanceApp.Models;
using System.Text;

namespace StudentClearanceApp.Services
{
    public class RegisterService : IRegisterService
    {
       

        async  Task<RegisterResponse> IRegisterService.Register(RegisterRequest registerRequest)
        {
            using var client = new HttpClient();

            string registerRequestStr = JsonConvert.SerializeObject(registerRequest);
          // await Shell.Current.DisplayAlert("register request", $"{registerRequestStr}", "ok");
            var response = await client.PostAsync("http://10.0.2.2:8000/api/register",
                new StringContent(registerRequestStr, Encoding.UTF8, "application/json"));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                await Shell.Current.DisplayAlert("checking resonse", $"Data has been registered successfully", "ok");

                return JsonConvert.DeserializeObject<RegisterResponse>(json);
            }
            else
            {
                return null;
            }
        }

      
    }
}
