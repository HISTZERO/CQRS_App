using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Products.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }

    }

    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(c => c.CategoryId).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
        }
    }


}
