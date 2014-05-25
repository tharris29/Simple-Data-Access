using DatabaseAccess.Maps;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.NHibernate
{
    public class SessionWrapper : ISessionWrapper
    {
        public ISession CreateSession(IPersistenceConfigurer config)
        {
            var sessionFactory = Fluently.Configure()
                .Database(config)
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Map>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(true, true, false))
                .BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            return session;
        }

        public IPersistenceConfigurer GetConfig(string connectionName)
        {
           var config = MsSqlConfiguration.MsSql2012.ConnectionString(x => x.FromConnectionStringWithKey(connectionName));
            return config;
        }
    }
}
