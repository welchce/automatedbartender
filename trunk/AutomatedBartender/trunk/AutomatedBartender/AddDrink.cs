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

        private void AddDrinkSubmitBtn_Click(object sender, EventArgs e)
        {
            if (AddDrinkTextBox.Text != "" && AddDrinkIngredientTable.Rows[0].Cells["Ingredient"].Value != null && AddDrinkIngredientTable.Rows[0].Cells["Amount"].Value != null)
            {
                DatabaseCalls DBC = new DatabaseCalls();
                DataGridViewRowCollection rows = AddDrinkIngredientTable.Rows;
                int drinkID = DBC.AddDrinkRecipe(AddDrinkTextBox.Text);
                foreach (DataGridViewRow row in rows)
                {
                    if (AddDrinkIngredientTable.Rows[row.Index].Cells["Ingredient"].Value != null && AddDrinkIngredientTable.Rows[row.Index].Cells["Amount"].Value != null)
                    {
                        string currentIngredient = AddDrinkIngredientTable.Rows[row.Index].Cells["Ingredient"].Value.ToString();
                        string currentAmount = AddDrinkIngredientTable.Rows[row.Index].Cells["Amount"].Value.ToString();
                        DBC.AddIngredientsToRecipe(drinkID, currentIngredient, currentAmount);
                    }
                }
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
        }

        private void AddDrink_Load(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            DataGridViewComboBoxColumn ingredientsColumn = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn amountColumn = new DataGridViewComboBoxColumn();
            ingredientsColumn.Name = "Ingredient";
            amountColumn.Name = "Amount";
            ingredientsColumn.DataSource = DBC.GetForDataGrid("SELECT LiquidName From tblInventory");
            ingredientsColumn.ValueMember = "LiquidName";
            amountColumn.DataSource = DBC.GetForDataGrid("SELECT Name from tblAmount");
            amountColumn.ValueMember = "Name";
            AddDrinkIngredientTable.Columns.Add(ingredientsColumn);
            AddDrinkIngredientTable.Columns.Add(amountColumn);
        }

    }
}
