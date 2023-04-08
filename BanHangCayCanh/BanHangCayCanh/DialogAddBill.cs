using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangCayCanh
{
    public partial class DialogAddBill : Form
    {
        public bool IsFromFormCayCanh { get; set; }

        private DataTable dtNewCTHD;
        private string currentId;
        public string currentIdHoaDon;

        public DialogAddBill()
        {
            InitializeComponent();
        }
        private void DialogAddBill_Load(object sender, EventArgs e)
        {
            LoadCBBCustormer();
            LoadCBBStaff();
            LoadCBBItems();
            if (IsFromFormCayCanh)
            {
                LoadDataGridView(FormCayCanh.ListIdSelecteds);
            }
        }

        private void LoadDataGridView(List<string> listIdSelecteds)
        {
            int maxId = (Common.GetMaxId(Data.GetDataToTable("Select * from HoaDon"), "idHoaDon") + 1);
            currentIdHoaDon = "hd_" + (maxId < 10 ? "0" + maxId : maxId);
            int startId = Common.GetMaxId(Data.GetDataToTable("Select * from ChiTietHoaDon"), "idCTHD") + 1;
            float tong = 0;
            if (listIdSelecteds != null)
            {
                for (int i = 0; i < listIdSelecteds.Count; i++)
                {
                    DataTable dt = Data.GetPropertiesById("CayCanh", "idCayCanh", listIdSelecteds[i]);
                    tong += float.Parse(dt.Rows[0]["gia"].ToString());
                    int newID = startId + i;
                    string newIdCTHD = "cthd_" + (newID < 10 ? "0" + newID : newID);
                    AddRowToDataGridView(dt, newIdCTHD, currentIdHoaDon);
                }
            }
            txtTongTien.Text = tong + "";
            dgvCTHD.ClearSelection();

        }

        private void AddRowToDataGridView(DataTable dt, string idCTHD, string idHoaDon)
        {
            var index = dgvCTHD.Rows.Add();
            DataGridViewRow dr = dgvCTHD.Rows[index];
            dr.Cells["idCTHD"].Value = idCTHD;
            dr.Cells["idHoaDon"].Value = idHoaDon;
            dr.Cells["idCay"].Value = dt.Rows[0]["idCayCanh"];
            dr.Cells["soLuong"].Value = 1;
            dr.Cells["donGia"].Value = dt.Rows[0]["gia"];
            dr.Cells["tenCay"].Value = dt.Rows[0]["tenCay"];
            dr.Cells["thanhTien"].Value = float.Parse(dt.Rows[0]["gia"].ToString());
        }

        private void LoadCBBItems()
        {
            string sql = "Select * from CayCanh";
            Data.FillCombo(sql, cbbTenCay, "idCayCanh", "tenCay");
            cbbTenCay.SelectedIndex = 0;
        }

        private void LoadCBBStaff()
        {
            string sql = "Select * from NhanVien";
            Data.FillCombo(sql, cbbNhanVien, "idNhanVien", "idNhanVien");
        }

        private void LoadCBBCustormer()
        {
            string sql = "Select * from KhachHang";
            Data.FillCombo(sql, cbbKhachHang, "idKH", "tenKH");
        }

        private void LoadInfoCustormer(string id)
        {
            DataTable dt = Data.GetPropertiesById("KhachHang", "idKH", id);
            if (dt.Rows.Count > 0)
            {
                txtSDT.Text = dt.Rows[0]["sdtKH"].ToString();
                txtDiaChiKH.Text = dt.Rows[0]["diaChiKH"].ToString();
            }
        }

        private void cbbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox? combo = sender as ComboBox;
            LoadInfoCustormer(combo.SelectedValue.ToString());
        }

        private void DialogAddBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormCayCanh().Show();
        }

        private void dgvCTHD_Click(object sender, EventArgs e)
        {
            currentId = dgvCTHD.CurrentRow.Cells["idCTHD"].Value.ToString();
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
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentId))
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
                            dgvCTHD.Rows[i].Cells["thanhTien"].Value = float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString()) + newTotal;
                            break;
                        }
                    }
                }
                else
                {
                    var index = dgvCTHD.Rows.Add();
                    DataGridViewRow dr = dgvCTHD.Rows[index];
                    int idCTHD = (Common.GetNumberOfId(dgvCTHD.Rows[dgvCTHD.Rows.Count - 2].Cells["idCTHD"].Value.ToString()) + 1);
                    dr.Cells["idCTHD"].Value = "cthd_" + (idCTHD < 10 ? "0" + idCTHD : idCTHD);
                    dr.Cells["idHoaDon"].Value = idHoaDon;
                    dr.Cells["idCay"].Value = cbbTenCay.SelectedValue;
                    dr.Cells["soLuong"].Value = nudSoLuong.Value;
                    dr.Cells["donGia"].Value = txtGiaBan.Text;
                    dr.Cells["tenCay"].Value = cbbTenCay.Text;
                    dr.Cells["thanhTien"].Value = txtThanhTien.Text;
                }
            }
            else
            {
                var index = dgvCTHD.Rows.Add();
                DataGridViewRow dr = dgvCTHD.Rows[index];
                int idCTHD = (Common.GetNumberOfId(dgvCTHD.Rows[dgvCTHD.Rows.Count - 2].Cells["idCTHD"].Value.ToString()) + 1);
                dr.Cells["idCTHD"].Value = "cthd_" + (idCTHD < 10 ? "0" + idCTHD : idCTHD);
                dr.Cells["idHoaDon"].Value = idHoaDon;
                dr.Cells["idCay"].Value = cbbTenCay.SelectedValue;
                dr.Cells["soLuong"].Value = nudSoLuong.Value;
                dr.Cells["donGia"].Value = txtGiaBan.Text;
                dr.Cells["tenCay"].Value = cbbTenCay.Text;
                dr.Cells["thanhTien"].Value = txtThanhTien.Text;
            }
            ResetTongTien();
            panelSanPham.Visible = false;

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

        private void btnClosePanelSP_Click(object sender, EventArgs e)
        {
            panelSanPham.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

        private void ResetTongTien()
        {
            float tong = 0;
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                tong += float.Parse(dgvCTHD.Rows[i].Cells["thanhTien"].Value.ToString());
            }
            txtTongTien.Text = (tong - float.Parse(txtGiamGia.Text)) + "";
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex("^[0-9]+$");
            if (float.Parse(txtTongTien.Text) < 0 || !regex.IsMatch(txtGiamGia.Text))
            {
                MessageBox.Show("Chiết khấu không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGiamGia.Text = "0";
                ResetTongTien();
                return;
            }
            ResetTongTien();
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
                if (dgvCTHD.Rows[i].Cells["idCTHD"].Value.ToString().Equals(currentId))
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

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            InsertHoaDon();
            InsertCTHD();
        }

        private void InsertCTHD()
        {
            for (int i = 0; i < dgvCTHD.Rows.Count; i++)
            {
                string sql = "Insert into ChiTietHoaDon VALUES (N'" + dgvCTHD.Rows[i].Cells["idCTHD"].Value +
                  "',N'" + dgvCTHD.Rows[i].Cells["idCay"].Value +
                  "',N'" + currentIdHoaDon +
                  "'," + dgvCTHD.Rows[i].Cells["soLuong"].Value +
                  "," + dgvCTHD.Rows[i].Cells["donGia"].Value + ")";
                Data.RunSQL(sql);
            }
            MessageBox.Show("Tạo hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void InsertHoaDon()
        {
            string sql; //Lưu câu lệnh sql
            if (dgvCTHD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn cây cảnh nào trong hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbbKhachHang.Text == "") //nếu chưa chọn khách hàng
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "Insert into HoaDon VALUES (N'" + currentIdHoaDon +
                  "',N'" + cbbNhanVien.SelectedValue +
                  "',N'" + dtpNgayLap.Text +
                  "',N'" + cbbKhachHang.SelectedValue +
                  "'," + txtGiamGia.Text +
                  "," + txtTongTien.Text + ")";
            Data.RunSQL(sql);
        }
    }

}
