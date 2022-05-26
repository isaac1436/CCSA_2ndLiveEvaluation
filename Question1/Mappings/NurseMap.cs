using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class NurseMap:ClassMap<Nurse>
    {
        public NurseMap()
        {
            Id(x => x.EmployeeID);
            Map(x => x.Name);
            Map(x=>x.gender);
            References(x=>x.currentDoctor);
            References(x => x.hospital);
        }
    }
}
