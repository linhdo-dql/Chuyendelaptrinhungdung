namespace BanHangCayCanh
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            panelTaiKhoan.BackColor = Color.FromArgb(97, Color.Black);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Data.Connect();
        }

        private void menuLCC_Click(object sender, EventArgs e)
        {
            FormLoaiCayCanh formLoaiCayCanh = new FormLoaiCayCanh();
            this.Hide();
            formLoaiCayCanh.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuCC_Click(object sender, EventArgs e)
        {
            FormCayCanh formCayCanh = new FormCayCanh();
            this.Hide();
            formCayCanh.ShowDialog();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuBH_Click(object sender, EventArgs e)
        {
            FormBanHang formBanHang = new FormBanHang();
            this.Hide();
            formBanHang.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}