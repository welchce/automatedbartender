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
    public partial class AddDrink : Form
    {
        bool isAdmin = false;
        public AddDrink(bool admin)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
        }
        private bool getIsAdmin()
        {
            return isAdmin;
        }

        private void setIsAdmin(bool value)
        {
            isAdmin = value;
        }

        private void AddDrinkBackBtn_Click(object sender, EventArgs e)
        {
            if (getIsAdmin() == true)
            {
                Form adminMainScreen = new AdminMain();
                adminMainScreen.Show();
                this.Close();
            }
            else
            {
                Form userMainScreen = new UserMain();
                userMainScreen.Show();
                this.Close();
            }
        }
    }
}
