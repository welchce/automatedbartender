﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutomatedBartender
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            AutomatedBartender.WindowProperties.resizeScreen(this);
        }

        private void AddUserNobtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
