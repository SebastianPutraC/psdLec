using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using psdLec.Model;
using psdLec.Handler;

namespace psdLec.Controller
{
    public class TransactionController
    {
        public static Transaction insertTransaction(int customer_id, int product_id, int shipper_id)
        {
            DateTime date = DateTime.Today;
            int status = 3;
            return TransactionHandler.insertTransaction(customer_id, product_id, shipper_id, date, status);
        }
        public static List<Transaction> GetTransactionByCustomer(Customer customer)
        {
            return TransactionHandler.GetTransactionByCustomer(customer);
        }

        public static List<Product> GetProductsBySeller(Seller seller)
        {
            return TransactionHandler.GetProductsBySeller(seller);
        }
        public static Product GetProductByName(string name)
        {
            Product product = TransactionHandler.GetProductByName(name);
            if (product == null)
                return null;
            else
                return product;
        }
        public static Product GetProductByID(int id)
        {
            return TransactionHandler.GetProductByID(id);
        }

        public static List<Shipper> GetAllShipper()
        {
            return TransactionHandler.GetAllShipper();
        }
        public static Shipper GetShipperByName(string name)
        {
            Shipper shipper = TransactionHandler.GetShipperByName(name);
            if (shipper == null)
                return null;
            else
                return shipper;
        }
        public static Shipper GetShipperByID(int id)
        {
            return TransactionHandler.GetShipperByID(id);
        }

        public static Customer GetCustomerByID(int id)
        {
            return CustomerHandler.GetCustomerByID(id);
        }
    }

}