 using Newtonsoft.Json;
using StudentClearanceApp.Models;
using System.Text;

namespace StudentClearanceApp.Services
{
    public class LibraryService : ILibraryService
    {
       
        async  Task<LibraryResponse> ILibraryService.Submit(LibraryRequest libraryRequest) { 
            using var client = new HttpClient();

            string libraryRequestStr = JsonConvert.SerializeObject(libraryRequest);
         await Shell.Current.DisplayAlert("rlibrary request", $"{libraryRequestStr}", "ok");
            var response = await client.PostAsync("http://10.0.2.2:8000/api/library",
                new StringContent(libraryRequestStr, Encoding.UTF8, "application/json"));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
               await Shell.Current.DisplayAlert("checking resonse", $"Library data", "ok");

                return JsonConvert.DeserializeObject<LibraryResponse>(json);
            }
            else
            {
                return null;
            }
        }

      
    }
}
