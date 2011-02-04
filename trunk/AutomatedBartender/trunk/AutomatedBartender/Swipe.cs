using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutomatedBartender
{
    class Swipe
    {
        public void InfoFromID(string IDINFO, string Suffix)
        {
            //declare all variables needed
            string State = "";
            string City = "";
            string Street = "";
            string FirstName = "";
            string MI = "";
            string LastName = "";
            string Gender = "";
            string DL = "";
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

            String INFOOUTPUT = "";

            //get current month
            CurrentMonth = DateTime.Today.Month;

            //get current day
            CurrentDay = DateTime.Today.Day;

            //get current year
            CurrentYear = DateTime.Today.Year;

            //2 letter state designation entered right away
            State = IDINFO.Substring(1, 2);

            //get city from ID
            indexStart = 3;
            indexEnd = IDINFO.IndexOf("^");
            City = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get last name from ID
            indexStart = IDINFO.IndexOf("^") + 1;
            indexEnd = IDINFO.IndexOf("$");
            LastName = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get first name from ID
            indexStart = IDINFO.IndexOf("$") + 1;
            indexEnd = IDINFO.IndexOf("$", indexStart);
            FirstName = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get middle initial from ID
            indexStart = IDINFO.IndexOf("", indexEnd) + 1;
            indexEnd = indexStart + 1;
            MI = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get street from ID
            indexStart = IDINFO.IndexOf("^", indexEnd) + 1;
            indexEnd = IDINFO.IndexOf("^?");
            Street = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get DL from ID
            indexStart = indexEnd+3;
            indexEnd = IDINFO.IndexOf("=");
            DL = IDINFO.Substring(indexStart, indexEnd - indexStart);

            //get ID expired year
            indexStart = IDINFO.IndexOf("=") + 1;
            indexEnd = indexStart + 2;
            ExpireYear = 2000 + int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //get ID expired month
            indexStart = indexEnd;
            indexEnd = indexStart + 2;
            ExpireMonth = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            //check if the ID is valid
            if (CurrentYear < ExpireYear)
            {
                INFOOUTPUT = INFOOUTPUT + "Valid\n";
            }
            else if (CurrentYear == ExpireYear)
            {
                if (CurrentMonth <= ExpireMonth)
                {
                    INFOOUTPUT = INFOOUTPUT + "Valid\n";
                }
                else
                {
                    INFOOUTPUT = INFOOUTPUT + "Not Valid\n";
                }
            }
            else
            {
                INFOOUTPUT = INFOOUTPUT + "Not Valid\n";
            }

            //get ID DOB Year
            indexStart = IDINFO.IndexOf("=") + 5;
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
                INFOOUTPUT = INFOOUTPUT + "Legal\n";
            }
            else if (CurrentYear - 21 == DOBYear)
            {
                if (CurrentMonth > DOBMonth)
                {
                    INFOOUTPUT = INFOOUTPUT + "Legal\n";
                }
                else if (CurrentMonth == DOBMonth)
                {
                    if (CurrentDay >= DOBDay)
                    {
                        INFOOUTPUT = INFOOUTPUT + "Legal\n";
                    }
                    else
                    {
                        INFOOUTPUT = INFOOUTPUT + "Underage\n";
                    }
                }
                else
                {
                    INFOOUTPUT = INFOOUTPUT + "Underage\n";
                }
            }
            else
            {
                INFOOUTPUT = INFOOUTPUT + "Underage\n";
            }

            //get ID gender
            indexStart = indexEnd + 31;
            indexEnd = indexStart + 1;
            Gender = IDINFO.Substring(indexStart, indexEnd - indexStart);
            if (Gender == "1" | Gender == "M")
            {
                Gender = "M";
            }
            else if (Gender == "2" | Gender == "F")
            {
                Gender = "F";
            }
            else
            {
                Gender = "N";
            }

            //get ID weight
            indexStart = indexEnd + 3;
            indexEnd = indexStart + 3;
            Weight = int.Parse(IDINFO.Substring(indexStart, indexEnd - indexStart));

            /*INFOOUTPUT = INFOOUTPUT + "First Name: " + FirstName + "\n";
            INFOOUTPUT = INFOOUTPUT + "Middle Initial: " + MI + "\n";
            INFOOUTPUT = INFOOUTPUT + "Last Name: " + LastName + "\n";
            INFOOUTPUT = INFOOUTPUT + "Address: " + Street + "\n";
            INFOOUTPUT = INFOOUTPUT + "City: " + City + "\n";
            INFOOUTPUT = INFOOUTPUT + "State: " + State + "\n";
            INFOOUTPUT = INFOOUTPUT + "DOB: " + DOBMonth + "/" + DOBDay + "/" + DOBYear + "\n";
            INFOOUTPUT = INFOOUTPUT + "Weight: " + Weight + " lbs\n";
            INFOOUTPUT = INFOOUTPUT + "Gender: " + Gender + "\n";
            INFOOUTPUT = INFOOUTPUT + "Suffix: " + Suffix + "\n";
            //return INFOOUTPUT;
            string[] arrayToReturn = new string[3];
            arrayToReturn[0] = DL;
            arrayToReturn[1] = LastName;
            arrayToReturn[2] = FirstName;
            return arrayToReturn;*/
            DatabaseCalls DBC = new DatabaseCalls();
            string userType = DBC.verifyUser(DL);
            if (userType == "New")
            {
                bool user = DBC.updateUser(LastName, FirstName, DL, Gender, Weight);
            }
            else
            {
            }
            
        }
    }
}
