 using Newtonsoft.Json;
using StudentClearanceApp.Models;
using System.Text;

namespace StudentClearanceApp.Services
{
    public class FinanceService : IFinanceService
    {
       
        async  Task<FinanceResponse> IFinanceService.Submit(FinanceRequest financeRequest) { 
            using var client = new HttpClient();

            string financeRequestStr = JsonConvert.SerializeObject(financeRequest);
       //   await Shell.Current.DisplayAlert("register request", $"{financeRequestStr}", "ok");

               // web service api....
            var response = await client.PostAsync("http://10.0.2.2:8000/api/finance",
                new StringContent(financeRequestStr, Encoding.UTF8, "application/json"));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
               // await Shell.Current.DisplayAlert("checking resonse", $"Finance data", "ok");

                return JsonConvert.DeserializeObject<FinanceResponse>(json);
            }
            else
            {
                return null;
            }
        }

      
    }
}
