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
    public partial class MainSwipeScreen : Form
    {
        public MainSwipeScreen()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }

        private void ToUserScreenBtn_Click(object sender, EventArgs e)
        {
            Form UserForm = new AutomatedBartender.UserMainScreen();
            UserForm.Show();
            MainSwipeScreen.
        }
    }
}
