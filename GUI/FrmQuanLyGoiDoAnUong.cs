using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FrmQuanLyGoiDoAnUong : Form
    {
        BLL_QuanLyGoiDoAnUong BLL = new BLL_QuanLyGoiDoAnUong();
        public FrmQuanLyGoiDoAnUong()
        {
            InitializeComponent();
        }

        private void FrmQuanLyGoiDoAnUong_Load(object sender, EventArgs e)
        {
            cbChonMon.DataSource = BLL.DuLieuComboboxChonMon();
            cbChonMon.DisplayMember = "TenLoai";
            cbChonMon.ValueMember = "LoaiHangID";

            cbTenMon.DataSource = BLL.DuLieuComboboxTenMon(cbChonMon.SelectedValue.ToString());
            cbTenMon.DisplayMember = "TenMatHang";
            cbTenMon.ValueMember = "MatHangID";

            btUpdate.Enabled = false;
            btDel.Enabled = false;

            cbPhong.DataSource = BLL.DuLieuComboboxPhong();
            cbPhong.DisplayMember = "TenPhong";
            cbPhong.ValueMember = "PhongHatID";
        }

        private void cbChonMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTenMon.DataSource = BLL.DuLieuComboboxTenMon(cbChonMon.SelectedValue.ToString());
            cbTenMon.DisplayMember = "TenMatHang";
            cbTenMon.ValueMember = "MatHangID";
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            btUpdate.Enabled = false;
            btDel.Enabled = false;
            btAdd.Enabled = true;

            txtSoLuong.Text = string.Empty;

            dgvMonDaGoi.DataSource = BLL.DuLieuDGVMatHangMua(cbPhong.SelectedValue.ToString());
            dgvMonDaGoi.Refresh();
        }

        private void dgvMonDaGoi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvMonDaGoi.Columns[0].HeaderText = "Tên loại";
            dgvMonDaGoi.Columns[1].HeaderText = "Tên mặt hàng";
            dgvMonDaGoi.Columns[2].HeaderText = "Đơn vị tính";
            dgvMonDaGoi.Columns[3].HeaderText = "Số lượng bán";
        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMonDaGoi.DataSource = BLL.DuLieuDGVMatHangMua(cbPhong.SelectedValue.ToString());
            dgvMonDaGoi.Refresh();
        }

        private void dgvMonDaGoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cbChonMon.Text = dgvMonDaGoi.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbTenMon.Text = dgvMonDaGoi.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvMonDaGoi.Rows[e.RowIndex].Cells[3].Value.ToString(); 

                btUpdate.Enabled = true;
                btDel.Enabled = true;
                btAdd.Enabled = false;
            }
            catch 
            {
                btLamMoi_Click(sender, e);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            MatHang MH = new MatHang();
            MH.SoLuongBan = int.Parse(txtSoLuong.Text);
            MH.KhachHangID = BLL.LayKhachHangID(cbPhong.Text);
            MessageBox.Show($"{MH.KhachHangID}", "Thông báo", MessageBoxButtons.OK);
            var LuaChon = MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (LuaChon != DialogResult.Yes)
            {
                btLamMoi_Click(sender, e);
            }
            else
            {
                BLL.SuaDuLieu(MH);
                btLamMoi_Click(sender, e);
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            MatHang MH = new MatHang();
            MH.KhachHangID = BLL.LayKhachHangID(cbPhong.Text);
            MH.MatHangID = cbTenMon.SelectedValue.ToString();
                MessageBox.Show($"{MH.KhachHangID} + {MH.MatHangID}");
            var LuaChon = MessageBox.Show("Bạn có muốn xoá mặt hàng này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (LuaChon != DialogResult.Yes)
            {  
                btLamMoi_Click(sender, e);
            }
            else
            {
                BLL.XoaDuLieu(MH);
                btLamMoi_Click(sender, e);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            MatHang MH = new MatHang();
            MH.MatHangID = cbTenMon.SelectedValue.ToString();
            MH.SoLuongBan = int.Parse(txtSoLuong.Text);
            MH.KhachHangID = BLL.LayKhachHangID(cbPhong.Text);
            MH.NhanVienID = BLL.LayNhanVienID(cbPhong.Text);
            var LuaChon = MessageBox.Show("Bạn có muốn thêm mặt hàng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (LuaChon != DialogResult.Yes)
            {
                MessageBox.Show($"{MH.KhachHangID} + {MH.NhanVienID}");
                btLamMoi_Click(sender, e);
            }
            else
            {
                BLL.ThemDuLieu(MH, cbPhong.SelectedValue.ToString());
                dgvMonDaGoi.Refresh();
                btLamMoi_Click(sender, e);
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
