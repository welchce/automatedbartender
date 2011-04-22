namespace AutomatedBartender
{
    partial class MainSwipe
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
            this.lblMainText = new System.Windows.Forms.Label();
            this.ToUserScreenBtn = new System.Windows.Forms.Button();
            this.ToAdminScreenBtn = new System.Windows.Forms.Button();
            this.DoneLbl = new System.Windows.Forms.Label();
            this.ChrisLoginBtn = new System.Windows.Forms.Button();
            this.TestLoginBtn = new System.Windows.Forms.Button();
            this.MattLoginBtn = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.lblMainText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToUserScreenBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ToAdminScreenBtn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 168);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMainText
            // 
            this.lblMainText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainText.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblMainText, 2);
            this.lblMainText.Location = new System.Drawing.Point(3, 0);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(253, 159);
            this.lblMainText.TabIndex = 0;
            this.lblMainText.Text = "To Begin\r\nPlease Swipe\r\nI.D.";
            this.lblMainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToUserScreenBtn
            // 
            this.ToUserScreenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToUserScreenBtn.Location = new System.Drawing.Point(3, 162);
            this.ToUserScreenBtn.Name = "ToUserScreenBtn";
            this.ToUserScreenBtn.Size = new System.Drawing.Size(123, 3);
            this.ToUserScreenBtn.TabIndex = 1;
            this.ToUserScreenBtn.Text = "User Main Screen";
            this.ToUserScreenBtn.UseVisualStyleBackColor = true;
            this.ToUserScreenBtn.Visible = false;
            this.ToUserScreenBtn.Click += new System.EventHandler(this.ToUserScreenBtn_Click);
            // 
            // ToAdminScreenBtn
            // 
            this.ToAdminScreenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToAdminScreenBtn.Location = new System.Drawing.Point(132, 162);
            this.ToAdminScreenBtn.Name = "ToAdminScreenBtn";
            this.ToAdminScreenBtn.Size = new System.Drawing.Size(124, 3);
            this.ToAdminScreenBtn.TabIndex = 2;
            this.ToAdminScreenBtn.Text = "Admin Main Screen";
            this.ToAdminScreenBtn.UseVisualStyleBackColor = true;
            this.ToAdminScreenBtn.Visible = false;
            this.ToAdminScreenBtn.Click += new System.EventHandler(this.ToAdminScreenBtn_Click);
            // 
            // DoneLbl
            // 
            this.DoneLbl.AutoSize = true;
            this.DoneLbl.Location = new System.Drawing.Point(29, 44);
            this.DoneLbl.Name = "DoneLbl";
            this.DoneLbl.Size = new System.Drawing.Size(33, 13);
            this.DoneLbl.TabIndex = 2;
            this.DoneLbl.Text = "Done";
            this.DoneLbl.Visible = false;
            // 
            // ChrisLoginBtn
            // 
            this.ChrisLoginBtn.Location = new System.Drawing.Point(97, 34);
            this.ChrisLoginBtn.Name = "ChrisLoginBtn";
            this.ChrisLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.ChrisLoginBtn.TabIndex = 3;
            this.ChrisLoginBtn.Text = "Chris Login";
            this.ChrisLoginBtn.UseVisualStyleBackColor = true;
            this.ChrisLoginBtn.Click += new System.EventHandler(this.ChrisLoginBtn_Click);
            // 
            // TestLoginBtn
            // 
            this.TestLoginBtn.Location = new System.Drawing.Point(178, 34);
            this.TestLoginBtn.Name = "TestLoginBtn";
            this.TestLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.TestLoginBtn.TabIndex = 4;
            this.TestLoginBtn.Text = "Test Login";
            this.TestLoginBtn.UseVisualStyleBackColor = true;
            this.TestLoginBtn.Click += new System.EventHandler(this.TestLoginBtn_Click);
            // 
            // MattLoginBtn
            // 
            this.MattLoginBtn.Location = new System.Drawing.Point(97, 63);
            this.MattLoginBtn.Name = "MattLoginBtn";
            this.MattLoginBtn.Size = new System.Drawing.Size(75, 23);
            this.MattLoginBtn.TabIndex = 5;
            this.MattLoginBtn.Text = "Matt Login";
            this.MattLoginBtn.UseVisualStyleBackColor = true;
            this.MattLoginBtn.Click += new System.EventHandler(this.MattLoginBtn_Click);
            // 
            // MainSwipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.MattLoginBtn);
            this.Controls.Add(this.TestLoginBtn);
            this.Controls.Add(this.ChrisLoginBtn);
            this.Controls.Add(this.DoneLbl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "MainSwipe";
            this.Text = "MainSwipeScreen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.Button ToUserScreenBtn;
        private System.Windows.Forms.Button ToAdminScreenBtn;
        private System.Windows.Forms.Label DoneLbl;
        private System.Windows.Forms.Button ChrisLoginBtn;
        private System.Windows.Forms.Button TestLoginBtn;
        private System.Windows.Forms.Button MattLoginBtn;
    }
}