using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using psdLec.Handler;
using psdLec.Model;

namespace psdLec.Controllers
{
    public class LoginController
    {
        public static (Customer, String) login(string email, string password)
        {
            string errorLog = CheckEmpty(email, password);
            Customer customer = CustomerHandler.login(email, password);

            if (errorLog != "")
                return (null, errorLog);
            if (customer == null)
                return (null, "Account Doesn't Exist");
            else
                return (customer, "Account Validated, Welcome");
        }
        private static string CheckEmpty(string email, string password)
        {
            if (string.IsNullOrEmpty(email))
                return "Email can't be empty";
            if (string.IsNullOrEmpty(password))
                return "Password can't be empty";
            else
                return "";
        }
    }
}