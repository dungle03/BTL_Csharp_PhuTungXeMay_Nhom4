using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhuTungXeMay.UI
{
    public partial class uc_QLKhachHang : UserControl
    {
        public uc_QLKhachHang()
        {
            InitializeComponent();
        }

        public void uc_QLKhachHang_Load(object sender, EventArgs e)
        {
            gcDanhSach.DataSource = myClass.getData("Select * from KHACHHANG");
        }
    }
}
