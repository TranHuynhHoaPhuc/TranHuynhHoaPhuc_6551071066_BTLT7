namespace Bai_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaTL = new Label();
            txtMaTL = new TextBox();
            lblTenTheLoai = new Label();
            txtTenTheLoai = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            dgvTheLoai = new DataGridView();
            lblNgayTao = new Label();
            lblNgayTaoValue = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).BeginInit();
            SuspendLayout();
            // 
            // lblMaTL
            // 
            lblMaTL.AutoSize = true;
            lblMaTL.Location = new Point(32, 29);
            lblMaTL.Name = "lblMaTL";
            lblMaTL.Size = new Size(100, 25);
            lblMaTL.TabIndex = 0;
            lblMaTL.Text = "Mã thể loại";
            // 
            // txtMaTL
            // 
            txtMaTL.Location = new Point(161, 23);
            txtMaTL.Name = "txtMaTL";
            txtMaTL.ReadOnly = true;
            txtMaTL.Size = new Size(150, 31);
            txtMaTL.TabIndex = 1;
            // 
            // lblTenTheLoai
            // 
            lblTenTheLoai.AutoSize = true;
            lblTenTheLoai.Location = new Point(32, 72);
            lblTenTheLoai.Name = "lblTenTheLoai";
            lblTenTheLoai.Size = new Size(101, 25);
            lblTenTheLoai.TabIndex = 2;
            lblTenTheLoai.Text = "Tên thể loại";
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.Location = new Point(161, 72);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.Size = new Size(150, 31);
            txtTenTheLoai.TabIndex = 3;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(32, 131);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(59, 25);
            lblMoTa.TabIndex = 4;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(161, 125);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.ScrollBars = ScrollBars.Vertical;
            txtMoTa.Size = new Size(273, 81);
            txtMoTa.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(443, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 34);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(533, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(59, 34);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(612, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(59, 34);
            btnXoa.TabIndex = 8;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(686, 20);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(102, 34);
            btnLamMoi.TabIndex = 9;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += button4_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(32, 235);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(354, 31);
            txtTimKiem.TabIndex = 10;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(419, 235);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(112, 34);
            btnTimKiem.TabIndex = 11;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvTheLoai
            // 
            dgvTheLoai.AllowUserToAddRows = false;
            dgvTheLoai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTheLoai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTheLoai.Location = new Point(-1, 371);
            dgvTheLoai.MultiSelect = false;
            dgvTheLoai.Name = "dgvTheLoai";
            dgvTheLoai.ReadOnly = true;
            dgvTheLoai.RowHeadersWidth = 62;
            dgvTheLoai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTheLoai.Size = new Size(1107, 212);
            dgvTheLoai.TabIndex = 12;
            dgvTheLoai.SelectionChanged += dgvTheLoai_SelectionChanged;
            // 
            // lblNgayTao
            // 
            lblNgayTao.AutoSize = true;
            lblNgayTao.Location = new Point(32, 302);
            lblNgayTao.Name = "lblNgayTao";
            lblNgayTao.Size = new Size(89, 25);
            lblNgayTao.TabIndex = 13;
            lblNgayTao.Text = "Ngày tạo:";
            // 
            // lblNgayTaoValue
            // 
            lblNgayTaoValue.AutoSize = true;
            lblNgayTaoValue.Location = new Point(161, 302);
            lblNgayTaoValue.Name = "lblNgayTaoValue";
            lblNgayTaoValue.Size = new Size(59, 25);
            lblNgayTaoValue.TabIndex = 14;
            lblNgayTaoValue.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 586);
            Controls.Add(lblNgayTaoValue);
            Controls.Add(lblNgayTao);
            Controls.Add(dgvTheLoai);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(lblMoTa);
            Controls.Add(txtTenTheLoai);
            Controls.Add(lblTenTheLoai);
            Controls.Add(txtMaTL);
            Controls.Add(lblMaTL);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thể Loại Sách - Tri Thức Books";
            ((System.ComponentModel.ISupportInitialize)dgvTheLoai).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaTL;
        private TextBox txtMaTL;
        private Label lblTenTheLoai;
        private TextBox txtTenTheLoai;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private DataGridView dgvTheLoai;
        private Label lblNgayTao;
        private Label lblNgayTaoValue;
    }
}
