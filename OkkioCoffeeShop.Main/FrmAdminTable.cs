using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkkioCoffeeShop.Main
{
    public partial class FrmAdminTable : Form
    {
        public FrmAdminTable()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewPersonalInfo_Click(object sender, EventArgs e)
        {
            FrmAccountProfile frmAccountProfile = new FrmAccountProfile();
            frmAccountProfile.ShowDialog();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc muốn đăng xuất",
                "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
