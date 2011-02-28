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
    public partial class UserMain : Form
    {
        string LICENSE = "";

        public UserMain(string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(DriversLicense);
            label2.Text = getLicense();
        }

        private void UserExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPersonalHistoryBtn_Click(object sender, EventArgs e)
        {
            Form drinkHistory = new DrinkHistory(false, getLicense());
            drinkHistory.Show();
            this.Close();
        }

        private void UserTop25Btn_Click(object sender, EventArgs e)
        {
            Form top25 = new Top25(false, getLicense());
            top25.Show();
            this.Close();
        }

        private void UserAllDrinksBtn_Click(object sender, EventArgs e)
        {
            Form allDrinks = new AllDrinks(false, getLicense());
            allDrinks.Show();
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

        private void UserNewDrinkBtn_Click(object sender, EventArgs e)
        {
            Form newDrink = new AddDrink(false, getLicense());
            newDrink.Show();
            this.Close();
        }
    }
}
