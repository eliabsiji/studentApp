using Newtonsoft.Json;

namespace StudentClearanceApp.Models
{
    public class RegisterResponse
    {
  
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }


        [JsonProperty("userdata", NullValueHandling = NullValueHandling.Ignore)]
        public Userdata Userdata { get; set; }

    }
}
