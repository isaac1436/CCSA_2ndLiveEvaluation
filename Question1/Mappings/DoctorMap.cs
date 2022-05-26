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

namespace Hospital_Management_System.Mappings
{
    internal class DoctorMap:ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Id(x => x.EmployeeID);
            Map(x => x.Name);
            Map(x=>x.PhoneNo);
            References(x=>x.DocsHospital);
            HasMany(x => x.Patients);
            HasMany(x => x.AppointedNurses);
        }
    }
}
