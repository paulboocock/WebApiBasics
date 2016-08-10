using System;
using WebApiBasics.WebApp.Models;

namespace WebApiBasics.WebApp.Responses
{
    public class ProductResponse : ErrorResponse
    {
        public Product Data { get; set; }
    }
}