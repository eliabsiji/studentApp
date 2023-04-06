﻿using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.Services
{
   public interface IRegisterService
    {
        //add method for this interface...
        public Task<RegisterResponse> Register(RegisterRequest registerRequest);

    }
}
