using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Products.Commands
{
    public class DeleteProduct : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteProductValidator : AbstractValidator<DeleteProduct>
    {
        public DeleteProductValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
