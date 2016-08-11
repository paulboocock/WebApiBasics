using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using WebApiBasics.Core.Services;
using WebApiBasics.Core.Types;
using WebApiBasics.WebApp.Responses;

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
        public ProductsResponse Get()
        {
            return new ProductsResponse
            {
                Data = Mapper.Map<IList<Product>, IList<Models.Product>>(_productsService.GetProducts())
            };
        }

        [Route("{id:int}", Name = "GetProductById")]
        [HttpGet]
        public ProductResponse Get(int id)
        {
            return new ProductResponse
        {
                Data = Mapper.Map<Product, Models.Product>(_productsService.GetProduct(id))
            };
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult AddProduct(Models.Product product)
        {
            var createdProduct = _productsService.AddProduct(Mapper.Map<Models.Product, Product>(product));
            return CreatedAtRoute("GetProductById", new { Id = createdProduct.ProductId }, Mapper.Map<Product, Models.Product>(createdProduct));
        }
    }
}
