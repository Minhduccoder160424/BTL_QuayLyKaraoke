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
    public partial class FrmTimKiemKhachHang : Form
    {
        BLL_TimKiemKhachHang BLL = new BLL_TimKiemKhachHang();
        public FrmTimKiemKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            comboBox1.SelectedIndex = -1;

            dataGridView1.DataSource = BLL.DuLieuBangKhachHang();
            dataGridView1.Refresh();
        }

        private void FrmTimKiemKhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.DuLieuBangKhachHang();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.DuLieuTimKiem(comboBox1.Text, textBox1.Text);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Mã khách hàng";
            dataGridView1.Columns[1].HeaderText = "Tên khách hàng";
            dataGridView1.Columns[2].HeaderText = "Số điện thoại";
            dataGridView1.Columns[3].HeaderText = "Độ thân thiết";
        }
    }
}
