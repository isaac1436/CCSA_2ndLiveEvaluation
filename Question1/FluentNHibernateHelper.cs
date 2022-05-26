using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;


namespace Hospital_Management_System
{
    public class FluentNHibernateHelper
    {
        private ISessionFactory _sessionFactory;
        private ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitialiseSessionFactory();
                }
                return _sessionFactory;
            }
        }
        
    public void InitialiseSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(
                MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\Hospital_Management_Database.mdf; Integrated Security = True; Connect Timeout = 30"))
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();//Initialise Session Factory
        }
        
    public ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
