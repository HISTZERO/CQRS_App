using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Users.Commands
{
    public class CreateRoleCommand : IRequest
    {
        public string RoleName { get; set; }
    }

    public class CreateRoleValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleValidator()
        {
            RuleFor(c => c.RoleName).NotEmpty();
        
        }
    }
}
