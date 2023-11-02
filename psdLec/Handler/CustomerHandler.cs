using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using psdLec.Model;
using psdLec.Repository;

namespace psdLec.Handler
{
    public class CustomerHandler
    {
        public static Customer login(string email, string password)
        {
            Customer cs = CustomerRepo.findCustomer(email, password);
            if (cs == null)
            {
                return null;
            }
            return cs;
        }
        public static Customer register(string name, string email, string phone, string password)
        {
            Customer cs = CustomerRepo.findCustomer(email);
            if (cs != null)
            {
                return null;
            }

            cs = CustomerRepo.InsertCustomer(name, email, phone, password);
            return cs;
        }
        public static string updateProfile(int customerId, string name, string email, string gender, string address, string password)
        {
            Customer cs = CustomerRepo.findCustomer(email);

            if (cs != null && cs.customer_id != customerId)
            {
                return "Email has already been used!";
            }

            //CustomerRepo.UpdateCustomer(customerId, name, email, address, password);
            return "";
        }
        public static Customer GetCustomerByID(int id)
        {
            return CustomerRepo.findCustomer(id);
        }
    }
}