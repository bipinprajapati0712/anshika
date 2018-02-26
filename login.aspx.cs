using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;


namespace Customer_Account_UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            string pwd = TextBox2.Text;

            if(FormsAuthentication.Authenticate(uname,pwd))
            {
                FormsAuthentication.RedirectFromLoginPage(uname, true);
            }
            else

            {
                Response.Write("<script>alert('Invalid Login Credentials')</script>");


            }
        }
    }
}
