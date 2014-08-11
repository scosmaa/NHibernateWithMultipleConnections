using FluentNHibernate.Cfg;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateWithMultipleConnections
{
    public static class SessionFactoryFactory
    {
        public static ISessionFactory CreateFactory<T>(string connectionString)
        {
            var cfg = new Configuration()
                .Configure()
                .SetProperty(NHibernate.Cfg.Environment.ConnectionString, connectionString);

            return Fluently.Configure(cfg)
                .Mappings(
                  m => m.FluentMappings.AddFromAssemblyOf<T>())
                  .ExposeConfiguration(config =>
                  {
                      SchemaExport se = new SchemaExport(config);
                      se.Drop(true, true);
                      se.Create(true, true);
                  })
                .BuildSessionFactory();
        }
    }
}
