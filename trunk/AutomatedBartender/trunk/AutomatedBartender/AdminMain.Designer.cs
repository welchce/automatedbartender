namespace AutomatedBartender
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
            this.AdminExitBtn = new System.Windows.Forms.Button();
            this.AdminBACLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminManageUsersBtn = new System.Windows.Forms.Button();
            this.AdminPersonalHistoryBtn = new System.Windows.Forms.Button();
            this.AdminAllDrinksBtn = new System.Windows.Forms.Button();
            this.AdminTop25Btn = new System.Windows.Forms.Button();
            this.AdminAddDrinkBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminManageInventoryBtn
            // 
            this.AdminManageInventoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminManageInventoryBtn.Location = new System.Drawing.Point(211, 135);
            this.AdminManageInventoryBtn.Name = "AdminManageInventoryBtn";
            this.AdminManageInventoryBtn.Size = new System.Drawing.Size(99, 60);
            this.AdminManageInventoryBtn.TabIndex = 5;
            this.AdminManageInventoryBtn.Text = "Manage Inventory";
            this.AdminManageInventoryBtn.UseVisualStyleBackColor = true;
            this.AdminManageInventoryBtn.Click += new System.EventHandler(this.AdminManageInventoryBtn_Click);
            // 
            // AdminExitBtn
            // 
            this.AdminExitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminExitBtn.Location = new System.Drawing.Point(3, 201);
            this.AdminExitBtn.Name = "AdminExitBtn";
            this.AdminExitBtn.Size = new System.Drawing.Size(98, 62);
            this.AdminExitBtn.TabIndex = 6;
            this.AdminExitBtn.Text = "Exit";
            this.AdminExitBtn.UseVisualStyleBackColor = true;
            this.AdminExitBtn.Click += new System.EventHandler(this.AdminExitBtn_Click);
            // 
            // AdminBACLabel
            // 
            this.AdminBACLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminBACLabel.AutoSize = true;
            this.AdminBACLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBACLabel.Location = new System.Drawing.Point(211, 198);
            this.AdminBACLabel.Name = "AdminBACLabel";
            this.AdminBACLabel.Size = new System.Drawing.Size(99, 68);
            this.AdminBACLabel.TabIndex = 7;
            this.AdminBACLabel.Text = "BAC\r\n0.0%";
            this.AdminBACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Admin Main Screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminManageUsersBtn
            // 
            this.AdminManageUsersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminManageUsersBtn.Location = new System.Drawing.Point(107, 135);
            this.AdminManageUsersBtn.Name = "AdminManageUsersBtn";
            this.AdminManageUsersBtn.Size = new System.Drawing.Size(98, 60);
            this.AdminManageUsersBtn.TabIndex = 4;
            this.AdminManageUsersBtn.Text = "Manage Users";
            this.AdminManageUsersBtn.UseVisualStyleBackColor = true;
            this.AdminManageUsersBtn.Click += new System.EventHandler(this.AdminManageUsersBtn_Click);
            // 
            // AdminPersonalHistoryBtn
            // 
            this.AdminPersonalHistoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPersonalHistoryBtn.Location = new System.Drawing.Point(3, 135);
            this.AdminPersonalHistoryBtn.Name = "AdminPersonalHistoryBtn";
            this.AdminPersonalHistoryBtn.Size = new System.Drawing.Size(98, 60);
            this.AdminPersonalHistoryBtn.TabIndex = 3;
            this.AdminPersonalHistoryBtn.Text = "Personal History";
            this.AdminPersonalHistoryBtn.UseVisualStyleBackColor = true;
            this.AdminPersonalHistoryBtn.Click += new System.EventHandler(this.AdminPersonalHistoryBtn_Click);
            // 
            // AdminAllDrinksBtn
            // 
            this.AdminAllDrinksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminAllDrinksBtn.Location = new System.Drawing.Point(211, 69);
            this.AdminAllDrinksBtn.Name = "AdminAllDrinksBtn";
            this.AdminAllDrinksBtn.Size = new System.Drawing.Size(99, 60);
            this.AdminAllDrinksBtn.TabIndex = 2;
            this.AdminAllDrinksBtn.Text = "All Drinks";
            this.AdminAllDrinksBtn.UseVisualStyleBackColor = true;
            this.AdminAllDrinksBtn.Click += new System.EventHandler(this.AdminAllDrinksBtn_Click);
            // 
            // AdminTop25Btn
            // 
            this.AdminTop25Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminTop25Btn.Location = new System.Drawing.Point(107, 69);
            this.AdminTop25Btn.Name = "AdminTop25Btn";
            this.AdminTop25Btn.Size = new System.Drawing.Size(98, 60);
            this.AdminTop25Btn.TabIndex = 1;
            this.AdminTop25Btn.Text = "Top 25";
            this.AdminTop25Btn.UseVisualStyleBackColor = true;
            this.AdminTop25Btn.Click += new System.EventHandler(this.AdminTop25Btn_Click);
            // 
            // AdminAddDrinkBtn
            // 
            this.AdminAddDrinkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminAddDrinkBtn.Location = new System.Drawing.Point(3, 69);
            this.AdminAddDrinkBtn.Name = "AdminAddDrinkBtn";
            this.AdminAddDrinkBtn.Size = new System.Drawing.Size(98, 60);
            this.AdminAddDrinkBtn.TabIndex = 0;
            this.AdminAddDrinkBtn.Text = "Add Drink";
            this.AdminAddDrinkBtn.UseVisualStyleBackColor = true;
            this.AdminAddDrinkBtn.Click += new System.EventHandler(this.AdminAddDrinkBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AdminPersonalHistoryBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminBACLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminExitBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminManageUsersBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminAllDrinksBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminManageInventoryBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.AdminTop25Btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminAddDrinkBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private System.Windows.Forms.Button AdminExitBtn;
        private System.Windows.Forms.Label AdminBACLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AdminPersonalHistoryBtn;
        private System.Windows.Forms.Button AdminManageUsersBtn;
        private System.Windows.Forms.Button AdminAllDrinksBtn;
        private System.Windows.Forms.Button AdminTop25Btn;
        private System.Windows.Forms.Button AdminAddDrinkBtn;
        private System.Windows.Forms.Label label2;
    }
}

