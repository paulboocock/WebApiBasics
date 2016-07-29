using MediatR;
using WebApiBasics.Core.Types;

namespace WebApiBasics.Core.Requests
{
    public class ProductRequest : IRequest<Product>
    {
        public int ProductId { get; set; }
    }
}