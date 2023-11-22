namespace PhuTungXeMay.Form
{
    partial class frmFluentDesignForm_Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluentDesignForm_Dashboard));
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLPhuTung = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnQLYeuCauSuaChua = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.mnBaoCao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(260, 31);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(835, 519);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(260, 519);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mnQLPhuTung,
            this.mnQLNhanVien,
            this.mnQLKhachHang,
            this.mnQLYeuCauSuaChua,
            this.mnBaoCao});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "DANH MỤC";
            // 
            // mnQLPhuTung
            // 
            this.mnQLPhuTung.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnQLPhuTung.Appearance.Normal.Options.UseFont = true;
            this.mnQLPhuTung.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.mnQLPhuTung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLPhuTung.ImageOptions.Image")));
            this.mnQLPhuTung.Name = "mnQLPhuTung";
            this.mnQLPhuTung.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLPhuTung.Text = "Quản Lý Phụ Tùng";
            this.mnQLPhuTung.Click += new System.EventHandler(this.mnQLPhuTung_Click);
            // 
            // mnQLNhanVien
            // 
            this.mnQLNhanVien.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnQLNhanVien.Appearance.Normal.Options.UseFont = true;
            this.mnQLNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLNhanVien.ImageOptions.Image")));
            this.mnQLNhanVien.Name = "mnQLNhanVien";
            this.mnQLNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLNhanVien.Text = "Quản Lý Nhân Viên";
            this.mnQLNhanVien.Click += new System.EventHandler(this.mnQLNhanVien_Click);
            // 
            // mnQLKhachHang
            // 
            this.mnQLKhachHang.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnQLKhachHang.Appearance.Normal.Options.UseFont = true;
            this.mnQLKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLKhachHang.ImageOptions.Image")));
            this.mnQLKhachHang.Name = "mnQLKhachHang";
            this.mnQLKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLKhachHang.Text = "Quản Lý Khách Hàng";
            this.mnQLKhachHang.Click += new System.EventHandler(this.mnQLKhachHang_Click);
            // 
            // mnQLYeuCauSuaChua
            // 
            this.mnQLYeuCauSuaChua.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnQLYeuCauSuaChua.Appearance.Normal.Options.UseFont = true;
            this.mnQLYeuCauSuaChua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnQLYeuCauSuaChua.ImageOptions.Image")));
            this.mnQLYeuCauSuaChua.Name = "mnQLYeuCauSuaChua";
            this.mnQLYeuCauSuaChua.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnQLYeuCauSuaChua.Text = "Quản Lý Yêu Cầu Sửa Chữa";
            this.mnQLYeuCauSuaChua.Click += new System.EventHandler(this.mnQLYeuCauSuaChua_Click);
            // 
            // mnBaoCao
            // 
            this.mnBaoCao.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnBaoCao.Appearance.Normal.Options.UseFont = true;
            this.mnBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mnBaoCao.ImageOptions.Image")));
            this.mnBaoCao.Name = "mnBaoCao";
            this.mnBaoCao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.mnBaoCao.Text = "Báo Cáo";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1095, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblTieuDe});
            this.fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Caption = "Bài tập lớn";
            this.lblTieuDe.Id = 0;
            this.lblTieuDe.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.lblTieuDe.ItemAppearance.Normal.Options.UseFont = true;
            this.lblTieuDe.ItemAppearance.Normal.Options.UseForeColor = true;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // frmFluentDesignForm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 550);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmFluentDesignForm_Dashboard";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Sữa Chữa Xe Máy";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLPhuTung;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnQLYeuCauSuaChua;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mnBaoCao;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
    }
}