using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class ReceptionistMap:ClassMap<Receptionist>
    {
        public ReceptionistMap()
        {
            Id(x => x.EmployeeID);
            Map(x => x.Name);
            HasOne(x => x.hospital);
            HasMany(x => x.Patients);
        }
    }
}
