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
    public partial class AdminMainScreen : Form
    {
        public AdminMainScreen()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }


        private void AdminExitBtn_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void AdminManageUsersBtn_Click(object sender, EventArgs e)
        {
            Form manageUsersScreen = new ManageUsersScreen();
            manageUsersScreen.Show();
            this.Close();
        }

        private void AdminPersonalHistoryBtn_Click(object sender, EventArgs e)
        {
            Form drinkHistory = new DrinkHistory(true);
            drinkHistory.Show();
            this.Close();
        }

        private void AdminTop25Btn_Click(object sender, EventArgs e)
        {
            Form top25 = new Top25(true);
            top25.Show();
            this.Close();
        }
    }
}
