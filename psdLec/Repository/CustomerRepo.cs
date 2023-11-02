using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using psdLec.Factory;

namespace psdLec.Repository
{
    public class CustomerRepo
    {
        static MydatabaseEntities2 db = Singleton.GetInstance();
        public static void save()
        {
            db.SaveChanges();
        }
        public static Customer InsertCustomer(string name, string email, string phone, string password)
        {
            int id = db.Customers.Count() + 1;
            db.Customers.Add(CustomerFactory.createCustomer(id, name, email, phone, password));
            save();

            return findCustomer(email);
        }
        public static void DeleteCustomer(Customer u)
        {
            db.Customers.Remove(u);
            save();
        }
        public static List<Customer> GetCustomer()
        {
            return (from Customer in db.Customers select Customer).ToList();
        }

        public static Customer findCustomer(string email, string password)
        {
            Customer cs = (from c in db.Customers where c.customer_email.Equals(email) && c.customer_password.Equals(password) select c).FirstOrDefault();
            return cs;
        }

        public static Customer findCustomer(string email)
        {
            Customer cs = (from c in db.Customers where c.customer_email.Equals(email) select c).FirstOrDefault();
            return cs;
        }

        public static Customer findCustomer(int id)
        {
            Customer cs = (from c in db.Customers where c.customer_id.Equals(id) select c).FirstOrDefault();
            return cs;
        }
    }
}