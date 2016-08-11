using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MediatR;
using SimpleInjector;
using WebApiBasics.Data.Queries.Products;

namespace WebApiBasics.WebApp
{
    public static class MediatorConfig
    {
        public static void Configure(Container container)
        {
            var assemblies = GetAssemblies().ToArray();

            container.RegisterSingleton<IMediator, Mediator>();
            container.Register(typeof(IRequestHandler<,>), assemblies);
            container.Register(typeof(IAsyncRequestHandler<,>), assemblies);
            container.RegisterCollection(typeof(INotificationHandler<>), assemblies);
            container.RegisterCollection(typeof(IAsyncNotificationHandler<>), assemblies);
            container.RegisterSingleton(Console.Out);
            container.RegisterSingleton(new SingleInstanceFactory(container.GetInstance));
            container.RegisterSingleton(new MultiInstanceFactory(container.GetAllInstances));
        }
        
        private static IEnumerable<Assembly> GetAssemblies()
        {
            yield return typeof(IMediator).GetTypeInfo().Assembly;
            yield return typeof(GetAllProducts).GetTypeInfo().Assembly;
        }
    }
}