using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Factory
{
    public class CustomerFactory
    {
        public static Customer createCustomer(int id, string nama, string email, string phone, string password)
        {
            Customer newUser = new Customer();
            newUser.customer_id = id;
            newUser.customer_name = nama;
            newUser.customer_email = email;
            newUser.customer_phone = phone;
            newUser.customer_password = password;
            return newUser;
        }
    }
}