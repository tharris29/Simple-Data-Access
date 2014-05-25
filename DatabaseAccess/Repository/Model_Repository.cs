using FluentNHibernate.Cfg;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using DatabaseAccess.Models;

namespace DatabaseAccess.Respository
{
    public class Model_Repository
    {
        private ISession _session;

        public Model_Repository(ISession session)
        {
            _session = session;
        }

        public IList<Model> Get()
        {
            var entities =  _session.Query<Model>();

            return entities.ToList();

        }

        public void Save(Model model)
        {
            var entities = _session.Query<Model>();

            _session.Transaction.Begin();
          
            _session.Save(model);

            _session.Transaction.Commit();
        }
    }
}
