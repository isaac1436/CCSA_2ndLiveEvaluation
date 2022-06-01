using Hospital_Management_System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class Program
    {
        static void Main()
        {
            var helper = new FluentNHibernateHelper();
            FluentNHibernateHelper.OpenSession();
            Accountant acct1 = new Accountant() { EmployeeID = 1, Name = "Taiwo Rosanwo", Gender = 'M' };

            Receptionist rcptnst = new Receptionist() { EmployeeID = 1, Name = "Glory Akpan", gender = 'F' };

            Pharmacist phrmcst = new Pharmacist() { EmployeeID = 1, Name = "Uboma Victory", gender = 'F' };



            Hospital hospitl = new Hospital() { Name = "Isaac's Hospital", Address = "PH", accountant = acct1, pharmacist = phrmcst, receptionist = rcptnst };


            Doctor doc = new Doctor() { Name = "Isaac Princess", gender = 'F', PhoneNo = "0805 251 4222", DocsHospital = hospitl, EmployeeID = 1 };
            Doctor doc2 = new Doctor() { Name = "Isaac Chizubem", gender = 'M', PhoneNo = "+66 065 346", DocsHospital = hospitl, EmployeeID = 2 };


            FluentNHibernateHelper.saveData(phrmcst);
            FluentNHibernateHelper.saveData(rcptnst);
            FluentNHibernateHelper.saveData(acct1);
            FluentNHibernateHelper.saveData(hospitl);
            FluentNHibernateHelper.saveData(doc);
            FluentNHibernateHelper.saveData(doc2);

            List<Patient> patients = new List<Patient>();

            for (int i = 0; i < 10; i++)
            {
                patients.Add(new Patient() { ID = i, Name = "Isaac", Condition = "Critical", gender = 'm', HospitalNumber = i + 1234, regStatus = true, phoneNo = "07054321", netWorth = 1000000 ,hospital = hospitl });
                if ((i % 2) != 0)
                {
                    patients[i].regStatus = false;
                    patients[i].currentDoctor = doc2;
                }

                else { patients[i].currentDoctor = doc; }
                FluentNHibernateHelper.saveData(patients[i]);
            }


            List<Nurse> nurses = new List<Nurse>();

            for (int i = 0; i < 10; i++)
            {
                nurses.Add(new Nurse() { Name = "Oge", gender = 'F', EmployeeID = i, hospital = hospitl });
                if ((i % 2) != 0)
                {
                    nurses[i].currentDoctor = doc2;
                }
                else { nurses[i].currentDoctor = doc; }
                FluentNHibernateHelper.saveData(nurses[i]);
            }
        }
    }
}
