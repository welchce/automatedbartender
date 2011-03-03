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
        public DrinkMaker(string UserID)
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            setLicense(UserID);
        }

        private string getLicense()
        {
            return LICENSE;
        }

        private void setLicense(string DL)
        {
            LICENSE = DL;
        }

        private void DrinkMaker_Load(object sender, EventArgs e)
        {
            label1.Text = "OMG!!!";
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
            AC.StopArduinoCommunication();
            this.Close();
        }

     

    }
}
