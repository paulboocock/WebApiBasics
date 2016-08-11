using AutoMapper;
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

                cfg.CreateMap<Data.Records.Product, Core.Types.Product>();
                cfg.CreateMap<Core.Types.Product, Data.Records.Product>();

                cfg.CreateMap<Core.Types.Product, Models.Product>();
                cfg.CreateMap<Models.Product, Core.Types.Product>();
            });
        }
    }
}