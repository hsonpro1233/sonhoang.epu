
namespace App1.Print
{
    partial class Sanpham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sanpham));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhapKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguonGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_sua = new Guna.UI2.WinForms.Guna2GradientButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 21);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1128, 508);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeight = 77;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.SoLuong,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.TenChatLieu,
            this.NgayNhapKho,
            this.NguonGoc,
            this.DaBan,
            this.ChiPhi,
            this.AnhHH,
            this.MaHang});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1128, 508);
            this.guna2DataGridView1.TabIndex = 1;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 77;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên sản phẩm";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá nhập (VND)";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá bán (VND)";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.ReadOnly = true;
            // 
            // TenChatLieu
            // 
            this.TenChatLieu.DataPropertyName = "TenChatLieu";
            this.TenChatLieu.HeaderText = "Chất Liệu";
            this.TenChatLieu.MinimumWidth = 6;
            this.TenChatLieu.Name = "TenChatLieu";
            this.TenChatLieu.ReadOnly = true;
            // 
            // NgayNhapKho
            // 
            this.NgayNhapKho.DataPropertyName = "NgayNhapKho";
            this.NgayNhapKho.HeaderText = "Ngày Nhập Kho";
            this.NgayNhapKho.MinimumWidth = 6;
            this.NgayNhapKho.Name = "NgayNhapKho";
            this.NgayNhapKho.ReadOnly = true;
            // 
            // NguonGoc
            // 
            this.NguonGoc.DataPropertyName = "NguonGoc";
            this.NguonGoc.HeaderText = "Nguồn gốc";
            this.NguonGoc.MinimumWidth = 6;
            this.NguonGoc.Name = "NguonGoc";
            this.NguonGoc.ReadOnly = true;
            // 
            // DaBan
            // 
            this.DaBan.DataPropertyName = "DaBan";
            this.DaBan.HeaderText = "Số lượng đã bán";
            this.DaBan.MinimumWidth = 6;
            this.DaBan.Name = "DaBan";
            this.DaBan.ReadOnly = true;
            // 
            // ChiPhi
            // 
            this.ChiPhi.DataPropertyName = "ChiPhi";
            this.ChiPhi.HeaderText = "Chi phí";
            this.ChiPhi.MinimumWidth = 6;
            this.ChiPhi.Name = "ChiPhi";
            this.ChiPhi.ReadOnly = true;
            // 
            // AnhHH
            // 
            this.AnhHH.DataPropertyName = "AnhHH";
            this.AnhHH.HeaderText = "AnhHH";
            this.AnhHH.MinimumWidth = 6;
            this.AnhHH.Name = "AnhHH";
            this.AnhHH.ReadOnly = true;
            this.AnhHH.Visible = false;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "MaHang";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Visible = false;
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_sua.Animated = true;
            this.btn_sua.BackColor = System.Drawing.Color.Transparent;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.CheckedState.Parent = this.btn_sua;
            this.btn_sua.CustomImages.Parent = this.btn_sua;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_sua.HoverState.Parent = this.btn_sua;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_sua.Location = new System.Drawing.Point(382, 554);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.ShadowDecoration.Parent = this.btn_sua;
            this.btn_sua.Size = new System.Drawing.Size(483, 55);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "In";
            this.btn_sua.UseTransparentBackground = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 621);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sanpham";
            this.Load += new System.EventHandler(this.Sanpham_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguonGoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private Guna.UI2.WinForms.Guna2GradientButton btn_sua;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}