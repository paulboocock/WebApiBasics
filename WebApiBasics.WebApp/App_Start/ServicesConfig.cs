using WebApiBasics.Core;
using WebApiBasics.Core.Services;
using SimpleInjector;

namespace WebApiBasics.WebApp
{
    public static class ServicesConfig
    {
        public static void Configure(Container container)
        {
            container.Register<IProductsService, ProductsService>();
        }
    }
}