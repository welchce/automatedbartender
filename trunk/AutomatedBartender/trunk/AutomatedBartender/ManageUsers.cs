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
        string LICENSE = "";

        public ManageUsers(string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(DriversLicense);
        }

        private void ManageUsersBackbtn_Click(object sender, EventArgs e)
        {
            Form adminMainScreen = new AdminMain(getLicense());
            adminMainScreen.Show();
            this.Close();
        }

        private void ManageUsersImportbtn_Click(object sender, EventArgs e)
        {
            openFD.InitialDirectory = "C:\\";
            openFD.Title = "Open an Excel File"; 
            openFD.ShowDialog();

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
