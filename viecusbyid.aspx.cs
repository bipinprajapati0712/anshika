using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_DAL;
using Customer_BO;

namespace Customer_Account_UI
{
    public partial class ViewCustomerbyid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            C_DAL obj = new C_DAL();

            int id = Convert.ToInt32(TextBox1.Text);
            List<C_BO> lst = new List<C_BO>();

            lst = obj.ViewCustomerbyid(id);

            GridView1.DataSource = lst;

            if (lst.Count()==0)
            {
                Response.Write("<script>alert('Customer Id doesnt exist')</script>");
                Label2.Text = "This id doesn't exist";
            }

            GridView1.DataBind();

        }
    }
}
