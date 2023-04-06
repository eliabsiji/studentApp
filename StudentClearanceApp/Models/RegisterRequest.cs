using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Models
{
    public  class RegisterRequest
    {

        public string firstname { get; set; }
        public string lastname { get; set; }
        public string othername { get; set; }
        public string phone { get; set; }
        public string state { get; set; }
        public string maritalstatus { get; set; }
        public string matricno { get; set; }
        public string gender { get; set; }
        public string religion { get; set; }
        public string level { get; set; }
        public string session { get; set; }
        public string dept { get; set; }
        public string qualification { get; set; }
        public string year { get; set; }
        public string school { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
