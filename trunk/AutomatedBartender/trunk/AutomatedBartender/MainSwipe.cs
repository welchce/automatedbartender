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
        public string IDINFO;
        public int NumQuestionMarks;
        public bool FoundPercent;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 37 )
            {
                FoundPercent = true;
            }
            if (FoundPercent)
            {
                IDINFO = IDINFO + e.KeyChar.ToString();
            }
            if (e.KeyChar == 63)
            {
                NumQuestionMarks++;
                if (NumQuestionMarks == 3)
                {
                    FoundPercent = false;
                    IDtextbox.Text = IDINFO;
                    InfoFromID();
                    IDINFO = "";
                }
            }
            e.Handled = true;
        }

        public MainSwipe()
        {
            InitializeComponent();
            FoundPercent = false;
            NumQuestionMarks = 0;
            IDINFO = "";
            AutomatedBartender.WindowProperties.resizeScreen(this);
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Form1_KeyPress);
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
            string Today = "";
            string Gender = "";
            int indexStart = 0;
            int indexEnd = 0;
            int CurrentYear = 10;
            int CurrentMonth = 0;
            int CurrentDay = 0;
            int DOBYear = 0;
            int DOBMonth = 0;
            int DOBDay = 0;
            int Weight = 0;
            int ExpireYear = 0;
            int ExpireMonth = 0;
            string test = "";

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
            LastName = IDtextbox.Text.Substring(indexStart, indexEnd - indexStart);

            indexStart = IDtextbox.Text.IndexOf("$")+1;
            indexEnd = IDtextbox.Text.IndexOf("$",indexStart);
            FirstName = IDtextbox.Text.Substring(indexStart, indexEnd - indexStart);

            indexStart = IDtextbox.Text.IndexOf("",indexEnd)+1;
            indexEnd = indexStart + 1;
            MI = IDtextbox.Text.Substring(indexStart, indexEnd - indexStart);

            indexStart = IDtextbox.Text.IndexOf("^",indexEnd)+1;
            indexEnd = IDtextbox.Text.IndexOf("^?");
            Street = IDtextbox.Text.Substring(indexStart, indexEnd - indexStart);

            indexStart = IDtextbox.Text.IndexOf("=")+1;
            indexEnd = indexStart + 2;
            ExpireYear = 2000 + int.Parse(IDtextbox.Text.Substring(indexStart, indexEnd - indexStart));

            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            ExpireMonth = int.Parse(IDtextbox.Text.Substring(indexStart, indexEnd - indexStart));

            if (CurrentYear < ExpireYear)
            {
                InfoRTB.Text = InfoRTB.Text + "Valid\n";
            }
            else if (CurrentYear == ExpireYear)
            {
                if (CurrentMonth <= ExpireMonth)
                {
                    InfoRTB.Text = InfoRTB.Text + "Valid\n";
                }
                else
                {
                    InfoRTB.Text = InfoRTB.Text + "Not Valid\n";
                }
            }
            else
            {
                InfoRTB.Text = InfoRTB.Text + "Not Valid\n";
            }

            indexStart = IDtextbox.Text.IndexOf("=")+5;
            indexEnd = indexStart + 4;
            DOBYear = int.Parse(IDtextbox.Text.Substring(indexStart, indexEnd - indexStart));

            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            DOBMonth = int.Parse(IDtextbox.Text.Substring(indexStart, indexEnd - indexStart));

            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            DOBDay = int.Parse(IDtextbox.Text.Substring(indexStart, indexEnd - indexStart));

            if (CurrentYear - 21 > DOBYear)
            {
                InfoRTB.Text = InfoRTB.Text + "Legal\n";
            }
            else if (CurrentYear - 21 == DOBYear)
            {
                if (CurrentMonth > DOBMonth)
                {
                    InfoRTB.Text = InfoRTB.Text + "Legal\n";
                }
                else if (CurrentMonth == DOBMonth)
                {
                    if (CurrentDay >= DOBDay)
                    {
                        InfoRTB.Text = InfoRTB.Text + "Legal\n";
                    }
                    else
                    {
                        InfoRTB.Text = InfoRTB.Text + "Underage\n";
                    }
                }
                else
                {
                    InfoRTB.Text = InfoRTB.Text + "Underage\n";
                }
            }
            else
            {
                InfoRTB.Text = InfoRTB.Text + "Underage\n";
            }


            indexStart = indexEnd + 31;
            indexEnd = indexStart + 1;
            Gender = IDtextbox.Text.Substring(indexStart, indexEnd - indexStart);
            if (Gender == "1" | Gender == "M")
            {
                Gender = "Male";
            }
            else if (Gender == "2" | Gender == "F")
            {
                Gender = "Female";
            }
            else
            {
                Gender = "N/A";
            }

            indexStart = indexEnd+3;
            indexEnd = indexStart + 3;
            test = IDtextbox.Text.Substring(indexStart, indexEnd - indexStart);
            Weight = int.Parse(IDtextbox.Text.Substring(indexStart, indexEnd - indexStart));

            InfoRTB.Text = InfoRTB.Text +  "First Name: " + FirstName +"\n";
            InfoRTB.Text = InfoRTB.Text + "Middle Initial: " + MI + "\n";
            InfoRTB.Text = InfoRTB.Text + "Last Name: " + LastName + "\n";
            InfoRTB.Text = InfoRTB.Text + "Address: " + Street + "\n";
            InfoRTB.Text = InfoRTB.Text + "City: " + City + "\n";
            InfoRTB.Text = InfoRTB.Text + "State: " + State + "\n";
            InfoRTB.Text = InfoRTB.Text + "DOB: " + DOBMonth + "/" + DOBDay + "/" + DOBYear + "\n";
            InfoRTB.Text = InfoRTB.Text + "Weight: " + Weight + " lbs\n";
            InfoRTB.Text = InfoRTB.Text + "Gender: " + Gender + "\n";
        }
    }
}
