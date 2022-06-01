using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class PharmacistMap:ClassMap<Pharmacist>
    {
        public PharmacistMap()
        {
            Map(x => x.EmployeeID);
            HasOne(x => x.hospital);
            Id(x => x.Name);
            Map(x => x.gender);
        }
    }
}
