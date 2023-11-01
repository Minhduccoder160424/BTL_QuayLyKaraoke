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
using BLL;

namespace GUI
{
    public partial class FrmQuanLyKhachHang : Form
    {
        BLL_QuanLyKhachHang BLL = new BLL_QuanLyKhachHang();
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
            Disable();
        }

        private void FrmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvKH.DataSource = BLL.LayDuLieuKhachHang();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }
        void Disable()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            ckbDoThanThiet.Enabled = false;
            btXacNhan.Enabled = false;
        }
        void Enable()
        {
            txtMaKH.Enabled = true;
            txtTenKH.Enabled = true;
            txtSDT.Enabled = true;
            ckbDoThanThiet.Enabled = true;
            btXacNhan.Enabled = true;
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            FrmQuanLyKhachHang_Load(sender, e);
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btAdd.Enabled = true;
            Disable();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Enable();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang();
            KH.KhachHangID = txtMaKH.Text;
            KH.TenKhachHang = txtTenKH.Text;
            KH.SoDienThoai = txtSDT.Text;
            if (ckbDoThanThiet.Checked)
            {
                KH.DoThanThiet = 1;
            }
            else
            {
                KH.DoThanThiet = 0;
            }
            if (btXoa.Enabled == false && btSua.Enabled == false)
            {
                BLL.ThemDuLieu(KH);
                FrmQuanLyKhachHang_Load(sender, e);
            }
            if (btXoa.Enabled == false && btAdd.Enabled == false)
            {
                BLL.SuaDuLieu(KH);
                FrmQuanLyKhachHang_Load(sender, e);
            }
            Disable();
            
        }

        private void dgvKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvKH.Columns[0].HeaderText = "Mã khách hàng";
            dgvKH.Columns[1].HeaderText = "Tên khách hàng";
            dgvKH.Columns[2].HeaderText = "Số điện thoại";
            dgvKH.Columns[3].HeaderText = "Độ thân thiết";
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Disable();
                btXoa.Enabled = true;
                btSua.Enabled = true;
                btXacNhan.Enabled = false;
                if (e.RowIndex != -1)
                {
                    txtMaKH.Text = dgvKH.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtTenKH.Text = dgvKH.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSDT.Text = dgvKH.Rows[e.RowIndex].Cells[2].Value.ToString();
                    ckbDoThanThiet.Checked = Convert.ToBoolean(dgvKH.Rows[e.RowIndex].Cells[3].Value);
                }
                btAdd.Enabled = false;
            }
            catch
            {
                btLamMoi_Click(sender, e);
                FrmQuanLyKhachHang_Load(sender, e);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            btAdd.Enabled = false;
            btXoa.Enabled = false;
            Enable();   
            txtMaKH.Enabled = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang();
            KH.KhachHangID = txtMaKH.Text;
            BLL.XoaDuLieu(KH);
            FrmQuanLyKhachHang_Load(sender, e);
            btAdd.Enabled = true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            dgvKH.DataSource = BLL.TimKiemDuLieu(cbLoaiTK.Text, txtTimKiem.Text);
            dgvKH.Refresh();
        }
    }
}
