using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Patient
    {
        public virtual int ID { get; set; }
        public virtual int HospitalNumber { get; set; }
        public virtual string Name { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual string phoneNo { get; set; }
        public virtual char gender { get; set; }
        public virtual string Condition { get; set; }
        public virtual Hospital hospital { get; set; }
        public virtual bool Confirmappointment { get;set; }
        public Appointment appointment { get; set; }

    }
}
