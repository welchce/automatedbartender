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

            double hours = 0;
            if (startTime != Convert.ToDateTime(null))
            {
                DateTime nowTime = DateTime.Now;
                System.TimeSpan diff = nowTime - startTime;
                hours = Convert.ToDouble(diff.Seconds)/3600.0;
            }
            else
                hours = 0;

            if (hours != 0)
            {
                double ounces = DBC.getUserAlcoholicOunces(LICENSE);
                double calculatedBAC = 0;

                if (GENDER == "F")
                    calculatedBAC = (ounces * 5.14 / WEIGHT * .66) - .015 * hours;
                else
                    calculatedBAC = (ounces * 5.14 / WEIGHT * .73) - .015 * hours;

                if (calculatedBAC > 0)
                    UserBACLabel.Text = "BAC \n" + calculatedBAC + "%";
                else
                {
                    UserBACLabel.Text = "BAC \n 0.00%";
                    DBC.resetOuncesandStartTime(LICENSE);
                }
            }
            else
            {
                UserBACLabel.Text = "BAC \n 0.00%";
                DBC.resetOuncesandStartTime(LICENSE);
            }
        
               
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
