using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{    
    public class AccountantMap:ClassMap<Accountant>
    {
        public AccountantMap()
        {
            Map(x => x.EmployeeID);
            Id(x => x.Name);
            HasOne(x => x.hospital);
            Map(x => x.Gender);
        }
    }
}
