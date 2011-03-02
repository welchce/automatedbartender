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
        /*SqlConnection myConnection = new SqlConnection("user id=LAPPY6400\\Christopher;" +
                               "password=elder01;server=localhost;" +
                               "Trusted_Connection=true;" +
                               "database=Bartender; " +
                               "connection timeout=30");*/

        /*SqlConnection myConnection = new SqlConnection("user id=WELCH2400\\Administrator;" +
                                   "password=elder01;server=WELCH2400\\SQLEXPRESS;" +
                                   "Trusted_Connection=yes;" +
                                   "database=Bartender; " +
                                   "connection timeout=30");*/

            SqlConnection myConnection = new SqlConnection("user id=External;" +
                                       "password=mattsucks;server=74.215.230.231;" +
                                       "Trusted_Connection=false;" +
                                       "database=Bartender; " +
                                       "connection timeout=10");


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

        public string verifyUser(string LastName, string FirstName, string LicenseNo, string Gender, int Weight)
        {
            string sqlCmd = "SELECT Admin FROM tblUsers WHERE LicenseNo = '" + LicenseNo + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            //SqlParameter returnParameter = new SqlParameter("@LicenseNo", SqlDbType.VarChar);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            myConnection.Open();
            if (cmd.ExecuteScalar() != null)
            {
                if ((bool)cmd.ExecuteScalar())
                    return "Admin";
                else
                    return "Regular";
            }
            //SELECT TOP 1 * FROM tblUsers WHERE FirstName = 'Matt' AND LastName = 'Fuller'
            string sqlCmd2 = "SELECT TOP 1 @ID = ID,@Admin = Admin FROM tblUsers WHERE FirstName = '" + FirstName + "' AND LastName = '" + LastName + "'";
            SqlCommand cmd2 = new SqlCommand(sqlCmd2, myConnection);
            SqlParameter adminParameter = cmd2.Parameters.Add("@Admin",SqlDbType.Bit);
            SqlParameter rowID = cmd2.Parameters.Add("@ID", SqlDbType.Int);
            adminParameter.Direction = ParameterDirection.Output;
            rowID.Direction = ParameterDirection.Output;
            cmd2.ExecuteReader().Close();
            if (rowID.Value.ToString() != "")
            {
                string sqlCmd3 = "UPDATE tblUsers SET Gender = '" + Gender + "', Weight = " + Weight + ", LicenseNo = '" + LicenseNo + "'WHERE   id = " + rowID.Value.ToString();
                SqlCommand cmd3 = new SqlCommand(sqlCmd3, myConnection);
                cmd3.ExecuteNonQuery();
                if ((bool)adminParameter.Value == false)
                    return "Regular";
                else
                    return "Admin";
                //return true;
            }
            return "None";
        }

        public BindingSource GetForDataGrid(string sqlCmd)
        {
            BindingSource dbBindSource = new BindingSource();
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd, myConnection);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
 
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            dbBindSource.DataSource = table;
            return dbBindSource;
        }

        public void AddDrinkToQueue(string LicenseNo, string DrinkID)
        {
            string sqlCmd = "INSERT INTO tblQueue VALUES ('"+LicenseNo+"','"+DrinkID+"', 0, null)";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            //SqlParameter returnParameter = new SqlParameter("@LicenseNo", SqlDbType.VarChar);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            myConnection.Open();
            cmd.ExecuteNonQuery();
        }
        public int GetDrinkFromQueue(string UserID)
        {
            string sqlCmd = "SELECT TOP 1 @RecipeID=RecipeID FROM tblQueue WHERE Dispensed = 0 and UserID=" +UserID +"ORDER BY ID ASC";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter RecipeID = cmd.Parameters.Add("@RecipeID", SqlDbType.Int);
            RecipeID.Direction = ParameterDirection.Output;
            myConnection.Open();
            cmd.ExecuteReader().Close();
            return Convert.ToInt32(RecipeID.Value);
        }

        public int[] GetDrinkPorts(int RecipeID)
        {
            string sqlCmd = "SELECT DISTINCT Location FROM tblRecipe R, tblInventory Inv, tblIngredients Ing WHERE R.ID = Ing.RecipeID AND Ing.LiquidID = Inv.ID AND R.ID =" + RecipeID;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlDataReader sqlReader;
            sqlReader = cmd.ExecuteReader();
            if (sqlReader.HasRows)
            {
                int[] locations = new int[10];
                int i = 0;
                while (sqlReader.Read())
                {
                    locations[i] = Convert.ToInt32(sqlReader.GetValue(0));
                    i++;
                }
                return locations;
            }

            return new int[1];
        }

        public void UpdateDrinkInQueue(int ID)
        {
            string sqlCmd = "UPDATE tblQueue SET Dispensed = 1 WHERE ID=" + ID;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            cmd.ExecuteReader().Close();
        }

        public void AddUser(string FirstName, string LastName)
        {
            string sqlCmd = "INSERT INTO tblUsers VALUES ('" + FirstName + "','" + LastName + "', null, 'False', null, null)";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteUser(string ID)
        {
            string sqlCmd = "DELETE FROM tblUsers WHERE ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
