using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Repository
{
    public class SellerRepo
    {
        static MydatabaseEntities2 db = Singleton.GetInstance();
        public static void save()
        {
            db.SaveChanges();
        }
        public static void InsertSeller(Seller u)
        {
            db.Sellers.Add(u);
            db.SaveChanges();
        }
        public static void DeleteSeller(Seller u)
        {
            db.Sellers.Remove(u);
            db.SaveChanges();
        }
        public static List<Seller> GetSeller()
        {
            return (from Seller in db.Sellers select Seller).ToList();
        }
        public static Seller GetSellerByName(String name)
        {
            Seller seller = (from s in db.Sellers where s.seller_email.Equals(name) select s).FirstOrDefault();
            return seller;
        }
        public static Seller GetSellerByID(int id)
        {
            Seller seller = (from s in db.Sellers where s.seller_id.Equals(id) select s).FirstOrDefault();
            return seller;
        }
    }
}