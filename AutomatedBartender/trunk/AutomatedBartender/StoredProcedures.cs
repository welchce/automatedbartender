using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AutomatedBartender
{
    class DatabaseCalls
    {
        public string verifyUser(string LicenseNo, string FirstName, string LastName)
        {
            SqlCommand cmd = new SqlCommand("SELECT LicenseNo FROM tblUsers WHERE LicenseNo = @LicenseNo", myConnection);
            licenseExists = 



        }
    }
}
