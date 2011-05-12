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
    public partial class ManageMixers : Form
    {
        string LICENSE = "";

        public ManageMixers(string DriversLicense)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(DriversLicense);
        }

        private void ManageMixers_Load(object sender, EventArgs e)
        {
            refreshInventoryList();
            DatabaseCalls DBC = new DatabaseCalls();
            NameComboBox.DataSource = DBC.GetForDataGrid("SELECT LiquidName FROM tblInventory WHERE Location = -2");
            NameComboBox.DisplayMember = "LiquidName";
            NameComboBox.ValueMember = "LiquidName";
        }

        private string getLicense()
        {
            return LICENSE;
        }

        private void setLicense(string DL)
        {
            LICENSE = DL;
        }

        private void refreshInventoryList()
        {
            DatabaseCalls DBC = new DatabaseCalls();
            manageInventoryGridView.DataSource = DBC.GetForDataGrid("SELECT ID, LiquidName AS 'Liquid Name' FROM tblInventory WHERE NOT Location = -1 AND NOT Location = -2 AND NOT Location > 0");
            manageInventoryGridView.Columns[0].Visible = false;
        }

        private void manageInventoryBackbtn_Click(object sender, EventArgs e)
        {
            Form adminMainScreen = new AdminMain(getLicense());
            adminMainScreen.Show();
            this.Close();
        }

        private void manageInventoryRemovebtn_Click(object sender, EventArgs e)
        {
            int row = manageInventoryGridView.CurrentCellAddress.Y;
            int inventoryID = Convert.ToInt32(manageInventoryGridView[0, row].Value);
            DatabaseCalls DBC = new DatabaseCalls();
            DBC.RemoveMixer(inventoryID);
            refreshInventoryList();
        }

        private void manageInventoryUpdateBtn_Click(object sender, EventArgs e)
        {            
            string ingredientName = NameComboBox.Text.ToString();
            DatabaseCalls DBC = new DatabaseCalls();
            DBC.UpdateMixer(ingredientName);
            refreshInventoryList();
        }

        private void manageInventoryAddBtn_Click(object sender, EventArgs e)
        {
            string ingredientName = addMixerTxtBox.Text.ToString();
            DatabaseCalls DBC = new DatabaseCalls();
            DBC.AddMixer(ingredientName);
            refreshInventoryList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                addMixerTxtBox.Enabled = true;
                manageInventoryAddBtn.Enabled = true;
            }
            else
            {
                addMixerTxtBox.Enabled = false;
                manageInventoryAddBtn.Enabled = false;
            }
        }
    }
}
