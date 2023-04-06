using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Services
{
   public interface IStudentaffairsService
    {
        //add method for this interface...
        public Task<StudentAffairsResponse> Submit(StudentAffairsRequest studentAffairsRequest);

    }
}
