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
    public partial class ManageInventory : Form
    {
        string LICENSE = "";

        public ManageInventory(string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(DriversLicense);
        }

        private void manageInventoryBackbtn_Click(object sender, EventArgs e)
        {
            Form adminMainScreen = new AdminMain(getLicense());
            adminMainScreen.Show();
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
    }
}
