 using Newtonsoft.Json;
using StudentClearanceApp.Models;
using System.Text;

namespace StudentClearanceApp.Services
{
    public class StudentAffairsService : IStudentaffairsService
    {
        public Task<StudentAffairsResponse> Submit(StudentAffairsRequest studentAffairsRequest)
        {
            throw new NotImplementedException();
        }

        async  Task<StudentAffairsResponse> IStudentaffairsService.Submit(StudentAffairsRequest studentAffairsRequest) { 
            using var client = new HttpClient();

            string studentAffairsRequestStr  = JsonConvert.SerializeObject(studentAffairsRequest);
       //   await Shell.Current.DisplayAlert("register request", $"{financeRequestStr}", "ok");
            var response = await client.PostAsync("http://10.0.2.2:8000/api/studentaffairs",
                new StringContent(studentAffairsRequestStr, Encoding.UTF8, "application/json"));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
               // await Shell.Current.DisplayAlert("checking resonse", $"Finance data", "ok");

                return JsonConvert.DeserializeObject<StudentAffairsResponse>(json);
            }
            else
            {
                return null;
            }
        }

      
    }
}
