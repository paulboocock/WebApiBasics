using AutoMapper;
using WebApiBasics.Data.Records;
using SimpleInjector;

namespace WebApiBasics.WebApp
{
    public static class AutoMapperConfig
    {
        public static void Configure(Container container)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.ConstructServicesUsing(container.GetInstance);
                cfg.CreateMap<Product, Core.Types.Product>();
                cfg.CreateMap<Core.Types.Product, Models.Product>();
            });
        }
    }
}