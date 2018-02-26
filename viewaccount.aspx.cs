using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_BO;
using Customer_DAL;
using Account_BO;

namespace Customer_Account_UI
{
    public partial class Viewaccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            C_DAL obj = new C_DAL();
            List<A_BO> lst = new List<A_BO>();

            lst = obj.ViewAccount();

            GridView1.DataSource = lst;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("del"))
            {
                int cid = Convert.ToInt32(e.CommandArgument);
                C_DAL Op = new C_DAL();
                int res = Op.delete(cid);
                if (res > 0)
                {
                    GridView1.DataSource = Op.ViewAccount();
                    GridView1.DataBind();
                    Response.Write("Deactivated");
                }



            }
        }
    }
}
