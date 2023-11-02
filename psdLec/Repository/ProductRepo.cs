using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Repository
{
    public class ProductRepo
    {
        static MydatabaseEntities2 db = Singleton.GetInstance();
        public static void save()
        {
            db.SaveChanges();
        }
        public static void InsertProduct(Product u)
        {
            db.Products.Add(u);
            save();
        }
        public static void DeleteProduct(Product u)
        {
            db.Products.Remove(u);
            save();
        }
        public static List<Product> GetProduct()
        {
            return (from Product in db.Products select Product).ToList();
        }
        public static List<Product> GetProductsBySeller(Seller seller)
        {
            return (from Product in db.Products where Product.seller_id.Equals(seller.seller_id) select Product).ToList();
        }
        public static Product GetProductByName(string name)
        {
            Product product= (from p in db.Products where p.product_name.Equals(name) select p).FirstOrDefault();
            return product;
        }
        public static Product GetProductByID(int id)
        {
            Product product = (from p in db.Products where p.product_id.Equals(id) select p).FirstOrDefault();
            return product;
        }
    }
}