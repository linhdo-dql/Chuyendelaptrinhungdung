namespace BanHangCayCanh
{
    partial class FormCayCanh
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCayCanh));
            panel1 = new Panel();
            dgvCayCanh = new DataGridView();
            anh = new DataGridViewImageColumn();
            idCayCanh = new DataGridViewTextBoxColumn();
            tenCayCanh = new DataGridViewTextBoxColumn();
            tenLoaicay = new DataGridViewTextBoxColumn();
            idLoaiCay = new DataGridViewTextBoxColumn();
            moTa = new DataGridViewTextBoxColumn();
            tuoi = new DataGridViewTextBoxColumn();
            mauSac = new DataGridViewTextBoxColumn();
            soLuong = new DataGridViewTextBoxColumn();
            gia = new DataGridViewTextBoxColumn();
            kichThuoc = new DataGridViewTextBoxColumn();
            delete = new DataGridViewImageColumn();
            selected = new DataGridViewCheckBoxColumn();
            pathAnh = new DataGridViewTextBoxColumn();
            panel9 = new Panel();
            txtSoLuongDaChon = new Label();
            btnTaoHoaDon = new Button();
            button1 = new Button();
            btnXoa = new Label();
            titleTable = new Label();
            panel6 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            btnHuyTimKiem = new Button();
            btnTimKiem = new Button();
            txtTimkiem = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            txtKichThuoc = new TextBox();
            label10 = new Label();
            btnChangeImage = new Button();
            txtSoLuong = new TextBox();
            label9 = new Label();
            txtGiaBan = new TextBox();
            label8 = new Label();
            txtTuoi = new TextBox();
            label7 = new Label();
            txtMauSac = new TextBox();
            label6 = new Label();
            cbbLoaiCay = new ComboBox();
            label5 = new Label();
            panel7 = new Panel();
            rtxtMota = new RichTextBox();
            label2 = new Label();
            txtTenCay = new TextBox();
            label4 = new Label();
            label3 = new Label();
            picCayCanh = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            btnSua = new Button();
            btnThem = new Button();
            btnReset = new Button();
            ofd = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCayCanh).BeginInit();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCayCanh).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(dgvCayCanh);
            panel1.Controls.Add(panel9);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 113);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(11, 13, 11, 7);
            panel1.Size = new Size(1227, 742);
            panel1.TabIndex = 9;
            // 
            // dgvCayCanh
            // 
            dgvCayCanh.AllowUserToResizeColumns = false;
            dgvCayCanh.BackgroundColor = SystemColors.Control;
            dgvCayCanh.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCayCanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCayCanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCayCanh.Columns.AddRange(new DataGridViewColumn[] { anh, idCayCanh, tenCayCanh, tenLoaicay, idLoaiCay, moTa, tuoi, mauSac, soLuong, gia, kichThuoc, delete, selected, pathAnh });
            dgvCayCanh.Dock = DockStyle.Fill;
            dgvCayCanh.EnableHeadersVisualStyles = false;
            dgvCayCanh.Location = new Point(11, 13);
            dgvCayCanh.Margin = new Padding(3, 4, 3, 4);
            dgvCayCanh.MultiSelect = false;
            dgvCayCanh.Name = "dgvCayCanh";
            dgvCayCanh.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCayCanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCayCanh.RowHeadersVisible = false;
            dgvCayCanh.RowHeadersWidth = 51;
            dgvCayCanh.RowTemplate.Height = 150;
            dgvCayCanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCayCanh.Size = new Size(1205, 641);
            dgvCayCanh.TabIndex = 15;
            dgvCayCanh.CellContentClick += dgvCayCanh_CellContentClick;
            dgvCayCanh.Click += dgvCayCanh_Click;
            // 
            // anh
            // 
            anh.HeaderText = "Ảnh";
            anh.ImageLayout = DataGridViewImageCellLayout.Stretch;
            anh.MinimumWidth = 6;
            anh.Name = "anh";
            anh.Width = 125;
            // 
            // idCayCanh
            // 
            idCayCanh.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCayCanh.DefaultCellStyle = dataGridViewCellStyle2;
            idCayCanh.HeaderText = "Mã cây cảnh";
            idCayCanh.MinimumWidth = 6;
            idCayCanh.Name = "idCayCanh";
            idCayCanh.ReadOnly = true;
            idCayCanh.Visible = false;
            idCayCanh.Width = 125;
            // 
            // tenCayCanh
            // 
            tenCayCanh.HeaderText = "Tên cây";
            tenCayCanh.MinimumWidth = 6;
            tenCayCanh.Name = "tenCayCanh";
            tenCayCanh.ReadOnly = true;
            tenCayCanh.Width = 125;
            // 
            // tenLoaicay
            // 
            tenLoaicay.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenLoaicay.HeaderText = "Loại Cây";
            tenLoaicay.MinimumWidth = 6;
            tenLoaicay.Name = "tenLoaicay";
            tenLoaicay.ReadOnly = true;
            // 
            // idLoaiCay
            // 
            idLoaiCay.HeaderText = "Mã Loại Cây";
            idLoaiCay.MinimumWidth = 6;
            idLoaiCay.Name = "idLoaiCay";
            idLoaiCay.Visible = false;
            idLoaiCay.Width = 125;
            // 
            // moTa
            // 
            moTa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            moTa.DefaultCellStyle = dataGridViewCellStyle3;
            moTa.HeaderText = "Mô tả";
            moTa.MinimumWidth = 200;
            moTa.Name = "moTa";
            moTa.ReadOnly = true;
            // 
            // tuoi
            // 
            tuoi.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            tuoi.HeaderText = "Tuổi";
            tuoi.MinimumWidth = 6;
            tuoi.Name = "tuoi";
            tuoi.ReadOnly = true;
            tuoi.Width = 67;
            // 
            // mauSac
            // 
            mauSac.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            mauSac.HeaderText = "Màu sắc";
            mauSac.MinimumWidth = 6;
            mauSac.Name = "mauSac";
            mauSac.ReadOnly = true;
            mauSac.Width = 85;
            // 
            // soLuong
            // 
            soLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            soLuong.HeaderText = "Số lượng";
            soLuong.MinimumWidth = 6;
            soLuong.Name = "soLuong";
            soLuong.ReadOnly = true;
            soLuong.Width = 91;
            // 
            // gia
            // 
            gia.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gia.HeaderText = "Giá bán";
            gia.MinimumWidth = 6;
            gia.Name = "gia";
            gia.ReadOnly = true;
            gia.Width = 83;
            // 
            // kichThuoc
            // 
            kichThuoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            kichThuoc.HeaderText = "Kích thước";
            kichThuoc.MinimumWidth = 6;
            kichThuoc.Name = "kichThuoc";
            // 
            // delete
            // 
            delete.HeaderText = "";
            delete.Image = Properties.Resources.remove;
            delete.MinimumWidth = 50;
            delete.Name = "delete";
            delete.Width = 50;
            // 
            // selected
            // 
            selected.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            selected.HeaderText = "";
            selected.MinimumWidth = 6;
            selected.Name = "selected";
            // 
            // pathAnh
            // 
            pathAnh.HeaderText = "";
            pathAnh.MinimumWidth = 6;
            pathAnh.Name = "pathAnh";
            pathAnh.Visible = false;
            pathAnh.Width = 125;
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(txtSoLuongDaChon);
            panel9.Controls.Add(btnTaoHoaDon);
            panel9.Controls.Add(button1);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(11, 654);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(13);
            panel9.Size = new Size(1205, 81);
            panel9.TabIndex = 14;
            // 
            // txtSoLuongDaChon
            // 
            txtSoLuongDaChon.AutoSize = true;
            txtSoLuongDaChon.Dock = DockStyle.Right;
            txtSoLuongDaChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuongDaChon.Location = new Point(938, 13);
            txtSoLuongDaChon.Margin = new Padding(3, 10, 0, 0);
            txtSoLuongDaChon.Name = "txtSoLuongDaChon";
            txtSoLuongDaChon.Padding = new Padding(0, 15, 20, 0);
            txtSoLuongDaChon.Size = new Size(103, 35);
            txtSoLuongDaChon.TabIndex = 14;
            txtSoLuongDaChon.Text = "Đã chọn: 2";
            // 
            // btnTaoHoaDon
            // 
            btnTaoHoaDon.Dock = DockStyle.Right;
            btnTaoHoaDon.Image = Properties.Resources.bill;
            btnTaoHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoHoaDon.Location = new Point(1041, 13);
            btnTaoHoaDon.MaximumSize = new Size(149, 53);
            btnTaoHoaDon.Name = "btnTaoHoaDon";
            btnTaoHoaDon.Padding = new Padding(10, 0, 10, 0);
            btnTaoHoaDon.Size = new Size(149, 53);
            btnTaoHoaDon.TabIndex = 13;
            btnTaoHoaDon.Text = "Tạo hóa đơn";
            btnTaoHoaDon.TextAlign = ContentAlignment.MiddleRight;
            btnTaoHoaDon.UseVisualStyleBackColor = true;
            btnTaoHoaDon.Click += btnTaoHoaDon_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.print;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(14, 16);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 10, 0);
            button1.Size = new Size(160, 51);
            button1.TabIndex = 12;
            button1.Text = "Xuất danh sách";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.AutoSize = true;
            btnXoa.Dock = DockStyle.Right;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Black;
            btnXoa.Image = Properties.Resources.bin;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(1068, 7);
            btnXoa.MinimumSize = new Size(153, 27);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(153, 27);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa mục đã chọn";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseMnemonic = false;
            btnXoa.Visible = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // titleTable
            // 
            titleTable.AutoSize = true;
            titleTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            titleTable.Location = new Point(11, 7);
            titleTable.Name = "titleTable";
            titleTable.Size = new Size(199, 28);
            titleTable.TabIndex = 14;
            titleTable.Text = "Danh sách cây cảnh";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnXoa);
            panel6.Controls.Add(titleTable);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 77);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 7, 6, 0);
            panel6.Size = new Size(1227, 36);
            panel6.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 113);
            panel2.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(btnHuyTimKiem);
            panel8.Controls.Add(btnTimKiem);
            panel8.Controls.Add(txtTimkiem);
            panel8.Controls.Add(label1);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 20, 6, 0);
            panel8.Size = new Size(1227, 77);
            panel8.TabIndex = 17;
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
            btnHuyTimKiem.Location = new Point(1078, 20);
            btnHuyTimKiem.MaximumSize = new Size(143, 35);
            btnHuyTimKiem.MinimumSize = new Size(143, 35);
            btnHuyTimKiem.Name = "btnHuyTimKiem";
            btnHuyTimKiem.Padding = new Padding(10, 0, 10, 0);
            btnHuyTimKiem.Size = new Size(143, 35);
            btnHuyTimKiem.TabIndex = 7;
            btnHuyTimKiem.Text = "Hủy tìm kiếm";
            btnHuyTimKiem.TextAlign = ContentAlignment.MiddleRight;
            btnHuyTimKiem.UseVisualStyleBackColor = false;
            btnHuyTimKiem.Click += btnHuyTimKiem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimKiem.Location = new Point(527, 21);
            btnTimKiem.MaximumSize = new Size(117, 35);
            btnTimKiem.MinimumSize = new Size(117, 35);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Padding = new Padding(6, 0, 6, 0);
            btnTimKiem.Size = new Size(117, 35);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(167, 22);
            txtTimkiem.MaximumSize = new Size(331, 50);
            txtTimkiem.MinimumSize = new Size(331, 33);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(331, 33);
            txtTimkiem.TabIndex = 5;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 4;
            label1.Text = "Nội dung tìm kiếm:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtKichThuoc);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(btnChangeImage);
            panel4.Controls.Add(txtSoLuong);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(txtGiaBan);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtTuoi);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(txtMauSac);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(cbbLoaiCay);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtTenCay);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(picCayCanh);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(6, 7);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 841);
            panel4.TabIndex = 0;
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.Location = new Point(342, 640);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.Size = new Size(60, 27);
            txtKichThuoc.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(304, 643);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 28;
            label10.Text = "Size:";
            // 
            // btnChangeImage
            // 
            btnChangeImage.Image = Properties.Resources.circular;
            btnChangeImage.Location = new Point(350, 267);
            btnChangeImage.Margin = new Padding(23, 27, 23, 27);
            btnChangeImage.Name = "btnChangeImage";
            btnChangeImage.Padding = new Padding(10, 0, 10, 0);
            btnChangeImage.Size = new Size(43, 43);
            btnChangeImage.TabIndex = 26;
            btnChangeImage.UseVisualStyleBackColor = true;
            btnChangeImage.Click += btnChangeImage_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(305, 425);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(97, 27);
            txtSoLuong.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(272, 429);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 24;
            label9.Text = "SL:";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(112, 697);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(289, 27);
            txtGiaBan.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 701);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 23;
            label8.Text = "Giá bán:";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(247, 640);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(33, 27);
            txtTuoi.TabIndex = 20;
            txtTuoi.TextChanged += txtTuoi_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 643);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 21;
            label7.Text = "Tuổi:";
            label7.Click += label7_Click;
            // 
            // txtMauSac
            // 
            txtMauSac.Location = new Point(112, 640);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(61, 27);
            txtMauSac.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 643);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 19;
            label6.Text = "Màu sắc:";
            // 
            // cbbLoaiCay
            // 
            cbbLoaiCay.FormattingEnabled = true;
            cbbLoaiCay.Location = new Point(112, 425);
            cbbLoaiCay.Margin = new Padding(3, 4, 3, 4);
            cbbLoaiCay.Name = "cbbLoaiCay";
            cbbLoaiCay.Size = new Size(154, 28);
            cbbLoaiCay.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 429);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 16;
            label5.Text = "Loại cây:";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(rtxtMota);
            panel7.Location = new Point(112, 481);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(290, 127);
            panel7.TabIndex = 13;
            // 
            // rtxtMota
            // 
            rtxtMota.BorderStyle = BorderStyle.None;
            rtxtMota.Location = new Point(-1, 1);
            rtxtMota.Margin = new Padding(3, 4, 3, 4);
            rtxtMota.Name = "rtxtMota";
            rtxtMota.Size = new Size(290, 125);
            rtxtMota.TabIndex = 8;
            rtxtMota.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 20);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 9;
            label2.Text = "Thông tin cây cảnh:";
            // 
            // txtTenCay
            // 
            txtTenCay.Location = new Point(112, 371);
            txtTenCay.Name = "txtTenCay";
            txtTenCay.Size = new Size(290, 27);
            txtTenCay.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 481);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 12;
            label4.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 375);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 10;
            label3.Text = "Tên cây cảnh:";
            // 
            // picCayCanh
            // 
            picCayCanh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picCayCanh.BackgroundImage = Properties.Resources._default;
            picCayCanh.BackgroundImageLayout = ImageLayout.Zoom;
            picCayCanh.BorderStyle = BorderStyle.FixedSingle;
            picCayCanh.Location = new Point(10, 69);
            picCayCanh.Margin = new Padding(3, 4, 3, 4);
            picCayCanh.MaximumSize = new Size(392, 252);
            picCayCanh.MinimumSize = new Size(392, 252);
            picCayCanh.Name = "picCayCanh";
            picCayCanh.Size = new Size(392, 252);
            picCayCanh.TabIndex = 14;
            picCayCanh.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1227, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6, 7, 6, 7);
            panel3.Size = new Size(423, 855);
            panel3.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(btnReset);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(6, 767);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(411, 81);
            panel5.TabIndex = 13;
            // 
            // btnSua
            // 
            btnSua.Image = Properties.Resources.write;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(161, 16);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(10, 0, 10, 0);
            btnSua.Size = new Size(101, 51);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Image = Properties.Resources.add;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(10, 16);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(10, 0, 10, 0);
            btnThem.Size = new Size(101, 51);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnReset
            // 
            btnReset.Image = Properties.Resources.circular;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(304, 16);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 10, 0);
            btnReset.Size = new Size(101, 51);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // FormCayCanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 855);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCayCanh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cây cảnh";
            FormClosed += FormCayCanh_FormClosed;
            Load += FormCayCanh_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCayCanh).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCayCanh).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label btnXoa;
        private Label titleTable;
        private Panel panel6;
        private Panel panel2;
        private Panel panel8;
        private Button btnHuyTimKiem;
        private Button btnTimKiem;
        private TextBox txtTimkiem;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private PictureBox picCayCanh;
        private TextBox txtSoLuong;
        private Label label9;
        private TextBox txtGiaBan;
        private Label label8;
        private TextBox txtTuoi;
        private Label label7;
        private TextBox txtMauSac;
        private Label label6;
        private ComboBox cbbLoaiCay;
        private Label label5;
        private Panel panel7;
        private RichTextBox rtxtMota;
        private Label label2;
        private TextBox txtTenCay;
        private Label label4;
        private Label label3;
        private Button btnChangeImage;
        private OpenFileDialog ofd;
        private TextBox txtKichThuoc;
        private Label label10;
        private DataGridView dgvCayCanh;
        private Panel panel9;
        private Button btnTaoHoaDon;
        private Button button1;
        private Panel panel5;
        private Button btnSua;
        private Button btnThem;
        private Button btnReset;
        private Label txtSoLuongDaChon;
        private DataGridViewImageColumn anh;
        private DataGridViewTextBoxColumn idCayCanh;
        private DataGridViewTextBoxColumn tenCayCanh;
        private DataGridViewTextBoxColumn tenLoaicay;
        private DataGridViewTextBoxColumn idLoaiCay;
        private DataGridViewTextBoxColumn moTa;
        private DataGridViewTextBoxColumn tuoi;
        private DataGridViewTextBoxColumn mauSac;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewTextBoxColumn gia;
        private DataGridViewTextBoxColumn kichThuoc;
        private DataGridViewImageColumn delete;
        private DataGridViewCheckBoxColumn selected;
        private DataGridViewTextBoxColumn pathAnh;
    }
}