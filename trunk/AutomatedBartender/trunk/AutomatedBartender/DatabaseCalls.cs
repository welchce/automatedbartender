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
            /*SqlConnection myConnection = new SqlConnection("user id=External;" +
                                       "password=mattsucks;server=tcp:10.63.3.61\\SQLEXPRESS;" +
                                       "Trusted_Connection=yes;" +
                                       "database=Bartender; " +
                                       "connection timeout=30");*/


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

        public string verifyUser(string LicenseNo)
        {
            string sqlCmd = "SELECT LicenseNo FROM tblUsers WHERE LicenseNo = '" + LicenseNo + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            //SqlParameter returnParameter = new SqlParameter("@LicenseNo", SqlDbType.VarChar);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            myConnection.Open();
            string test = (string)cmd.ExecuteScalar();
            if (cmd.ExecuteScalar() != null)
            {
                string sqlCmd2 = "SELECT Admin FROM tblUsers WHERE LicenseNo = '" + LicenseNo + "'";
                SqlCommand cmd2 = new SqlCommand(sqlCmd2, myConnection);
                //myConnection.Open();
                try
                {
                    if ((bool)cmd2.ExecuteScalar())
                    {
                        return "Admin";
                    }
                    else
                    {
                        return "Regular";
                    }
                }
                catch
                {
                    return "Regular";
                }

            }

            return "New";
        }
        public bool updateUser(string LastName, string FirstName, string LicenseNo, string Gender, int Weight)
        {
            //SELECT TOP 1 * FROM tblUsers WHERE FirstName = 'Matt' AND LastName = 'Fuller'
            string sqlCmd = "SELECT TOP 1 * FROM tblUsers WHERE FirstName = '"+FirstName+"' AND LastName = '"+LastName+"'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            //int test = (int)cmd.ExecuteScalar();
            if (cmd.ExecuteScalar() != null)
            {
                int id = (int)cmd.ExecuteScalar();
                string sqlCmd2 = "UPDATE tblUsers SET Gender = '" + Gender + "', Weight = " + Weight + ", LicenseNo = '" + LicenseNo + "'WHERE   id = " + id;
                SqlCommand cmd2 = new SqlCommand(sqlCmd2, myConnection);
                cmd2.ExecuteNonQuery();
                return true;
            }
            return false;
        }
    }
}
