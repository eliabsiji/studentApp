using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Models
{

    public class Financedata
    {
        [JsonProperty("finance", NullValueHandling = NullValueHandling.Ignore)]
        public Finance Finance;
    }
    public class Finance
    {
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId;

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name;

        [JsonProperty("matricno", NullValueHandling = NullValueHandling.Ignore)]
        public string Matricno;

        [JsonProperty("dept", NullValueHandling = NullValueHandling.Ignore)]
        public string Dept;

        [JsonProperty("receipt", NullValueHandling = NullValueHandling.Ignore)]
        public string Receipt;

        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt;

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt;

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id;
    }

    
}
