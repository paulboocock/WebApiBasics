using System;
using AutoMapper;
using MediatR;
using WebApiBasics.Core.Requests;
using WebApiBasics.Core.Types;

namespace WebApiBasics.Data.Commands.Products
{
    public class AddProduct : IRequestHandler<AddProductRequest, Product>
    {
        public Product Handle(AddProductRequest request)
        {
            using (var session = Database.Instance.OpenSession())
            {
                var record = Mapper.Map<Product, Records.Product>(request.Product);
                session.SaveOrUpdate(record);
                return Mapper.Map<Records.Product, Product>(record);
            }
        }
    }
}
