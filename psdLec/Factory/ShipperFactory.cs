using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Factory
{
    public class ShipperFactory
    {
        public static Shipper createShipper(int id, int age, string lisence, string nama, string phone)
        {
            Shipper newUser = new Shipper();
            newUser.Shipper_id = id;
            newUser.shipper_age = age;
            newUser.shipper_name = nama;
            newUser.shipper_phone = phone;
            newUser.shipper_lisence = lisence;
            return newUser;
        }
    }
}