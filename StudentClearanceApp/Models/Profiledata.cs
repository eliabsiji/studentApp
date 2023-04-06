using Newtonsoft.Json;

namespace StudentClearanceApp.Models
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Profiledata
    {
        [JsonProperty("userprofile", NullValueHandling = NullValueHandling.Ignore)]
        public Userprofile Userprofile { get; set; }
    }

    public class Userprofile
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

        [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
        public string Firstname { get; set; }

        [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastname { get; set; }

        [JsonProperty("othername", NullValueHandling = NullValueHandling.Ignore)]
        public string Othername { get; set; }

        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("religion", NullValueHandling = NullValueHandling.Ignore)]
        public string Religion { get; set; }

        [JsonProperty("maritalstatus", NullValueHandling = NullValueHandling.Ignore)]
        public string Maritalstatus { get; set; }

        [JsonProperty("matricno", NullValueHandling = NullValueHandling.Ignore)]
        public string Matricno { get; set; }

        [JsonProperty("school", NullValueHandling = NullValueHandling.Ignore)]
        public string School { get; set; }

        [JsonProperty("session", NullValueHandling = NullValueHandling.Ignore)]
        public string Session { get; set; }

        [JsonProperty("year", NullValueHandling = NullValueHandling.Ignore)]
        public string Year { get; set; }

        [JsonProperty("dept", NullValueHandling = NullValueHandling.Ignore)]
        public string Dept { get; set; }

        [JsonProperty("qualification", NullValueHandling = NullValueHandling.Ignore)]
        public string Qualification { get; set; }

        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public string Gender { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }
    }
}
