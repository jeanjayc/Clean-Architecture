using CleanArcMvc.Application.Products.Commands;
using CleanArcMvc.Domain.Entities;
using CleanArcMvc.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArcMvc.Application.Products.Handlers
{
    public class ProductRemoveCommandHandler : IRequestHandler<ProductRemoveCommand, Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductRemoveCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Product> Handle(ProductRemoveCommand request, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProductByIdAsync(request.Id);

            if(product == null)
            {
                throw new ApplicationException($"Entity could not be found");
            }
            else
            {
                var result = await _productRepository.RemoveAsync(product);
                return result;
            }
        }   
    
    }
}

