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
        public DrinkMaker()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            ArduinoCalls AC = new ArduinoCalls();
            AC.StartArduinoCommunication();
            AC.TurnOnMotor1();
            AC.TurnOnMotor2();
            Thread.Sleep(5000);
            AC.TurnOffMotor1();
            AC.TurnOffMotor2();
            this.Close();
        }

    }
}
