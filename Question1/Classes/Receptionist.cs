using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Receptionist
    {
        public virtual int EmployeeID { get; set; }
        public virtual string Name { get; set; }
        public Hospital hospital { get; set; }
        public virtual List<Patient> Patients { get { return Patients; } set { Patients.AddRange(hospital.HospitalPatients); } }

        public bool checkReg(Patient patient)
        {
            if(patient.HospitalNumber == null)
            {
                Console.WriteLine("Please go and register");
                return false;
            }
            else { return true; }
        }
        public void appointmentCheck(Patient patient)
        {
            if (patient.appointment == null) { patient.appointment.DateOfAppointment.AddDays(1); }
        }
    }
}
