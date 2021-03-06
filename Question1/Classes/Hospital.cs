using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Hospital
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
        public virtual List<Nurse> Nurses { get; set; }
        public virtual Receptionist receptionist { get; set; }
        public virtual Pharmacist pharmacist { get; set; }
        public virtual Accountant accountant { get; set; }

    }
}
