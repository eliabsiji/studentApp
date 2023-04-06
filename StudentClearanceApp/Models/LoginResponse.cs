using Newtonsoft.Json;

namespace StudentClearanceApp.Models
{
    public class LoginResponse
    {
  
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public object Message { get; set; }

        [JsonProperty("userdata", NullValueHandling = NullValueHandling.Ignore)]
        public Userdata Userdata { get; set; }

    }
}
