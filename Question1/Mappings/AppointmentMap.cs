using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class AppointmentMap:ClassMap<Appointment>
    {
        public AppointmentMap()
        {
            Id(x => x.ID);

            Map(x=>x.DateOfAppointment);

            References(x => x.doctor);

            References(x => x.patient);
        }
    }
}
