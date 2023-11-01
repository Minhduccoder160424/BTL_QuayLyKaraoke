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
    public partial class FrmDangNhap : Form
    {
        BLL_DangNhap BLL = new BLL_DangNhap();
        FrmQuanLy FrmQuanLy = new FrmQuanLy(); 
        public FrmDangNhap(Form Form)
        {
            InitializeComponent();
            FrmQuanLy = (FrmQuanLy)Form;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            NguoiDung ND = new NguoiDung();

            ND.TaiKhoan = txtTenTaiKhoan.Text;
            ND.MatKhau = txtMatKhau.Text;

            try
            {
                int Quyen = BLL.KiemTraQuyen(ND);

                if (Quyen == 1)
                {
                    MessageBox.Show("Truy cập thành công với quyền admin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmQuanLy.DisableQuyenAdmin();
                    this.Close();
                }
                if (Quyen == 2)
                {
                    MessageBox.Show("Truy cập thành công với quyền nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmQuanLy.DisableQuyenNhanVien();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đăng nhập thất bại, sai tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ckbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbHienMatKhau.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}
