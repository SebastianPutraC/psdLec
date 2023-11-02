using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Factory
{
    public class ProductFactory
    {
        public static Product createProduct(int id, string desc, string nama, int idSeller, int price)
        {
            Product newUser = new Product();
            newUser.product_id = id;
            newUser.product_name = nama;
            newUser.product_description = desc;
            newUser.product_price = price;
            newUser.seller_id = idSeller;
            return newUser;
        }
    }
}