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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmAdminTable frmAdmin = new FrmAdminTable();

            Hide();

            frmAdmin.ShowDialog(); // top most

            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc muốn thoát",
                "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
