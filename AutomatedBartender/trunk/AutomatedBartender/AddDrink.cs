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
    public partial class AddDrink : Form
    {
        bool isAdmin = false;
        string LICENSE = "";

        public AddDrink(bool admin, string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
            setLicense(DriversLicense);
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
                Form adminMainScreen = new AdminMain(getLicense());
                adminMainScreen.Show();
                this.Close();
            }
            else
            {
                Form userMainScreen = new UserMain(getLicense());
                userMainScreen.Show();
                this.Close();
            }
        }

        private string getLicense()
        {
            return LICENSE;
        }

        private void setLicense(string DL)
        {
            LICENSE = DL;
        }

        private void AddDrinkAddRowBtn_Click(object sender, EventArgs e)
        {
            AddDrinkIngredientTable.Rows.Add();
        }
    }
}
