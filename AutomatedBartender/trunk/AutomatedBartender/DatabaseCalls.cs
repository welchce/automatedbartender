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
        /*SqlConnection myConnection = new SqlConnection("user id=WELCH2400\\Administrator;" +
                                   "password=elder01;server=WELCH2400\\SQLEXPRESS;" +
                                   "Trusted_Connection=yes;" +
                                   "database=Bartender; " +
                                   "connection timeout=30");*/

            SqlConnection myConnection = new SqlConnection("user id=External;" +
                                       "password=mattsucks;server=72.49.95.137;" +
                                       "Trusted_Connection=false;" +
                                       "database=Bartender; " +
                                       "connection timeout=10");


            
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
            myConnection.Close();
            return dbBindSource;
        }

        public int AddDrinkRecipe(string name)
        {
            string sqlCmd = "INSERT INTO tblRecipe VALUES ('" + name + "',0); SELECT @ID=ID FROM tblRecipe WHERE ID = SCOPE_IDENTITY()" ;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter returnParameter = cmd.Parameters.Add("@ID", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.Output;
            myConnection.Open();
            cmd.ExecuteReader();
            myConnection.Close();
            return Convert.ToInt32(returnParameter.Value);
        }

        public void AddInventory(string name, string proof, int amount, int slot)
        {
            string sqlCmd = "INSERT INTO tblInventory VALUES ('" + name + "','" + proof + "','" + amount + "','" + slot + "')";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteReader().Close();
        }

        public void AddIngredientsToRecipe(int drinkID, string inventory, string amount)
        {
            myConnection.Open();
            string sqlCmd = "SELECT @AmountID=ID FROM tblAmount WHERE Name = '" + amount + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter amountID = cmd.Parameters.Add("@AmountID", DbType.String);
            amountID.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            sqlCmd = "SELECT @InventoryID=ID FROM tblInventory WHERE LiquidName = '" + inventory + "'";
            cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter inventoryID = cmd.Parameters.Add("@InventoryID", DbType.String);
            inventoryID.Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();

            sqlCmd = "INSERT INTO tblIngredients VALUES ('" + drinkID + "','" + inventoryID.Value + "','" + amountID.Value + "')";
            cmd = new SqlCommand(sqlCmd, myConnection);
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        public void RemoveInventory(int inventoryID)
        {
            string sqlCmd = "DELETE FROM tblInventory WHERE ID = '" + inventoryID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        public void AddDrinkToQueue(string LicenseNo, string DrinkID)
        {
            string sqlCmd = "INSERT INTO tblQueue VALUES ('"+LicenseNo+"','"+DrinkID+"', 0, null)";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            //SqlParameter returnParameter = new SqlParameter("@LicenseNo", SqlDbType.VarChar);
            //returnParameter.Direction = ParameterDirection.ReturnValue;
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public int GetDrinkFromQueue(string UserID)
        {
            string sqlCmd = "SELECT TOP 1 @RecipeID=RecipeID FROM tblQueue WHERE Dispensed = 0 and UserID=" +UserID +"ORDER BY ID DESC";
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
                sqlReader.Close();
                return locations;
            }
            sqlReader.Close();
            return new int[1];
        }

        public void UpdateDrinkInQueue(string UserID)
        {
            string sqlCmd = "UPDATE TOP (1) tblQueue SET Dispensed = 1 WHERE UserID=" + UserID;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            cmd.ExecuteReader().Close();
        }

        public void AddUser(string FirstName, string LastName)
        {
            string sqlCmd = "INSERT INTO tblUsers VALUES ('" + FirstName + "','" + LastName + "', null, 'False', null, null)";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
        public void DeleteUser(string ID)
        {
            string sqlCmd = "DELETE FROM tblUsers WHERE ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}
