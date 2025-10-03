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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            AdminPageUsers adminPageUsers = new AdminPageUsers();
            adminPageUsers.TopLevel = false;
            adminPageUsers.FormBorderStyle = FormBorderStyle.None;
            adminPageUsers.AutoScroll = true;
            adminPageUsers.Dock = DockStyle.Fill;
            this.pnlMain.Controls.Add(adminPageUsers);
            adminPageUsers.Show();
        }
    }
}
