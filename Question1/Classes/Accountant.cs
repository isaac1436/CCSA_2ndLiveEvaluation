using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Accountant
    {
        public virtual int EmployeeID { get; set; }
        public virtual string Name { get; set; }
        public virtual char Gender { get; set; }
        public virtual Hospital hospital { get; set; }
        public virtual double calcBills(Patient patient)
        {
            double totalAmt=patient.netWorth;


            return totalAmt;
        }

    }
}
