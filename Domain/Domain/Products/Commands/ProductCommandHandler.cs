using Core.Domain.Entities;
using Core.Interface;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Products.Commands
{
    public class ProductCommandHandler : IRequestHandler<CreateProductCommand, int>, IRequestHandler<UpdateProductCommand, int>, IRequestHandler<DeleteProductCommand>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateProductValidator();
            validator.ValidateAndThrow(request);



            var product = new Product()
            {
                Name = request.Name,
                Quantity = request.Quantity,
                Price = request.Price,
                CategoryId = request.CategoryId,
            };

            _unitOfWork.Products.Add(product);
            await _unitOfWork.SaveChangesAsync();

            return product.Id;
        }

        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateProductValidator();
            validator.ValidateAndThrow(request);

            var updateModel = _unitOfWork.Products.Find(request);

            if (updateModel == null)
            {
                return -1;
            }
            updateModel.Name = request.Name;
            updateModel.Quantity = request.Quantity;
            updateModel.Price = request.Price;

            await _unitOfWork.SaveChangesAsync();

            return request.Id;
        }

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var validator = new DeleteProductValidator();
            validator.ValidateAndThrow(request);

            var deleteModel = _unitOfWork.Products.Where(r => r.Id == request.Id).FirstOrDefault();

            if (deleteModel == null)
            {
                return Unit.Value;
            }

             _unitOfWork.Products.Remove(deleteModel);
            await _unitOfWork.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
