﻿namespace AutomatedBartender
{
    partial class AdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminManageInventoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminManageUsersBtn = new System.Windows.Forms.Button();
            this.AdminAddDrinkBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AdminExitBtn = new System.Windows.Forms.Button();
            this.AdminAllDrinksBtn = new System.Windows.Forms.Button();
            this.manageMixersBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminManageInventoryBtn
            // 
            this.AdminManageInventoryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminManageInventoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminManageInventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminManageInventoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminManageInventoryBtn.ForeColor = System.Drawing.Color.White;
            this.AdminManageInventoryBtn.Location = new System.Drawing.Point(159, 135);
            this.AdminManageInventoryBtn.Name = "AdminManageInventoryBtn";
            this.AdminManageInventoryBtn.Size = new System.Drawing.Size(151, 60);
            this.AdminManageInventoryBtn.TabIndex = 5;
            this.AdminManageInventoryBtn.Text = "Manage Liquor Inventory";
            this.AdminManageInventoryBtn.UseVisualStyleBackColor = false;
            this.AdminManageInventoryBtn.Click += new System.EventHandler(this.AdminManageInventoryBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Main Screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminManageUsersBtn
            // 
            this.AdminManageUsersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminManageUsersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminManageUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminManageUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminManageUsersBtn.ForeColor = System.Drawing.Color.White;
            this.AdminManageUsersBtn.Location = new System.Drawing.Point(159, 69);
            this.AdminManageUsersBtn.Name = "AdminManageUsersBtn";
            this.AdminManageUsersBtn.Size = new System.Drawing.Size(151, 60);
            this.AdminManageUsersBtn.TabIndex = 4;
            this.AdminManageUsersBtn.Text = "Manage Users";
            this.AdminManageUsersBtn.UseVisualStyleBackColor = false;
            this.AdminManageUsersBtn.Click += new System.EventHandler(this.AdminManageUsersBtn_Click);
            // 
            // AdminAddDrinkBtn
            // 
            this.AdminAddDrinkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminAddDrinkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminAddDrinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminAddDrinkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminAddDrinkBtn.ForeColor = System.Drawing.Color.White;
            this.AdminAddDrinkBtn.Location = new System.Drawing.Point(3, 69);
            this.AdminAddDrinkBtn.Name = "AdminAddDrinkBtn";
            this.AdminAddDrinkBtn.Size = new System.Drawing.Size(150, 60);
            this.AdminAddDrinkBtn.TabIndex = 0;
            this.AdminAddDrinkBtn.Text = "Add Drink";
            this.AdminAddDrinkBtn.UseVisualStyleBackColor = false;
            this.AdminAddDrinkBtn.Click += new System.EventHandler(this.AdminAddDrinkBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.manageMixersBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminExitBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminManageInventoryBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminAddDrinkBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AdminAllDrinksBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminManageUsersBtn, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 266);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // AdminExitBtn
            // 
            this.AdminExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminExitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminExitBtn.ForeColor = System.Drawing.Color.White;
            this.AdminExitBtn.Location = new System.Drawing.Point(159, 201);
            this.AdminExitBtn.Name = "AdminExitBtn";
            this.AdminExitBtn.Size = new System.Drawing.Size(151, 62);
            this.AdminExitBtn.TabIndex = 6;
            this.AdminExitBtn.Text = "Exit";
            this.AdminExitBtn.UseVisualStyleBackColor = false;
            this.AdminExitBtn.Click += new System.EventHandler(this.AdminExitBtn_Click);
            // 
            // AdminAllDrinksBtn
            // 
            this.AdminAllDrinksBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminAllDrinksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminAllDrinksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AdminAllDrinksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdminAllDrinksBtn.ForeColor = System.Drawing.Color.White;
            this.AdminAllDrinksBtn.Location = new System.Drawing.Point(3, 135);
            this.AdminAllDrinksBtn.Name = "AdminAllDrinksBtn";
            this.AdminAllDrinksBtn.Size = new System.Drawing.Size(150, 60);
            this.AdminAllDrinksBtn.TabIndex = 9;
            this.AdminAllDrinksBtn.Text = "All Drinks";
            this.AdminAllDrinksBtn.UseVisualStyleBackColor = false;
            this.AdminAllDrinksBtn.Click += new System.EventHandler(this.AdminAllDrinksBtn_Click_1);
            // 
            // manageMixersBtn
            // 
            this.manageMixersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.manageMixersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageMixersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageMixersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.manageMixersBtn.ForeColor = System.Drawing.Color.White;
            this.manageMixersBtn.Location = new System.Drawing.Point(3, 201);
            this.manageMixersBtn.Name = "manageMixersBtn";
            this.manageMixersBtn.Size = new System.Drawing.Size(150, 62);
            this.manageMixersBtn.TabIndex = 10;
            this.manageMixersBtn.Text = "Manage Mixers Inventory";
            this.manageMixersBtn.UseVisualStyleBackColor = false;
            this.manageMixersBtn.Click += new System.EventHandler(this.manageMixersBtn_Click);
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(337, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminMain";
            this.Text = "Admin Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminManageInventoryBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AdminManageUsersBtn;
        private System.Windows.Forms.Button AdminAddDrinkBtn;
        private System.Windows.Forms.Button AdminAllDrinksBtn;
        private System.Windows.Forms.Button AdminExitBtn;
        private System.Windows.Forms.Button manageMixersBtn;
    }
}

