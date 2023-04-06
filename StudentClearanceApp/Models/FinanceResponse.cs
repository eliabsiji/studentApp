using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Models
{
    
    public class FinanceResponse
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status;

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public object Message;

        [JsonProperty("financedata", NullValueHandling = NullValueHandling.Ignore)]
        public Financedata Financedata;
    }



}
