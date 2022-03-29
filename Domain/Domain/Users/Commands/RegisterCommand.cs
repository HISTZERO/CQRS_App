using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Users
{
    public class RegisterCommand : IRequest
    {
        
        public string? Username { get; set; }
        
        public string? Email { get; set; }

        public string? Password { get; set; }

        public string RoleName { get; set; }
    }

    public class RegisterValidator: AbstractValidator<RegisterCommand>
    {
        public RegisterValidator()
        {
            RuleFor(c => c.Username).NotEmpty();
            RuleFor(c => c.Email).NotEmpty();
            RuleFor(c => c.Password).NotEmpty();
        }
    }
}
