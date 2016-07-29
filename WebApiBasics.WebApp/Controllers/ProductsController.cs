using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using WebApiBasics.Core.Services;
using WebApiBasics.WebApp.Models;

namespace WebApiBasics.WebApp.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public IEnumerable<Product> Get()
        {
            return Mapper.Map<IList<Core.Types.Product>, IList<Product>>(_productsService.GetProducts());
        }

        public Product Get(int id)
        {
            return Mapper.Map<Core.Types.Product, Product>(_productsService.GetProduct(id));
        }
    }
}
