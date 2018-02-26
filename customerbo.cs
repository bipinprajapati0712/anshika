using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_BO
{
    public class C_BO
    {
        int C_id;
        string C_Name;
        string Gender;
        DateTime DOB;
        double C_Number;
        string City;

        public string C_Name1
        {
            get
            {
                return C_Name;
            }

            set
            {
                C_Name = value;
            }
        }

        public string Gender1
        {
            get
            {
                return Gender;
            }

            set
            {
                Gender = value;
            }
        }

        public DateTime DOB1
        {
            get
            {
                return DOB;
            }

            set
            {
                DOB = value;
            }
        }

        public double C_Number1
        {
            get
            {
                return C_Number;
            }

            set
            {
                C_Number = value;
            }
        }

        public string City1
        {
            get
            {
                return City;
            }

            set
            {
                City = value;
            }
        }

        public int C_id1
        {
            get
            {
                return C_id;
            }

            set
            {
                C_id = value;
            }
        }

        public C_BO(string c_Name, string gender, DateTime dOB, double c_Number, string city)
        {
            C_Name = c_Name;
            Gender = gender;
            DOB = dOB;
            C_Number = c_Number;
            City = city;
        }

        
        public C_BO()
        {

        }

        public C_BO(int c_id, string c_Name, string gender, DateTime dOB, double c_Number, string city)
        {
            C_id = c_id;
            C_Name = c_Name;
            Gender = gender;
            DOB = dOB;
            C_Number = c_Number;
            City = city;
        }
    }
}
