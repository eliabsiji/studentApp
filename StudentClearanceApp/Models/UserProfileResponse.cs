using Newtonsoft.Json;


namespace StudentClearanceApp.Models
{
   public class UserProfileResponse
    {
           [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
            public string Status { get; set; }

            [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
            public object Message { get; set; }

            [JsonProperty("profiledata", NullValueHandling = NullValueHandling.Ignore)]
            public Profiledata Profiledata { get; set; }
        
    }

}
