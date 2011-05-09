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
        string GENDER = "";
        int WEIGHT = 0;

        public UserMain(string DriversLicense, string Gender, int Weight)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(DriversLicense);
            setGender(Gender);
            setWeight(Weight);

            DatabaseCalls DBC = new DatabaseCalls();
            DateTime startTime = DBC.getStartDrinkTime(LICENSE);
            int hours = 1;
            if (hours != 0)
            {
                double ounces = .6;
                double calculatedBAC = 0;

                if (GENDER == "F")
                    calculatedBAC = (ounces * 5.14 / WEIGHT * .66) - .015 * hours;
                else
                    calculatedBAC = (ounces * 5.14 / WEIGHT * .73) - .015 * hours;
 
                UserBACLabel.Text = "BAC \n" + calculatedBAC + "%";
            }
            else
                UserBACLabel.Text = "BAC \n 0.00%";
        
               
        }

        private void UserExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPersonalHistoryBtn_Click(object sender, EventArgs e)
        {
            Form drinkHistory = new DrinkHistory(false, getLicense(), getGender(), getWeight());
            drinkHistory.Show();
            this.Close();
        }

        private void UserTop25Btn_Click(object sender, EventArgs e)
        {
            Form top25 = new Top25(false, getLicense(), getGender(), getWeight());
            top25.Show();
            this.Close();
        }

        private void UserAllDrinksBtn_Click(object sender, EventArgs e)
        {
            Form allDrinks = new AllDrinks(false, getLicense(), getGender(), getWeight());
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

        private void UserNewDrinkBtn_Click(object sender, EventArgs e)
        {
            Form newDrink = new AddDrink(false, getLicense(), getGender(), getWeight());
            newDrink.Show();
            this.Close();
        }

    }
}
