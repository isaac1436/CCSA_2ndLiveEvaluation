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
        public virtual string DateOfAppointment { get; set; }
        public virtual Doctor doctor { get; set; }

        public Appointment()
        {
            Random r = new Random();
            DateOnly day = DateOnly.FromDateTime(DateTime.Today.AddDays(r.Next(1, 8)));
            DateOfAppointment = day.ToString();
        }
    }
}
