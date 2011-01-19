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
            this.label1 = new System.Windows.Forms.Label();
            this.ToUserScreenBtn = new System.Windows.Forms.Button();
            this.ToAdminScreenBtn = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ToUserScreenBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ToAdminScreenBtn, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 225);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Begin\r\nPlease Swipe\r\nI.D.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ToUserScreenBtn
            // 
            this.ToUserScreenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToUserScreenBtn.Location = new System.Drawing.Point(3, 228);
            this.ToUserScreenBtn.Name = "ToUserScreenBtn";
            this.ToUserScreenBtn.Size = new System.Drawing.Size(123, 6);
            this.ToUserScreenBtn.TabIndex = 1;
            this.ToUserScreenBtn.Text = "User Main Screen";
            this.ToUserScreenBtn.UseVisualStyleBackColor = true;
            this.ToUserScreenBtn.Click += new System.EventHandler(this.ToUserScreenBtn_Click);
            // 
            // ToAdminScreenBtn
            // 
            this.ToAdminScreenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToAdminScreenBtn.Location = new System.Drawing.Point(132, 228);
            this.ToAdminScreenBtn.Name = "ToAdminScreenBtn";
            this.ToAdminScreenBtn.Size = new System.Drawing.Size(124, 6);
            this.ToAdminScreenBtn.TabIndex = 2;
            this.ToAdminScreenBtn.Text = "Admin Main Screen";
            this.ToAdminScreenBtn.UseVisualStyleBackColor = true;
            this.ToAdminScreenBtn.Click += new System.EventHandler(this.ToAdminScreenBtn_Click);
            // 
            // MainSwipeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainSwipeScreen";
            this.Text = "MainSwipeScreen";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ToUserScreenBtn;
        private System.Windows.Forms.Button ToAdminScreenBtn;
    }
}