using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer_BO;
using Account_BO;
using System.Data;
using System.Data.SqlClient;


namespace Customer_DAL
{
    public class C_DAL

    {
        public int AddCustomer(C_BO C)

        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addcustomer03", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cn", C.C_Name1);
            cmd.Parameters.AddWithValue("@g", C.Gender1);
            cmd.Parameters.AddWithValue("@dob", C.DOB1);
            cmd.Parameters.AddWithValue("@cno", C.C_Number1);
            cmd.Parameters.AddWithValue("@city", C.City1);
            cmd.Parameters.AddWithValue("@cid", 0);

            cmd.Parameters["@cid"].Direction = ParameterDirection.Output;

            int rowaffected = cmd.ExecuteNonQuery();

            if (rowaffected > 0)
            {
                int cid = Convert.ToInt32(cmd.Parameters["@cid"].Value);
                return cid;

            }

            else

                return 0;
        }

        public int AddAcc(A_BO A)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addaccount031", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cid", A.C_ID1);
            cmd.Parameters.AddWithValue("@amnt", A.Amnt);
            cmd.Parameters.AddWithValue("@acc_type", A.Acc_type);
            cmd.Parameters.AddWithValue("@acc_id", 0);

            cmd.Parameters["@acc_id"].Direction = ParameterDirection.Output;

            int rowaffected = cmd.ExecuteNonQuery();
            if (rowaffected > 0)
            {
                int acc_id = Convert.ToInt32(cmd.Parameters["@acc_id"].Value);
                return acc_id;
            }

            else
                return 0;
        }


        public List<C_BO> ViewCustomer()
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_viewcustomer123", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();
            List<C_BO> lst = new List<C_BO>();

            while (reader.Read())
            {
                C_BO c = new C_BO();
                c.C_id1 = Convert.ToInt32(reader["C_id"]);
                c.C_Name1 = reader["C_Name"].ToString();
                c.Gender1 = reader["Gender"].ToString();
                c.DOB1 = Convert.ToDateTime(reader["DOB"]);
                c.C_Number1 = Convert.ToInt64(reader["C_Number"]);
                c.City1 = reader["City"].ToString();

                lst.Add(c);

            }

            return lst;


        }

        public List<C_BO> ViewCustomerbyid(int cid)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_viewcustomerbyid123", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cid", cid);

            SqlDataReader reader = cmd.ExecuteReader();

            List<C_BO> lstnew = new List<C_BO>();
            while (reader.Read())
            {
                C_BO c = new C_BO();
                c.C_id1 = Convert.ToInt32(reader["C_id"]);
                c.C_Name1 = reader["C_Name"].ToString();
                c.Gender1 = reader["Gender"].ToString();
                c.DOB1 = Convert.ToDateTime(reader["DOB"]);
                c.C_Number1 = Convert.ToInt64(reader["C_Number"]);
                c.City1 = reader["City"].ToString();

                lstnew.Add(c);

            }
            return lstnew;
        }

        public List<A_BO> ViewAccount()
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_viewaccount123", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = cmd.ExecuteReader();

            List<A_BO> lstacc = new List<A_BO>();
            while (reader.Read())
            {
                A_BO obj = new A_BO();
                obj.Acc_id = Convert.ToInt64(reader["acc_id"]);
                obj.C_ID1 = Convert.ToInt16(reader["C_id"]);
                obj.Amnt = Convert.ToInt64(reader["amnt"]);
                obj.Acc_status = reader["acc_status"].ToString();
                obj.Acc_type = reader["acc_type"].ToString();

                lstacc.Add(obj);
              

            }
            return lstacc;


        }

        public int delete(int cid)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=PJ09TMS101_1718;password=tcstvm;database=DB09TMS101_1718");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_deaccustomer_03",con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cid",cid);

            int rowaffected = cmd.ExecuteNonQuery();

            return rowaffected;
        }



    }
}


