using System.Collections.Generic;
using MediatR;
using WebApiBasics.Core.Types;

namespace WebApiBasics.Core.Requests
{
    public class AllProductsRequest : IRequest<IList<Product>>
    {
    }
}