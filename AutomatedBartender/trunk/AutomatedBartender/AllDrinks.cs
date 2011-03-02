﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace AutomatedBartender
{
    public partial class AllDrinks : Form
    {
        bool isAdmin;
        string LICENSE = "";
        public AllDrinks(bool admin, string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
            setLicense(DriversLicense);
        }

        private void AllDrinksBackBtn_Click(object sender, EventArgs e)
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

        private void AllDrinks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bartenderDataSet.spAllDrinks' table. You can move, or remove it, as needed.
            //this.spAllDrinksTableAdapter.Fill(this.bartenderDataSet.spAllDrinks);

            DatabaseCalls DBC = new DatabaseCalls();
            AllDrinksDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            AllDrinksDataGrid.ReadOnly = true;
            AllDrinksDataGrid.DataSource = DBC.GetForDataGrid("SELECT ID, Name FROM tblRecipe");
            //column 0 is ID and we don't want to see it but we will need id later
            AllDrinksDataGrid.Columns[0].Visible = false;
            if (isAdmin)
                AllDrinksSubmitBtn.Visible = false;

        }

        private void AllDrinksSubmitBtn_Click(object sender, EventArgs e)
        {
            Form drinkMakerForm = new DrinkMaker();
            DatabaseCalls DBC = new DatabaseCalls();
            
            //ADD DRINK TO QUEUE
            int row = AllDrinksDataGrid.CurrentCellAddress.Y;
            string DrinkID = AllDrinksDataGrid[0, row].Value.ToString();
            DBC.AddDrinkToQueue(getLicense(), DrinkID);
            drinkMakerForm.Show();
            this.Close();
        }
    }
}
