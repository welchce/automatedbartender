using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutomatedBartender
{
    class DatabaseCalls
    {
            SqlConnection myConnection = new SqlConnection("user id=WELCH2400\\Administrator;" +
                                       "password=elder01;server=WELCH2400\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=Bartender; " +
                                       "connection timeout=30");


            /*SqlCommand cmd = new SqlCommand("spInsertUser", myConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@FName", SqlDbType.VarChar);
            cmd.Parameters.Add("@LName", SqlDbType.VarChar);
            cmd.Parameters.Add("@LicenseNo", SqlDbType.VarChar);
            cmd.Parameters.Add("@Admin", SqlDbType.Bit);
            cmd.Parameters.Add("@Weight", SqlDbType.VarChar);
            cmd.Parameters.Add("@Gender", SqlDbType.VarChar);

            cmd.Parameters["@FName"].Value = "Joe";
            cmd.Parameters["@LName"].Value = "Smith";
            cmd.Parameters["@LicenseNo"].Value = "1841297";
            cmd.Parameters["@Admin"].Value = true;
            cmd.Parameters["@Weight"].Value = "120";
            cmd.Parameters["@Gender"].Value = "W";


            myConnection.Open();

            int test = cmd.ExecuteNonQuery();*/

        public bool verifyUser(string LicenseNo)
        {
            string sqlCmd = "SELECT LicenseNo FROM tblUsers WHERE LicenseNo = '" + LicenseNo + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            //SqlParameter returnParameter = new SqlParameter("@LicenseNo", SqlDbType.VarChar);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            myConnection.Open();
            if ((string)cmd.ExecuteScalar() != "null")
            {
                return true;
            }

            return false;
        }
    }
}
