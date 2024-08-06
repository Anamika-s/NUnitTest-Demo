using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericFunctions
{
    public class Employee
    {
        public string GetLeaves(int exp, string dept)
        {
            if (exp >= 10 && dept.Equals("HR"))
            {
                return "You can get 10 leaves";
            }
            else if (exp < 10 && dept.Equals("HR"))
            {
                return "You can get 5 leaves";
            }
            else if ((exp >= 5 && exp <= 8) && dept.Equals("Sales"))
            {
                return "You can get 15 leaves";
            }
            else
                return "No Leaves";

        }

        //public bool AddUser()
        //{
        //    // some logic will come here to add rec in database
        //    EMail eMail = new EMail();
        //    eMail.SendMail();
        //    return true;
        //}


        public bool AddUser(EMail eMail)
        {
            // some logic will come here to add rec in database
            //EMail eMail = new EMail();
            eMail.SendMail();
            return true;
        }


    }

    //public class EMail
    //{
    //    public bool SendMail()
    //    {
    //        // some logic will come here to send mail
    //        return true;
    //    }
    //}

    public class EMail
    {
        public virtual bool SendMail()
        {
            // some logic will come here to send mail
            return true;
        }
    }
}
