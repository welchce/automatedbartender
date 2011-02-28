namespace AutomatedBartender
{
    partial class AddDrink
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
            this.label2 = new System.Windows.Forms.Label();
            this.AddDrinkTextBox = new System.Windows.Forms.TextBox();
            this.AddDrinkIngredientTable = new System.Windows.Forms.DataGridView();
            this.Ingredient = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AddDrinkAddRowBtn = new System.Windows.Forms.Button();
            this.AddDrinkBackBtn = new System.Windows.Forms.Button();
            this.AddDrinkSubmitBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddDrinkIngredientTable)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddDrinkTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddDrinkIngredientTable, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddDrinkAddRowBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.AddDrinkBackBtn, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.AddDrinkSubmitBtn, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Drink";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name of Drink:";
            // 
            // AddDrinkTextBox
            // 
            this.AddDrinkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.AddDrinkTextBox, 3);
            this.AddDrinkTextBox.Location = new System.Drawing.Point(3, 130);
            this.AddDrinkTextBox.Multiline = true;
            this.AddDrinkTextBox.Name = "AddDrinkTextBox";
            this.AddDrinkTextBox.Size = new System.Drawing.Size(397, 45);
            this.AddDrinkTextBox.TabIndex = 2;
            // 
            // AddDrinkIngredientTable
            // 
            this.AddDrinkIngredientTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDrinkIngredientTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddDrinkIngredientTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredient,
            this.Amount});
            this.tableLayoutPanel1.SetColumnSpan(this.AddDrinkIngredientTable, 3);
            this.AddDrinkIngredientTable.Location = new System.Drawing.Point(3, 181);
            this.AddDrinkIngredientTable.Name = "AddDrinkIngredientTable";
            this.AddDrinkIngredientTable.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.AddDrinkIngredientTable, 2);
            this.AddDrinkIngredientTable.Size = new System.Drawing.Size(397, 78);
            this.AddDrinkIngredientTable.TabIndex = 3;
            // 
            // Ingredient
            // 
            this.Ingredient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ingredient.FillWeight = 175F;
            this.Ingredient.HeaderText = "Ingredient";
            this.Ingredient.Name = "Ingredient";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.FillWeight = 175F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // AddDrinkAddRowBtn
            // 
            this.AddDrinkAddRowBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddDrinkAddRowBtn.Location = new System.Drawing.Point(271, 265);
            this.AddDrinkAddRowBtn.Name = "AddDrinkAddRowBtn";
            this.AddDrinkAddRowBtn.Size = new System.Drawing.Size(129, 23);
            this.AddDrinkAddRowBtn.TabIndex = 4;
            this.AddDrinkAddRowBtn.Text = "Add Row";
            this.AddDrinkAddRowBtn.UseVisualStyleBackColor = true;
            this.AddDrinkAddRowBtn.Click += new System.EventHandler(this.AddDrinkAddRowBtn_Click);
            // 
            // AddDrinkBackBtn
            // 
            this.AddDrinkBackBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDrinkBackBtn.Location = new System.Drawing.Point(271, 307);
            this.AddDrinkBackBtn.Name = "AddDrinkBackBtn";
            this.AddDrinkBackBtn.Size = new System.Drawing.Size(129, 32);
            this.AddDrinkBackBtn.TabIndex = 5;
            this.AddDrinkBackBtn.Text = "Back";
            this.AddDrinkBackBtn.UseVisualStyleBackColor = true;
            this.AddDrinkBackBtn.Click += new System.EventHandler(this.AddDrinkBackBtn_Click);
            // 
            // AddDrinkSubmitBtn
            // 
            this.AddDrinkSubmitBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDrinkSubmitBtn.Location = new System.Drawing.Point(137, 307);
            this.AddDrinkSubmitBtn.Name = "AddDrinkSubmitBtn";
            this.AddDrinkSubmitBtn.Size = new System.Drawing.Size(128, 32);
            this.AddDrinkSubmitBtn.TabIndex = 6;
            this.AddDrinkSubmitBtn.Text = "Submit";
            this.AddDrinkSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // AddDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddDrink";
            this.Text = "AddDrink";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddDrinkIngredientTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddDrinkTextBox;
        private System.Windows.Forms.DataGridView AddDrinkIngredientTable;
        private System.Windows.Forms.Button AddDrinkAddRowBtn;
        private System.Windows.Forms.Button AddDrinkBackBtn;
        private System.Windows.Forms.Button AddDrinkSubmitBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ingredient;
        private System.Windows.Forms.DataGridViewComboBoxColumn Amount;

    }
}