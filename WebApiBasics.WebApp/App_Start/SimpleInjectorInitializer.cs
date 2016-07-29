using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;

namespace WebApiBasics.WebApp
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            MediatorConfig.Configure(container);
            AutoMapperConfig.Configure(container);
            ServicesConfig.Configure(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}