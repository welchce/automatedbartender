﻿using System;
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
            Form drinkHistory = new DrinkHistory(true, getLicense(),"",0);
            drinkHistory.Show();
            this.Close();
        }

        private void AdminTop25Btn_Click(object sender, EventArgs e)
        {
            Form top25 = new Top25(true, getLicense(),"",0);
            top25.Show();
            this.Close();
        }

        private void AdminManageInventoryBtn_Click(object sender, EventArgs e)
        {
            Form manageInventory = new ManageInventory(getLicense());
            manageInventory.Show();
            this.Close();
        }


        private void AdminAddDrinkBtn_Click(object sender, EventArgs e)
        {
            Form addDrink = new AddDrink(true, getLicense(),"",0);
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

        private void AdminAllDrinksBtn_Click_1(object sender, EventArgs e)
        {
            Form allDrinks = new AllDrinks(true, getLicense(),"",0);
            allDrinks.Show();
            this.Close();
        }

        private void manageMixersBtn_Click(object sender, EventArgs e)
        {
            Form manageMixers = new ManageMixers(getLicense());
            manageMixers.Show();
            this.Close();
        }

    }
}
