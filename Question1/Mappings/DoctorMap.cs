
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    internal class DoctorMap:ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Map(x => x.EmployeeID);
            Id(x => x.Name);
            Map(x=>x.PhoneNo);
            Map(x => x.gender);
            HasMany(x => x.appointments);
            HasMany(x => x.Patients);
            References(x => x.DocsHospital);            
            HasMany(x => x.AppointedNurses);
        }
    }
}
