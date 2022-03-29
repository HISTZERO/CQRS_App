using Core.Domain.Products.Dto;
using Core.Interface;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Products.Queries
{
    public class ProductQueryHandler : IRequestHandler<GetProductQuery,ProductDto>, IRequestHandler<GetAllProductsQuery ,List<ProductDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductDto> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product = await _unitOfWork.Products.Where(s => s.Id == request.Id).Select(s => new ProductDto
            {
                Name = s.Name,
                Quantity = s.Quantity,
                Price = s.Price,
                CategoryName = s.Category.Name
            }).FirstOrDefaultAsync();

            return product;
            
        }

     
        public async Task<List<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _unitOfWork.Products.Select(s => new ProductDto
            {
                Name = s.Name,
                Quantity = s.Quantity,
                Price = s.Price,
                CategoryName = s.Category.Name
            }).ToListAsync();

            return products;
        }
    }
}
