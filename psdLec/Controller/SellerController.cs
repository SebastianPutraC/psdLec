using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using psdLec.Handler;
using psdLec.Model;

namespace psdLec.Controller
{
    public class SellerController
    {
        public static List<Seller> GetAllSeller()
        {
            return TransactionHandler.GetAllSeller();
        }
        public static Seller GetSellerByName(string name)
        {
            Seller seller = TransactionHandler.GetSellerByName(name);
            if (seller == null)
                return null;
            else
                return seller;
        }
    }
}