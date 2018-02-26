using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_BO;
using Customer_DAL;

namespace Customer_Account_UI
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string c_name = TextBox1.Text;
            string g = DropDownList1.Text;
            DateTime dob = DateTime.Parse(TextBox2.Text);
            double c_no = Convert.ToInt64(TextBox3.Text);
            string city = TextBox4.Text;

            C_BO obj = new C_BO(c_name, g, dob, c_no, city);
            C_DAL obj1 = new C_DAL();

            int cid = obj1.AddCustomer(obj);

            if (cid>0)
            {
                Response.Write("<script>alert('Your customer id is" + cid+ "')</script>");
                
            }

            else
            {
                Response.Write("<script>alert('Error')</script>");

            }
            

        }
    }
}
