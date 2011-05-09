using System;
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
    public partial class DrinkMaker : Form
    {
        string LICENSE = "";
        string GENDER = "";
        int WEIGHT = 0;

        string GloRecipeID = "";
        public DrinkMaker(string UserID, String RecipeID, string Gender, int Weight)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(UserID);
            setGender(Gender);
            setWeight(Weight);

            GloRecipeID = RecipeID;
            DatabaseCalls DBC = new DatabaseCalls();
            DrinkMixerInfoTbl.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DrinkMixerInfoTbl.ReadOnly = true;
            DrinkMixerInfoTbl.DataSource = DBC.GetForDataGrid("SELECT LiquidName FROM tblInventory WHERE ID IN (SELECT LiquidID FROM tblIngredients WHERE RecipeID = '" + RecipeID + "') AND Proof = 0"); 
            DrinkMixerInfoTbl.Columns[0].Visible = false;
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

        private void DrinkMaker_Load(object sender, EventArgs e)
        {/*
            //label1.Text = "OMG!!!";
            ArduinoCalls AC = new ArduinoCalls();
            DatabaseCalls DBC = new DatabaseCalls();
            int RecipeID = DBC.GetDrinkFromQueue(getLicense());
            int[] ports = DBC.GetDrinkPorts(RecipeID);
            AC.StartArduinoCommunication();
            int i = 0;
            while (ports[i] != 0)
            {
                AC.TurnOnMotor(ports[i]);
                i++;
            }
            i = 0;
            Thread.Sleep(5000);
            while (ports[i] != 0)
            {
                AC.TurnOffMotor(ports[i]);
                i++;
            }
            DBC.UpdateDrinkInQueue(getLicense()); //pass DrinkID
            AC.StopArduinoCommunication();*/
            //this.Close();
        }

        private void NoUserbtn_Click(object sender, EventArgs e)
        {

            DatabaseCalls DBC = new DatabaseCalls();
            //ADD DRINK TO QUEUE
            DBC.AddDrinkToHistory(LICENSE, GloRecipeID);
            DBC.DispensedDrink(GloRecipeID);

            ArduinoCalls AC = new ArduinoCalls();
            int[] ports = DBC.GetDrinkPorts(Convert.ToInt32(GloRecipeID));
            AC.StartArduinoCommunication();
            int i = 0;
            while (i < 10)
            {
                AC.TurnOnMotor(ports[i]);
                i++;
            }
            i = 0;
            Thread.Sleep(2000);
            while (i < 10)
            {
                AC.TurnOffMotor(ports[i]);
                i++;
            }
            AC.StopArduinoCommunication();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form userMainScreen = new UserMain(LICENSE,GENDER,WEIGHT);
            userMainScreen.Show();
            this.Close();
        }

     

    }
}
