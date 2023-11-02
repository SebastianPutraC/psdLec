using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using psdLec.Model;
using psdLec.Controller;

namespace psdLec.Views
{
    public partial class Sellers : System.Web.UI.Page
    {
        private MydatabaseEntities2 db = new MydatabaseEntities2();
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckUser();
            FillDropDownList();
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
        private void FillDropDownList()
        {
            List<Seller> sellers = SellerController.GetAllSeller();
            List<String> names = new List<string>();
            for (int i = 0; i < sellers.Count; i++)
            {
                names.Add(sellers[i].seller_name);
            }

            seller_list.DataSource = names;
            seller_list.DataBind();
        }
        protected void to_main_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void to_order_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("user_seller");
            cookie.Value = seller_list.SelectedValue;
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);

            Response.Redirect("Order.aspx");
        }
    }
}