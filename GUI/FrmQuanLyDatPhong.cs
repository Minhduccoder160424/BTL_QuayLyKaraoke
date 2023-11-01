using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FrmQuanLyDatPhong : Form
    {
        BLL_QuanLyDatPhong BLL = new BLL_QuanLyDatPhong();
        public FrmQuanLyDatPhong()
        {
            InitializeComponent();
        }
        void Disable()
        {
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            cbPhongDat.Enabled = false;
            cbNVPT.Enabled = false;
            dtpTimeDatPhong.Enabled = false;
        }
        void Enable()
        {
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            cbPhongDat.Enabled = true;
            cbNVPT.Enabled = true;
            dtpTimeDatPhong.Enabled = true;
        }
        private void FrmQuanLyDatPhong_Load(object sender, EventArgs e)
        {
            dgvPhongHat.DataSource = BLL.DuLieuDGVPhongHat();
            dgvCTPH.DataSource = BLL.DuLieuDGVDatPhongHat();

            cbPhongDat.DisplayMember = "TenPhong";
            cbPhongDat.ValueMember = "PhongHatID";
            cbPhongDat.DataSource = BLL.DuLieuComboboxPhongDat();

            cbNVPT.DisplayMember = "HoTenNV";
            cbNVPT.ValueMember = "NhanVienID";
            cbNVPT.DataSource = BLL.DuLieuComboboxNhanVien();

            btDel.Enabled = false;
            ckbKHTT.Enabled = false;

            dtpTimeDatPhong.Value = DateTime.Now;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var _KhachHang = BLL.TimKiemKhachHang(txtTenKH.Text, txtSDT.Text);
            if (_KhachHang == null)
            {
                KhachHang KH = new KhachHang();
                KH.KhachHangID = BLL.TaoKhachHangID();
                KH.TenKhachHang = txtTenKH.Text;
                KH.SoDienThoai = txtSDT.Text;
                if (ckbKHTT.Checked)
                {
                    KH.DoThanThiet = 1;
                }
                else
                {
                    KH.DoThanThiet = 0;
                }
                var LuaChon1 = MessageBox.Show("Khách hàng này chưa tồn tại trong hệ thống, bạn có muốn thêm khách hàng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (LuaChon1 == DialogResult.Yes)
                {
                    BLL.ThemKhachHang(KH);
                }
                _KhachHang = KH;
            }

            DatPhong DP = new DatPhong();

            DP.PhongHatID = cbPhongDat.SelectedValue.ToString();
            DP.TenPhong = cbPhongDat.Text;
            DP.KhachHangID = _KhachHang.KhachHangID;
            DP.NhanVienID = cbNVPT.SelectedValue.ToString();
            DP.ThoiGianDatPhong = dtpTimeDatPhong.Value.ToString();
            DP.TrangThaiPhong = 1;

            var LuaChon = MessageBox.Show("Bạn có muốn đặt phòng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (LuaChon == DialogResult.Yes)
            {
                if (!BLL.KiemTraPhongTrong(cbPhongDat.Text))
                {
                    BLL.ThemPhong(DP);
                    BLL.CapNhatTrangThaiPhong(DP.TenPhong, DP.TrangThaiPhong);

                    FrmQuanLyDatPhong_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Phòng này đã có người đặt !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private void btDel_Click(object sender, EventArgs e)
        {
            var LuaChon = MessageBox.Show("Bạn có muốn xoá phòng đã đặt này không ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (LuaChon != DialogResult.Yes)
            {
                btLamMoi_Click(sender, e);
            }
            else
            {
                BLL.CapNhatTrangThaiPhong(cbPhongDat.Text, 0);
                BLL.XoaPhong(cbPhongDat.SelectedValue.ToString());
                BLL.XoaMatHangCuaPhong(cbPhongDat.SelectedValue.ToString());

                Enable();
                FrmQuanLyDatPhong_Load(sender, e);
                btLamMoi_Click(sender, e);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            Enable();
            btDel.Enabled = false;
            btAdd.Enabled = true;

            txtTenKH.Text = string.Empty;
            txtSDT.Text = string.Empty;
            ckbKHTT.Checked = false;
            cbPhongDat.SelectedIndex = -1;
            cbNVPT.SelectedIndex = -1;
            dtpTimeDatPhong.Value = DateTime.Now;
        }

        private void dgvPhongHat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvPhongHat.Columns[0].HeaderText = "Tên phòng";
            dgvPhongHat.Columns[1].HeaderText = "Trạng thái phòng";
        }

        private void dgvCTPH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvCTPH.Columns[0].HeaderText = "Mã phòng";
            dgvCTPH.Columns[1].HeaderText = "Mã nhân viên";
            dgvCTPH.Columns[2].HeaderText = "Mã khách hàng";
            dgvCTPH.Columns[3].HeaderText = "Thời gian đặt phòng";
        }

        private void dgvCTPH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Disable();
                var TruyXuat = dgvCTPH.Rows[e.RowIndex].Cells;
                var KhachHang = BLL.LayThongTinKhachHang(TruyXuat[2].Value.ToString());
                txtTenKH.Text = KhachHang.TenKhachHang;
                txtSDT.Text = KhachHang.SoDienThoai;
                if (KhachHang.DoThanThiet == 0)
                {
                    ckbKHTT.Checked = false;
                }
                else
                {
                    ckbKHTT.Checked = true;
                }
                cbPhongDat.SelectedValue = TruyXuat[0].Value.ToString();
                dtpTimeDatPhong.Value = Convert.ToDateTime(TruyXuat[3].Value);
                cbNVPT.SelectedValue = TruyXuat[1].Value.ToString();

                btDel.Enabled = true;
                btAdd.Enabled = false;
            }
            catch
            {
                btLamMoi_Click(sender, e);
            }
        }
    }
}
