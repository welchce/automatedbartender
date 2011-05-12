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

        public void AddInventory(string name, int proof, int amount, int slot)
        {
            string sqlCmd3 = "SELECT @LocationNumber=Location FROM tblInventory WHERE LiquidName = '" + name + "' AND Location > 0";
            SqlCommand cmd3 = new SqlCommand(sqlCmd3, myConnection);
            SqlParameter locationNumber = cmd3.Parameters.Add("@LocationNumber", SqlDbType.Int);
            locationNumber.Direction = ParameterDirection.Output;
            myConnection.Open();
            cmd3.ExecuteNonQuery();
            myConnection.Close();

            if (locationNumber.Value == DBNull.Value || Convert.ToInt32(locationNumber.Value) == slot)
            {
                string sqlCmd = "UPDATE tblInventory SET Location=-1,Quantity=0 WHERE Location=" + slot;
                SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
                myConnection.Open();
                cmd.ExecuteNonQuery();
                myConnection.Close();

                string sqlCmd2 = "UPDATE tblInventory SET Proof=" + proof + ", Quantity=" + amount + ", Location=" + slot + "WHERE LiquidName='" + name + "'";
                cmd = new SqlCommand(sqlCmd2, myConnection);
                myConnection.Open();
                cmd.ExecuteNonQuery();
                myConnection.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(liquid.Value + " already exists in the system");
            }
        }

        public void AddMixer(string name)
        {
            string sqlCmd = "INSERT INTO tblInventory VALUES ('"+name+"',0,0,0)";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        public void UpdateMixer(string name)
        {
            string sqlCmd = "UPDATE tblInventory SET Location=0 WHERE LiquidName='" + name + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        public void RemoveMixer(int inventoryID)
        {
            string sqlCmd = "UPDATE tblInventory SET Location=-2 WHERE ID=" + inventoryID;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
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
            string sqlCmd = "UPDATE tblInventory SET Location = -1, Quantity = 0 WHERE ID = '" + inventoryID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }

        public void AddDrinkToHistory(string LicenseNo, string DrinkID)
        {
            string sqlCmd = "SELECT TOP 1 @numDispensed=numDispensed FROM tblHistory WHERE UserID=" + LicenseNo + " and RecipeID =" + DrinkID;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter numDispensed = cmd.Parameters.Add("@numDispensed", SqlDbType.Int);
            int value;
            numDispensed.Direction = ParameterDirection.Output;
            myConnection.Open();
            cmd.ExecuteReader();
            myConnection.Close();

            try
            {
                value = Convert.ToInt32(numDispensed.Value);
                string sqlCmd2 = "UPDATE tblHistory SET numDispensed = numDispensed+1 WHERE UserID=" + LicenseNo + "AND RecipeID = " + DrinkID;
                SqlCommand cmd2 = new SqlCommand(sqlCmd2, myConnection);
                myConnection.Open();
                cmd2.ExecuteReader();
                myConnection.Close();
            }
            catch (Exception e)
            {
                if (e.Message.Contains ("DBNull"))
                {
                    string sqlCmd3 = "INSERT INTO tblHistory VALUES ('" + LicenseNo + "','" + DrinkID + "', 1)";
                    SqlCommand cmd3 = new SqlCommand(sqlCmd3, myConnection);
                    myConnection.Open();
                    cmd3.ExecuteNonQuery();
                    myConnection.Close();
                }
            }

            DateTime userStartTime = getStartDrinkTime(LicenseNo);
            if (userStartTime == Convert.ToDateTime(null))
            {
                string sqlCmd4 = "UPDATE tblUsers SET TimeStarted ='" + System.DateTime.Now + "' WHERE LicenseNo = " + LicenseNo;
                SqlCommand cmd4 = new SqlCommand(sqlCmd4, myConnection);
                myConnection.Open();
                cmd4.ExecuteNonQuery();
                myConnection.Close();
            }
        }

        public int[] GetDrinkPorts(int RecipeID)
        {
            string sqlCmd = "SELECT DISTINCT Location FROM tblRecipe R, tblInventory Inv, tblIngredients Ing WHERE R.ID = Ing.RecipeID AND Ing.LiquidID = Inv.ID AND R.ID =" + RecipeID;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlDataReader sqlReader;
            myConnection.Open();
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
            myConnection.Close();
            return new int[1];
        }

        public void AddUser(string FirstName, string LastName)
        {
            string sqlCmd = "INSERT INTO tblUsers VALUES ('" + FirstName + "','" + LastName + "', null, 'False', null, null, null, null)";
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
        public void DispensedDrink(string drinkID, string LicenseNo)
        {
            string sqlCmd = "UPDATE dbo.tblRecipe SET numDispensed=numDispensed+1 WHERE ID='" + drinkID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();

            string sqlCmd2 = "SELECT DISTINCT Inv.ID FROM tblRecipe R, tblInventory Inv, tblIngredients Ing WHERE R.ID = Ing.RecipeID AND Ing.LiquidID = Inv.ID AND R.ID =" + drinkID;
            SqlCommand cmd2 = new SqlCommand(sqlCmd2, myConnection);
            SqlDataReader sqlReader;
            myConnection.Open();
            sqlReader = cmd2.ExecuteReader();
            int[] IDs = new int[10];
            int i = 0;

            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    IDs[i] = Convert.ToInt32(sqlReader.GetValue(0));
                    i++;
                }
                sqlReader.Close();
            }
            myConnection.Close();
            i = 0;
            string sqlCmd3;
            SqlCommand cmd3;
            SqlDataReader sqlReader3;
            myConnection.Open();
            while (IDs[i] != 0)
            {
                sqlCmd3 = "UPDATE dbo.tblInventory SET Quantity=Quantity-35 WHERE ID='" + Convert.ToString(IDs[i]) + "' AND Proof<>0";
                cmd3 = new SqlCommand(sqlCmd3, myConnection);
                sqlReader3 = cmd3.ExecuteReader();
                sqlReader3.Close();
                string sqlCmd5 = "SELECT @Proof=Proof FROM tblInventory WHERE ID = '" + Convert.ToString(IDs[i]) + "'";
                SqlCommand cmd5 = new SqlCommand(sqlCmd5, myConnection);
                SqlParameter proof = cmd5.Parameters.Add("@Proof", SqlDbType.Int);
                proof.Direction = ParameterDirection.Output;
                cmd5.ExecuteNonQuery();
                double convertedOunces = 1.18349079 * Convert.ToDouble(proof.Value);
                convertedOunces = convertedOunces / 200;
                string sqlCmd6 = "UPDATE tblUsers SET AlcoholicOunces = AlcoholicOunces+" + convertedOunces + " WHERE LicenseNo = '" + LicenseNo + "'";
                SqlCommand cmd6 = new SqlCommand(sqlCmd6, myConnection);
                cmd6.ExecuteNonQuery();
                i++;
            }
            sqlReader.Close();
            myConnection.Close();
           
        }
        public void getNotificationForAdmin()
        {

            string sqlCmd = "SELECT LiquidName, Location, Quantity FROM tblInventory WHERE Quantity < 100 AND (Location > 0 OR Location = -3) ORDER BY Location ASC";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlDataReader sqlReader;
            myConnection.Open();
            sqlReader = cmd.ExecuteReader();
            string[] IDs = new string[10];
            int i = 0;

            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    if (Convert.ToString(sqlReader.GetValue(1)) == "-3")
                        IDs[i] = Convert.ToString(sqlReader.GetValue(0)) +" : " +  Convert.ToString(sqlReader.GetValue(2)) + "mL remaining";
                    else
                        IDs[i] = Convert.ToString(sqlReader.GetValue(0)) +" - Slot " + Convert.ToString(sqlReader.GetValue(1)) + " : " +  Convert.ToString(sqlReader.GetValue(2)) + "mL remaining";
                    i++;
                }
                sqlReader.Close();
            }
            myConnection.Close();
            i = 0;
            string warningMessage = "";
            while (IDs[i] != null)
            {
                warningMessage = warningMessage + IDs[i] + '\n';
                i++;
            }
            if (warningMessage != "")
                System.Windows.Forms.MessageBox.Show("Please contact a system adminstrator, the following drinks are running low: \n\n" + warningMessage);    

            string sqlCmd2 = "UPDATE tblInventory SET Location=-3, Quantity = 0 WHERE Quantity < 0 AND Proof <> 0";
            SqlCommand cmd2 = new SqlCommand(sqlCmd2, myConnection);
            myConnection.Open();
            cmd2.ExecuteNonQuery();
            myConnection.Close();
        }
        public double getUserAlcoholicOunces(string UserID)
        {
            string sqlCmd = "SELECT @AlcoholicOunces=AlcoholicOunces FROM tblUsers WHERE LicenseNo = '" + UserID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter ounces = cmd.Parameters.Add("@AlcoholicOunces", SqlDbType.Float);
            ounces.Direction = ParameterDirection.Output;
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
            if (ounces.Value != DBNull.Value)
                return Convert.ToDouble(ounces.Value);
            else
                return 0;
        }

        public DateTime getStartDrinkTime(string UserID)
        {
            string sqlCmd = "SELECT @TimeStarted=TimeStarted FROM tblUsers WHERE LicenseNo = '" + UserID + "'";
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            SqlParameter time = cmd.Parameters.Add("@TimeStarted", SqlDbType.DateTime);
            time.Direction = ParameterDirection.Output;
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
            if (time.Value != DBNull.Value)
                return Convert.ToDateTime(time.Value);
            else
                return Convert.ToDateTime(null);
        }

        public void resetOuncesandStartTime(string LICENSE)
        {
            string sqlCmd = "UPDATE tblUsers SET AlcoholicOunces=0, TimeStarted = NULL WHERE LicenseNo = " + LICENSE;
            SqlCommand cmd = new SqlCommand(sqlCmd, myConnection);
            myConnection.Open();
            cmd.ExecuteNonQuery();
            myConnection.Close();
        }
    }
}
