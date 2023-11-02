using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using psdLec.Controllers;
using psdLec.Model;
using System.Diagnostics;

namespace psdLec.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_account_Click(object sender, EventArgs e)
        {
            String realName = register_realname.Text;
            string phoneNumber = register_phone.Text;
            String email = register_email.Text;
            String password = register_password.Text;

            var checker = RegisterController.register(realName, email, phoneNumber, password);
            Customer customer = checker.Item1;

            if (customer != null)
            {
                Session["user"] = customer;
                Response.Redirect("Main.aspx");
            }
            else
            {
                Debug.WriteLine(checker.Item2);
            }
        }

        protected void to_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}