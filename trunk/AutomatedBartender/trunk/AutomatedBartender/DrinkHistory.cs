using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedBartender
{
    public partial class DrinkHistory : Form
    {
        bool isAdmin = false;
        string LICENSE = "";
        string GENDER = "";
        int WEIGHT = 0;

        public DrinkHistory(bool admin, string DriversLicense, string Gender, int Weight)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
            setLicense(DriversLicense);
            setGender(Gender);
            setWeight(Weight);
        }

        private void DrinkHistoryBackBtn_Click(object sender, EventArgs e)
        {
            if (getIsAdmin() == true)
            {
                Form adminMainScreen = new AdminMain(getLicense());
                adminMainScreen.Show();
                this.Close();
            }
            else
            {
                Form userMainScreen = new UserMain(getLicense(), getGender(), getWeight());
                userMainScreen.Show();
                this.Close();
            }
        }

        private bool getIsAdmin()
        {
            return isAdmin;
        }

        private void setIsAdmin(bool value)
        {
            isAdmin = value;
        }

        private string getLicense()
        {
            return LICENSE;
        }

        private void setLicense(string DL)
        {
            LICENSE = DL;
        }
        
        private string getGender()
        {
            return GENDER;
        }

        private void setGender(string Gender)
        {
            GENDER = Gender;
        }

        private int getWeight()
        {
            return WEIGHT;
        }

        private void setWeight(int Weight)
        {
            WEIGHT = Weight;
        }

        private void DrinkHistory_Load(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            DrinkHistoryDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DrinkHistoryDataGrid.ReadOnly = true;
            DrinkHistoryDataGrid.DataSource = DBC.GetForDataGrid("SELECT R.ID, R.Name, Q.numDispensed AS 'Number Dispensed' FROM tblHistory Q, tblRecipe R WHERE Q.UserID = '" + getLicense() + "' AND R.ID = Q.RecipeID");
            DrinkHistoryDataGrid.Columns[0].Visible = false;
        }

        private void DrinkHistoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

    }
}
