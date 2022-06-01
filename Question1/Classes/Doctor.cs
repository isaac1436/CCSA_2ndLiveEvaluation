using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Doctor
    {
        public virtual int EmployeeID { get; set; }
        public virtual string Name { get; set; }
        public virtual string PhoneNo { get; set; }
        public virtual char gender { get; set; }
        public virtual List<Appointment> appointments { get; set; }
        public virtual Hospital DocsHospital { get; set; }
        public virtual List<Patient> Patients { get; set; }
        public virtual List<Nurse> AppointedNurses { get; set; }
       
    }

}
