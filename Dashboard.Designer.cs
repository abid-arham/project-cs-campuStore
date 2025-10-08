namespace CampuStore
{
    partial class Dashboard
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkBooks = new System.Windows.Forms.CheckBox();
            this.chkElectronics = new System.Windows.Forms.CheckBox();
            this.chkStationary = new System.Windows.Forms.CheckBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 395);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.lblPrice);
            this.panel4.Controls.Add(this.txtPrice);
            this.panel4.Controls.Add(this.txtBrand);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtProductName);
            this.panel4.Controls.Add(this.lblQuantity);
            this.panel4.Controls.Add(this.lblcategory);
            this.panel4.Controls.Add(this.lblBrand);
            this.panel4.Controls.Add(this.lblProductName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(472, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 342);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(472, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 41);
            this.panel2.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(113, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 38);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 41);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(104, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 37);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 38);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(463, 342);
            this.panel3.TabIndex = 2;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(13, 233);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 17);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(13, 303);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(62, 17);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategory.Location = new System.Drawing.Point(13, 131);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(64, 17);
            this.lblcategory.TabIndex = 8;
            this.lblcategory.Text = "Category";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(11, 76);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(44, 17);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Brand";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 10);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(96, 17);
            this.lblProductName.TabIndex = 6;
            this.lblProductName.Text = "Product Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(81, 295);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(143, 33);
            this.txtQuantity.TabIndex = 18;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(9, 253);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 23);
            this.txtPrice.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.chkBooks);
            this.panel5.Controls.Add(this.chkElectronics);
            this.panel5.Controls.Add(this.chkStationary);
            this.panel5.Location = new System.Drawing.Point(11, 162);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 68);
            this.panel5.TabIndex = 15;
            // 
            // chkBooks
            // 
            this.chkBooks.AutoSize = true;
            this.chkBooks.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBooks.Location = new System.Drawing.Point(3, 3);
            this.chkBooks.Name = "chkBooks";
            this.chkBooks.Size = new System.Drawing.Size(67, 21);
            this.chkBooks.TabIndex = 5;
            this.chkBooks.Text = "Books";
            this.chkBooks.UseVisualStyleBackColor = true;
            // 
            // chkElectronics
            // 
            this.chkElectronics.AutoSize = true;
            this.chkElectronics.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkElectronics.Location = new System.Drawing.Point(3, 33);
            this.chkElectronics.Name = "chkElectronics";
            this.chkElectronics.Size = new System.Drawing.Size(96, 21);
            this.chkElectronics.TabIndex = 7;
            this.chkElectronics.Text = "Electronics";
            this.chkElectronics.UseVisualStyleBackColor = true;
            // 
            // chkStationary
            // 
            this.chkStationary.AutoSize = true;
            this.chkStationary.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStationary.Location = new System.Drawing.Point(102, 3);
            this.chkStationary.Name = "chkStationary";
            this.chkStationary.Size = new System.Drawing.Size(94, 21);
            this.chkStationary.TabIndex = 6;
            this.chkStationary.Text = "Stationary";
            this.chkStationary.UseVisualStyleBackColor = true;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(9, 101);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(215, 22);
            this.txtBrand.TabIndex = 14;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(9, 35);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(215, 33);
            this.txtProductName.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 37);
            this.textBox1.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(463, 342);
            this.dgv.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkBooks;
        private System.Windows.Forms.CheckBox chkElectronics;
        private System.Windows.Forms.CheckBox chkStationary;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv;
    }
}