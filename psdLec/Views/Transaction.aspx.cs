using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using psdLec.Model;
using psdLec.Controller;
using System.Data;

namespace psdLec.Views
{
    public partial class Transaction : System.Web.UI.Page
    {
        private MydatabaseEntities2 db = new MydatabaseEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser();
            DisplayTransaction();
        }
        private void CheckUser()
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Customer user;
                if (Session["user"] == null)
                {
                    var id = Request.Cookies["user_cookie"].Value;
                    user = (from x in db.Customers where x.customer_id == int.Parse(id) select x).FirstOrDefault();
                    Session["user"] = user;
                }
                else
                {
                    user = (Customer)Session["user"];
                }
            }
        }
        private void DisplayTransaction()
        {
            Customer user = (Customer)Session["user"];

            List<Model.Transaction> transactions = TransactionController.GetTransactionByCustomer(user);

            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Product");
            table.Columns.Add("Shipper");
            table.Columns.Add("Date");
            table.Columns.Add("Status");

            for (int i = 0; i < transactions.Count; i++)
            {
                Product product = TransactionController.GetProductByID(transactions[i].product_id);
                Shipper shipper = TransactionController.GetShipperByID(transactions[i].shipper_id);
                string status = "";
                switch(transactions[i].transaction_status)
                {
                    case 1:
                        status = "Delivered";
                        break;
                    case 2:
                        status = "Shipping";
                        break;
                    case 3:
                        status = "Preparing";
                        break;
                    default:
                        status = "Unknown";
                        break;
                }
                table.Rows.Add(transactions[i].transaction_id.ToString(), product.product_name, shipper.shipper_name, transactions[i].transaction_date.ToString("MM/dd/yyyy h:mm tt"), status);
            }

            DataList1.DataSource = table;
            DataList1.DataBind();
        }
    }
}