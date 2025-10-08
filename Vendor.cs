using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class Vendor : Form
    {
        public Vendor()
        {
            InitializeComponent();
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.Blue;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = SystemColors.ControlLight;
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            NewProduct form = new NewProduct();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void btnVendorInfo_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            VendorInfo form = new VendorInfo();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Dashboard form = new Dashboard();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }

        private void Vendor_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            Dashboard form = new Dashboard();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(form);
            form.Show();
        }
    }
}
