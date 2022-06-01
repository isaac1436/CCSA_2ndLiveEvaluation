using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class HospitalMap : ClassMap<Hospital>
    {
        public HospitalMap()
        {
            Map(x => x.ID);
            Id(x => x.Name);
            Map(x => x.Address);
            References(x => x.accountant);
            References(x => x.pharmacist);
            References(x => x.receptionist);
            HasMany(x => x.Patients);
            HasMany(x => x.Doctors);
            HasMany(x => x.Nurses);
            
        }
    }
}
