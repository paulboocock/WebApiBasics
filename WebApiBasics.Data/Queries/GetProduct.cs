using System.Collections.Generic;
using System.Linq;
using AutoMapper.QueryableExtensions;
using MediatR;
using NHibernate.Linq;
using WebApiBasics.Core.Requests;
using WebApiBasics.Core.Types;

namespace WebApiBasics.Data.Queries
{
    public class GetProduct : IRequestHandler<ProductRequest, Product>
    {
        public Product Handle(ProductRequest message)
        {
            using (var session = Database.Instance.OpenSession())
            {
                return session.Query<Records.Product>().ProjectTo<Product>().SingleOrDefault(x => x.ProductId == message.ProductId);
            }
        }
    }
}
