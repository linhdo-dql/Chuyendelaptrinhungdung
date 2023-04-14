namespace BanHangCayCanh
{
    partial class FormBanHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            dgvCTHD = new DataGridView();
            idCTHD = new DataGridViewTextBoxColumn();
            idCay = new DataGridViewTextBoxColumn();
            tenCay = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            donGia = new DataGridViewTextBoxColumn();
            thanhTien = new DataGridViewTextBoxColumn();
            idHoaDon = new DataGridViewTextBoxColumn();
            panelSanPham = new Panel();
            btnClosePanelSP = new Button();
            txtThanhTien = new TextBox();
            label8 = new Label();
            btnSuaSP = new Button();
            btnXoaSP = new Button();
            nudSoLuong = new NumericUpDown();
            btnThemSP = new Button();
            txtGiaBan = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbbTenCay = new ComboBox();
            label12 = new Label();
            panel9 = new Panel();
            label16 = new Label();
            btnThem = new Button();
            label20 = new Label();
            txtGiamGia = new TextBox();
            panel12 = new Panel();
            txtGiaCay = new Label();
            label19 = new Label();
            txtTongTien = new Label();
            label13 = new Label();
            panel11 = new Panel();
            panel10 = new Panel();
            dtpNgayLap = new DateTimePicker();
            label7 = new Label();
            txtDiaChiKH = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            label5 = new Label();
            label4 = new Label();
            cbbKhachHang = new ComboBox();
            label3 = new Label();
            cbbNhanVien = new ComboBox();
            label2 = new Label();
            label15 = new Label();
            panel5 = new Panel();
            btnResetFormHoaDon = new Button();
            button5 = new Button();
            button4 = new Button();
            btnTaoHoaDon = new Button();
            panel1 = new Panel();
            panel8 = new Panel();
            dgvHoaDon = new DataGridView();
            idHoaDonAll = new DataGridViewTextBoxColumn();
            idNhanVien = new DataGridViewTextBoxColumn();
            idKhachHang = new DataGridViewTextBoxColumn();
            ngayLap = new DataGridViewTextBoxColumn();
            chietKhau = new DataGridViewTextBoxColumn();
            tongTien = new DataGridViewTextBoxColumn();
            panel14 = new Panel();
            button2 = new Button();
            panel13 = new Panel();
            btnXoa = new Label();
            titleTable = new Label();
            panel6 = new Panel();
            btnHuyTimKiem = new Button();
            btnTimKiem = new Button();
            txtTimkiem = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            panel9.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).BeginInit();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(879, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(703, 953);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(683, 933);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(683, 933);
            panel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvCTHD);
            panel7.Controls.Add(panelSanPham);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 233);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10);
            panel7.Size = new Size(681, 509);
            panel7.TabIndex = 6;
            // 
            // dgvCTHD
            // 
            dgvCTHD.AllowUserToAddRows = false;
            dgvCTHD.AllowUserToDeleteRows = false;
            dgvCTHD.AllowUserToResizeColumns = false;
            dgvCTHD.AllowUserToResizeRows = false;
            dgvCTHD.BackgroundColor = SystemColors.Control;
            dgvCTHD.BorderStyle = BorderStyle.None;
            dgvCTHD.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCTHD.ColumnHeadersHeight = 29;
            dgvCTHD.Columns.AddRange(new DataGridViewColumn[] { idCTHD, idCay, tenCay, soLuong, donGia, thanhTien, idHoaDon });
            dgvCTHD.Dock = DockStyle.Fill;
            dgvCTHD.EnableHeadersVisualStyles = false;
            dgvCTHD.GridColor = SystemColors.ControlDarkDark;
            dgvCTHD.Location = new Point(10, 10);
            dgvCTHD.Name = "dgvCTHD";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCTHD.RowHeadersVisible = false;
            dgvCTHD.RowHeadersWidth = 51;
            dgvCTHD.RowTemplate.Height = 29;
            dgvCTHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTHD.ShowCellErrors = false;
            dgvCTHD.ShowCellToolTips = false;
            dgvCTHD.ShowEditingIcon = false;
            dgvCTHD.ShowRowErrors = false;
            dgvCTHD.Size = new Size(661, 292);
            dgvCTHD.TabIndex = 12;
            dgvCTHD.Click += dgvCTHD_Click;
            // 
            // idCTHD
            // 
            idCTHD.HeaderText = "Mã CTHD";
            idCTHD.MinimumWidth = 6;
            idCTHD.Name = "idCTHD";
            idCTHD.ReadOnly = true;
            idCTHD.Width = 75;
            // 
            // idCay
            // 
            idCay.HeaderText = "Mã cây";
            idCay.MinimumWidth = 6;
            idCay.Name = "idCay";
            idCay.ReadOnly = true;
            idCay.Visible = false;
            idCay.Width = 125;
            // 
            // tenCay
            // 
            tenCay.HeaderText = "Tên cây";
            tenCay.MinimumWidth = 6;
            tenCay.Name = "tenCay";
            tenCay.ReadOnly = true;
            tenCay.Width = 125;
            // 
            // soLuong
            // 
            soLuong.HeaderText = "Số lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.ReadOnly = true;
            soLuong.Width = 105;
            // 
            // donGia
            // 
            donGia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            donGia.HeaderText = "Đơn giá";
            donGia.MinimumWidth = 6;
            donGia.Name = "donGia";
            donGia.ReadOnly = true;
            // 
            // thanhTien
            // 
            thanhTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            thanhTien.HeaderText = "Thành tiền";
            thanhTien.MinimumWidth = 6;
            thanhTien.Name = "thanhTien";
            thanhTien.ReadOnly = true;
            // 
            // idHoaDon
            // 
            idHoaDon.HeaderText = "Mã Hóa Đơn";
            idHoaDon.MinimumWidth = 6;
            idHoaDon.Name = "idHoaDon";
            idHoaDon.ReadOnly = true;
            idHoaDon.Visible = false;
            idHoaDon.Width = 125;
            // 
            // panelSanPham
            // 
            panelSanPham.BorderStyle = BorderStyle.FixedSingle;
            panelSanPham.Controls.Add(btnClosePanelSP);
            panelSanPham.Controls.Add(txtThanhTien);
            panelSanPham.Controls.Add(label8);
            panelSanPham.Controls.Add(btnSuaSP);
            panelSanPham.Controls.Add(btnXoaSP);
            panelSanPham.Controls.Add(nudSoLuong);
            panelSanPham.Controls.Add(btnThemSP);
            panelSanPham.Controls.Add(txtGiaBan);
            panelSanPham.Controls.Add(label11);
            panelSanPham.Controls.Add(label9);
            panelSanPham.Controls.Add(label10);
            panelSanPham.Controls.Add(cbbTenCay);
            panelSanPham.Controls.Add(label12);
            panelSanPham.Dock = DockStyle.Bottom;
            panelSanPham.Location = new Point(10, 302);
            panelSanPham.Name = "panelSanPham";
            panelSanPham.Size = new Size(661, 197);
            panelSanPham.TabIndex = 11;
            panelSanPham.Visible = false;
            // 
            // btnClosePanelSP
            // 
            btnClosePanelSP.FlatAppearance.BorderSize = 0;
            btnClosePanelSP.FlatStyle = FlatStyle.Flat;
            btnClosePanelSP.Image = Properties.Resources.clear2;
            btnClosePanelSP.Location = new Point(632, 6);
            btnClosePanelSP.Name = "btnClosePanelSP";
            btnClosePanelSP.Size = new Size(20, 20);
            btnClosePanelSP.TabIndex = 23;
            btnClosePanelSP.UseVisualStyleBackColor = true;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Enabled = false;
            txtThanhTien.Location = new Point(458, 91);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(194, 27);
            txtThanhTien.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 93);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 21;
            label8.Text = "Thành tiền:";
            // 
            // btnSuaSP
            // 
            btnSuaSP.Image = Properties.Resources.write;
            btnSuaSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnSuaSP.Location = new Point(458, 138);
            btnSuaSP.Name = "btnSuaSP";
            btnSuaSP.Padding = new Padding(10, 0, 10, 0);
            btnSuaSP.Size = new Size(94, 46);
            btnSuaSP.TabIndex = 20;
            btnSuaSP.Text = "Sửa";
            btnSuaSP.TextAlign = ContentAlignment.MiddleRight;
            btnSuaSP.UseVisualStyleBackColor = true;
            btnSuaSP.Click += btnSuaSP_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Image = Properties.Resources.remove;
            btnXoaSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoaSP.Location = new Point(558, 138);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Padding = new Padding(10, 0, 10, 0);
            btnXoaSP.Size = new Size(94, 46);
            btnXoaSP.TabIndex = 19;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.TextAlign = ContentAlignment.MiddleRight;
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(118, 91);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(199, 27);
            nudSoLuong.TabIndex = 18;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnThemSP
            // 
            btnThemSP.Image = Properties.Resources.add;
            btnThemSP.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemSP.Location = new Point(558, 138);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Padding = new Padding(10, 0, 10, 0);
            btnThemSP.Size = new Size(94, 46);
            btnThemSP.TabIndex = 17;
            btnThemSP.Text = "Thêm";
            btnThemSP.TextAlign = ContentAlignment.MiddleRight;
            btnThemSP.UseVisualStyleBackColor = true;
            btnThemSP.Click += btnThemSP_Click;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Enabled = false;
            txtGiaBan.Location = new Point(458, 44);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(194, 27);
            txtGiaBan.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(348, 47);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 11;
            label11.Text = "Giá bán:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 4);
            label9.Name = "label9";
            label9.Size = new Size(153, 20);
            label9.TabIndex = 0;
            label9.Text = "Thông tin sản phẩm:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 94);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 13;
            label10.Text = "Số lượng:";
            // 
            // cbbTenCay
            // 
            cbbTenCay.FormattingEnabled = true;
            cbbTenCay.Location = new Point(118, 44);
            cbbTenCay.Name = "cbbTenCay";
            cbbTenCay.Size = new Size(199, 28);
            cbbTenCay.TabIndex = 12;
            cbbTenCay.SelectedIndexChanged += cbbTenCay_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 48);
            label12.Name = "label12";
            label12.Size = new Size(61, 20);
            label12.TabIndex = 11;
            label12.Text = "Tên cây:";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label16);
            panel9.Controls.Add(btnThem);
            panel9.Controls.Add(label20);
            panel9.Controls.Add(txtGiamGia);
            panel9.Controls.Add(panel12);
            panel9.Controls.Add(txtGiaCay);
            panel9.Controls.Add(label19);
            panel9.Controls.Add(txtTongTien);
            panel9.Controls.Add(label13);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 742);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 0, 10, 0);
            panel9.Size = new Size(681, 120);
            panel9.TabIndex = 5;
            panel9.Paint += panel9_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(632, 92);
            label16.Name = "label16";
            label16.Size = new Size(50, 20);
            label16.TabIndex = 35;
            label16.Text = "(VND)";
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(10, 21);
            btnThem.MaximumSize = new Size(159, 53);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(10, 0, 10, 0);
            btnThem.Size = new Size(159, 53);
            btnThem.TabIndex = 33;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(455, 54);
            label20.Name = "label20";
            label20.Size = new Size(81, 20);
            label20.TabIndex = 31;
            label20.Text = "Chiết khấu:";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(543, 51);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(125, 27);
            txtGiamGia.TabIndex = 32;
            txtGiamGia.Text = "0";
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            // 
            // panel12
            // 
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Location = new Point(459, 84);
            panel12.Name = "panel12";
            panel12.Size = new Size(200, 1);
            panel12.TabIndex = 30;
            panel12.Paint += panel12_Paint;
            // 
            // txtGiaCay
            // 
            txtGiaCay.AutoSize = true;
            txtGiaCay.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtGiaCay.Location = new Point(587, 22);
            txtGiaCay.MaximumSize = new Size(81, 20);
            txtGiaCay.MinimumSize = new Size(81, 20);
            txtGiaCay.Name = "txtGiaCay";
            txtGiaCay.Size = new Size(81, 20);
            txtGiaCay.TabIndex = 29;
            txtGiaCay.Text = "0";
            txtGiaCay.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(455, 22);
            label19.Name = "label19";
            label19.Size = new Size(60, 20);
            label19.TabIndex = 28;
            label19.Text = "Giá cây:";
            label19.Click += label19_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTongTien.Location = new Point(543, 92);
            txtTongTien.MaximumSize = new Size(90, 20);
            txtTongTien.MinimumSize = new Size(90, 20);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(90, 20);
            txtTongTien.TabIndex = 20;
            txtTongTien.Text = "0";
            txtTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(455, 92);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 19;
            label13.Text = "Tổng tiền:";
            // 
            // panel11
            // 
            panel11.Controls.Add(panel10);
            panel11.Controls.Add(label15);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(681, 233);
            panel11.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Controls.Add(dtpNgayLap);
            panel10.Controls.Add(label7);
            panel10.Controls.Add(txtDiaChiKH);
            panel10.Controls.Add(label6);
            panel10.Controls.Add(txtSDT);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(label4);
            panel10.Controls.Add(cbbKhachHang);
            panel10.Controls.Add(label3);
            panel10.Controls.Add(cbbNhanVien);
            panel10.Controls.Add(label2);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 50);
            panel10.Name = "panel10";
            panel10.Size = new Size(681, 189);
            panel10.TabIndex = 1;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(437, 13);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(235, 27);
            dtpNgayLap.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(0, 147);
            label7.Name = "label7";
            label7.Padding = new Padding(5, 10, 0, 0);
            label7.Size = new Size(158, 30);
            label7.TabIndex = 10;
            label7.Text = "Danh sách sản phẩm";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(162, 110);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(510, 27);
            txtDiaChiKH.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 113);
            label6.Name = "label6";
            label6.Padding = new Padding(5, 0, 0, 0);
            label6.Size = new Size(142, 20);
            label6.TabIndex = 8;
            label6.Text = "Địa chỉ khách hàng:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(437, 60);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(235, 27);
            txtSDT.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 13);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Ngày lập:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(325, 63);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 4;
            label4.Text = "Số điện thoại:";
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(107, 59);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(199, 28);
            cbbKhachHang.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 63);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 0, 0, 0);
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Khách hàng:";
            // 
            // cbbNhanVien
            // 
            cbbNhanVien.FormattingEnabled = true;
            cbbNhanVien.Location = new Point(107, 9);
            cbbNhanVien.Name = "cbbNhanVien";
            cbbNhanVien.Size = new Size(199, 28);
            cbbNhanVien.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 13);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 0, 0);
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhân viên:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Top;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(0, 0);
            label15.Name = "label15";
            label15.Padding = new Padding(5, 10, 0, 20);
            label15.Size = new Size(143, 50);
            label15.TabIndex = 0;
            label15.Text = "Thông tin hóa đơn";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnResetFormHoaDon);
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(btnTaoHoaDon);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 862);
            panel5.Name = "panel5";
            panel5.Size = new Size(681, 69);
            panel5.TabIndex = 0;
            // 
            // btnResetFormHoaDon
            // 
            btnResetFormHoaDon.Image = Properties.Resources.refresh;
            btnResetFormHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetFormHoaDon.Location = new Point(351, 6);
            btnResetFormHoaDon.MaximumSize = new Size(149, 53);
            btnResetFormHoaDon.Name = "btnResetFormHoaDon";
            btnResetFormHoaDon.Padding = new Padding(10, 0, 10, 0);
            btnResetFormHoaDon.Size = new Size(149, 53);
            btnResetFormHoaDon.TabIndex = 25;
            btnResetFormHoaDon.Text = "Reset";
            btnResetFormHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnResetFormHoaDon.UseVisualStyleBackColor = true;
            btnResetFormHoaDon.Click += btnResetFormHoaDon_Click;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.bill;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(522, 6);
            button5.MaximumSize = new Size(149, 53);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 10, 0);
            button5.Size = new Size(149, 53);
            button5.TabIndex = 24;
            button5.Text = "In hóa đơn";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Image = Properties.Resources.write;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(180, 6);
            button4.MaximumSize = new Size(149, 53);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 10, 0);
            button4.Size = new Size(149, 53);
            button4.TabIndex = 23;
            button4.Text = "Cập nhật";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Image = Properties.Resources.add;
            btnTaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoHoaDon.Location = new Point(9, 6);
            btnTaoHoaDon.MaximumSize = new Size(149, 53);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Padding = new Padding(10, 0, 10, 0);
            btnTaoHoaDon.Size = new Size(149, 53);
            btnTaoHoaDon.TabIndex = 22;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(879, 953);
            panel1.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvHoaDon);
            panel8.Controls.Add(panel14);
            panel8.Controls.Add(panel13);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(10, 110);
            panel8.Name = "panel8";
            panel8.Size = new Size(859, 833);
            panel8.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            dgvHoaDon.AllowUserToAddRows = false;
            dgvHoaDon.AllowUserToDeleteRows = false;
            dgvHoaDon.AllowUserToResizeColumns = false;
            dgvHoaDon.AllowUserToResizeRows = false;
            dgvHoaDon.BackgroundColor = SystemColors.Control;
            dgvHoaDon.BorderStyle = BorderStyle.None;
            dgvHoaDon.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHoaDon.ColumnHeadersHeight = 29;
            dgvHoaDon.Columns.AddRange(new DataGridViewColumn[] { idHoaDonAll, idNhanVien, idKhachHang, ngayLap, chietKhau, tongTien });
            dgvHoaDon.Dock = DockStyle.Fill;
            dgvHoaDon.EnableHeadersVisualStyles = false;
            dgvHoaDon.GridColor = SystemColors.ControlDarkDark;
            dgvHoaDon.Location = new Point(0, 65);
            dgvHoaDon.Name = "dgvHoaDon";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHoaDon.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHoaDon.RowHeadersVisible = false;
            dgvHoaDon.RowHeadersWidth = 51;
            dgvHoaDon.RowTemplate.Height = 29;
            dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDon.ShowCellErrors = false;
            dgvHoaDon.ShowCellToolTips = false;
            dgvHoaDon.ShowEditingIcon = false;
            dgvHoaDon.ShowRowErrors = false;
            dgvHoaDon.Size = new Size(859, 698);
            dgvHoaDon.TabIndex = 21;
            dgvHoaDon.CellContentClick += dgvHoaDon_CellContentClick;
            dgvHoaDon.Click += dgvHoaDon_Click;
            // 
            // idHoaDonAll
            // 
            idHoaDonAll.HeaderText = "Mã hóa đơn";
            idHoaDonAll.MinimumWidth = 6;
            idHoaDonAll.Name = "idHoaDonAll";
            idHoaDonAll.ReadOnly = true;
            idHoaDonAll.Width = 125;
            // 
            // idNhanVien
            // 
            idNhanVien.HeaderText = "Mã nhân viên";
            idNhanVien.MinimumWidth = 6;
            idNhanVien.Name = "idNhanVien";
            idNhanVien.ReadOnly = true;
            idNhanVien.Width = 125;
            // 
            // idKhachHang
            // 
            idKhachHang.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            idKhachHang.HeaderText = "Mã khách hàng";
            idKhachHang.MinimumWidth = 6;
            idKhachHang.Name = "idKhachHang";
            idKhachHang.ReadOnly = true;
            idKhachHang.Width = 138;
            // 
            // ngayLap
            // 
            ngayLap.HeaderText = "Ngày lập";
            ngayLap.MinimumWidth = 6;
            ngayLap.Name = "ngayLap";
            ngayLap.ReadOnly = true;
            ngayLap.Width = 125;
            // 
            // chietKhau
            // 
            chietKhau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            chietKhau.HeaderText = "Chiết khấu";
            chietKhau.MinimumWidth = 6;
            chietKhau.Name = "chietKhau";
            chietKhau.ReadOnly = true;
            // 
            // tongTien
            // 
            tongTien.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tongTien.HeaderText = "Tổng tiền";
            tongTien.MinimumWidth = 6;
            tongTien.Name = "tongTien";
            tongTien.ReadOnly = true;
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(button2);
            panel14.Dock = DockStyle.Bottom;
            panel14.Location = new Point(0, 763);
            panel14.Margin = new Padding(3, 4, 3, 4);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(13);
            panel14.Size = new Size(859, 70);
            panel14.TabIndex = 19;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.print;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(14, 7);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 10, 0);
            button2.Size = new Size(160, 51);
            button2.TabIndex = 12;
            button2.Text = "Xuất danh sách";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnXoa);
            panel13.Controls.Add(titleTable);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 0);
            panel13.Margin = new Padding(3, 4, 3, 4);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(0, 20, 6, 0);
            panel13.Size = new Size(859, 65);
            panel13.TabIndex = 18;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Dock = DockStyle.Right;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Image = Properties.Resources.bin;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(700, 20);
            btnXoa.MinimumSize = new Size(153, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 27);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa mục đã chọn";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseMnemonic = false;
            btnXoa.Visible = false;
            // 
            // titleTable
            // 
            titleTable.AutoSize = true;
            titleTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleTable.Location = new Point(0, 20);
            titleTable.Name = "titleTable";
            titleTable.Size = new Size(195, 28);
            titleTable.TabIndex = 14;
            titleTable.Text = "Danh sách hóa đơn";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnHuyTimKiem);
            panel6.Controls.Add(btnTimKiem);
            panel6.Controls.Add(txtTimkiem);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 10);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 25, 0, 0);
            panel6.Size = new Size(859, 100);
            panel6.TabIndex = 0;
            // 
            // btnHuyTimKiem
            // 
            btnHuyTimKiem.BackColor = Color.Transparent;
            btnHuyTimKiem.BackgroundImageLayout = ImageLayout.Zoom;
            btnHuyTimKiem.Dock = DockStyle.Right;
            btnHuyTimKiem.FlatAppearance.BorderSize = 0;
            btnHuyTimKiem.FlatStyle = FlatStyle.Flat;
            btnHuyTimKiem.Image = Properties.Resources.clear2;
            btnHuyTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyTimKiem.Location = new Point(716, 25);
            btnHuyTimKiem.MaximumSize = new Size(143, 35);
            btnHuyTimKiem.MinimumSize = new Size(143, 35);
            btnHuyTimKiem.Name = "btnHuyTimKiem";
            btnHuyTimKiem.Padding = new Padding(10, 0, 10, 0);
            btnHuyTimKiem.Size = new Size(143, 35);
            btnHuyTimKiem.TabIndex = 11;
            btnHuyTimKiem.Text = "Hủy tìm kiếm";
            btnHuyTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnHuyTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(520, 23);
            btnTimKiem.MaximumSize = new Size(117, 35);
            btnTimKiem.MinimumSize = new Size(117, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Padding = new Padding(6, 0, 6, 0);
            btnTimKiem.Size = new Size(117, 35);
            btnTimKiem.TabIndex = 10;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(160, 24);
            txtTimkiem.MaximumSize = new Size(331, 50);
            txtTimkiem.MinimumSize = new Size(331, 33);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(331, 33);
            txtTimkiem.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 8;
            label1.Text = "Nội dung tìm kiếm:";
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 953);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán hàng";
            FormClosed += FormBanHang_FormClosed;
            Load += FormBanHang_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            panelSanPham.ResumeLayout(false);
            panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDon).EndInit();
            panel14.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel7;
        private Panel panel9;
        private Label txtTongTien;
        private Label label13;
        private Panel panel11;
        private Panel panel10;
        private DateTimePicker dtpNgayLap;
        private Label label7;
        private TextBox txtDiaChiKH;
        private Label label6;
        private TextBox txtSDT;
        private Label label5;
        private Label label4;
        private ComboBox cbbKhachHang;
        private Label label3;
        private ComboBox cbbNhanVien;
        private Label label2;
        private Label label15;
        private Panel panel5;
        private Button button5;
        private Button button4;
        private Button btnTaoHoaDon;
        private Label txtGiaCay;
        private Label label19;
        private Panel panel12;
        private Button btnResetFormHoaDon;
        private Button btnThem;
        private Label label20;
        private TextBox txtGiamGia;
        private DataGridView dgvCTHD;
        private DataGridViewTextBoxColumn idCTHD;
        private DataGridViewTextBoxColumn idCay;
        private DataGridViewTextBoxColumn tenCay;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
        private DataGridViewTextBoxColumn idHoaDon;
        private Panel panelSanPham;
        private Button btnClosePanelSP;
        private TextBox txtThanhTien;
        private Label label8;
        private Button btnSuaSP;
        private Button btnXoaSP;
        private NumericUpDown nudSoLuong;
        private Button btnThemSP;
        private TextBox txtGiaBan;
        private Label label11;
        private Label label9;
        private Label label10;
        private ComboBox cbbTenCay;
        private Label label12;
        private Panel panel1;
        private Panel panel6;
        private Panel panel8;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label1;
        private Panel panel13;
        private Label btnXoa;
        private Label titleTable;
        private DataGridView dgvHoaDon;
        private Panel panel14;
        private Button button2;
        private DataGridViewTextBoxColumn idHoaDonAll;
        private DataGridViewTextBoxColumn idNhanVien;
        private DataGridViewTextBoxColumn idKhachHang;
        private DataGridViewTextBoxColumn ngayLap;
        private DataGridViewTextBoxColumn chietKhau;
        private DataGridViewTextBoxColumn tongTien;
        private Label label16;
    }
}