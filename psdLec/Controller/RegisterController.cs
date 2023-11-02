using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

using psdLec.Handler;
using psdLec.Model;

namespace psdLec.Controllers
{
    public class RegisterController
    {
        public static string checkName(string name)
        {
            string info = "";
            if (string.IsNullOrWhiteSpace(name))
            {
                info = "Name must be filled";
            }
            else if (name.Length < 5 || name.Length > 50)
            {
                info = "Name must be 5-50 characters";
            }
            return info;
        }

        public static string checkEmail(string email)
        {
            string info = "";
            if (string.IsNullOrWhiteSpace(email))
            {
                info = "Email must be filled";
            }

            return info;
        }


        public static string checkPhone(string phone)
        {
            string info = "";
            if (string.IsNullOrWhiteSpace(phone))
            {
                info = "Phone must be entered";
            }
            else if (phone == null)
            {
                info = "Phone needs to be entered";
            }
            return info; 
        }

        public static string checkPassword(string password)
        {
            string info = "";
            if (string.IsNullOrWhiteSpace(password))
            {
                info = "Password can not be empty";
            }
            /*else if (!Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d).+$"))
            {
                info = "Password must be alphanumeric (letters+numbers)";
            }*/
            return info;
        }

        public static (Customer, string) register(string name, string email, string phone, string password)
        {
            String[] errors = { checkName(name), checkEmail(email), checkPhone(phone), checkPassword(password) };
            for (int i = 0; i < errors.Length; i++)
            {
                if (errors[i] != "")
                    return (null, errors[i]);
            }
            Customer customer = CustomerHandler.register(name, email, phone, password);
            if (customer == null)
                return (null, "Email has already been registered");

            return (customer, "Your new Account has been made, Welcome");
        }
    }
}