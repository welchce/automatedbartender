namespace AutomatedBartender
{
	partial class AllDrinks
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AllDrinksDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AllDrinksSubmitBtn = new System.Windows.Forms.Button();
            this.AllDrinksBackBtn = new System.Windows.Forms.Button();
            this.bartenderDataSet = new AutomatedBartender.BartenderDataSet();
            this.spAllDrinksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spAllDrinksTableAdapter = new AutomatedBartender.BartenderDataSetTableAdapters.spAllDrinksTableAdapter();
            this.spAllDrinksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDrinksDataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bartenderDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAllDrinksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAllDrinksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.AllDrinksDataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(276, 242);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // AllDrinksDataGrid
            // 
            this.AllDrinksDataGrid.AllowDrop = true;
            this.AllDrinksDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AllDrinksDataGrid.AutoGenerateColumns = false;
            this.AllDrinksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllDrinksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.AllDrinksDataGrid.DataSource = this.spAllDrinksBindingSource;
            this.AllDrinksDataGrid.Location = new System.Drawing.Point(3, 39);
            this.AllDrinksDataGrid.Name = "AllDrinksDataGrid";
            this.AllDrinksDataGrid.Size = new System.Drawing.Size(270, 163);
            this.AllDrinksDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "All Drinks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.Controls.Add(this.AllDrinksSubmitBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.AllDrinksBackBtn, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 208);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(270, 31);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // AllDrinksSubmitBtn
            // 
            this.AllDrinksSubmitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDrinksSubmitBtn.Location = new System.Drawing.Point(137, 3);
            this.AllDrinksSubmitBtn.Name = "AllDrinksSubmitBtn";
            this.AllDrinksSubmitBtn.Size = new System.Drawing.Size(61, 25);
            this.AllDrinksSubmitBtn.TabIndex = 0;
            this.AllDrinksSubmitBtn.Text = "Submit";
            this.AllDrinksSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // AllDrinksBackBtn
            // 
            this.AllDrinksBackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDrinksBackBtn.Location = new System.Drawing.Point(204, 3);
            this.AllDrinksBackBtn.Name = "AllDrinksBackBtn";
            this.AllDrinksBackBtn.Size = new System.Drawing.Size(63, 25);
            this.AllDrinksBackBtn.TabIndex = 1;
            this.AllDrinksBackBtn.Text = "Back";
            this.AllDrinksBackBtn.UseVisualStyleBackColor = true;
            this.AllDrinksBackBtn.Click += new System.EventHandler(this.AllDrinksBackBtn_Click);
            // 
            // bartenderDataSet
            // 
            this.bartenderDataSet.DataSetName = "BartenderDataSet";
            this.bartenderDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spAllDrinksBindingSource
            // 
            this.spAllDrinksBindingSource.DataMember = "spAllDrinks";
            this.spAllDrinksBindingSource.DataSource = this.bartenderDataSet;
            // 
            // spAllDrinksTableAdapter
            // 
            this.spAllDrinksTableAdapter.ClearBeforeFill = true;
            // 
            // spAllDrinksBindingSource1
            // 
            this.spAllDrinksBindingSource1.DataMember = "spAllDrinks";
            this.spAllDrinksBindingSource1.DataSource = this.bartenderDataSet;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // AllDrinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 266);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AllDrinks";
            this.Text = "AllDrinks";
            this.Load += new System.EventHandler(this.AllDrinks_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllDrinksDataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bartenderDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAllDrinksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spAllDrinksBindingSource1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView AllDrinksDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AllDrinksSubmitBtn;
        private System.Windows.Forms.Button AllDrinksBackBtn;
        private BartenderDataSet bartenderDataSet;
        private System.Windows.Forms.BindingSource spAllDrinksBindingSource;
        private BartenderDataSetTableAdapters.spAllDrinksTableAdapter spAllDrinksTableAdapter;
        private System.Windows.Forms.BindingSource spAllDrinksBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
	}
}