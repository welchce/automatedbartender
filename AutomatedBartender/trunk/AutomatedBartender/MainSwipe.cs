using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            if (e.KeyChar == 37)
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
                //InfoRTB.Text = "";
                Swipe ThisSwipe = new Swipe();
                ThisSwipe.InfoFromID(IDINFO, Suffix);
                //string theReturn = "";
                //InfoRTB.Text = theReturn;
                WaitForIDInput = false;
                WaitForSuffix = false;
                NumQuestionMarks = 0;
                IDINFO = "";
                Suffix = "";
                //DatabaseCalls DBC = new DatabaseCalls();
                //DBC.verifyUser(theReturn[0]);
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
            //Form userMainScreen = new UserMain();
            //userMainScreen.Show();
        }

        private void ToAdminScreenBtn_Click(object sender, EventArgs e)
        {
            //Form adminMainScreen = new AdminMain();
            //adminMainScreen.Show();
        }

        private void ChrisLoginBtn_Click(object sender, EventArgs e)
        {
            Swipe ThisSwipe = new Swipe();
            ThisSwipe.InfoFromID("%OHNORTH BEND^WELCH$CHRISTOPHER$E$^31 MUIRFIELD DR^?;6360231921525308=130619880630?%1045052      D B             1600150BROBRO                          92\"*SA     ?", "A");
            //DatabaseCalls DBC = new DatabaseCalls();
            //DBC.verifyUser(theReturn[0]);
        }

        private void TestLoginBtn_Click(object sender, EventArgs e)
        {
            Swipe ThisSwipe = new Swipe();
            ThisSwipe.InfoFromID("%OHNORTH BEND^WELCH$STEVE$E$^31 MUIRFIELD DR^?;6360231921525369=130619880630?%1045052      D B             1600150BROBRO                          92\"*SA     ?", "A");
        }

        private void MattLoginBtn_Click(object sender, EventArgs e)
        {
            Swipe ThisSwipe = new Swipe();
            ThisSwipe.InfoFromID("%OHNORTH BEND^Fuller$Matt$E$^31 MUIRFIELD DR^?;6360231921696969=130619880630?%1045052      D B             1600150BROBRO                          92\"*SA     ?", "A");
        }
    }
}
