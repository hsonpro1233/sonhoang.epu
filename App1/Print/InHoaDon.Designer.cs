
namespace App1.Print
{
    partial class InHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaNhap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaxuat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHDXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunadetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaHdXuat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaNhap)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaxuat)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunadetail)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.gunaNhap);
            resources.ApplyResources(this.guna2Panel1, "guna2Panel1");
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            // 
            // gunaNhap
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaNhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaNhap.BackgroundColor = System.Drawing.Color.White;
            this.gunaNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaNhap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.gunaNhap, "gunaNhap");
            this.gunaNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDNhap,
            this.MaHang,
            this.TenHang,
            this.MaNv,
            this.NgayNhap,
            this.SoLuong,
            this.DonGiaNhap,
            this.ThanhTien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaNhap.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaNhap.EnableHeadersVisualStyles = false;
            this.gunaNhap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaNhap.Name = "gunaNhap";
            this.gunaNhap.ReadOnly = true;
            this.gunaNhap.RowHeadersVisible = false;
            this.gunaNhap.RowTemplate.Height = 24;
            this.gunaNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaNhap.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gunaNhap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaNhap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaNhap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaNhap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaNhap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaNhap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaNhap.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaNhap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaNhap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaNhap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaNhap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaNhap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaNhap.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaNhap.ThemeStyle.ReadOnly = true;
            this.gunaNhap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaNhap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaNhap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaNhap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaNhap.ThemeStyle.RowsStyle.Height = 24;
            this.gunaNhap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaNhap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHDNhap
            // 
            this.MaHDNhap.DataPropertyName = "MaHDNhap";
            resources.ApplyResources(this.MaHDNhap, "MaHDNhap");
            this.MaHDNhap.Name = "MaHDNhap";
            this.MaHDNhap.ReadOnly = true;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            resources.ApplyResources(this.MaHang, "MaHang");
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            resources.ApplyResources(this.TenHang, "TenHang");
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // MaNv
            // 
            this.MaNv.DataPropertyName = "MaNv";
            resources.ApplyResources(this.MaNv, "MaNv");
            this.MaNv.Name = "MaNv";
            this.MaNv.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            resources.ApplyResources(this.NgayNhap, "NgayNhap");
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            resources.ApplyResources(this.SoLuong, "SoLuong");
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            resources.ApplyResources(this.DonGiaNhap, "DonGiaNhap");
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            resources.ApplyResources(this.ThanhTien, "ThanhTien");
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.gunaxuat);
            resources.ApplyResources(this.guna2Panel2, "guna2Panel2");
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // gunaxuat
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaxuat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaxuat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gunaxuat.BackgroundColor = System.Drawing.Color.White;
            this.gunaxuat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaxuat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaxuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaxuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            resources.ApplyResources(this.gunaxuat, "gunaxuat");
            this.gunaxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDXuat,
            this.dataGridViewTextBoxColumn1,
            this.MaKh,
            this.NgayBan,
            this.TongTien});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaxuat.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaxuat.EnableHeadersVisualStyles = false;
            this.gunaxuat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaxuat.Name = "gunaxuat";
            this.gunaxuat.ReadOnly = true;
            this.gunaxuat.RowHeadersVisible = false;
            this.gunaxuat.RowTemplate.Height = 24;
            this.gunaxuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaxuat.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gunaxuat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaxuat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaxuat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaxuat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaxuat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaxuat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaxuat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaxuat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaxuat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaxuat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaxuat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaxuat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaxuat.ThemeStyle.HeaderStyle.Height = 77;
            this.gunaxuat.ThemeStyle.ReadOnly = true;
            this.gunaxuat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaxuat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaxuat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaxuat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaxuat.ThemeStyle.RowsStyle.Height = 24;
            this.gunaxuat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaxuat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHDXuat
            // 
            this.MaHDXuat.DataPropertyName = "MaHDXuat";
            resources.ApplyResources(this.MaHDXuat, "MaHDXuat");
            this.MaHDXuat.Name = "MaHDXuat";
            this.MaHDXuat.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNv";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // MaKh
            // 
            this.MaKh.DataPropertyName = "MaKh";
            resources.ApplyResources(this.MaKh, "MaKh");
            this.MaKh.Name = "MaKh";
            this.MaKh.ReadOnly = true;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            resources.ApplyResources(this.NgayBan, "NgayBan");
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            resources.ApplyResources(this.TongTien, "TongTien");
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.gunadetail);
            resources.ApplyResources(this.guna2Panel3, "guna2Panel3");
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            // 
            // gunadetail
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gunadetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gunadetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunadetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gunadetail.BackgroundColor = System.Drawing.Color.White;
            this.gunadetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunadetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunadetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunadetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            resources.ApplyResources(this.gunadetail, "gunadetail");
            this.gunadetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHdXuat2,
            this.dataGridViewTextBoxColumn2,
            this.SoLuongBan,
            this.Sale,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunadetail.DefaultCellStyle = dataGridViewCellStyle9;
            this.gunadetail.EnableHeadersVisualStyles = false;
            this.gunadetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadetail.Name = "gunadetail";
            this.gunadetail.RowHeadersVisible = false;
            this.gunadetail.RowTemplate.Height = 24;
            this.gunadetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunadetail.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gunadetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunadetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunadetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunadetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunadetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunadetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunadetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunadetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunadetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunadetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunadetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunadetail.ThemeStyle.HeaderStyle.Height = 77;
            this.gunadetail.ThemeStyle.ReadOnly = false;
            this.gunadetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunadetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunadetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunadetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunadetail.ThemeStyle.RowsStyle.Height = 24;
            this.gunadetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunadetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaHdXuat2
            // 
            this.MaHdXuat2.DataPropertyName = "MaHdXuat";
            resources.ApplyResources(this.MaHdXuat2, "MaHdXuat2");
            this.MaHdXuat2.Name = "MaHdXuat2";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaHang";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.DataPropertyName = "SoLuongBan";
            resources.ApplyResources(this.SoLuongBan, "SoLuongBan");
            this.SoLuongBan.Name = "SoLuongBan";
            // 
            // Sale
            // 
            this.Sale.DataPropertyName = "Sale";
            resources.ApplyResources(this.Sale, "Sale");
            this.Sale.Name = "Sale";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ThanhTien";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btn_sua
            // 
            resources.ApplyResources(this.btn_sua, "btn_sua");
            this.btn_sua.Animated = true;
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.UseTransparentBackground = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(this.printPreviewDialog1, "printPreviewDialog1");
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.btn_sua);
            resources.ApplyResources(this.guna2GradientPanel1, "guna2GradientPanel1");
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            // 
            // InHoaDon
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaNhap)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaxuat)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunadetail)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView gunaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private Guna.UI2.WinForms.Guna2DataGridView gunaxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private Guna.UI2.WinForms.Guna2DataGridView gunadetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHdXuat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}