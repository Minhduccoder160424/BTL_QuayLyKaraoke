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
    public partial class FrmQuanLyNhanVien : Form
    {
        BLL_QuanLyNhanVien BLL = new BLL_QuanLyNhanVien();
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.LayBangNhanVien();
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btXacNhan.Enabled = false;
            btAdd.Enabled = true;
            Disable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btUpdate.Enabled = false;
            btDelete.Enabled = false;
            btXacNhan.Enabled = true;
            Enable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoten.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            dtpNgaySinh.Value = Convert.ToDateTime("01/01/2000");
            rbtNam.Checked = false;
            rbtNu.Checked = false;       
            FrmQuanLyNhanVien_Load(sender, e);
            
        }
        void Disable()
        {
            txtMaNV.Enabled = false;
            txtHoten.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            dtpNgaySinh.Enabled = false;
            rbtNam.Enabled = false;
            rbtNu.Enabled = false;
        }
        void Enable()
        {
            txtMaNV.Enabled = true;
            txtHoten.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            dtpNgaySinh.Enabled = true;
            rbtNam.Enabled = true;
            rbtNu.Enabled = true;
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (btUpdate.Enabled == false && btDelete.Enabled == false)
            {
                NhanVien NV = new NhanVien();
                NV.NhanVienID = txtMaNV.Text;
                NV.HoTenNV = txtHoten.Text;
                NV.DiaChi = txtDiaChi.Text;
                NV.SoDienThoai = txtSDT.Text;
                if (rbtNam.Checked)
                {
                    NV.GioiTinhNV = "Nam";
                }
                if (rbtNu.Checked)
                {
                    NV.GioiTinhNV = "Nữ";
                }
                NV.NgaySinh = dtpNgaySinh.Value;
                BLL.ThemDuLieu(NV);
            }
            if (btDelete.Enabled == false && btAdd.Enabled == false)
            {
                NhanVien NV = new NhanVien();
                NV.NhanVienID = txtMaNV.Text;
                NV.HoTenNV = txtHoten.Text;
                NV.DiaChi = txtDiaChi.Text;
                NV.SoDienThoai = txtSDT.Text;
                if (rbtNam.Checked)
                {
                    NV.GioiTinhNV = "Nam";
                }
                if (rbtNu.Checked)
                {
                    NV.GioiTinhNV = "Nữ";
                }
                NV.NgaySinh = dtpNgaySinh.Value;
                BLL.SuaDuLieu(NV);
            }
            button2_Click(sender, e);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[1].Width = 225;
            dataGridView1.Columns[2].HeaderText = "Giới tính";
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "Địa chỉ";
            dataGridView1.Columns[4].Width = 300;
            dataGridView1.Columns[5].HeaderText = "Số điện thoại";
            dataGridView1.Columns[5].Width = 150;

            dataGridView1.RowTemplate.Height = 30;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Disable();
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
                btXacNhan.Enabled = false;
                if (e.RowIndex != -1)
                {
                    txtMaNV.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtHoten.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string GioiTinh = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    if (Equals(GioiTinh, "Nam"))
                    {
                        rbtNam.Checked = true;
                        rbtNu.Checked = false;
                    }
                    else
                    {
                        rbtNam.Checked = false;
                        rbtNu.Checked = true;
                    }
                    dtpNgaySinh.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtSDT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                }
                btAdd.Enabled = false;
            }
            catch
            {
                btDelete.Enabled = true;
                btUpdate.Enabled = true;
                button2_Click(sender, e);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Enable();
            txtMaNV.Enabled = false;
            btXacNhan.Enabled = true;
            btDelete.Enabled = false;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            NhanVien NV = new NhanVien();
            NV.NhanVienID = txtMaNV.Text;

            BLL.XoaDuLieu(NV);

            FrmQuanLyNhanVien_Load(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Họ và tên":
                    dataGridView1.DataSource = BLL.TimKiemDuLieu("HoTenNV", textBox7.Text);
                    break;
                case "Địa chỉ":
                    dataGridView1.DataSource = BLL.TimKiemDuLieu("DiaChi", textBox7.Text);
                    break;
            }
        }
    }
}