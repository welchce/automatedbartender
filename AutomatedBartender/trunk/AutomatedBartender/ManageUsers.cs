using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    readFile(openFileDialog1.FileName.ToString());
                    refreshUserList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
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

        private void readFile(string file)
        {
            //StreamReader streamReader = new StreamReader(@"c:\file.csv");
            StreamReader streamReader = new StreamReader(@file);
            string text = streamReader.ReadToEnd();
            streamReader.Close();
            string firstcol = "";
            string secondcol = "";
            int start = 0;
            for (int i = start; i <= text.Length-2; i++)
            {
                string test = text.Substring(i);
                if (text.Substring(i,1) == ",")
                {
                    firstcol = text.Substring(start,i-start);
                    firstcol = firstcol.ToUpper();
                    start = i + 1;
                }
                if (text.Substring(i, 2) == "\r\n")
                {
                    secondcol = text.Substring(start, i - start);
                    secondcol = secondcol.ToUpper();
                    DatabaseCalls DBC = new DatabaseCalls();
                    if (FNLNRB.Checked)
                    {
                        DBC.AddUser(firstcol, secondcol);
                    }
                    else if (LNFNRB.Checked)
                    {
                        DBC.AddUser(secondcol,firstcol);
                    }
                    firstcol = "";
                    secondcol = "";
                    start = i + 2;
                }
            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            refreshUserList();
            manageUsersGridView.Columns[0].Visible = false;
        }
        private void refreshUserList()
        {
            DatabaseCalls DBC = new DatabaseCalls();
            manageUsersGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            manageUsersGridView.ReadOnly = true;
            manageUsersGridView.DataSource = DBC.GetForDataGrid("SELECT * FROM tblUsers ORDER BY LastName ASC");
        }

        private void ManageUsersRemovebtn_Click(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            int row = manageUsersGridView.CurrentCellAddress.Y;
            string UserID = manageUsersGridView[0, row].Value.ToString();
            DBC.DeleteUser(UserID);
            refreshUserList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseCalls DBC = new DatabaseCalls();
            DBC.AddUser(textBox1.Text.ToUpper(), textBox2.Text.ToUpper());
            refreshUserList();
        }
    }
}
