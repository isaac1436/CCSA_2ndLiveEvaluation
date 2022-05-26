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
            Accountant acct1 = new Accountant() { EmployeeID = 1, Name = "Isaac Desmond", Gender = 'M' };
            FluentNHibernateHelper.saveData(acct1);

            Doctor doc = new Doctor() { EmployeeID = 1, Name = "Isaac", gender = 'F', PhoneNo = "07052511362" };

            List<Patient> patients = new List<Patient>();

            for (int i = 0; i < 10; i++)
            {
                patients.Add(new Patient() { Name = "Isaac", Condition = "Critical", gender = 'm', ID = i, HospitalNumber = i + 1234, regStatus = true, phoneNo = "07054321", netWorth = 1000000 }); ;
                if ((i % 2) != 0)
                {
                    patients[i].regStatus = false;
                }
                FluentNHibernateHelper.saveData(patients[i]);
            }

            List<Nurse> nurses = new List<Nurse>();

            for (int i = 0; i < 10; i++)
            {
                nurses.Add(new Nurse() { Name = "Oge", gender = 'F', EmployeeID = i + 100 });
                FluentNHibernateHelper.saveData(nurses[i]);
            }

            List<Doctor> docs = new List<Doctor>();
            docs.Add(doc);

            Hospital hospital = new Hospital() { Name = "Isaac's Hospital", Address = "PH", ID = 1};

            doc.DocsHospital = hospital;

            FluentNHibernateHelper.saveData(hospital);
            FluentNHibernateHelper.saveData(doc);
        }
    }
}
