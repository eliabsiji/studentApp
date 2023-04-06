using FluentValidation;
using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels
{
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator() {

           
            RuleFor(registerRequest => registerRequest.email).NotEmpty()
                .WithMessage("Username field cannot be empty");
            RuleFor(registerRequest => registerRequest.password).NotEmpty()
                .WithMessage("Password  field cannot be empty");

        }
    }
}
