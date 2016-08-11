using System.Collections.Generic;
using MediatR;
using WebApiBasics.Core.Requests;
using WebApiBasics.Core.Types;

namespace WebApiBasics.Core.Services
{
    public interface IProductsService
    {
        IList<Product> GetProducts();
        Product GetProduct(int productId);
        Product AddProduct(Product product);
    }

    public class ProductsService : IProductsService
    {
        private readonly IMediator _mediator;

        public ProductsService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IList<Product> GetProducts()
        {
            return _mediator.Send(new AllProductsRequest());
        }

        public Product GetProduct(int productId)
        {
            return _mediator.Send(new ProductRequest
            {
                ProductId = productId
            });
        }

        public Product AddProduct(Product product)
        {
            return _mediator.Send(new AddProductRequest
            {
                Product = product
            });
        }
    }
}