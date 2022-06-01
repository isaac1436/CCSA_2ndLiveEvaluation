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
            Map(x => x.EmployeeID);
            Id(x => x.Name);
            Map(x => x.gender);
            HasOne(x => x.hospital);
        }
    }
}
