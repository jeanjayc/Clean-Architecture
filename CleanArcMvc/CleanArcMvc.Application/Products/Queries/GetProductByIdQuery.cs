using CleanArcMvc.Domain.Entities;
using MediatR;

namespace CleanArcMvc.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
