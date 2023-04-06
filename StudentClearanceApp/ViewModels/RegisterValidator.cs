using FluentValidation;
using StudentClearanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClearanceApp.ViewModels
{
    public class RegisterValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterValidator() {

            RuleFor(registerRequest => registerRequest.firstname).NotNull();
               // .WithMessage("First Name field cannot be empty");
            RuleFor(registerRequest => registerRequest.lastname).NotNull();
            // .WithMessage("Last Name field cannot be empty");
            RuleFor(registerRequest => registerRequest.othername).NotNull();
            // .WithMessage("Other Name field cannot be empty");
            RuleFor(registerRequest => registerRequest.phone).NotNull();
            // .WithMessage("Phone cannot field be empty");
            RuleFor(registerRequest => registerRequest.email).NotNull();
            // .WithMessage("Email cannot field be empty");
            RuleFor(registerRequest => registerRequest.maritalstatus).NotNull();
            // .WithMessage("Marital Status field cannot be empty");
            RuleFor(registerRequest => registerRequest.matricno).NotNull();
            //   .WithMessage("Matric No field cannot be empty");
            RuleFor(registerRequest => registerRequest.school).NotNull();
            //  .WithMessage("School field cannot be empty");
            RuleFor(registerRequest => registerRequest.level).NotNull();
            //  .WithMessage("Level field cannot be empty");
            RuleFor(registerRequest => registerRequest.dept).NotNull();
            //  .WithMessage("Department field  cannot be empty");
            RuleFor(registerRequest => registerRequest.year).NotNull();
            // .WithMessage("Year cannot field be empty");
            RuleFor(registerRequest => registerRequest.session).NotNull();
            // .WithMessage("Session cannot be empty");
            RuleFor(registerRequest => registerRequest.qualification).NotNull();
            //  .WithMessage("Qualification field cannot be empty");
            RuleFor(registerRequest => registerRequest.gender).NotNull();
            //  .WithMessage("Gender fieldcannot be empty");
            RuleFor(registerRequest => registerRequest.state).NotNull();
            // .WithMessage("State field  be empty");
            RuleFor(registerRequest => registerRequest.religion).NotNull();
            // .WithMessage("Religion field cannot be empty");
            RuleFor(registerRequest => registerRequest.username).NotNull();
            // .WithMessage("Username field cannot be empty");
            RuleFor(registerRequest => registerRequest.password).NotNull();
            // .WithMessage("Password  field cannot be empty");

        }
    }
}
