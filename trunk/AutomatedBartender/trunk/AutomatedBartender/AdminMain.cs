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
    public partial class AdminMain : Form
    {
        string LICENSE="";

        public AdminMain(string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(DriversLicense);
        }


        private void AdminExitBtn_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void AdminManageUsersBtn_Click(object sender, EventArgs e)
        {
            Form manageUsersScreen = new ManageUsers(getLicense());
            manageUsersScreen.Show();
            this.Close();
        }

        private void AdminPersonalHistoryBtn_Click(object sender, EventArgs e)
        {
            Form drinkHistory = new DrinkHistory(true, getLicense());
            drinkHistory.Show();
            this.Close();
        }

        private void AdminTop25Btn_Click(object sender, EventArgs e)
        {
            Form top25 = new Top25(true, getLicense());
            top25.Show();
            this.Close();
        }

        private void AdminManageInventoryBtn_Click(object sender, EventArgs e)
        {
            Form manageInventory = new ManageInventory(getLicense());
            manageInventory.Show();
            this.Close();
        }

        private void AdminAllDrinksBtn_Click(object sender, EventArgs e)
        {
            Form allDrinks = new AllDrinks(true, getLicense());
            allDrinks.Show();
            this.Close();
        }

        private void AdminAddDrinkBtn_Click(object sender, EventArgs e)
        {
            Form addDrink = new AddDrink(true, getLicense());
            addDrink.Show();
            this.Close();
        }

        private string getLicense()
        {
            return LICENSE;
        }

        private void setLicense(string DL)
        {
            LICENSE = DL;
        }
    }
}
