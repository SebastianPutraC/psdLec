using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Factory
{
    public class SellerFactory
    {
        public static Seller createSeller(int id, string email, string nama, string password, string phone, int bank)
        {
            Seller newUser = new Seller();
            newUser.seller_id = id;
            newUser.seller_name = nama;
            newUser.seller_password = password;
            newUser.seller_phone = phone;
            newUser.seller_email = email;
            newUser.seller_bank = bank;
            return newUser;
        }
    }
}