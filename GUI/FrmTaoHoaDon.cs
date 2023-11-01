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
    public partial class FrmTaoHoaDon : Form
    {
        string MaHD;
        BLL_TaoHoaDon BLL = new BLL_TaoHoaDon();
        public FrmTaoHoaDon()
        {
            InitializeComponent();
        }

        private void FrmTaoHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = BLL.DuLieuBangHoaDon();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmXuatHoaDon Frm = new FrmXuatHoaDon();
            XuatHoaDon XHD = new XuatHoaDon();
            XHD.SetDataSource(BLL.DuLieuBangCTHoaDon(MaHD));
            Frm.crpHoaDon.ReportSource = XHD;
            Frm.Show();
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                button1.Enabled = true;
                var TruyXuat = dgvHoaDon.Rows[e.RowIndex].Cells;
                MaHD = TruyXuat[0].Value.ToString();
                dataGridView2.DataSource = BLL.DuLieuBangCTHoaDon(MaHD);
                dataGridView2.Refresh();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void dgvHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvHoaDon.Columns[0].HeaderText = "Mã hoá đơn";
            dgvHoaDon.Columns[1].HeaderText = "Mã khách hàng";
            dgvHoaDon.Columns[2].HeaderText = "Mã nhân viên";
            dgvHoaDon.Columns[3].HeaderText = "Ngày lập hoá đơn";
            dgvHoaDon.Columns[4].HeaderText = "Tổng thanh toán";
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView2.Columns[0].HeaderText = "Mã mặt hàng";
            dataGridView2.Columns[1].HeaderText = "Tên mặt hàng";
            dataGridView2.Columns[2].HeaderText = "Tổng tiền trả";
        }
    }
}
