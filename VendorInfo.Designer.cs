namespace CampuStore
{
    partial class VendorInfo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.lblVendorID = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(195, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 38);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(56, 241);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 28);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(45, 236);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(412, 33);
            this.txtPassword.TabIndex = 9;
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Annex 1",
            "Annex 2",
            "Annex 3",
            "Annex 4",
            "Annex 5",
            "Annex 6",
            "Annex 7",
            "Annex 8",
            "Annex 9",
            "D-Building Ground",
            "D-Building 7th Floor"});
            this.cmbLocation.Location = new System.Drawing.Point(45, 303);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(412, 28);
            this.cmbLocation.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(45, 179);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(412, 33);
            this.txtEmail.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(64, 303);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(93, 28);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(93, 179);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 28);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblShopName
            // 
            this.lblShopName.AutoSize = true;
            this.lblShopName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShopName.Location = new System.Drawing.Point(36, 117);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(121, 28);
            this.lblShopName.TabIndex = 0;
            this.lblShopName.Text = "Shop Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtVendorID);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.cmbLocation);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtShopName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(189, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 389);
            this.panel2.TabIndex = 1;
            // 
            // txtShopName
            // 
            this.txtShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.Location = new System.Drawing.Point(45, 117);
            this.txtShopName.Multiline = true;
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(412, 33);
            this.txtShopName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVendorID);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblShopName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 389);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.61996F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.38004F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(699, 395);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtVendorID
            // 
            this.txtVendorID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendorID.Location = new System.Drawing.Point(45, 55);
            this.txtVendorID.Multiline = true;
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.ReadOnly = true;
            this.txtVendorID.Size = new System.Drawing.Size(412, 33);
            this.txtVendorID.TabIndex = 11;
            // 
            // lblVendorID
            // 
            this.lblVendorID.AutoSize = true;
            this.lblVendorID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorID.Location = new System.Drawing.Point(51, 55);
            this.lblVendorID.Name = "lblVendorID";
            this.lblVendorID.Size = new System.Drawing.Size(106, 28);
            this.lblVendorID.TabIndex = 6;
            this.lblVendorID.Text = "Vendor ID";
            // 
            // VendorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 395);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VendorInfo";
            this.Text = "VendorInfo";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtShopName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.Label lblVendorID;
    }
}