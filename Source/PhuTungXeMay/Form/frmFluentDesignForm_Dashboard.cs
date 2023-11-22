using DevExpress.XtraBars;
using PhuTungXeMay.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PhuTungXeMay.Form
{
    public partial class frmFluentDesignForm_Dashboard : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        //ProcessDatabase pd = new ProcessDatabase();
        public frmFluentDesignForm_Dashboard()
        {
            InitializeComponent();
        }

        uc_QLPhuTung ucPhuTung;
        uc_QLNhanVien ucNhanVien;
        uc_QLKhachHang ucKhachHang;
        uc_QLYeuCauSuaChua ucYeuCauSuaChua;
        uc_BaoCao uc_BaoCao;

        private void mnQLPhuTung_Click(object sender, EventArgs e)
        {
            if (ucPhuTung == null)
            {
                ucPhuTung = new uc_QLPhuTung();
                ucPhuTung.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucPhuTung);
                ucPhuTung.BringToFront();
            }
            else
            {
                ucPhuTung.BringToFront();
            }
            lblTieuDe.Caption = mnQLPhuTung.Text;

        }

        private void mnQLNhanVien_Click(object sender, EventArgs e)
        {
            if (ucNhanVien == null)
            {

                ucNhanVien = new uc_QLNhanVien();
                ucNhanVien.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucNhanVien);
                ucNhanVien.BringToFront();
            }
            else
            {
                ucNhanVien.BringToFront();
            }
            lblTieuDe.Caption = mnQLNhanVien.Text;
        }

        private void mnQLKhachHang_Click(object sender, EventArgs e)
        {
            if(ucKhachHang == null)
            {
                ucKhachHang = new uc_QLKhachHang();
                ucKhachHang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucKhachHang);
                ucKhachHang.BringToFront();
            }
            else
            {
                ucKhachHang.BringToFront();
            }
            lblTieuDe.Caption = mnQLKhachHang.Text;

        }

        private void mnQLYeuCauSuaChua_Click(object sender, EventArgs e)
        {
            if(ucYeuCauSuaChua == null)
            {
                ucYeuCauSuaChua = new uc_QLYeuCauSuaChua();
                ucYeuCauSuaChua.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucYeuCauSuaChua);
                ucYeuCauSuaChua.BringToFront();
            }
            else
            {
                ucYeuCauSuaChua.BringToFront();
            }
            lblTieuDe.Caption = mnQLYeuCauSuaChua.Text;
        }
    }
}
