using System.Collections.Generic;
using WebApiBasics.WebApp.Models;

namespace WebApiBasics.WebApp.Responses
{
    public class ProductsResponse : ErrorResponse
    {
        public IList<Product> Data { get; set; }
    }
}