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

        public DrinkHistory(bool admin, string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
            setLicense(DriversLicense);
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
                Form userMainScreen = new UserMain(getLicense());
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

        private void DrinkHistory_Load(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            DrinkHistoryDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DrinkHistoryDataGrid.ReadOnly = true;
            DrinkHistoryDataGrid.DataSource = DBC.GetForDataGrid("SELECT R.ID, R.Name FROM tblQueue Q, tblRecipe R WHERE Q.UserID = '" + getLicense() + "' AND Q.Dispensed = 'True' AND R.ID = Q.ID");
            DrinkHistoryDataGrid.Columns[0].Visible = false;
        }

        private void DrinkHistoryDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void DrinkHistorySubmitBtn_Click(object sender, EventArgs e)
        {
            Form drinkMakerForm = new DrinkMaker(getLicense());
            DatabaseCalls DBC = new DatabaseCalls();
            //ADD DRINK TO QUEUE
            int row = DrinkHistoryDataGrid.CurrentCellAddress.Y;
            string DrinkID = DrinkHistoryDataGrid[0, row].Value.ToString();
            DBC.AddDrinkToQueue(getLicense(), DrinkID);
            drinkMakerForm.Show();
            this.Close();
        }

    }
}
