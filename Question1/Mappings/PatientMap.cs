using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Id(x => x.ID);
            Map(x => x.HospitalNumber);
            Map(x => x.regStatus);
            Map(x => x.Name);
            Map(x => x.gender);
            Map(x => x.phoneNo);
            Map(x => x.Condition);
            Map(x => x.netWorth);
            HasOne(x => x.appointment);
            References(x => x.currentDoctor);
            References(x => x.hospital);
        }
    }
}
