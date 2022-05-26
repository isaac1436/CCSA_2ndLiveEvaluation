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
            Id(x => x.ID);
            Map(x => x.Name);
            Map(x => x.Address);
            HasMany(x => x.HospitalPatients);
            HasMany(x => x.Doctors);
            HasMany(x => x.Nurses);
            HasOne(x => x.accountant);
            HasOne(x => x.pharmacist);
            HasOne(x => x.receptionist);
        }
    }
}
