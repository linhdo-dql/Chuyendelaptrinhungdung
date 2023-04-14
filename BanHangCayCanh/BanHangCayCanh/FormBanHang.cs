using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class FormBanHang : Form
    {
        private DataTable dtHoaDon;
        private string currentIdHoaDon;
        private DataTable dtCTHD;
        private string? currentIdCTHD;

        public FormBanHang()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvCTHD.AutoGenerateColumns = false;
            LoadDataGridViewBill();
            LoadCBBItems();
            LoadCBBStaff();
            LoadCBBCustormer();
        }

        private void LoadDataGridViewBill()
        {
            dtHoaDon = Data.GetDataToTable("Select * from HoaDon");
            dgvHoaDon.DataSource = dtHoaDon;
            BindingDataGridViewUI();
        }

        private void LoadCBBStaff()
        {
            string sql = "Select * from NhanVien";
            Data.FillCombo(sql, cbbNhanVien, "idNhanVien", "idNhanVien");
            cbbNhanVien.Text = "";
        }

        private void LoadCBBCustormer()
        {
            string sql = "Select * from KhachHang";
            Data.FillCombo(sql, cbbKhachHang, "idKH", "tenKH");
            cbbKhachHang.Text = "";
        }
        private void LoadCBBItems()
        {
            string sql = "Select * from CayCanh";
            Data.FillCombo(sql, cbbTenCay, "idCayCanh", "tenCay");
            cbbTenCay.SelectedIndex = 0;
        }
        private void BindingDataGridViewUI()
        {
            btnXoa.Visible = false;
            dgvHoaDon.Columns["idHoaDonAll"].DataPropertyName = "idHoaDon";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["idNhanVien"].DataPropertyName = "idNhanVien";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["ngayLap"].DataPropertyName = "ngayLap";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["idKhachHang"].DataPropertyName = "idKH";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["chietKhau"].DataPropertyName = "chietKhau";//Binding dữ liệu vào các cột
            dgvHoaDon.Columns["tongTien"].DataPropertyName = "tongTien";//Binding dữ liệu vào các cột
            dgvHoaDon.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvHoaDon.ClearSelection();
        }

        private void FormBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMain().Show();
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            if (dtHoaDon.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            /* if (txtTenCay.Text != "")
             {
                 DialogResult r = MessageBox.Show("Bạn đang ở chế độ thêm mới hoặc chỉnh sửa. Bạn có muốn hủy dữ liệu vừa nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                 if (r.Equals(DialogResult.Yes))
                 {
                   
                     txtTenCay.Text = dgvCayCanh.CurrentRow.Cells["tenCay"].Value.ToString();
                     rtxtMota.Text = dgvCayCanh.CurrentRow.Cells["moTa"].Value.ToString();
                 }
                 return;
             }
             else
             {*/
            currentIdHoaDon = dgvHoaDon.CurrentRow.Cells["idHoaDonAll"].Value.ToString();
            cbbNhanVien.Text = dgvHoaDon.CurrentRow.Cells["idNhanVien"].Value.ToString();
            DataRow dr = Data.GetPropertiesById("KhachHang", "idKH", dgvHoaDon.CurrentRow.Cells["idKhachHang"].Value.ToString()).Rows[0];
            cbbKhachHang.Text = dr["tenKH"].ToString();
            txtDiaChiKH.Text = dr["diaChiKH"].ToString();
            txtSDT.Text = dr["sdtKH"].ToString();
            dtpNgayLap.Value = DateTime.Parse(dgvHoaDon.CurrentRow.Cells["ngayLap"].Value.ToString());
            txtGiamGia.Text = dgvHoaDon.CurrentRow.Cells["chietKhau"].Value.ToString();
            txtTongTien.Text = dgvHoaDon.CurrentRow.Cells["tongTien"].Value.ToString();
            LoadDataGridViewBillDetail();
            ResetTongTien();
            // }
        }

        private void LoadDataGridViewBillDetail()
        {
            dtCTHD = Data.GetDataToTable("Select * from ChiTietHoaDon where idHoaDon like N'" + currentIdHoaDon + "'");
            dgvCTHD.DataSource = dtCTHD;
            BindingDataGridViewUIBillDetails();
        }

        private void BindingDataGridViewUIBillDetails()
        {
            dgvCTHD.Columns["idHoaDon"].DataPropertyName = "idHoaDon";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["idCTHD"].DataPropertyName = "idCTHD";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["idCay"].DataPropertyName = "idCayCanh";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["soLuong"].DataPropertyName = "soLuong";//Binding dữ liệu vào các cột
            dgvCTHD.Columns["donGia"].DataPropertyName = "donGia";
            LoadTenCay();
        }

        private void LoadTenCay()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                dgvCTHD.Rows[i].Cells["tenCay"].Value = Data.GetPropertiesById("CayCanh", "idCayCanh", dtCTHD.Rows[i]["idCayCanh"].ToString()).Rows[0]["tenCay"];
                dgvCTHD.Rows[i].Cells["thanhTien"].Value = (float.Parse(dgvCTHD.Rows[i].Cells["soLuong"].Value.ToString()) * float.Parse(dgvCTHD.Rows[i].Cells["donGia"].Value.ToString())) + "";
            }
            dgvCTHD.ClearSelection();
        }

        private void ResetTongTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                tong += float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString());
            }
            txtGiaCay.Text = tong + "";
            txtTongTien.Text = (tong - float.Parse(txtGiamGia.Text)) + "";
        }
        private void cbbTenCay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (panelSanPham.Visible)
            {
                DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", (sender as ComboBox).SelectedValue.ToString());
                txtGiaBan.Text = dt.Rows[0]["gia"].ToString();
                txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            }
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (panelSanPham.Visible)
            {
                txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            panelSanPham.Visible = true;
            btnXoaSP.Visible = false;
            btnSuaSP.Visible = false;
            btnThemSP.Visible = true;
            DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", cbbTenCay.SelectedValue.ToString());
            txtGiaBan.Text = dt.Rows[0]["gia"].ToString();
            txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            ResetFormSP();
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa cây cảnh này khỏi hóa đơn? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                DeleteItem();
                ResetTongTien();
            }
        }

        private void DeleteItem()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentIdCTHD))
                {
                    dgvCTHD.Rows.Remove(dgvCTHD.Rows[i]);
                }
            }
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                dgvCTHD.Rows[i].Cells["idCTHD"].Value = "cthd_" + (i < 10 ? "0" + i : i);
            }
            ResetFormSP();
            panelSanPham.Visible = false;
        }

        private void btnResetFormHoaDon_Click(object sender, EventArgs e)
        {
            ResetDialog();
        }

        private void ResetDialog()
        {
            dgvCTHD.ClearSelection();
            cbbNhanVien.Text = "";
            cbbKhachHang.Text = "";
            txtDiaChiKH.Text = "";
            txtSDT.Text = "";
            ResetFormSP();
            panelSanPham.Visible = false;
        }
        private void dgvCTHD_Click(object sender, EventArgs e)
        {
            currentIdCTHD = dgvCTHD.CurrentRow.Cells["idCTHD"].Value.ToString();
            cbbTenCay.Text = dgvCTHD.CurrentRow.Cells["tenCay"].Value.ToString();
            nudSoLuong.Value = int.Parse(dgvCTHD.CurrentRow.Cells["soLuong"].Value.ToString());
            txtGiaBan.Text = dgvCTHD.CurrentRow.Cells["donGia"].Value.ToString();
            txtThanhTien.Text = (int.Parse(nudSoLuong.Value.ToString()) * float.Parse(txtGiaBan.Text)) + "";
            btnXoaSP.Visible = true;
            btnSuaSP.Visible = true;
            btnThemSP.Visible = false;
            panelSanPham.Visible = true;
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentIdCTHD))
                {
                    dgvCTHD.Rows[i].Cells["idCay"].Value = cbbTenCay.SelectedValue;
                    dgvCTHD.Rows[i].Cells["tenCay"].Value = cbbTenCay.Text;
                    dgvCTHD.Rows[i].Cells["soLuong"].Value = nudSoLuong.Value;
                    dgvCTHD.Rows[i].Cells["donGia"].Value = txtGiaBan.Text;
                    dgvCTHD.Rows[i].Cells["thanhTien"].Value = txtThanhTien.Text;
                    break;
                }
            }
            ResetTongTien();
            panelSanPham.Visible = false;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (IsHavedItems())
            {
                DialogResult r = MessageBox.Show("Đã có cây cảnh này trong danh sách! Bạn có muốn tăng số lượng của cây trong danh sách hiện có?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    float newTotal = float.Parse(txtGiaBan.Text) * int.Parse(nudSoLuong.Value.ToString());
                    for (int i = 0; i < dgvCTHD.Rows.Count; i++)
                    {
                        if (dgvCTHD.Rows[i].Cells["idCay"].Value.ToString().Equals(cbbTenCay.SelectedValue))
                        {
                            int newAmount = (int)(int.Parse(dgvCTHD.Rows[i].Cells["soLuong"].Value.ToString()) + nudSoLuong.Value);
                            dgvCTHD.Rows[i].Cells["soLuong"].Value = newAmount;
                            float newValue = float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString()) + newTotal;
                            dgvCTHD.Rows[i].Cells["thanhTien"].Value = newValue;
                            UpdateAmount(dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString(), newAmount);
                            break;
                        }

                    }
                }
                else
                {
                    int maxId = Common.GetMaxId(dtCTHD, "idCTHD") + 1;
                    string sql = "Insert into ChiTietHoaDon VALUES (N'cthd_" + (maxId < 10 ? "0" + maxId : maxId) +
                    "',N'" + cbbTenCay.SelectedValue +
                    "',N'" + currentIdHoaDon +
                    "'," + nudSoLuong.Value +
                    "," + txtGiaBan.Text + ")";
                    Data.RunSQL(sql);
                }
            }
            else
            {
                int maxId = Common.GetMaxId(dtCTHD, "idCTHD") + 1;
                string sql = "Insert into ChiTietHoaDon VALUES (N'cthd_" + (maxId < 10 ? "0" + maxId : maxId) +
                "',N'" + cbbTenCay.SelectedValue +
                "',N'" + currentIdHoaDon +
                "'," + nudSoLuong.Value +
                "," + txtGiaBan.Text + ")";
                Data.RunSQL(sql);
            }
            ResetTongTien();
            LoadDataGridViewBillDetail();
            panelSanPham.Visible = false;

        }
        private void UpdateAmount(string? idCTHD, int newAmount)
        {
            string sql = "UPDATE ChiTietHoaDon SET soLuong=" + newAmount +
                   " Where idCTHD = N'" + idCTHD + "'";
            Data.RunSQL(sql);

        }
        private void UpdateDatabase()
        {
            string sql = "UPDATE ChiTietHoaDon SET soLuong=" + nudSoLuong.Value +
                   ", idCayCanh = N'" + cbbTenCay.SelectedValue.ToString() +
                   "', donGia=" + txtGiaBan.Text +
                   " Where idCTHD = N'" + currentIdCTHD + "'";
            Data.RunSQL(sql);
        }

        private void ResetFormSP()
        {
            cbbTenCay.SelectedIndex = 0;
            nudSoLuong.Value = 1;
        }

        private bool IsHavedItems()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                if (dgvCTHD.Rows[i].Cells["idCay"].Value.ToString().Equals(cbbTenCay.SelectedValue))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            DialogAddBill dialog = new DialogAddBill();
            this.Hide();
            dialog.IsFromFormCayCanh = false;
            dialog.ShowDialog();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
