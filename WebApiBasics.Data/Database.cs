using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace WebApiBasics.Data
{
    public class Database
    {
        private readonly ISessionFactory _sessionFactory;
        private static readonly Lazy<Database> LazyInstance = new Lazy<Database>(() => new Database());

        public static Database Instance => LazyInstance.Value;

        private Database()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["AzureSQLConnection"].ConnectionString;

            _sessionFactory = Fluently.Configure()
                          .Database(MsSqlConfiguration.MsSql2005
                            .ConnectionString(connectionString))
                          .Mappings(m => m
                            .FluentMappings.AddFromAssemblyOf<Maps.ProductMap>())
                          .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
