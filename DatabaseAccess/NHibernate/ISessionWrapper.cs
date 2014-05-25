using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public interface ISessionWrapper
    {
        ISession CreateSession(IPersistenceConfigurer config);

        IPersistenceConfigurer GetConfig(string connectionName);
    }
}
