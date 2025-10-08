using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CampuStore.Result;

namespace CampuStore
{
    public partial class AdminDashboard : Form
    {
        private void loadUserInfo()
        {
            string query = "select * from Users";
            try
            {
                
                var result = DbHelper.GetQueryData(query);
                if (result.HasError == true)
                {
                    MessageBox.Show(result.Message);
                    return;

                }


                dgvUser.AutoGenerateColumns = true;
                dgvUser.DataSource = result.Data;
                dgvUser.Refresh();
                dgvUser.ClearSelection();

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.loadUserInfo();
        }
    }
}
