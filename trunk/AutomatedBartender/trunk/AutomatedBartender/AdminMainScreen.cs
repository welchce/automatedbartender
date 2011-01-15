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
    public partial class AdminMainScreen : Form
    {
        public AdminMainScreen()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
            AdminNewDrinkBtn.Left = this.Width/10;
            AdminNewDrinkBtn.Top = this.Height/10;
            AdminTop25Btn.Left = 4 * this.Width / 10;
            AdminTop25Btn.Top = this.Height / 10;
            AdminAllDrinksBtn.Left = 7 * this.Width / 10;
            AdminAllDrinksBtn.Top = this.Height / 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AdminMainScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
