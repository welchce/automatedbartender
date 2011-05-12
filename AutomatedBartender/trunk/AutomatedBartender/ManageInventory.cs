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

        private void manageInventoryAddBtn_Click(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            string ingredientName = NameComboBox.Text.ToString();
            string ingredientProof = manageInventoryProofTxt.Text.ToString();
            string ingredientAmount = manageInventoryAmountTxt.Text.ToString();
            string ingredientSlot = SlotComboBox.Text.ToString();
            if (ingredientName != "" && ingredientProof != "" && ingredientSlot != "" && ingredientAmount != "" )
            {
                try
                {
                    DBC.AddInventory(ingredientName, Convert.ToInt32(ingredientProof), Convert.ToInt32(ingredientAmount), Convert.ToInt32(ingredientSlot));
                    refreshInventoryList();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Check your inputs");
                }

                manageInventoryProofTxt.ResetText();
                manageInventoryAmountTxt.ResetText();

            }

        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bartenderDataSet.tblInventory' table. You can move, or remove it, as needed.
            this.tblInventoryTableAdapter.Fill(this.bartenderDataSet.tblInventory);
            refreshInventoryList();
            DatabaseCalls DBC = new DatabaseCalls();
            NameComboBox.DataSource = DBC.GetForDataGrid("SELECT LiquidName FROM tblInventory WHERE NOT Location = -2 AND NOT Location = 0");
            NameComboBox.DisplayMember = "LiquidName";
            NameComboBox.ValueMember = "LiquidName";
            SlotComboBox.DataSource = DBC.GetForDataGrid("SELECT Location FROM tblLocations");
            SlotComboBox.DisplayMember = "Location";
            SlotComboBox.ValueMember = "Location";
        }

        private void refreshInventoryList()
        {
            DatabaseCalls DBC = new DatabaseCalls();
            manageInventoryGridView.DataSource = DBC.GetForDataGrid("SELECT ID, LiquidName AS 'Liquid Name', Proof, Quantity, Location AS 'Slot' FROM tblInventory WHERE Location > 0 ORDER BY Location ASC");
            manageInventoryGridView.Columns[0].Visible = false;
        }

        private void manageInventoryRemovebtn_Click(object sender, EventArgs e)
        {
            int row = manageInventoryGridView.CurrentCellAddress.Y;
            int inventoryID = Convert.ToInt32(manageInventoryGridView[0, row].Value);
            DatabaseCalls DBC = new DatabaseCalls();
            DBC.RemoveInventory(inventoryID);
            refreshInventoryList();
        }

    }
}
