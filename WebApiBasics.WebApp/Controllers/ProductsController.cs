using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using WebApiBasics.Core.Services;
using WebApiBasics.Core.Types;
using WebApiBasics.WebApp.Responses;

namespace WebApiBasics.WebApp.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public ProductsResponse Get()
        {
            return new ProductsResponse
            {
                Data = Mapper.Map<IList<Product>, IList<Models.Product>>(_productsService.GetProducts())
            };
        }

        public ProductResponse Get(int id)
        {
            return new ProductResponse
            {
                Data = Mapper.Map<Product, Models.Product>(_productsService.GetProduct(id))
            };
        }
    }
}