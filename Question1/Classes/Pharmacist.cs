using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public class Pharmacist
    {
        public virtual int EmployeeID { get; set; }
        public virtual string Name { get; set; }
        public virtual char gender { get; set; }
        public virtual Hospital hospital { get; set; }

        
    }

}
