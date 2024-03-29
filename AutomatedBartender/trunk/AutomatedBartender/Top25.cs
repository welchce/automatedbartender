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
    public partial class Top25 : Form
    {
        bool isAdmin = false;
        string LICENSE = "";
        string GENDER = "";
        int WEIGHT = 0;

        public Top25(bool admin, string DriversLicense, string Gender, int Weight)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setIsAdmin(admin);
            setLicense(DriversLicense);
            setGender(Gender);
            setWeight(Weight);
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
                Form userMainScreen = new UserMain(getLicense(), getGender(), getWeight());
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

        private string getGender()
        {
            return GENDER;
        }

        private void setGender(string Gender)
        {
            GENDER = Gender;
        }

        private int getWeight()
        {
            return WEIGHT;
        }

        private void setWeight(int Weight)
        {
            WEIGHT = Weight;
        }

        private void Top25_Load(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            Top25DataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            Top25DataGrid.ReadOnly = true;
            Top25DataGrid.DataSource = DBC.GetForDataGrid("SELECT TOP 25 ID,NAME,numDispensed AS 'Number Dispensed' FROM tblRecipe WHERE ID NOT IN (SELECT RecipeID FROM tblIngredients t WHERE t.LiquidID IN (SELECT ID FROM tblInventory i WHERE i.Location<0)) AND numDispensed>0 ORDER BY numDispensed DESC");
            Top25DataGrid.Columns["ID"].Visible = false;
            //Top25DataGrid.Rows[3].Selected = true;
        }


        private void Top25SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int row = Top25DataGrid.CurrentCellAddress.Y;
                string DrinkID = Top25DataGrid[0, row].Value.ToString();
                Form drinkMakerForm = new DrinkMaker(getLicense(), DrinkID, getGender(), getWeight());
                DatabaseCalls DBC = new DatabaseCalls();
                //ADD DRINK TO QUEUE
                DBC.AddDrinkToHistory(getLicense(), DrinkID);
                drinkMakerForm.Show();
                this.Close();
            }
            catch
            {
            }
        }
       
    }
}
