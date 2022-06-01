using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Appointment
    {
        public virtual int ID { get; set; }
        public virtual DateTime DateOfAppointment { get { return DateOfAppointment; } set { setAppointment(); } }
        public virtual Doctor doctor { get; set; }
        public virtual Patient patient { get; set; }

        public virtual void setAppointment()
        {
            Random r = new Random();
            DateTime day = DateTime.Today.AddDays(r.Next(1, 8));
            DateOfAppointment = day;
        }

    }
}
