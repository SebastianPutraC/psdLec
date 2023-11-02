using psdLec.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace psdLec.Factory
{
    public class TransactionFactory
    {
        public static Transaction createTransaction(int idTrans, int idShip, int idCust, int idProd, DateTime date, int status)
        {
            Transaction newUser = new Transaction();
            newUser.transaction_id = idTrans;
            newUser.transaction_date = date;
            newUser.transaction_status = status;
            newUser.customer_id = idCust;
            newUser.shipper_id = idShip;
            newUser.product_id = idProd;
            return newUser;
        }
    }
}