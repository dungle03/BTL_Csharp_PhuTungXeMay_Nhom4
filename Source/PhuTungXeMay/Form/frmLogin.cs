using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuTungXeMay
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // sau khi nhập đúng tài khoản và mật khẩu thì mở form Dashboard
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                this.Hide();
                Form.frmFluentDesignForm_Dashboard f = new Form.frmFluentDesignForm_Dashboard();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}