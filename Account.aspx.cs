using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Customer_DAL;
using Account_BO;


namespace Customer_Account_UI
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int C_ID = Convert.ToInt32(TextBox1.Text);
            double amnt = Convert.ToInt64(TextBox2.Text);
            string acc_type = DropDownList1.Text;
            DateTime dt = DateTime.Now;
            



            A_BO obj2 = new A_BO(C_ID, amnt, acc_type);

            C_DAL obj3 = new C_DAL();

            int acc_id = obj3.AddAcc(obj2);

      if(acc_id>0)
            {
                Response.Write("<script>alert('Your account id is:" + acc_id + "')</script>");
            }
            else
            {
                Response.Write("<script>alert(''error)</script>");
            }





        }
    }
}
