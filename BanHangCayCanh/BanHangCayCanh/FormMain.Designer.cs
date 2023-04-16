namespace BanHangCayCanh
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip1 = new MenuStrip();
            menuDM = new ToolStripMenuItem();
            menuCC = new ToolStripMenuItem();
            menuLCC = new ToolStripMenuItem();
            menuNV = new ToolStripMenuItem();
            menuKH = new ToolStripMenuItem();
            menuBH = new ToolStripMenuItem();
            menuBC = new ToolStripMenuItem();
            menuTK = new ToolStripMenuItem();
            menuDX = new ToolStripMenuItem();
            panel = new Panel();
            panelDangNhap = new Panel();
            label5 = new Label();
            label4 = new Label();
            btnShowHidePass = new Label();
            lkTaoTaiKhoan = new LinkLabel();
            rbSaveLogined = new RadioButton();
            btnDangNhap = new Button();
            txtMatKhauDangNhap = new TextBox();
            label3 = new Label();
            cbbMaNVDangNhap = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panelTaiKhoan = new Panel();
            panelTaoTaiKhoan = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMatKhauNhapLai = new TextBox();
            label9 = new Label();
            btnShowHidePassDangKy = new Label();
            lkQuayLaiDangNhap = new LinkLabel();
            btnTaoTaiKhoan = new Button();
            txtMatKhauDangKy = new TextBox();
            label19 = new Label();
            cbbMaNVDangKy = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox2 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            textBox1 = new TextBox();
            label16 = new Label();
            comboBox1 = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            menuStrip1.SuspendLayout();
            panel.SuspendLayout();
            panelDangNhap.SuspendLayout();
            panelTaiKhoan.SuspendLayout();
            panelTaoTaiKhoan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDM, menuBH, menuBC, menuTK });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(610, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.Visible = false;
            // 
            // menuDM
            // 
            menuDM.DropDownItems.AddRange(new ToolStripItem[] { menuCC, menuLCC, menuNV, menuKH });
            menuDM.Name = "menuDM";
            menuDM.Size = new Size(90, 30);
            menuDM.Text = "Danh mục";
            // 
            // menuCC
            // 
            menuCC.Name = "menuCC";
            menuCC.ShortcutKeys = Keys.Shift | Keys.F1;
            menuCC.Size = new Size(245, 26);
            menuCC.Text = "Cây cảnh";
            menuCC.Click += menuCC_Click;
            // 
            // menuLCC
            // 
            menuLCC.Name = "menuLCC";
            menuLCC.ShortcutKeys = Keys.Shift | Keys.F2;
            menuLCC.Size = new Size(245, 26);
            menuLCC.Text = "Loại cây cảnh";
            menuLCC.Click += menuLCC_Click;
            // 
            // menuNV
            // 
            menuNV.Name = "menuNV";
            menuNV.ShortcutKeys = Keys.Shift | Keys.F3;
            menuNV.Size = new Size(245, 26);
            menuNV.Text = "Nhân viên";
            // 
            // menuKH
            // 
            menuKH.Name = "menuKH";
            menuKH.ShortcutKeys = Keys.Shift | Keys.F4;
            menuKH.Size = new Size(245, 26);
            menuKH.Text = "Khách hàng";
            // 
            // menuBH
            // 
            menuBH.Name = "menuBH";
            menuBH.ShortcutKeys = Keys.Shift | Keys.F5;
            menuBH.Size = new Size(85, 30);
            menuBH.Text = "Bán hàng";
            menuBH.Click += menuBH_Click;
            // 
            // menuBC
            // 
            menuBC.Name = "menuBC";
            menuBC.ShortcutKeys = Keys.Shift | Keys.F10;
            menuBC.Size = new Size(77, 30);
            menuBC.Text = "Báo cáo";
            // 
            // menuTK
            // 
            menuTK.DropDownItems.AddRange(new ToolStripItem[] { menuDX });
            menuTK.Name = "menuTK";
            menuTK.Size = new Size(129, 30);
            menuTK.Text = "Tài khoản: nv_00";
            // 
            // menuDX
            // 
            menuDX.AutoSize = false;
            menuDX.AutoToolTip = true;
            menuDX.Name = "menuDX";
            menuDX.RightToLeft = RightToLeft.No;
            menuDX.RightToLeftAutoMirrorImage = true;
            menuDX.Size = new Size(223, 26);
            menuDX.Text = "Đăng xuất";
            menuDX.Click += menuDX_Click;
            // 
            // panel
            // 
            panel.CausesValidation = false;
            panel.Controls.Add(panelDangNhap);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(90, 50);
            panel.Name = "panel";
            panel.Size = new Size(430, 275);
            panel.TabIndex = 0;
            // 
            // panelDangNhap
            // 
            panelDangNhap.BackColor = SystemColors.Control;
            panelDangNhap.BorderStyle = BorderStyle.FixedSingle;
            panelDangNhap.Controls.Add(label5);
            panelDangNhap.Controls.Add(label4);
            panelDangNhap.Controls.Add(btnShowHidePass);
            panelDangNhap.Controls.Add(lkTaoTaiKhoan);
            panelDangNhap.Controls.Add(rbSaveLogined);
            panelDangNhap.Controls.Add(btnDangNhap);
            panelDangNhap.Controls.Add(txtMatKhauDangNhap);
            panelDangNhap.Controls.Add(label3);
            panelDangNhap.Controls.Add(cbbMaNVDangNhap);
            panelDangNhap.Controls.Add(label2);
            panelDangNhap.Controls.Add(label1);
            panelDangNhap.Dock = DockStyle.Fill;
            panelDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            panelDangNhap.Location = new Point(0, 0);
            panelDangNhap.Name = "panelDangNhap";
            panelDangNhap.Size = new Size(430, 275);
            panelDangNhap.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(118, 119);
            label5.MaximumSize = new Size(10, 10);
            label5.MinimumSize = new Size(10, 10);
            label5.Name = "label5";
            label5.Size = new Size(10, 10);
            label5.TabIndex = 11;
            label5.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(145, 69);
            label4.MaximumSize = new Size(10, 10);
            label4.MinimumSize = new Size(10, 10);
            label4.Name = "label4";
            label4.Size = new Size(10, 10);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // btnShowHidePass
            // 
            btnShowHidePass.AutoSize = true;
            btnShowHidePass.ForeColor = Color.Lime;
            btnShowHidePass.Location = new Point(373, 124);
            btnShowHidePass.MaximumSize = new Size(40, 20);
            btnShowHidePass.MinimumSize = new Size(40, 20);
            btnShowHidePass.Name = "btnShowHidePass";
            btnShowHidePass.Size = new Size(40, 20);
            btnShowHidePass.TabIndex = 9;
            btnShowHidePass.Text = "Hiện";
            btnShowHidePass.Click += btnShowHidePass_Click;
            // 
            // lkTaoTaiKhoan
            // 
            lkTaoTaiKhoan.AutoSize = true;
            lkTaoTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
            lkTaoTaiKhoan.LinkColor = Color.Black;
            lkTaoTaiKhoan.Location = new Point(135, 225);
            lkTaoTaiKhoan.Name = "lkTaoTaiKhoan";
            lkTaoTaiKhoan.Size = new Size(141, 20);
            lkTaoTaiKhoan.TabIndex = 8;
            lkTaoTaiKhoan.TabStop = true;
            lkTaoTaiKhoan.Text = "Thêm tài khoản mới";
            lkTaoTaiKhoan.LinkClicked += lkTaoTaiKhoan_LinkClicked_1;
            // 
            // rbSaveLogined
            // 
            rbSaveLogined.AutoSize = true;
            rbSaveLogined.ForeColor = SystemColors.ActiveCaptionText;
            rbSaveLogined.Location = new Point(56, 171);
            rbSaveLogined.Name = "rbSaveLogined";
            rbSaveLogined.Size = new Size(74, 24);
            rbSaveLogined.TabIndex = 7;
            rbSaveLogined.TabStop = true;
            rbSaveLogined.Text = "Lưu lại";
            rbSaveLogined.UseVisualStyleBackColor = true;
            rbSaveLogined.CheckedChanged += rbSaveLogined_CheckedChanged;
            rbSaveLogined.Click += rbSaveLogined_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(164, 166);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(207, 35);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhauDangNhap
            // 
            txtMatKhauDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauDangNhap.Location = new Point(164, 121);
            txtMatKhauDangNhap.MaximumSize = new Size(205, 30);
            txtMatKhauDangNhap.MinimumSize = new Size(205, 30);
            txtMatKhauDangNhap.Name = "txtMatKhauDangNhap";
            txtMatKhauDangNhap.PasswordChar = '*';
            txtMatKhauDangNhap.Size = new Size(205, 30);
            txtMatKhauDangNhap.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(54, 124);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbMaNVDangNhap
            // 
            cbbMaNVDangNhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaNVDangNhap.FormattingEnabled = true;
            cbbMaNVDangNhap.Location = new Point(164, 71);
            cbbMaNVDangNhap.Name = "cbbMaNVDangNhap";
            cbbMaNVDangNhap.Size = new Size(205, 31);
            cbbMaNVDangNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(54, 75);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(135, 10);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTaiKhoan
            // 
            panelTaiKhoan.BackColor = Color.Transparent;
            panelTaiKhoan.Controls.Add(panelTaoTaiKhoan);
            panelTaiKhoan.Controls.Add(panel);
            panelTaiKhoan.Dock = DockStyle.Fill;
            panelTaiKhoan.Location = new Point(0, 0);
            panelTaiKhoan.Name = "panelTaiKhoan";
            panelTaiKhoan.Padding = new Padding(90, 50, 90, 50);
            panelTaiKhoan.Size = new Size(610, 375);
            panelTaiKhoan.TabIndex = 1;
            // 
            // panelTaoTaiKhoan
            // 
            panelTaoTaiKhoan.BackColor = SystemColors.Control;
            panelTaoTaiKhoan.Controls.Add(panel1);
            panelTaoTaiKhoan.Controls.Add(label11);
            panelTaoTaiKhoan.Controls.Add(label12);
            panelTaoTaiKhoan.Controls.Add(label13);
            panelTaoTaiKhoan.Controls.Add(textBox2);
            panelTaoTaiKhoan.Controls.Add(label14);
            panelTaoTaiKhoan.Controls.Add(label15);
            panelTaoTaiKhoan.Controls.Add(linkLabel1);
            panelTaoTaiKhoan.Controls.Add(button2);
            panelTaoTaiKhoan.Controls.Add(textBox1);
            panelTaoTaiKhoan.Controls.Add(label16);
            panelTaoTaiKhoan.Controls.Add(comboBox1);
            panelTaoTaiKhoan.Controls.Add(label17);
            panelTaoTaiKhoan.Controls.Add(label18);
            panelTaoTaiKhoan.Dock = DockStyle.Fill;
            panelTaoTaiKhoan.ForeColor = SystemColors.ActiveCaptionText;
            panelTaoTaiKhoan.Location = new Point(90, 50);
            panelTaoTaiKhoan.Name = "panelTaoTaiKhoan";
            panelTaoTaiKhoan.Size = new Size(430, 275);
            panelTaoTaiKhoan.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtMatKhauNhapLai);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnShowHidePassDangKy);
            panel1.Controls.Add(lkQuayLaiDangNhap);
            panel1.Controls.Add(btnTaoTaiKhoan);
            panel1.Controls.Add(txtMatKhauDangKy);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(cbbMaNVDangKy);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(label21);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 275);
            panel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(176, 147);
            label6.MaximumSize = new Size(10, 10);
            label6.MinimumSize = new Size(10, 10);
            label6.Name = "label6";
            label6.Size = new Size(10, 10);
            label6.TabIndex = 14;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(118, 106);
            label7.MaximumSize = new Size(10, 10);
            label7.MinimumSize = new Size(10, 10);
            label7.Name = "label7";
            label7.Size = new Size(10, 10);
            label7.TabIndex = 13;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(143, 62);
            label8.MaximumSize = new Size(10, 10);
            label8.MinimumSize = new Size(10, 10);
            label8.Name = "label8";
            label8.Size = new Size(10, 10);
            label8.TabIndex = 12;
            label8.Text = "*";
            // 
            // txtMatKhauNhapLai
            // 
            txtMatKhauNhapLai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauNhapLai.Location = new Point(189, 148);
            txtMatKhauNhapLai.Name = "txtMatKhauNhapLai";
            txtMatKhauNhapLai.Size = new Size(180, 30);
            txtMatKhauNhapLai.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(54, 153);
            label9.Name = "label9";
            label9.Size = new Size(133, 20);
            label9.TabIndex = 10;
            label9.Text = "Nhập lại mật khẩu:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnShowHidePassDangKy
            // 
            btnShowHidePassDangKy.AutoSize = true;
            btnShowHidePassDangKy.ForeColor = Color.Lime;
            btnShowHidePassDangKy.Location = new Point(375, 111);
            btnShowHidePassDangKy.MaximumSize = new Size(40, 20);
            btnShowHidePassDangKy.MinimumSize = new Size(40, 20);
            btnShowHidePassDangKy.Name = "btnShowHidePassDangKy";
            btnShowHidePassDangKy.Size = new Size(40, 20);
            btnShowHidePassDangKy.TabIndex = 9;
            btnShowHidePassDangKy.Text = "Hiện";
            // 
            // lkQuayLaiDangNhap
            // 
            lkQuayLaiDangNhap.AutoSize = true;
            lkQuayLaiDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            lkQuayLaiDangNhap.LinkColor = Color.Black;
            lkQuayLaiDangNhap.Location = new Point(146, 245);
            lkQuayLaiDangNhap.Name = "lkQuayLaiDangNhap";
            lkQuayLaiDangNhap.Size = new Size(138, 20);
            lkQuayLaiDangNhap.TabIndex = 8;
            lkQuayLaiDangNhap.TabStop = true;
            lkQuayLaiDangNhap.Text = "Quay lại đăng nhập";
            lkQuayLaiDangNhap.LinkClicked += lkQuayLaiDangNhap_LinkClicked;
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.Location = new Point(56, 195);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(315, 35);
            btnTaoTaiKhoan.TabIndex = 6;
            btnTaoTaiKhoan.Text = "Tạo tài khoản";
            btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // txtMatKhauDangKy
            // 
            txtMatKhauDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhauDangKy.Location = new Point(189, 106);
            txtMatKhauDangKy.Name = "txtMatKhauDangKy";
            txtMatKhauDangKy.Size = new Size(180, 30);
            txtMatKhauDangKy.TabIndex = 5;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = SystemColors.ActiveCaptionText;
            label19.Location = new Point(54, 111);
            label19.Name = "label19";
            label19.Size = new Size(73, 20);
            label19.TabIndex = 3;
            label19.Text = "Mật khẩu:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbbMaNVDangKy
            // 
            cbbMaNVDangKy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaNVDangKy.FormattingEnabled = true;
            cbbMaNVDangKy.Location = new Point(189, 63);
            cbbMaNVDangKy.Name = "cbbMaNVDangKy";
            cbbMaNVDangKy.Size = new Size(180, 31);
            cbbMaNVDangKy.TabIndex = 2;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(54, 68);
            label20.Name = "label20";
            label20.Size = new Size(100, 20);
            label20.TabIndex = 1;
            label20.Text = "Mã nhân viên:";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ActiveCaptionText;
            label21.Location = new Point(117, 10);
            label21.Name = "label21";
            label21.Size = new Size(197, 38);
            label21.TabIndex = 0;
            label21.Text = "Tạo tài khoản";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(176, 139);
            label11.MaximumSize = new Size(10, 10);
            label11.MinimumSize = new Size(10, 10);
            label11.Name = "label11";
            label11.Size = new Size(10, 10);
            label11.TabIndex = 14;
            label11.Text = "*";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(118, 98);
            label12.MaximumSize = new Size(10, 10);
            label12.MinimumSize = new Size(10, 10);
            label12.Name = "label12";
            label12.Size = new Size(10, 10);
            label12.TabIndex = 13;
            label12.Text = "*";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(143, 54);
            label13.MaximumSize = new Size(10, 10);
            label13.MinimumSize = new Size(10, 10);
            label13.Name = "label13";
            label13.Size = new Size(10, 10);
            label13.TabIndex = 12;
            label13.Text = "*";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(189, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 30);
            textBox2.TabIndex = 11;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ActiveCaptionText;
            label14.Location = new Point(54, 145);
            label14.Name = "label14";
            label14.Size = new Size(133, 20);
            label14.TabIndex = 10;
            label14.Text = "Nhập lại mật khẩu:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Lime;
            label15.Location = new Point(375, 103);
            label15.MaximumSize = new Size(40, 20);
            label15.MinimumSize = new Size(40, 20);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 9;
            label15.Text = "Hiện";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = SystemColors.ActiveCaptionText;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(146, 245);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(138, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quay lại đăng nhập";
            // 
            // button2
            // 
            button2.Location = new Point(56, 187);
            button2.Name = "button2";
            button2.Size = new Size(315, 35);
            button2.TabIndex = 6;
            button2.Text = "Tạo tài khoản";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(189, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 30);
            textBox1.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(54, 103);
            label16.Name = "label16";
            label16.Size = new Size(73, 20);
            label16.TabIndex = 3;
            label16.Text = "Mật khẩu:";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 31);
            comboBox1.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ActiveCaptionText;
            label17.Location = new Point(54, 60);
            label17.Name = "label17";
            label17.Size = new Size(100, 20);
            label17.TabIndex = 1;
            label17.Text = "Mã nhân viên:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ActiveCaptionText;
            label18.Location = new Point(117, 10);
            label18.Name = "label18";
            label18.Size = new Size(197, 38);
            label18.TabIndex = 0;
            label18.Text = "Tạo tài khoản";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.LinhBonsai;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(610, 375);
            Controls.Add(panelTaiKhoan);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cửa hàng cây cảnh LinhBonsai";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel.ResumeLayout(false);
            panelDangNhap.ResumeLayout(false);
            panelDangNhap.PerformLayout();
            panelTaiKhoan.ResumeLayout(false);
            panelTaoTaiKhoan.ResumeLayout(false);
            panelTaoTaiKhoan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDM;
        private ToolStripMenuItem menuCC;
        private ToolStripMenuItem menuLCC;
        private ToolStripMenuItem menuNV;
        private ToolStripMenuItem menuKH;
        private ToolStripMenuItem menuBH;
        private ToolStripMenuItem menuBC;
        private Panel panel;
        private Panel panelDangNhap;
        private Label btnShowHidePass;
        private LinkLabel lkTaoTaiKhoan;
        private RadioButton rbSaveLogined;
        private Button btnDangNhap;
        private TextBox txtMatKhauDangNhap;
        private Label label3;
        private ComboBox cbbMaNVDangNhap;
        private Label label2;
        private Label label1;
        private Panel panelTaiKhoan;
        private Label label5;
        private Label label4;
        private Panel panelTaoTaiKhoan;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMatKhauNhapLai;
        private Label label9;
        private Label btnShowHidePassDangKy;
        private LinkLabel lkQuayLaiDangNhap;
        private Button btnTaoTaiKhoan;
        private TextBox txtMatKhauDangKy;
        private Label label19;
        private ComboBox cbbMaNVDangKy;
        private Label label20;
        private Label label21;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox2;
        private Label label14;
        private Label label15;
        private LinkLabel linkLabel1;
        private Button button2;
        private TextBox textBox1;
        private Label label16;
        private ComboBox comboBox1;
        private Label label17;
        private Label label18;
        private ToolStripMenuItem menuTK;
        private ToolStripMenuItem menuDX;
    }
}