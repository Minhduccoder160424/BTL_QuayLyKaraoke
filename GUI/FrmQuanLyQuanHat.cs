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

namespace GUI
{
    public partial class FrmQuanLyQuanHat : Form
    {
        BLL_QuanLyQuanHat BLL = new BLL_QuanLyQuanHat();
        string KhachHangID, NhanVienID;
        public FrmQuanLyQuanHat()
        {
            InitializeComponent();
        }

        private void FrmQuanLyQuanHat_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = BLL.DuLieuBangPhongHat();

            timer1.Start();

            lbTongTienTheoGio.Text = "0 đồng.";
            lbTongTienGoiMon.Text = "0 đồng.";
            lbTongTienThanhToan.Text = "0 đồng.";

            ckbPhongDat.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPhongDat.Checked)
            {
                dgvPhong.DataSource = BLL.DuLieuBangPhong();
                
                dgvPhong.Columns[0].HeaderText = "Tên phòng";
                dgvPhong.Columns[1].HeaderText = "Mã khách hàng";
                dgvPhong.Columns[2].HeaderText = "Mã nhân viên";
                dgvPhong.Columns[3].HeaderText = "Thời gian đặt phòng";
                dgvPhong.Columns[4].HeaderText = "Giá theo giờ";
                
                dgvPhong.Refresh();
            }
            else
            {
                dgvPhong.DataSource = BLL.DuLieuBangPhongHat();
                dgvPhong.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbTenNV.Text = string.Empty;
            lbTenKhachHang.Text = string.Empty;
            lbPhongDat.Text = string.Empty;
            lbThoiGianDatPhong.Text = string.Empty;
            lbTongTienTheoGio.Text = "0 đồng.";
            lbTongTienGoiMon.Text = "0 đồng.";
            lbTongTienThanhToan.Text = "0 đồng.";
            dgvMonDaGoi.Refresh();
            dgvPhong.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var LuaChon = MessageBox.Show("Bạn có muốn thanh toán phòng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (LuaChon != DialogResult.Yes)
            {
                timer1.Start();
                lbTongTienGoiMon.Refresh();
                lbTongTienTheoGio.Refresh();
                lbTongTienThanhToan.Refresh();
            }
            else
            {
                HoaDon HD = new HoaDon();
                HD.MaHD = BLL.TaoIDHoaDon();
                HD.NhanVienID = NhanVienID;
                HD.KhachHangID = KhachHangID;
                MessageBox.Show($"{HD.NhanVienID} + {HD.KhachHangID}");
                HD.NgayLapHD = DateTime.Now;
                HD.TongGiaTien = double.Parse(lbTongTienThanhToan.Text.Split(' ')[0].Trim());
                BLL.ThemHoaDon(HD);

                double SoGio = BLL.TinhSoGio(DateTime.Now, Convert.ToDateTime(lbThoiGianDatPhong.Text));
                BLL.ThemChiTietHoaDon(HD.MaHD, BLL.LayPhongHatID(lbPhongDat.Text), double.Parse(lbTongTienTheoGio.Text.Split(' ')[0].Trim()), SoGio);

                BLL.XoaDatPhongHat(BLL.LayPhongHatID(lbPhongDat.Text));
                BLL.XoaDonHangBan(BLL.LayPhongHatID(lbPhongDat.Text));

                BLL.CapNhatTrangThaiPhong(lbPhongDat.Text, 0);

                dgvMonDaGoi.DataSource = BLL.DuLieuBangMonDaGoi(BLL.LayPhongHatID(lbPhongDat.Text));
                dgvMonDaGoi.Refresh();

                FrmQuanLyQuanHat_Load(sender, e);

                button1_Click(sender, e);
            }
        }

        private void dgvPhong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ckbPhongDat.Checked)
            {
                
            }
            else
            {
                dgvPhong.Columns[0].HeaderText = "Mã phòng";
                dgvPhong.Columns[1].HeaderText = "Tên phòng";
                dgvPhong.Columns[2].HeaderText = "Trạng thái phòng";
            }

        }

        private void dgvMonDaGoi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvMonDaGoi.Columns[0].HeaderText = "Tên loại";
            dgvMonDaGoi.Columns[1].HeaderText = "Tên mặt hàng";
            dgvMonDaGoi.Columns[2].HeaderText = "Số lượng bán";
            dgvMonDaGoi.Columns[3].HeaderText = "Đơn giá bán";
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                var _Rows = dgvPhong.Rows[e.RowIndex];

                if (ckbPhongDat.Checked == true)
                {
                    KhachHangID = _Rows.Cells[1].Value.ToString();
                    NhanVienID = _Rows.Cells[2].Value.ToString();

                    NhanVien NV = BLL.LayNhanVien(_Rows.Cells[2].Value.ToString());
                    lbTenNV.Text = NV.HoTenNV;

                    KhachHang KH = BLL.LayKhachHang(_Rows.Cells[1].Value.ToString());
                    lbTenKhachHang.Text = KH.TenKhachHang;

                    lbPhongDat.Text = _Rows.Cells[0].Value.ToString();
                    lbThoiGianDatPhong.Text = _Rows.Cells[3].Value.ToString();

                    double TienTheoGio = Convert.ToDouble(_Rows.Cells[4].Value);

                    double SoGio = BLL.TinhSoGio(DateTime.Now, Convert.ToDateTime(lbThoiGianDatPhong.Text));

                    dgvMonDaGoi.DataSource = BLL.DuLieuBangMonDaGoi(BLL.LayPhongHatID(lbPhongDat.Text));
                    dgvMonDaGoi.Refresh();

                    double TongTienTheoGio = Math.Round(BLL.TinhSoTienPhong(SoGio, TienTheoGio), 0);
                    lbTongTienTheoGio.Text = $"{TongTienTheoGio} đồng.";
                    double TongTienGoiMon = BLL.TinhTongTienMatHang(BLL.LayPhongHatID(lbPhongDat.Text));
                    lbTongTienGoiMon.Text = $"{TongTienGoiMon} đồng.";
                    double TongTienThanhToan = BLL.TinhTongTienPhaiTra(TongTienTheoGio, TongTienGoiMon);
                    lbTongTienThanhToan.Text = $"{TongTienThanhToan} đồng.";

                }

            }
            catch
            {
                button1_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbThoiGianHoatDong.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }
    }
}
