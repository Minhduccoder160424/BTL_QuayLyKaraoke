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
    public partial class FrmDangKy : Form
    {
        FrmQuanLy FrmQuanLy = new FrmQuanLy();
        BLL_DangKy BLL = new BLL_DangKy();
        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (BLL.KiemTraHopLe(txtMatKhau.Text, txtNhapLaiMatKhau.Text))
            {
                try
                {
                    NguoiDung ND = new NguoiDung();
                    ND.NguoiDungID = BLL.TaoNguoiDungID();
                    ND.TaiKhoan = txtTenTaiKhoan.Text;
                    ND.MatKhau = txtMatKhau.Text;
                    ND.QuyenTruyCap = 2;

                    BLL.TaoTaiKhoan(ND);

                    MessageBox.Show("Tạo tài khoản thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception) 
                {
                    //MessageBox.Show(i.Message);
                    MessageBox.Show("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
