using PhuTungXeMay.Form;
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
    public partial class uc_QLPhuTung : UserControl
    {
        public uc_QLPhuTung()
        {
            InitializeComponent();
        }

        public void uc_QLPhuTung_Load(object sender, EventArgs e)
        {
            gcDanhSach.DataSource = myClass.getData("Select * from PHUTUNG");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // khi ấn vào thêm, thì mở frmThemPhuTung lên
            frmThemPhuTung frm = new frmThemPhuTung();
            frm.ShowDialog();

            
        }
    }
}
