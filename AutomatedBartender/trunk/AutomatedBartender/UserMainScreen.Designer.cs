namespace AutomatedBartender
{
    partial class UserMainScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UserNewDrinkBtn = new System.Windows.Forms.Button();
            this.UserTop25Btn = new System.Windows.Forms.Button();
            this.UserAllDrinksBtn = new System.Windows.Forms.Button();
            this.UserPersonalHistoryBtn = new System.Windows.Forms.Button();
            this.UserExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserBACLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UserNewDrinkBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserTop25Btn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UserAllDrinksBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserPersonalHistoryBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserExitBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.UserBACLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 238);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // UserNewDrinkBtn
            // 
            this.UserNewDrinkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNewDrinkBtn.Location = new System.Drawing.Point(3, 62);
            this.UserNewDrinkBtn.Name = "UserNewDrinkBtn";
            this.UserNewDrinkBtn.Size = new System.Drawing.Size(124, 53);
            this.UserNewDrinkBtn.TabIndex = 0;
            this.UserNewDrinkBtn.Text = "New Drink";
            this.UserNewDrinkBtn.UseVisualStyleBackColor = true;
            // 
            // UserTop25Btn
            // 
            this.UserTop25Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTop25Btn.Location = new System.Drawing.Point(133, 62);
            this.UserTop25Btn.Name = "UserTop25Btn";
            this.UserTop25Btn.Size = new System.Drawing.Size(124, 53);
            this.UserTop25Btn.TabIndex = 1;
            this.UserTop25Btn.Text = "Top 25";
            this.UserTop25Btn.UseVisualStyleBackColor = true;
            // 
            // UserAllDrinksBtn
            // 
            this.UserAllDrinksBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAllDrinksBtn.Location = new System.Drawing.Point(3, 121);
            this.UserAllDrinksBtn.Name = "UserAllDrinksBtn";
            this.UserAllDrinksBtn.Size = new System.Drawing.Size(124, 53);
            this.UserAllDrinksBtn.TabIndex = 2;
            this.UserAllDrinksBtn.Text = "All Drinks";
            this.UserAllDrinksBtn.UseVisualStyleBackColor = true;
            // 
            // UserPersonalHistoryBtn
            // 
            this.UserPersonalHistoryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserPersonalHistoryBtn.Location = new System.Drawing.Point(133, 121);
            this.UserPersonalHistoryBtn.Name = "UserPersonalHistoryBtn";
            this.UserPersonalHistoryBtn.Size = new System.Drawing.Size(124, 53);
            this.UserPersonalHistoryBtn.TabIndex = 3;
            this.UserPersonalHistoryBtn.Text = "Personal History";
            this.UserPersonalHistoryBtn.UseVisualStyleBackColor = true;
            // 
            // UserExitBtn
            // 
            this.UserExitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserExitBtn.Location = new System.Drawing.Point(3, 180);
            this.UserExitBtn.Name = "UserExitBtn";
            this.UserExitBtn.Size = new System.Drawing.Size(124, 55);
            this.UserExitBtn.TabIndex = 4;
            this.UserExitBtn.Text = "Exit";
            this.UserExitBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 59);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Main Screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserBACLabel
            // 
            this.UserBACLabel.AutoSize = true;
            this.UserBACLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserBACLabel.Location = new System.Drawing.Point(133, 177);
            this.UserBACLabel.Name = "UserBACLabel";
            this.UserBACLabel.Size = new System.Drawing.Size(124, 61);
            this.UserBACLabel.TabIndex = 7;
            this.UserBACLabel.Text = "BAC\r\n0.0%";
            this.UserBACLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserMainScreen";
            this.Text = "UserMainScreen";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button UserNewDrinkBtn;
        private System.Windows.Forms.Button UserTop25Btn;
        private System.Windows.Forms.Button UserAllDrinksBtn;
        private System.Windows.Forms.Button UserPersonalHistoryBtn;
        private System.Windows.Forms.Button UserExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserBACLabel;

    }
}