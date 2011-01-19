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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }

        private void ManageUsersBackbtn_Click(object sender, EventArgs e)
        {
            Form adminMainScreen = new AdminMain();
            adminMainScreen.Show();
            this.Close();
        }
    }
}
