namespace BanHangCayCanh
{
    partial class DialogAddBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogAddBill));
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label14 = new Label();
            btnResetFormHoaDon = new Button();
            btnThem = new Button();
            btnTaoHoaDon = new Button();
            txtTongTien = new Label();
            label13 = new Label();
            label12 = new Label();
            txtGiamGia = new TextBox();
            panel4 = new Panel();
            panel13 = new Panel();
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
            label18 = new Label();
            btnSuaSP = new Button();
            btnXoaSP = new Button();
            nudSoLuong = new NumericUpDown();
            btnThemSP = new Button();
            txtGiaBan = new TextBox();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            cbbTenCay = new ComboBox();
            label22 = new Label();
            panel12 = new Panel();
            label16 = new Label();
            label17 = new Label();
            panelKhachHang = new Panel();
            txtTenKhachHang = new TextBox();
            txtDiaChiKH = new TextBox();
            label11 = new Label();
            txtSDT = new TextBox();
            label3 = new Label();
            cbbKhachHang = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            rbKhachHangCu = new RadioButton();
            rbKhachHangMoi = new RadioButton();
            panel11 = new Panel();
            txtIdNhanVien = new TextBox();
            dtpNgayLap = new DateTimePicker();
            label2 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).BeginInit();
            panelSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            panel12.SuspendLayout();
            panelKhachHang.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 10, 0, 0);
            label1.Size = new Size(143, 30);
            label1.TabIndex = 0;
            label1.Text = "Thông tin hóa đơn";
            // 
            // panel3
            // 
            panel3.Controls.Add(label14);
            panel3.Controls.Add(btnResetFormHoaDon);
            panel3.Controls.Add(btnThem);
            panel3.Controls.Add(btnTaoHoaDon);
            panel3.Controls.Add(txtTongTien);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtGiamGia);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 747);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 10, 0);
            panel3.Size = new Size(702, 76);
            panel3.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(473, 43);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 28;
            label14.Text = "(VND)";
            // 
            // btnResetFormHoaDon
            // 
            btnResetFormHoaDon.Image = Properties.Resources.refresh;
            btnResetFormHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetFormHoaDon.Location = new Point(172, 10);
            btnResetFormHoaDon.MaximumSize = new Size(89, 53);
            btnResetFormHoaDon.Name = "btnResetFormHoaDon";
            btnResetFormHoaDon.Padding = new Padding(10, 0, 10, 0);
            btnResetFormHoaDon.Size = new Size(89, 53);
            btnResetFormHoaDon.TabIndex = 27;
            btnResetFormHoaDon.Text = "Reset";
            btnResetFormHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnResetFormHoaDon.UseVisualStyleBackColor = true;
            btnResetFormHoaDon.Click += btnResetFormHoaDon_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(7, 10);
            btnThem.MaximumSize = new Size(159, 53);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(10, 0, 10, 0);
            btnThem.Size = new Size(159, 53);
            btnThem.TabIndex = 26;
            btnThem.Text = "Thêm sản phẩm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Image = Properties.Resources.bill;
            btnTaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoHoaDon.Location = new Point(529, 10);
            btnTaoHoaDon.MaximumSize = new Size(149, 53);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Padding = new Padding(10, 0, 10, 0);
            btnTaoHoaDon.Size = new Size(145, 53);
            btnTaoHoaDon.TabIndex = 21;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // txtTongTien
            // 
            txtTongTien.AutoSize = true;
            txtTongTien.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTongTien.Location = new Point(387, 43);
            txtTongTien.MinimumSize = new Size(90, 20);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(90, 20);
            txtTongTien.TabIndex = 20;
            txtTongTien.Text = "1";
            txtTongTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(306, 43);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 19;
            label13.Text = "Tổng tiền:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(306, 13);
            label12.Name = "label12";
            label12.Size = new Size(81, 20);
            label12.TabIndex = 15;
            label12.Text = "Chiết khấu:";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(387, 10);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(136, 27);
            txtGiamGia.TabIndex = 16;
            txtGiamGia.Text = "0";
            txtGiamGia.TextAlign = HorizontalAlignment.Right;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panelKhachHang);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel11);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 42);
            panel4.Name = "panel4";
            panel4.Size = new Size(702, 705);
            panel4.TabIndex = 3;
            // 
            // panel13
            // 
            panel13.Controls.Add(dgvCTHD);
            panel13.Controls.Add(panelSanPham);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 211);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(10);
            panel13.Size = new Size(702, 494);
            panel13.TabIndex = 26;
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
            dgvCTHD.Size = new Size(682, 277);
            dgvCTHD.TabIndex = 8;
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
            panelSanPham.Controls.Add(label18);
            panelSanPham.Controls.Add(btnSuaSP);
            panelSanPham.Controls.Add(btnXoaSP);
            panelSanPham.Controls.Add(nudSoLuong);
            panelSanPham.Controls.Add(btnThemSP);
            panelSanPham.Controls.Add(txtGiaBan);
            panelSanPham.Controls.Add(label19);
            panelSanPham.Controls.Add(label20);
            panelSanPham.Controls.Add(label21);
            panelSanPham.Controls.Add(cbbTenCay);
            panelSanPham.Controls.Add(label22);
            panelSanPham.Dock = DockStyle.Bottom;
            panelSanPham.Location = new Point(10, 287);
            panelSanPham.Name = "panelSanPham";
            panelSanPham.Size = new Size(682, 197);
            panelSanPham.TabIndex = 7;
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
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(348, 93);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 21;
            label18.Text = "Thành tiền:";
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
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(118, 91);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(199, 27);
            nudSoLuong.TabIndex = 18;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.ValueChanged += nudSoLuong_ValueChanged;
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
            // 
            // txtGiaBan
            // 
            txtGiaBan.Enabled = false;
            txtGiaBan.Location = new Point(458, 44);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(194, 27);
            txtGiaBan.TabIndex = 12;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(348, 47);
            label19.Name = "label19";
            label19.Size = new Size(63, 20);
            label19.TabIndex = 11;
            label19.Text = "Giá bán:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(6, 4);
            label20.Name = "label20";
            label20.Size = new Size(153, 20);
            label20.TabIndex = 0;
            label20.Text = "Thông tin sản phẩm:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 94);
            label21.Name = "label21";
            label21.Size = new Size(72, 20);
            label21.TabIndex = 13;
            label21.Text = "Số lượng:";
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
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 48);
            label22.Name = "label22";
            label22.Size = new Size(61, 20);
            label22.TabIndex = 11;
            label22.Text = "Tên cây:";
            // 
            // panel12
            // 
            panel12.Controls.Add(label16);
            panel12.Controls.Add(label17);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 176);
            panel12.Name = "panel12";
            panel12.Size = new Size(702, 35);
            panel12.TabIndex = 25;
            panel12.Paint += panel12_Paint;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.Black;
            label16.Image = Properties.Resources.bin;
            label16.ImageAlign = ContentAlignment.MiddleLeft;
            label16.Location = new Point(526, 7);
            label16.MinimumSize = new Size(153, 27);
            label16.Name = "label16";
            label16.Size = new Size(153, 27);
            label16.TabIndex = 17;
            label16.Text = "Xóa mục đã chọn";
            label16.TextAlign = ContentAlignment.MiddleRight;
            label16.UseMnemonic = false;
            label16.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(0, 7);
            label17.Name = "label17";
            label17.Padding = new Padding(5, 0, 0, 0);
            label17.Size = new Size(158, 20);
            label17.TabIndex = 10;
            label17.Text = "Danh sách sản phẩm";
            // 
            // panelKhachHang
            // 
            panelKhachHang.Controls.Add(txtTenKhachHang);
            panelKhachHang.Controls.Add(txtDiaChiKH);
            panelKhachHang.Controls.Add(label11);
            panelKhachHang.Controls.Add(txtSDT);
            panelKhachHang.Controls.Add(label3);
            panelKhachHang.Controls.Add(cbbKhachHang);
            panelKhachHang.Controls.Add(label4);
            panelKhachHang.Dock = DockStyle.Top;
            panelKhachHang.Location = new Point(0, 81);
            panelKhachHang.Name = "panelKhachHang";
            panelKhachHang.Size = new Size(702, 95);
            panelKhachHang.TabIndex = 24;
            panelKhachHang.Visible = false;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(131, 10);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(230, 27);
            txtTenKhachHang.TabIndex = 16;
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(129, 53);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(549, 27);
            txtDiaChiKH.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 56);
            label11.Name = "label11";
            label11.Padding = new Padding(5, 0, 0, 0);
            label11.Size = new Size(63, 20);
            label11.TabIndex = 14;
            label11.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(443, 10);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(236, 27);
            txtSDT.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 12;
            label3.Text = "SĐT:";
            // 
            // cbbKhachHang
            // 
            cbbKhachHang.FormattingEnabled = true;
            cbbKhachHang.Location = new Point(132, 9);
            cbbKhachHang.Name = "cbbKhachHang";
            cbbKhachHang.Size = new Size(230, 28);
            cbbKhachHang.TabIndex = 11;
            cbbKhachHang.SelectedIndexChanged += cbbKhachHang_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 13);
            label4.Name = "label4";
            label4.Padding = new Padding(5, 0, 0, 0);
            label4.Size = new Size(119, 20);
            label4.TabIndex = 10;
            label4.Text = "Tên khách hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbKhachHangCu);
            panel2.Controls.Add(rbKhachHangMoi);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 35);
            panel2.TabIndex = 23;
            // 
            // rbKhachHangCu
            // 
            rbKhachHangCu.AutoSize = true;
            rbKhachHangCu.Location = new Point(175, 6);
            rbKhachHangCu.Name = "rbKhachHangCu";
            rbKhachHangCu.Size = new Size(126, 24);
            rbKhachHangCu.TabIndex = 1;
            rbKhachHangCu.Text = "Khách hàng cũ";
            rbKhachHangCu.UseVisualStyleBackColor = true;
            rbKhachHangCu.CheckedChanged += rbKhachHangCu_CheckedChanged;
            // 
            // rbKhachHangMoi
            // 
            rbKhachHangMoi.AutoSize = true;
            rbKhachHangMoi.Location = new Point(17, 5);
            rbKhachHangMoi.Name = "rbKhachHangMoi";
            rbKhachHangMoi.Size = new Size(137, 24);
            rbKhachHangMoi.TabIndex = 0;
            rbKhachHangMoi.Text = "Khách hàng mới";
            rbKhachHangMoi.UseVisualStyleBackColor = true;
            rbKhachHangMoi.CheckedChanged += rbKhachHangMoi_CheckedChanged;
            // 
            // panel11
            // 
            panel11.Controls.Add(txtIdNhanVien);
            panel11.Controls.Add(dtpNgayLap);
            panel11.Controls.Add(label2);
            panel11.Controls.Add(label15);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(702, 46);
            panel11.TabIndex = 22;
            // 
            // txtIdNhanVien
            // 
            txtIdNhanVien.Enabled = false;
            txtIdNhanVien.Location = new Point(132, 7);
            txtIdNhanVien.Name = "txtIdNhanVien";
            txtIdNhanVien.Size = new Size(230, 27);
            txtIdNhanVien.TabIndex = 16;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Format = DateTimePickerFormat.Short;
            dtpNgayLap.Location = new Point(443, 7);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(235, 27);
            dtpNgayLap.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(368, 10);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 14;
            label2.Text = "Ngày lập:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 10);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 12;
            label15.Text = "Nhân viên:";
            // 
            // DialogAddBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 823);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DialogAddBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo hóa đơn";
            FormClosed += DialogAddBill_FormClosed;
            Load += DialogAddBill_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTHD).EndInit();
            panelSanPham.ResumeLayout(false);
            panelSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panelKhachHang.ResumeLayout(false);
            panelKhachHang.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label txtTongTien;
        private Label label13;
        private Button btnTaoHoaDon;
        private Button btnThem;
        private Button btnResetFormHoaDon;
        private Label label14;
        private Label label12;
        private TextBox txtGiamGia;
        private Panel panel11;
        private DateTimePicker dtpNgayLap;
        private Label label2;
        private Label label15;
        private Panel panelKhachHang;
        private TextBox txtDiaChiKH;
        private Label label11;
        private TextBox txtSDT;
        private Label label3;
        private ComboBox cbbKhachHang;
        private Label label4;
        private Panel panel2;
        private Panel panel12;
        private Label label16;
        private Label label17;
        private Panel panel13;
        private DataGridView dgvCTHD;
        private Panel panelSanPham;
        private Button btnClosePanelSP;
        private TextBox txtThanhTien;
        private Label label18;
        private Button btnSuaSP;
        private Button btnXoaSP;
        private NumericUpDown nudSoLuong;
        private Button btnThemSP;
        private TextBox txtGiaBan;
        private Label label19;
        private Label label20;
        private Label label21;
        private ComboBox cbbTenCay;
        private Label label22;
        private RadioButton rbKhachHangCu;
        private RadioButton rbKhachHangMoi;
        private DataGridViewTextBoxColumn idCTHD;
        private DataGridViewTextBoxColumn idCay;
        private DataGridViewTextBoxColumn tenCay;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn donGia;
        private DataGridViewTextBoxColumn thanhTien;
        private DataGridViewTextBoxColumn idHoaDon;
        private TextBox txtTenKhachHang;
        private TextBox txtIdNhanVien;
    }
}