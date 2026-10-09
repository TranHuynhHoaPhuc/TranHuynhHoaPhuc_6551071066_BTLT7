namespace day_5_10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuanLyLoaiPhong = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.picHinhAnh = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTinhTrang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numTangSo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHienTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboTimTinhTrang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTimLoaiPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTangSo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(984, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG Ở - SUNRISE HOMESTAY";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuanLyLoaiPhong);
            this.groupBox1.Controls.Add(this.btnChonAnh);
            this.groupBox1.Controls.Add(this.picHinhAnh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboTinhTrang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboLoaiPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numTangSo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // btnQuanLyLoaiPhong
            // 
            this.btnQuanLyLoaiPhong.Location = new System.Drawing.Point(405, 110);
            this.btnQuanLyLoaiPhong.Name = "btnQuanLyLoaiPhong";
            this.btnQuanLyLoaiPhong.Size = new System.Drawing.Size(160, 30);
            this.btnQuanLyLoaiPhong.TabIndex = 11;
            this.btnQuanLyLoaiPhong.Text = "Quản lý loại phòng...";
            this.btnQuanLyLoaiPhong.UseVisualStyleBackColor = true;
            this.btnQuanLyLoaiPhong.Click += new System.EventHandler(this.btnQuanLyLoaiPhong_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(825, 160);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(120, 30);
            this.btnChonAnh.TabIndex = 10;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHinhAnh.Location = new System.Drawing.Point(800, 25);
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Size = new System.Drawing.Size(145, 128);
            this.picHinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinhAnh.TabIndex = 9;
            this.picHinhAnh.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hình ảnh:";
            // 
            // cboTinhTrang
            // 
            this.cboTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTinhTrang.FormattingEnabled = true;
            this.cboTinhTrang.Location = new System.Drawing.Point(120, 150);
            this.cboTinhTrang.Name = "cboTinhTrang";
            this.cboTinhTrang.Size = new System.Drawing.Size(260, 25);
            this.cboTinhTrang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tình trạng:";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(120, 110);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(260, 25);
            this.cboLoaiPhong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại phòng:";
            // 
            // numTangSo
            // 
            this.numTangSo.Location = new System.Drawing.Point(120, 70);
            this.numTangSo.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numTangSo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numTangSo.Name = "numTangSo";
            this.numTangSo.Size = new System.Drawing.Size(120, 25);
            this.numTangSo.TabIndex = 3;
            this.numTangSo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tầng số:";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(120, 30);
            this.txtSoPhong.MaxLength = 10;
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(260, 25);
            this.txtSoPhong.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phòng:";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(132, 255);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(110, 35);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(262, 255);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(392, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 35);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.Location = new System.Drawing.Point(522, 255);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHienTatCa);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.cboTimTinhTrang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboTimLoaiPhong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Kết Hợp";
            // 
            // btnHienTatCa
            // 
            this.btnHienTatCa.Location = new System.Drawing.Point(825, 25);
            this.btnHienTatCa.Name = "btnHienTatCa";
            this.btnHienTatCa.Size = new System.Drawing.Size(115, 30);
            this.btnHienTatCa.TabIndex = 5;
            this.btnHienTatCa.Text = "Hiện tất cả";
            this.btnHienTatCa.UseVisualStyleBackColor = true;
            this.btnHienTatCa.Click += new System.EventHandler(this.btnHienTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(700, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 30);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTimTinhTrang
            // 
            this.cboTimTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimTinhTrang.FormattingEnabled = true;
            this.cboTimTinhTrang.Location = new System.Drawing.Point(490, 28);
            this.cboTimTinhTrang.Name = "cboTimTinhTrang";
            this.cboTimTinhTrang.Size = new System.Drawing.Size(185, 25);
            this.cboTimTinhTrang.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(410, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tình trạng:";
            // 
            // cboTimLoaiPhong
            // 
            this.cboTimLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimLoaiPhong.FormattingEnabled = true;
            this.cboTimLoaiPhong.Location = new System.Drawing.Point(120, 28);
            this.cboTimLoaiPhong.Name = "cboTimLoaiPhong";
            this.cboTimLoaiPhong.Size = new System.Drawing.Size(260, 25);
            this.cboTimLoaiPhong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPhong);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 295);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phòng";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToAddRows = false;
            this.dgvPhong.AllowUserToDeleteRows = false;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhong.Location = new System.Drawing.Point(3, 21);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(954, 271);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 682);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Homestay Sunrise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTangSo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTangSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picHinhAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnQuanLyLoaiPhong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTimLoaiPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTimTinhTrang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnHienTatCa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhong;
    }
}
