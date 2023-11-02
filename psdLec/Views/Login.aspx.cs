using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using psdLec.Model;
using psdLec.Controllers;
using System.Diagnostics;

namespace psdLec.Views
{
    public partial class Login : System.Web.UI.Page
    {
        private Label warnLabel;
        protected void Page_Load(object sender, EventArgs e)
        {
            warnLabel = warn_login;
            warnLabel.Style.Add("display", "none");
        }
        protected void login_account_Click(object sender, EventArgs e)
        {
            string email = login_email.Text;
            string password = login_password.Text;
            bool isRemember = remember.Checked;

            var checker = LoginController.login(email, password);
            Customer customer = checker.Item1;
            if (customer != null)
            {
                Session["user"] = customer;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = customer.customer_id.ToString();
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }

                Response.Redirect("Main.aspx");
            }
            else
            {
                warn_login.Style.Remove("display"); // Show Warn
                Debug.WriteLine(checker.Item2);
            }
        }

        protected void to_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}