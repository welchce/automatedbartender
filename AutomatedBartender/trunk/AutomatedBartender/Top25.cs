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
        string LICENSE = "";

        public Top25(bool admin, string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
            setLicense(DriversLicense);
        }

        private void Top25BackBtn_Click(object sender, EventArgs e)
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
        
        private bool getIsAdmin()
        {
            return isAdmin;
        }

        private void setIsAdmin(bool value)
        {
            isAdmin = value;
        }

        private string getLicense()
        {
            return LICENSE;
        }

        private void setLicense(string DL)
        {
            LICENSE = DL;
        }

        private void Top25_Load(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            Top25DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Top25DataGrid.ReadOnly = true;
            Top25DataGrid.DataSource = DBC.GetForDataGrid("SELECT TOP 5 * FROM tblRecipe ORDER BY numDispensed DESC");
            //Top25DataGrid.Rows[3].Selected = true;
        }

        private void Top25DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Top25SubmitBtn_Click(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            int row = Top25DataGrid.CurrentCellAddress.Y;
            string DrinkID = Top25DataGrid[0, row].Value.ToString();
            DBC.AddDrinkToQueue(getLicense(), DrinkID);
        }
       
    }
}
