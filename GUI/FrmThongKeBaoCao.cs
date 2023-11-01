using BLL;
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
    public partial class FrmThongKeBaoCao : Form
    {
        BLL_ThongKeBaoCao BLL = new BLL_ThongKeBaoCao();
        public FrmThongKeBaoCao()
        {
            InitializeComponent();
        }

        private void FrmThongKeBaoCao1_Load(object sender, EventArgs e)
        {
            lbDoanhThuNam.Text = $"0 đồng.";
            lbDoanhThuThang.Text = $"0 đồng.";
        }
        private void btLamMoi_Click(object sender, EventArgs e)
        {
            rbtNam.Checked = false;
            rbtThang.Checked = false;
            txtNam.Text = string.Empty;
            txtThang.Text = string.Empty;
            lbDoanhThuNam.Text = $"0 đồng.";
            lbDoanhThuThang.Text = $"0 đồng.";
        }

        private void rbtThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtThang.Checked == true)
            {
                txtNam.Enabled = true;
                txtThang.Enabled = true;
            }
            else
            {
                txtNam.Enabled = false;
                txtThang.Enabled = false;
            }
        }

        private void rbtNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNam.Checked == true)
            {
                txtNam.Enabled = true;
            }
            else
            {
                txtNam.Enabled = false;
                txtThang.Enabled = false;
            }
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            if (rbtNam.Checked)
            {
                lbDoanhThuNam.Text = $"{BLL.ThongKeTheoNam(int.Parse(txtNam.Text))} đồng.";
                lbDoanhThuNam.Refresh();
            }
            if (rbtThang.Checked)
            {
                lbDoanhThuThang.Text = $"{BLL.ThongKeTheoThang(int.Parse(txtNam.Text), int.Parse(txtThang.Text))} đồng.";
                lbDoanhThuThang.Refresh();
            }
        }
    }
}
