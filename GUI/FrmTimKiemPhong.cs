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
    public partial class FrmTimKiemPhong : Form
    {
        BLL_TimKiemPhong BLL = new BLL_TimKiemPhong();
        public FrmTimKiemPhong()
        {
            InitializeComponent();
        }

        private void FrmTimKiemPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL.DuLieuBangPhongHat();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Mã phòng";
            dataGridView1.Columns[1].HeaderText = "Tên phòng";
            dataGridView1.Columns[2].HeaderText = "Trạng thái phòng";
            dataGridView1.Columns[3].HeaderText = "Giá theo giờ";
            dataGridView1.Columns[4].HeaderText = "Giảm giá thân thiết";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            textBox1.Text = string.Empty;

            FrmTimKiemPhong_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Equals(comboBox1.Text, "Tên phòng"))
            {
                dataGridView1.DataSource = BLL.TimKiemTenPhong(textBox1.Text);
                dataGridView1.Refresh();
            }
            if (Equals(comboBox1.Text, "Trạng thái phòng"))
            {
                try
                {
                    dataGridView1.DataSource = BLL.TimKiemTrangThai(int.Parse(textBox1.Text));
                    dataGridView1.Refresh();
                }
                catch (Exception i)
                {
                    MessageBox.Show(i.Message);
                }
            }
        }
    }
}
