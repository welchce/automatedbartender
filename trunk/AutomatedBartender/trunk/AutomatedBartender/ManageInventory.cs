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
            try
            {
                this.tblInventoryTableAdapter.Update(this.bartenderDataSet.tblInventory);
                // sqlDataAdapter.Update(dataTable);
            }
            catch (Exception exceptionObj)
            {
                MessageBox.Show(exceptionObj.Message.ToString());
            }

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
            string ingredientName = manageInventoryNameTxt.Text.ToString();
            string ingredientProof = manageInventoryProofTxt.Text.ToString();
            string ingredientAmount = manageInventoryAmountTxt.Text.ToString();
            string ingredientSlot = manageInventorySlotTxt.Text.ToString();
            if (ingredientName != "" && ingredientProof != "" && ingredientSlot != "" && ingredientAmount != "" )
            {
                try
                {
                    DBC.AddInventory(ingredientName, Convert.ToInt32(ingredientProof), Convert.ToInt32(ingredientAmount), Convert.ToInt32(ingredientSlot));
                    refreshInventoryList();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Check your damn inputs, faggot");
                }

            }

        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bartenderDataSet.tblInventory' table. You can move, or remove it, as needed.
            this.tblInventoryTableAdapter.Fill(this.bartenderDataSet.tblInventory);
            refreshInventoryList();
        }

        private void refreshInventoryList()
        {
            //DatabaseCalls DBC = new DatabaseCalls();
            //manageInventoryGridView.DataSource = DBC.GetForDataGrid("SELECT ID, LiquidName AS 'Liquid Name', Proof, Quantity, Location AS 'Slot' FROM tblInventory");
            //manageInventoryGridView.Columns[0].Visible = false;
            //manageInventoryGridView.Rows[manageInventoryGridView.Rows.Count-1].Visible = false;
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
