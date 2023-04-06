using Newtonsoft.Json;

namespace StudentClearanceApp.Models;

public class Userdata
{
    [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
    public User User { get; set; }

    [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
    public string Token { get; set; }

}

public class User
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public int Id { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string Email { get; set; }

    [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
    public DateTime UpdatedAt { get; set; }
}

