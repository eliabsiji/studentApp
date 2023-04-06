using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Services
{
   public interface IFinanceService
    {
        //add method for this interface...
        public Task<FinanceResponse> Submit(FinanceRequest financeRequest);

    }
}
