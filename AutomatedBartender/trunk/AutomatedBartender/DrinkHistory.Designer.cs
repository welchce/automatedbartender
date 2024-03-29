﻿namespace AutomatedBartender
{
    partial class DrinkHistory
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
            this.label1 = new System.Windows.Forms.Label();
            this.DrinkHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DrinkHistoryBackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrinkHistoryDataGrid)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drink History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrinkHistoryDataGrid
            // 
            this.DrinkHistoryDataGrid.AllowUserToAddRows = false;
            this.DrinkHistoryDataGrid.AllowUserToDeleteRows = false;
            this.DrinkHistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DrinkHistoryDataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.DrinkHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrinkHistoryDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrinkHistoryDataGrid.Location = new System.Drawing.Point(3, 43);
            this.DrinkHistoryDataGrid.Name = "DrinkHistoryDataGrid";
            this.DrinkHistoryDataGrid.RowHeadersVisible = false;
            this.DrinkHistoryDataGrid.Size = new System.Drawing.Size(307, 180);
            this.DrinkHistoryDataGrid.TabIndex = 0;
            this.DrinkHistoryDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrinkHistoryDataGrid_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.DrinkHistoryDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 267);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.DrinkHistoryBackBtn, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 229);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 35);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // DrinkHistoryBackBtn
            // 
            this.DrinkHistoryBackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DrinkHistoryBackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrinkHistoryBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DrinkHistoryBackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.DrinkHistoryBackBtn.ForeColor = System.Drawing.Color.White;
            this.DrinkHistoryBackBtn.Location = new System.Drawing.Point(231, 3);
            this.DrinkHistoryBackBtn.Name = "DrinkHistoryBackBtn";
            this.DrinkHistoryBackBtn.Size = new System.Drawing.Size(73, 29);
            this.DrinkHistoryBackBtn.TabIndex = 1;
            this.DrinkHistoryBackBtn.Text = "Back";
            this.DrinkHistoryBackBtn.UseVisualStyleBackColor = false;
            this.DrinkHistoryBackBtn.Click += new System.EventHandler(this.DrinkHistoryBackBtn_Click);
            // 
            // DrinkHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(337, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DrinkHistory";
            this.Text = "Drink History";
            this.Load += new System.EventHandler(this.DrinkHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DrinkHistoryDataGrid)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DrinkHistoryDataGrid;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DrinkHistoryBackBtn;
    }
}