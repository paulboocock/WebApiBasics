using MediatR;
using WebApiBasics.Core.Types;

namespace WebApiBasics.Core.Requests
{
    public class AddProductRequest : IRequest<Product>
    {
        public Product Product { get; set; }
    }
}