using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using WebApiBasics.Core.Services;
using WebApiBasics.WebApp.Models;

namespace WebApiBasics.WebApp.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return Mapper.Map<IList<Core.Types.Product>, IList<Product>>(_productsService.GetProducts());
        }

        [Route("{id:int}", Name = "GetProductById")]
        [HttpGet]
        public Product GetProduct(int id)
        {
            return Mapper.Map<Core.Types.Product, Product>(_productsService.GetProduct(id));
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult AddProduct(Product product)
        {
            var createdProduct = _productsService.AddProduct(Mapper.Map<Product, Core.Types.Product>(product));
            return CreatedAtRoute("GetProductById", new { Id = createdProduct.ProductId }, Mapper.Map<Core.Types.Product, Product>(createdProduct));
        }
    }
}
