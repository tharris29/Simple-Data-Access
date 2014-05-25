using DatabaseAccess.Models;
using DatabaseAccess.NHibernate;
using DatabaseAccess.Respository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public static class SimpleDBRunner
    {
        public static string RunLoad(int load)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            ISessionWrapper sessionWrapper = new SessionWrapper();

            var config = sessionWrapper.GetConfig("DefaultConnection");
            var session = sessionWrapper.CreateSession(config);

            var repo = new Model_Repository(session);

            while(load > 0)
            {
                RunSave(repo);
                load--;
            }


            sw.Stop();

            return String.Format("Elapsed={0}", sw.Elapsed);
        }

        private static void RunSave(Model_Repository repo)
        {
            var model = new Model() { name = "Tom Harris" };
            repo.Save(model);
        }
    }
}
