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
        public string Suffix;
        public int NumQuestionMarks;
        public bool WaitForIDInput;
        public bool WaitForSuffix;
        /*Author Christopher Welch
         *      2011 01 31     */
        private void MainSwipe_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if the character pressed is a %
            if (e.KeyChar == 37 )
            {
                WaitForIDInput = true;
            }
            //since % starts an ID, start logging the following characters
            if (WaitForIDInput)
            {
                if (WaitForSuffix)
                {
                    Suffix = e.KeyChar.ToString();
                }
                else
                {
                    IDINFO = IDINFO + e.KeyChar.ToString();
                }
                e.Handled = true;   //e.Handled = true; tells the program that the character has been consumed and will not be used any where else
            }
            //if no percent has been entered, input is regular from the user
            else
            {
                IDINFO = "";
                e.Handled = false;  //e.Handled = false; tells the program that the character has NOT been consumed and can be used else where
            }
            //if the character is a question mark, count
            if (e.KeyChar == 63)
            {
                NumQuestionMarks++;
            }
            //the 3rd question mark ends the ID sequence
            if (NumQuestionMarks == 3)
            {
                WaitForSuffix = true;
            }
            //once the suffix has been recorded, parse the information
            if (NumQuestionMarks == 3 && Suffix != "")
            {
                InfoRTB.Text = "";
                InfoFromID();
                WaitForIDInput = false;
                WaitForSuffix = false;
                NumQuestionMarks = 0;
                IDINFO = "";
                Suffix = "";
            }
        }

        public MainSwipe()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);

            //sets up all variables for the ID swipe
            WaitForIDInput = false;
            WaitForSuffix = false;
            NumQuestionMarks = 0;
            Suffix = "";
            IDINFO = "";
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(MainSwipe_KeyPress);
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

        private void InfoFromID()
        {
            //declare all variables needed
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

            Today = DateTime.Today.ToString();

            //get current month
            indexStart = 0;
            indexEnd = Today.IndexOf("/");
            CurrentMonth = int.Parse(Today.Substring(indexStart, indexEnd - indexStart));

            //get current day
            indexStart = indexEnd+1;
            indexEnd = Today.IndexOf("/",indexStart);
            CurrentDay = int.Parse(Today.Substring(indexStart, indexEnd - indexStart));

            //get current year
            indexStart = indexEnd + 1;
            indexEnd = Today.IndexOf(" ");
            CurrentYear = int.Parse(Today.Substring(indexStart, indexEnd - indexStart));

            //2 letter state designation entered right away
            State = IDINFO.Substring(1, 2);

            //get city from ID
            indexStart = 3;
            indexEnd = IDINFO.IndexOf("^");
            City = IDINFO.Substring(indexStart,indexEnd-indexStart);

            //get last name from ID
            indexStart = IDINFO.IndexOf("^")+1;
            indexEnd = IDINFO.IndexOf("$");
            LastName = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get first name from ID
            indexStart = IDINFO.IndexOf("$")+1;
            indexEnd = IDINFO.IndexOf("$",indexStart);
            FirstName = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get middle initial from ID
            indexStart = IDINFO.IndexOf("",indexEnd)+1;
            indexEnd = indexStart + 1;
            MI = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get street from ID
            indexStart = IDINFO.IndexOf("^",indexEnd)+1;
            indexEnd = IDINFO.IndexOf("^?");
            Street = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get ID expired year
            indexStart = IDINFO.IndexOf("=")+1;
            indexEnd = indexStart + 2;
            ExpireYear = 2000 + int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //get ID expired month
            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            ExpireMonth = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //check if the ID is valid
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

            //get ID DOB Year
            indexStart = IDINFO.IndexOf("=")+5;
            indexEnd = indexStart + 4;
            DOBYear = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //get ID DOB Month
            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            DOBMonth = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //get ID DOB Day
            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            DOBDay = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //check if they are of age
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

            //get ID gender
            indexStart = indexEnd + 31;
            indexEnd = indexStart + 1;
            Gender = IDINFO.Substring(indexStart, indexEnd - indexStart);
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

            //get ID weight
            indexStart = indexEnd+3;
            indexEnd = indexStart + 3;
            Weight = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

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
