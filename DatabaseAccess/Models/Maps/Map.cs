using DatabaseAccess.Models;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess.Maps
{
    public class Map: ClassMap<Model>
    {
        public Map()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.name).Length(50);
        }
    }
}
