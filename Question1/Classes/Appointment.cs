using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Appointment
    {
        public DateOnly DateOfAppointment
        {
            get { return DateOfAppointment; }
            set
            {
                Random r = new Random();
                DateOfAppointment = DateOnly.FromDateTime(DateTime.Today.AddDays(r.Next(1,8)));
            }
        }

        public Doctor doctor { get; set; }

    }
}
