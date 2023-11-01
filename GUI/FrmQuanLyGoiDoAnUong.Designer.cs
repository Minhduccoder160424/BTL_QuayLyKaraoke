namespace GUI
{
    partial class FrmQuanLyGoiDoAnUong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChonMon = new System.Windows.Forms.ComboBox();
            this.cbTenMon = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPhong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMonDaGoi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDaGoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(335, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ GỌI ĐỒ ĂN - UỐNG";
            // 
            // btLamMoi
            // 
            this.btLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLamMoi.Location = new System.Drawing.Point(11, 29);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(143, 52);
            this.btLamMoi.TabIndex = 1;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.Location = new System.Drawing.Point(177, 29);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(143, 52);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Thêm món";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUpdate.Location = new System.Drawing.Point(11, 89);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(143, 52);
            this.btUpdate.TabIndex = 3;
            this.btUpdate.Text = "Sửa số lượng";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDel
            // 
            this.btDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDel.Location = new System.Drawing.Point(177, 89);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(143, 52);
            this.btDel.TabIndex = 4;
            this.btDel.Text = "Xoá món";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.btUpdate);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.btLamMoi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(146, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn món :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên món :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng : ";
            // 
            // cbChonMon
            // 
            this.cbChonMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbChonMon.FormattingEnabled = true;
            this.cbChonMon.Location = new System.Drawing.Point(135, 40);
            this.cbChonMon.Name = "cbChonMon";
            this.cbChonMon.Size = new System.Drawing.Size(171, 29);
            this.cbChonMon.TabIndex = 9;
            this.cbChonMon.SelectedIndexChanged += new System.EventHandler(this.cbChonMon_SelectedIndexChanged);
            // 
            // cbTenMon
            // 
            this.cbTenMon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTenMon.FormattingEnabled = true;
            this.cbTenMon.Location = new System.Drawing.Point(135, 79);
            this.cbTenMon.Name = "cbTenMon";
            this.cbTenMon.Size = new System.Drawing.Size(171, 29);
            this.cbTenMon.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoLuong.Location = new System.Drawing.Point(135, 156);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(171, 29);
            this.txtSoLuong.TabIndex = 11;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.cbPhong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cbTenMon);
            this.groupBox2.Controls.Add(this.cbChonMon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(146, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 222);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // cbPhong
            // 
            this.cbPhong.FormattingEnabled = true;
            this.cbPhong.Location = new System.Drawing.Point(135, 116);
            this.cbPhong.Name = "cbPhong";
            this.cbPhong.Size = new System.Drawing.Size(172, 29);
            this.cbPhong.TabIndex = 13;
            this.cbPhong.SelectedIndexChanged += new System.EventHandler(this.cbPhong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phòng gọi :";
            // 
            // dgvMonDaGoi
            // 
            this.dgvMonDaGoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvMonDaGoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonDaGoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMonDaGoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMonDaGoi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMonDaGoi.Location = new System.Drawing.Point(517, 241);
            this.dgvMonDaGoi.Name = "dgvMonDaGoi";
            this.dgvMonDaGoi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMonDaGoi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMonDaGoi.RowTemplate.Height = 30;
            this.dgvMonDaGoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonDaGoi.Size = new System.Drawing.Size(426, 374);
            this.dgvMonDaGoi.TabIndex = 16;
            this.dgvMonDaGoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonDaGoi_CellClick);
            this.dgvMonDaGoi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMonDaGoi_CellFormatting);
            // 
            // FrmQuanLyGoiDoAnUong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1085, 822);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMonDaGoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuanLyGoiDoAnUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý gọi đồ ăn (uống)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyGoiDoAnUong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonDaGoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbChonMon;
        private System.Windows.Forms.ComboBox cbTenMon;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMonDaGoi;
        private System.Windows.Forms.ComboBox cbPhong;
        private System.Windows.Forms.Label label5;
    }
}