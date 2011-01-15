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
    public partial class UserMainScreen : Form
    {
        public UserMainScreen()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }

        private void UserExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPersonalHistoryBtn_Click(object sender, EventArgs e)
        {
            Form drinkHistory = new DrinkHistory(false);
            drinkHistory.Show();
            this.Close();
        }

        private void UserTop25Btn_Click(object sender, EventArgs e)
        {
            Form top25 = new Top25(false);
            top25.Show();
            this.Close();
        }
    }
}
