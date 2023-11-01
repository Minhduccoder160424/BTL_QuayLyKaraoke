using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmQuanLy : Form
    {
        void Disable()
        {
            quảnLýToolStripMenuItem.Enabled = false;
            hoáĐơnToolStripMenuItem.Enabled = false;
            tìmKiếmToolStripMenuItem.Enabled = false;
            thốngKêBáoCáoToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = false;
            trangChủToolStripMenuItem.Enabled = false;
        }
        public void DisableQuyenAdmin()
        {
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngKýToolStripMenuItem.Enabled = false;
            Enable();
        }
        public void DisableQuyenNhanVien()
        {
            quảnLýToolStripMenuItem.Enabled = true;
            quảnLýNhânViênToolStripMenuItem.Enabled = false;
            hoáĐơnToolStripMenuItem.Enabled = true;
            đăngNhậpToolStripMenuItem.Enabled = false;
            đăngKýToolStripMenuItem.Enabled = false;
            đăngXuấtToolStripMenuItem.Enabled = true;
            trangChủToolStripMenuItem.Enabled = true;
        }
        void Enable()
        {
            quảnLýToolStripMenuItem.Enabled = true;
            hoáĐơnToolStripMenuItem.Enabled = true;
            tìmKiếmToolStripMenuItem.Enabled = true;
            thốngKêBáoCáoToolStripMenuItem.Enabled = true;
            đăngXuấtToolStripMenuItem.Enabled = true;
            trangChủToolStripMenuItem.Enabled = true;
        }
        public FrmQuanLy()
        {
            InitializeComponent();
        }
        public void MoFrm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
        public void DongFrm()
        {
            foreach (var i in MdiChildren)
            {
                i.Close();
            }
        }
        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmDangNhap(this));
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmDangKy());
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            Disable();
            MoFrm(new FrmDangNhap(this));
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmQuanLyNhanVien());
        }

        private void quảnLýQuánHátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmQuanLyQuanHat());
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmQuanLyKhachHang());
        }

        private void quảnLýGọiĐồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmQuanLyGoiDoAnUong());
        }

        private void quảnLýĐặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmQuanLyDatPhong());
        }

        private void tạoHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmTaoHoaDon());
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmTimKiemKhachHang());
        }

        private void tìmKiếmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmTimKiemPhong());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            Disable();
            đăngNhậpToolStripMenuItem.Enabled = true;
            đăngKýToolStripMenuItem.Enabled = true;
            MoFrm(new FrmDangNhap(this));
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", "HuongDanSuDung.txt");
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongFrm();
            MoFrm(new FrmThongKeBaoCao());
        }
    }
}