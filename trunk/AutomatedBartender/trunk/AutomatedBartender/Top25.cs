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
    public partial class Top25 : Form
    {
        bool isAdmin = false;
        public Top25(bool admin)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
        }

        private void Top25BackBtn_Click(object sender, EventArgs e)
        {
            if (getIsAdmin() == true)
            {
                Form adminMainScreen = new AdminMainScreen();
                adminMainScreen.Show();
                this.Close();
            }
            else
            {
                Form userMainScreen = new UserMainScreen();
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
    }
}
