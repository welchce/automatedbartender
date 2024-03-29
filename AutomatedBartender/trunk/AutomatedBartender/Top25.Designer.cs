﻿namespace AutomatedBartender
{
    partial class Top25
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Top25SubmitBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Top25BackBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Top25DataGrid = new System.Windows.Forms.DataGridView();
            this.bartenderDataSet = new AutomatedBartender.BartenderDataSet();
            this.spTop25BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spTop25TableAdapter = new AutomatedBartender.BartenderDataSetTableAdapters.spTop25TableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top25DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTop25BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Top 25";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Top25SubmitBtn
            // 
            this.Top25SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Top25SubmitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top25SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Top25SubmitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Top25SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.Top25SubmitBtn.Location = new System.Drawing.Point(155, 3);
            this.Top25SubmitBtn.Name = "Top25SubmitBtn";
            this.Top25SubmitBtn.Size = new System.Drawing.Size(70, 29);
            this.Top25SubmitBtn.TabIndex = 0;
            this.Top25SubmitBtn.Text = "Submit";
            this.Top25SubmitBtn.UseVisualStyleBackColor = false;
            this.Top25SubmitBtn.Click += new System.EventHandler(this.Top25SubmitBtn_Click);
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
            this.tableLayoutPanel2.Controls.Add(this.Top25SubmitBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Top25BackBtn, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 229);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 35);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // Top25BackBtn
            // 
            this.Top25BackBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Top25BackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top25BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Top25BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Top25BackBtn.ForeColor = System.Drawing.Color.White;
            this.Top25BackBtn.Location = new System.Drawing.Point(231, 3);
            this.Top25BackBtn.Name = "Top25BackBtn";
            this.Top25BackBtn.Size = new System.Drawing.Size(73, 29);
            this.Top25BackBtn.TabIndex = 1;
            this.Top25BackBtn.Text = "Back";
            this.Top25BackBtn.UseVisualStyleBackColor = false;
            this.Top25BackBtn.Click += new System.EventHandler(this.Top25BackBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Top25DataGrid, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 267);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Top25DataGrid
            // 
            this.Top25DataGrid.AllowUserToAddRows = false;
            this.Top25DataGrid.AllowUserToDeleteRows = false;
            this.Top25DataGrid.AllowUserToResizeColumns = false;
            this.Top25DataGrid.AllowUserToResizeRows = false;
            this.Top25DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Top25DataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.Top25DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Top25DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Top25DataGrid.Location = new System.Drawing.Point(3, 43);
            this.Top25DataGrid.Name = "Top25DataGrid";
            this.Top25DataGrid.RowHeadersVisible = false;
            this.Top25DataGrid.Size = new System.Drawing.Size(307, 180);
            this.Top25DataGrid.TabIndex = 0;
            // 
            // bartenderDataSet
            // 
            this.bartenderDataSet.DataSetName = "BartenderDataSet";
            this.bartenderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spTop25BindingSource
            // 
            this.spTop25BindingSource.DataMember = "spTop25";
            this.spTop25BindingSource.DataSource = this.bartenderDataSet;
            // 
            // spTop25TableAdapter
            // 
            this.spTop25TableAdapter.ClearBeforeFill = true;
            // 
            // Top25
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(337, 291);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Top25";
            this.Text = "Top 25";
            this.Load += new System.EventHandler(this.Top25_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Top25DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spTop25BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Top25SubmitBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Top25BackBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView Top25DataGrid;
        private BartenderDataSet bartenderDataSet;
        private System.Windows.Forms.BindingSource spTop25BindingSource;
        private BartenderDataSetTableAdapters.spTop25TableAdapter spTop25TableAdapter;
    }
}