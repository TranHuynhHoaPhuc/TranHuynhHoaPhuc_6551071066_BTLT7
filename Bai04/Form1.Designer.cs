namespace Bai04
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnQuanLyBacSi = new System.Windows.Forms.Button();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaLichHienTai = new System.Windows.Forms.Label();
            this.lblMaLichLabel = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboBacSi = new System.Windows.Forms.ComboBox();
            this.lblBacSi = new System.Windows.Forms.Label();
            this.dtpGioKham = new System.Windows.Forms.DateTimePicker();
            this.lblGioKham = new System.Windows.Forms.Label();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtTenBenhNhan = new System.Windows.Forms.TextBox();
            this.lblTenBenhNhan = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboLocBacSi = new System.Windows.Forms.ComboBox();
            this.lblLocBacSi = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvLichKham = new System.Windows.Forms.DataGridView();
            this.colMaLich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenBacSi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTongSo = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.pnlHeader.Controls.Add(this.btnQuanLyBacSi);
            this.pnlHeader.Controls.Add(this.lblSubHeader);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1164, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnQuanLyBacSi
            // 
            this.btnQuanLyBacSi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuanLyBacSi.BackColor = System.Drawing.Color.White;
            this.btnQuanLyBacSi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyBacSi.FlatAppearance.BorderSize = 0;
            this.btnQuanLyBacSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyBacSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnQuanLyBacSi.Location = new System.Drawing.Point(970, 18);
            this.btnQuanLyBacSi.Name = "btnQuanLyBacSi";
            this.btnQuanLyBacSi.Size = new System.Drawing.Size(175, 40);
            this.btnQuanLyBacSi.TabIndex = 2;
            this.btnQuanLyBacSi.Text = "👨‍⚕️ Quản lý Bác sĩ";
            this.btnQuanLyBacSi.UseVisualStyleBackColor = false;
            this.btnQuanLyBacSi.Click += new System.EventHandler(this.btnQuanLyBacSi_Click);
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.lblSubHeader.Location = new System.Drawing.Point(20, 43);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(306, 19);
            this.lblSubHeader.TabIndex = 1;
            this.lblSubHeader.Text = "HỆ THỐNG QUẢN LÝ LỊCH HẸN VÀ KHÁM BỆNH";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(18, 10);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(462, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "PHÒNG KHÁM TƯ AN KHANG CLINIC";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.lblMaLichHienTai);
            this.grpThongTin.Controls.Add(this.lblMaLichLabel);
            this.grpThongTin.Controls.Add(this.btnLamMoi);
            this.grpThongTin.Controls.Add(this.btnXoa);
            this.grpThongTin.Controls.Add(this.btnSua);
            this.grpThongTin.Controls.Add(this.btnThem);
            this.grpThongTin.Controls.Add(this.cboTrangThai);
            this.grpThongTin.Controls.Add(this.lblTrangThai);
            this.grpThongTin.Controls.Add(this.cboBacSi);
            this.grpThongTin.Controls.Add(this.lblBacSi);
            this.grpThongTin.Controls.Add(this.dtpGioKham);
            this.grpThongTin.Controls.Add(this.lblGioKham);
            this.grpThongTin.Controls.Add(this.dtpNgayKham);
            this.grpThongTin.Controls.Add(this.lblNgayKham);
            this.grpThongTin.Controls.Add(this.txtSdt);
            this.grpThongTin.Controls.Add(this.lblSdt);
            this.grpThongTin.Controls.Add(this.txtTenBenhNhan);
            this.grpThongTin.Controls.Add(this.lblTenBenhNhan);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.grpThongTin.Location = new System.Drawing.Point(16, 85);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(730, 235);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin Đăng Ký Lịch Khám";
            // 
            // lblMaLichHienTai
            // 
            this.lblMaLichHienTai.AutoSize = true;
            this.lblMaLichHienTai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaLichHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblMaLichHienTai.Location = new System.Drawing.Point(620, 22);
            this.lblMaLichHienTai.Name = "lblMaLichHienTai";
            this.lblMaLichHienTai.Size = new System.Drawing.Size(84, 17);
            this.lblMaLichHienTai.TabIndex = 17;
            this.lblMaLichHienTai.Text = "(Thêm mới)";
            // 
            // lblMaLichLabel
            // 
            this.lblMaLichLabel.AutoSize = true;
            this.lblMaLichLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaLichLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblMaLichLabel.Location = new System.Drawing.Point(545, 23);
            this.lblMaLichLabel.Name = "lblMaLichLabel";
            this.lblMaLichLabel.Size = new System.Drawing.Size(71, 15);
            this.lblMaLichLabel.TabIndex = 16;
            this.lblMaLichLabel.Text = "Đang chọn:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(542, 178);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(125, 38);
            this.btnLamMoi.TabIndex = 15;
            this.btnLamMoi.Text = "🔄 Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(397, 178);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 38);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "🗑️ Xóa lịch";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(252, 178);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 38);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "✏️ Cập nhật";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(107, 178);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 38);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "➕ Đặt lịch";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(525, 131);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(185, 25);
            this.cboTrangThai.TabIndex = 11;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTrangThai.Location = new System.Drawing.Point(445, 135);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(73, 17);
            this.lblTrangThai.TabIndex = 10;
            this.lblTrangThai.Text = "Trạng thái: *";
            // 
            // cboBacSi
            // 
            this.cboBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboBacSi.FormattingEnabled = true;
            this.cboBacSi.Location = new System.Drawing.Point(125, 131);
            this.cboBacSi.Name = "cboBacSi";
            this.cboBacSi.Size = new System.Drawing.Size(295, 25);
            this.cboBacSi.TabIndex = 9;
            // 
            // lblBacSi
            // 
            this.lblBacSi.AutoSize = true;
            this.lblBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBacSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblBacSi.Location = new System.Drawing.Point(18, 135);
            this.lblBacSi.Name = "lblBacSi";
            this.lblBacSi.Size = new System.Drawing.Size(95, 17);
            this.lblBacSi.TabIndex = 8;
            this.lblBacSi.Text = "Chọn Bác sĩ: *";
            // 
            // dtpGioKham
            // 
            this.dtpGioKham.CustomFormat = "HH:mm";
            this.dtpGioKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpGioKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKham.Location = new System.Drawing.Point(525, 87);
            this.dtpGioKham.Name = "dtpGioKham";
            this.dtpGioKham.ShowUpDown = true;
            this.dtpGioKham.Size = new System.Drawing.Size(185, 24);
            this.dtpGioKham.TabIndex = 7;
            // 
            // lblGioKham
            // 
            this.lblGioKham.AutoSize = true;
            this.lblGioKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGioKham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblGioKham.Location = new System.Drawing.Point(445, 91);
            this.lblGioKham.Name = "lblGioKham";
            this.lblGioKham.Size = new System.Drawing.Size(73, 17);
            this.lblGioKham.TabIndex = 6;
            this.lblGioKham.Text = "Giờ khám: *";
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(125, 87);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(295, 24);
            this.dtpNgayKham.TabIndex = 5;
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgayKham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNgayKham.Location = new System.Drawing.Point(18, 91);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(84, 17);
            this.lblNgayKham.TabIndex = 4;
            this.lblNgayKham.Text = "Ngày khám: *";
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSdt.Location = new System.Drawing.Point(525, 45);
            this.txtSdt.MaxLength = 15;
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(185, 24);
            this.txtSdt.TabIndex = 3;
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblSdt.Location = new System.Drawing.Point(445, 49);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(35, 17);
            this.lblSdt.TabIndex = 2;
            this.lblSdt.Text = "SĐT:";
            // 
            // txtTenBenhNhan
            // 
            this.txtTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenBenhNhan.Location = new System.Drawing.Point(125, 45);
            this.txtTenBenhNhan.MaxLength = 100;
            this.txtTenBenhNhan.Name = "txtTenBenhNhan";
            this.txtTenBenhNhan.Size = new System.Drawing.Size(295, 24);
            this.txtTenBenhNhan.TabIndex = 1;
            // 
            // lblTenBenhNhan
            // 
            this.lblTenBenhNhan.AutoSize = true;
            this.lblTenBenhNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenBenhNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTenBenhNhan.Location = new System.Drawing.Point(18, 49);
            this.lblTenBenhNhan.Name = "lblTenBenhNhan";
            this.lblTenBenhNhan.Size = new System.Drawing.Size(107, 17);
            this.lblTenBenhNhan.TabIndex = 0;
            this.lblTenBenhNhan.Text = "Tên bệnh nhân: *";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.btnTatCa);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.cboLocBacSi);
            this.grpTimKiem.Controls.Add(this.lblLocBacSi);
            this.grpTimKiem.Controls.Add(this.dtpDenNgay);
            this.grpTimKiem.Controls.Add(this.lblDenNgay);
            this.grpTimKiem.Controls.Add(this.dtpTuNgay);
            this.grpTimKiem.Controls.Add(this.lblTuNgay);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.grpTimKiem.Location = new System.Drawing.Point(758, 85);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(390, 235);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Bộ Lọc & Tìm Kiếm";
            // 
            // btnTatCa
            // 
            this.btnTatCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCa.FlatAppearance.BorderSize = 0;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Location = new System.Drawing.Point(215, 178);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(155, 38);
            this.btnTatCa.TabIndex = 7;
            this.btnTatCa.Text = "📋 Hiện tất cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(20, 178);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(175, 38);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboLocBacSi
            // 
            this.cboLocBacSi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLocBacSi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLocBacSi.FormattingEnabled = true;
            this.cboLocBacSi.Location = new System.Drawing.Point(95, 131);
            this.cboLocBacSi.Name = "cboLocBacSi";
            this.cboLocBacSi.Size = new System.Drawing.Size(275, 25);
            this.cboLocBacSi.TabIndex = 5;
            // 
            // lblLocBacSi
            // 
            this.lblLocBacSi.AutoSize = true;
            this.lblLocBacSi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocBacSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblLocBacSi.Location = new System.Drawing.Point(20, 135);
            this.lblLocBacSi.Name = "lblLocBacSi";
            this.lblLocBacSi.Size = new System.Drawing.Size(49, 17);
            this.lblLocBacSi.TabIndex = 4;
            this.lblLocBacSi.Text = "Bác sĩ:";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(95, 87);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(275, 24);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDenNgay.Location = new System.Drawing.Point(20, 91);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(68, 17);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(95, 45);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(275, 24);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTuNgay.Location = new System.Drawing.Point(20, 49);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(60, 17);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // grpDanhSach
            // 
            this.grpDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDanhSach.Controls.Add(this.dgvLichKham);
            this.grpDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.grpDanhSach.Location = new System.Drawing.Point(16, 328);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(1132, 345);
            this.grpDanhSach.TabIndex = 3;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh Sách Lịch Khám Bệnh";
            // 
            // dgvLichKham
            // 
            this.dgvLichKham.AllowUserToAddRows = false;
            this.dgvLichKham.AllowUserToDeleteRows = false;
            this.dgvLichKham.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvLichKham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLichKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichKham.BackgroundColor = System.Drawing.Color.White;
            this.dgvLichKham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(132)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLichKham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLichKham.ColumnHeadersHeight = 36;
            this.dgvLichKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLichKham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLich,
            this.colTenBenhNhan,
            this.colSdt,
            this.colNgayKham,
            this.colGioKham,
            this.colTenBacSi,
            this.colChuyenKhoa,
            this.colTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(230)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLichKham.AutoGenerateColumns = false;
            this.dgvLichKham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLichKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLichKham.EnableHeadersVisualStyles = false;
            this.dgvLichKham.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvLichKham.Location = new System.Drawing.Point(3, 21);
            this.dgvLichKham.MultiSelect = false;
            this.dgvLichKham.Name = "dgvLichKham";
            this.dgvLichKham.ReadOnly = true;
            this.dgvLichKham.RowHeadersVisible = false;
            this.dgvLichKham.RowTemplate.Height = 32;
            this.dgvLichKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichKham.Size = new System.Drawing.Size(1126, 321);
            this.dgvLichKham.TabIndex = 0;
            this.dgvLichKham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichKham_CellClick);
            // 
            // colMaLich
            // 
            this.colMaLich.DataPropertyName = "MaLich";
            this.colMaLich.FillWeight = 8F;
            this.colMaLich.MinimumWidth = 60;
            this.colMaLich.HeaderText = "Mã";
            this.colMaLich.Name = "colMaLich";
            this.colMaLich.ReadOnly = true;
            this.colMaLich.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // colTenBenhNhan
            // 
            this.colTenBenhNhan.DataPropertyName = "TenBenhNhan";
            this.colTenBenhNhan.FillWeight = 22F;
            this.colTenBenhNhan.MinimumWidth = 140;
            this.colTenBenhNhan.HeaderText = "Tên bệnh nhân";
            this.colTenBenhNhan.Name = "colTenBenhNhan";
            this.colTenBenhNhan.ReadOnly = true;
            // 
            // colSdt
            // 
            this.colSdt.DataPropertyName = "Sdt";
            this.colSdt.FillWeight = 13F;
            this.colSdt.MinimumWidth = 110;
            this.colSdt.HeaderText = "Số điện thoại";
            this.colSdt.Name = "colSdt";
            this.colSdt.ReadOnly = true;
            this.colSdt.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // colNgayKham
            // 
            this.colNgayKham.DataPropertyName = "NgayKhamText";
            this.colNgayKham.FillWeight = 12F;
            this.colNgayKham.MinimumWidth = 100;
            this.colNgayKham.HeaderText = "Ngày khám";
            this.colNgayKham.Name = "colNgayKham";
            this.colNgayKham.ReadOnly = true;
            this.colNgayKham.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // colGioKham
            // 
            this.colGioKham.DataPropertyName = "GioKhamText";
            this.colGioKham.FillWeight = 10F;
            this.colGioKham.MinimumWidth = 85;
            this.colGioKham.HeaderText = "Giờ khám";
            this.colGioKham.Name = "colGioKham";
            this.colGioKham.ReadOnly = true;
            this.colGioKham.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // colTenBacSi
            // 
            this.colTenBacSi.DataPropertyName = "TenBacSi";
            this.colTenBacSi.FillWeight = 20F;
            this.colTenBacSi.MinimumWidth = 140;
            this.colTenBacSi.HeaderText = "Bác sĩ khám";
            this.colTenBacSi.Name = "colTenBacSi";
            this.colTenBacSi.ReadOnly = true;
            // 
            // colChuyenKhoa
            // 
            this.colChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            this.colChuyenKhoa.FillWeight = 15F;
            this.colChuyenKhoa.MinimumWidth = 120;
            this.colChuyenKhoa.HeaderText = "Chuyên khoa";
            this.colChuyenKhoa.Name = "colChuyenKhoa";
            this.colChuyenKhoa.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.FillWeight = 12F;
            this.colTrangThai.MinimumWidth = 95;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblTongSo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 679);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1164, 32);
            this.pnlBottom.TabIndex = 4;
            // 
            // lblTongSo
            // 
            this.lblTongSo.AutoSize = true;
            this.lblTongSo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTongSo.Location = new System.Drawing.Point(16, 6);
            this.lblTongSo.Name = "lblTongSo";
            this.lblTongSo.Size = new System.Drawing.Size(119, 17);
            this.lblTongSo.TabIndex = 0;
            this.lblTongSo.Text = "Tổng số: 0 lịch khám";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1164, 711);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Lịch khám bệnh - Phòng khám tư An Khang Clinic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichKham)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;
        private System.Windows.Forms.Button btnQuanLyBacSi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.TextBox txtTenBenhNhan;
        private System.Windows.Forms.Label lblTenBenhNhan;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.DateTimePicker dtpNgayKham;
        private System.Windows.Forms.Label lblNgayKham;
        private System.Windows.Forms.DateTimePicker dtpGioKham;
        private System.Windows.Forms.Label lblGioKham;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblMaLichLabel;
        private System.Windows.Forms.Label lblMaLichHienTai;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.ComboBox cboLocBacSi;
        private System.Windows.Forms.Label lblLocBacSi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.DataGridView dgvLichKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenBacSi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChuyenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTongSo;
    }
}
