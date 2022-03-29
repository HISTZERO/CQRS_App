using Core.Domain.Products.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Products.Queries
{
    public class GetAllProductsQuery : IRequest<List<ProductDto>>
    {
        public GetAllProductsQuery()
        {

        }
    }
}
