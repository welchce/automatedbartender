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
    public partial class NewDrink : Form
    {
        public NewDrink()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }
    }
}
