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
    public partial class MainSwipe : Form
    {
        public MainSwipe()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }

        private void ToUserScreenBtn_Click(object sender, EventArgs e)
        {
            Form userMainScreen = new UserMain();
            userMainScreen.Show();
        }

        private void ToAdminScreenBtn_Click(object sender, EventArgs e)
        {
            Form adminMainScreen = new AdminMain();
            adminMainScreen.Show();
        }

        private void MainSwipe_Load(object sender, EventArgs e)
        {
            IDtextbox.Focus();
        }

        private void IDtextbox_TextChanged(object sender, EventArgs e)
        {
            int done = 0;
            for (int i = 0; i < IDtextbox.TextLength; i++)
            {   
                if (IDtextbox.Text.Substring(i,1) == "?")
                {
                    done++;
                    if (done == 3)
                    {
                        DoneLbl.Visible = true;
                        InfoFromID();
                    }
                }
            }
        }

        private void InfoFromID()
        {
            string State = "";
            string City = "";
            string Street = "";
            string FirstName = "";
            string MI = "";
            string LastName = "";
            string strOfInterest = "";
            string Today = "";
            int indexStart = 0;
            int indexEnd = 0;
            int CurrentYear = 0;
            int CurrentMonth = 0;
            int CurrentDay = 0;

            Today = DateTime.Today.ToString();

            indexStart = 0;
            indexEnd = Today.IndexOf("/");
            CurrentMonth = int.Parse(Today.Substring(indexStart, indexEnd - indexStart));

            indexStart = indexEnd+1;
            indexEnd = Today.IndexOf("/",indexStart);
            CurrentDay = int.Parse(Today.Substring(indexStart, indexEnd - indexStart));

            indexStart = indexEnd + 1;
            indexEnd = Today.IndexOf(" ");
            CurrentYear = int.Parse(Today.Substring(indexStart, indexEnd - indexStart));

            State = IDtextbox.Text.Substring(1, 2);

            indexStart = 3;
            indexEnd = IDtextbox.Text.IndexOf("^");
            City = IDtextbox.Text.Substring(indexStart,indexEnd-indexStart);

            indexStart = IDtextbox.Text.IndexOf("^")+1;
            indexEnd = IDtextbox.Text.IndexOf("$");
            LastName = strGood[indexStart:indexEnd]

            DoneLbl.Text = City.ToString();
        }
    }
}
