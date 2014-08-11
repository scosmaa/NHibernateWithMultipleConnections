using Database1Models.Mapping;
using Database2Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateWithMultipleConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            string NHDatabase1ConnectionString = ConfigurationManager.ConnectionStrings["NHDatabase1"].ToString();
            string NHDatabase2ConnectionString = ConfigurationManager.ConnectionStrings["NHDatabase2"].ToString();

            ISessionFactory sfDB1 = SessionFactoryFactory.CreateFactory<User>(NHDatabase1ConnectionString);
            ISessionFactory sfDB2 = SessionFactoryFactory.CreateFactory<Phone>(NHDatabase2ConnectionString);

            // Database1 Save data
            User user = new User();
            user.Name = "John";
            user.Surname = "Doe";

            Computer computer = new Computer();
            computer.Brand = "ACME";
            computer.Model = "Fake COMPUTER Model";

            user.AddComputer(computer);

            ISession sessionDB1 = sfDB1.OpenSession();
            sessionDB1.Save(user);
            sessionDB1.Close();

            // Database2 Save Data
            Phone phone = new Phone();
            phone.Brand = "ACME";
            phone.Model = "Fake PHONE model";

            ISession sessionDB2 = sfDB2.OpenSession();
            sessionDB2.Save(phone);
            sessionDB2.Close();

            Console.ReadLine();

        }
    }
}