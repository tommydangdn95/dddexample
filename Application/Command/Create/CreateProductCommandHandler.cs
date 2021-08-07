using Domain;
using Infrastructure.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Command.Create
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Unit>
    {
        private readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product(Guid.NewGuid(), request.Name, request.Price);

            product.TransformNameUppercase();

            // bussiness 
            var modelProduct = new Infrastructure.Model.Product
            {
                Id = product.Id,
                Name = product.Name,
                Amount = product.Price.Amount,
                Concurency = product.Price.Concurrency
            };

            // save db 
            await this._productRepository.CreateProductAsync(modelProduct);


            return await Task.FromResult(Unit.Value);
        }
    }
}
