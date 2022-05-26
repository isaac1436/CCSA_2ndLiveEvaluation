//NHibernate helps you link your C# class to your table/database
//Entity Framework core can also do this
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Hospital_Management_System
{
    public class FluentNHibernateHelper
    {
        //The session factory links your objects/code to your database
        public static ISessionFactory? _sessionFactory;

        public static ISessionFactory SessionFactory
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


        public static void InitialiseSessionFactory()
        {
            //Fluently.Configure( ) connects your session factory to your database
            //To initialise your database you need your connection string as it gives you access to your database

            _sessionFactory = Fluently.Configure().Database(

                MsSqlConfiguration.MsSql2012.ConnectionString(
                    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\Hospital_Management_Database.mdf;Integrated Security=True;Connect Timeout=30"
                    )
                .ShowSql())

                //Mapping helps the database recognise which properties become the columns to use to create the table
                .Mappings(map => map.FluentMappings.AddFromAssemblyOf<Program>())

                //This ensures that the databse is created            
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))

                .BuildSessionFactory();


        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static void saveData<T>(T model)
        {
            var session = FluentNHibernateHelper.OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Save(model);
                transaction.Commit();
            }
        }

        public static void updateData<T>(T model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Update(model);
                transaction.Commit();
            }
        }

        public static void deleteData<T>(T model)
        {
            var session = OpenSession();
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(model);
                transaction.Commit();
            }
        }
    }
}
