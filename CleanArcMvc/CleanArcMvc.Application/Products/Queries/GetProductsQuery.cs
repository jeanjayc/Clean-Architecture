using CleanArcMvc.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CleanArcMvc.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}
