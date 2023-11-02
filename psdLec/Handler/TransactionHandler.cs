using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using psdLec.Repository;
using psdLec.Model;

namespace psdLec.Handler
{
    public class TransactionHandler
    {
        public static Transaction insertTransaction(int customer_id, int product_id, int shipper_id, DateTime date, int status)
        {
            return TransactionRepo.InsertTransaction(customer_id, product_id, shipper_id, date, status);
        }
        public static List<Transaction> GetTransactionByCustomer(Customer customer)
        {
            return TransactionRepo.GetTransactionByCustomer(customer);
        }

        public static Product GetProductByName(string name)
        {
            Product product = ProductRepo.GetProductByName(name);
            if (product == null)
                return null;
            else
                return product;
        }
        public static List<Product> GetProductsBySeller(Seller seller)
        {
            return ProductRepo.GetProductsBySeller(seller);
        }
        public static Product GetProductByID(int id)
        {
            return ProductRepo.GetProductByID(id);
        }

        public static List<Seller> GetAllSeller()
        {
            return SellerRepo.GetSeller();
        }
        public static Seller GetSellerByName(string name)
        {
            Seller seller = SellerRepo.GetSellerByName(name);
            if (seller == null)
                return null;
            else
                return seller;
        }

        public static Shipper GetShipperByName(string name)
        {
            Shipper shipper = ShipperRepo.GetShipperByName(name);
            if (shipper == null)
                return null;
            else
                return shipper;
        }
        public static List<Shipper> GetAllShipper()
        {
            return ShipperRepo.GetShipper();
        }
        public static Shipper GetShipperByID(int id)
        {
            return ShipperRepo.GetShipperByID(id);
        }
    }
}