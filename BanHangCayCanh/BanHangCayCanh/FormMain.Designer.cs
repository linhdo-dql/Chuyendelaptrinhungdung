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
            panelTaiKhoan = new Panel();
            panel = new Panel();
            panelDangNhap = new Panel();
            linkLabel1 = new LinkLabel();
            radioButton1 = new RadioButton();
            btnDangNhap = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelTaiKhoan.SuspendLayout();
            panel.SuspendLayout();
            panelDangNhap.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDM, menuBH, menuBC });
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
            // panelTaiKhoan
            // 
            panelTaiKhoan.BackColor = Color.Transparent;
            panelTaiKhoan.Controls.Add(panel);
            panelTaiKhoan.Dock = DockStyle.Fill;
            panelTaiKhoan.Location = new Point(0, 36);
            panelTaiKhoan.Name = "panelTaiKhoan";
            panelTaiKhoan.Padding = new Padding(90, 50, 90, 50);
            panelTaiKhoan.Size = new Size(610, 339);
            panelTaiKhoan.TabIndex = 1;
            // 
            // panel
            // 
            panel.CausesValidation = false;
            panel.Controls.Add(panelDangNhap);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(90, 50);
            panel.Name = "panel";
            panel.Size = new Size(430, 239);
            panel.TabIndex = 0;
            // 
            // panelDangNhap
            // 
            panelDangNhap.BackColor = Color.Transparent;
            panelDangNhap.Controls.Add(linkLabel1);
            panelDangNhap.Controls.Add(radioButton1);
            panelDangNhap.Controls.Add(btnDangNhap);
            panelDangNhap.Controls.Add(textBox1);
            panelDangNhap.Controls.Add(label3);
            panelDangNhap.Controls.Add(comboBox1);
            panelDangNhap.Controls.Add(label2);
            panelDangNhap.Controls.Add(label1);
            panelDangNhap.Dock = DockStyle.Fill;
            panelDangNhap.ForeColor = SystemColors.ActiveCaptionText;
            panelDangNhap.Location = new Point(0, 0);
            panelDangNhap.Name = "panelDangNhap";
            panelDangNhap.Size = new Size(430, 239);
            panelDangNhap.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = SystemColors.ButtonHighlight;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(144, 210);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Thêm tài khoản mới";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(54, 171);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Lưu đăng nhập";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(198, 166);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(173, 35);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 27);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(54, 124);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = " Mật khẩu:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(164, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(54, 75);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = " Mã nhân viên:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(144, 10);
            label1.Name = "label1";
            label1.Size = new Size(161, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cửa hàng cây cảnh LinhBonsai";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelTaiKhoan.ResumeLayout(false);
            panel.ResumeLayout(false);
            panelDangNhap.ResumeLayout(false);
            panelDangNhap.PerformLayout();
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
        private Panel panelTaiKhoan;
        private Panel panel;
        private Panel panelDangNhap;
        private LinkLabel linkLabel1;
        private RadioButton radioButton1;
        private Button btnDangNhap;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
    }
}