using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using psdLec.Factory;

namespace psdLec.Repository
{
    public class TransactionRepo
    {
        static MydatabaseEntities2 db = Singleton.GetInstance();
        public static void save()
        {
            db.SaveChanges();
        }
        public static Transaction InsertTransaction(int customer_id, int product_id, int shipper_id, DateTime date, int status)
        {
            int id = db.Transactions.Count() + 1;
            Transaction transaction = db.Transactions.Add(TransactionFactory.createTransaction(id, customer_id, product_id, shipper_id, date, status));
            save();

            return transaction;
        }
        public static void DeleteTransaction(Transaction u)
        {
            db.Transactions.Remove(u);
            save();
        }
        public static List<Transaction> GetTransaction()
        {
            return (from Transaction in db.Transactions select Transaction).ToList();
        }
        public static List<Transaction> GetTransactionByCustomer(Customer customer)
        {
            return (from Transaction in db.Transactions where Transaction.customer_id.Equals(customer.customer_id) select Transaction).ToList();
        }
    }
}