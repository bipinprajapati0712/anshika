using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_BO

{
    public class A_BO
    {
        double acc_id;
        int C_ID;
        double amnt ;
        string acc_type;
        string acc_status;

        public int C_ID1
        {
            get
            {
                return C_ID;
            }

            set
            {
                C_ID = value;
            }
        }

        public double Amnt
        {
            get
            {
                return amnt;
            }

            set
            {
                amnt = value;
            }
        }

        public string Acc_type
        {
            get
            {
                return acc_type;
            }

            set
            {
                acc_type = value;
            }
        }

        public double Acc_id
        {
            get
            {
                return acc_id;
            }

            set
            {
                acc_id = value;
            }
        }

        public string Acc_status
        {
            get
            {
                return acc_status;
            }

            set
            {
                acc_status = value;
            }
        }

        public A_BO(int c_ID, double amnt, string acc_type)
        {
            C_ID = c_ID;
            this.amnt = amnt;
            this.acc_type = acc_type;
        }
        public A_BO()
        {

        }

        public A_BO(double acc_id)
        {
            this.acc_id = acc_id;
        }
    }
}
