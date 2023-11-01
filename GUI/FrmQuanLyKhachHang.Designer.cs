namespace GUI
{
    partial class FrmQuanLyKhachHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDoThanThiet = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại :";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaKH.Location = new System.Drawing.Point(183, 38);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(219, 29);
            this.txtMaKH.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenKH.Location = new System.Drawing.Point(183, 80);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(219, 29);
            this.txtTenKH.TabIndex = 5;
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(183, 123);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(219, 29);
            this.txtSDT.TabIndex = 6;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXacNhan.Location = new System.Drawing.Point(310, 212);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(108, 42);
            this.btXacNhan.TabIndex = 8;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ckbDoThanThiet);
            this.groupBox1.Controls.Add(this.btXacNhan);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // ckbDoThanThiet
            // 
            this.ckbDoThanThiet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbDoThanThiet.AutoSize = true;
            this.ckbDoThanThiet.Location = new System.Drawing.Point(124, 181);
            this.ckbDoThanThiet.Name = "ckbDoThanThiet";
            this.ckbDoThanThiet.Size = new System.Drawing.Size(189, 25);
            this.ckbDoThanThiet.TabIndex = 9;
            this.ckbDoThanThiet.Text = "Khách hàng thân thiết";
            this.ckbDoThanThiet.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(375, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tìm kiếm theo :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimKiem.Location = new System.Drawing.Point(187, 77);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(209, 29);
            this.txtTimKiem.TabIndex = 13;
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Số điện thoại"});
            this.cbLoaiTK.Location = new System.Drawing.Point(187, 33);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(209, 29);
            this.cbLoaiTK.TabIndex = 14;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTimKiem.Location = new System.Drawing.Point(413, 28);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(75, 78);
            this.btTimKiem.TabIndex = 15;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Controls.Add(this.cbLoaiTK);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(541, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 119);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhanh";
            // 
            // btLamMoi
            // 
            this.btLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLamMoi.Location = new System.Drawing.Point(52, 28);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(183, 55);
            this.btLamMoi.TabIndex = 17;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.Location = new System.Drawing.Point(268, 29);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(183, 55);
            this.btAdd.TabIndex = 18;
            this.btAdd.Text = "Thêm khách hàng";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btSua.Location = new System.Drawing.Point(52, 87);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(183, 55);
            this.btSua.TabIndex = 19;
            this.btSua.Text = "Sửa thông tin";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btXoa.Location = new System.Drawing.Point(268, 87);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(183, 55);
            this.btXoa.TabIndex = 20;
            this.btXoa.Text = "Xoá khách hàng";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btLamMoi);
            this.groupBox3.Controls.Add(this.btAdd);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(541, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 157);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // dgvKH
            // 
            this.dgvKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.Location = new System.Drawing.Point(45, 451);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.RowTemplate.Height = 30;
            this.dgvKH.RowTemplate.ReadOnly = true;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(1000, 303);
            this.dgvKH.TabIndex = 22;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            this.dgvKH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKH_CellFormatting);
            // 
            // FrmQuanLyKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1085, 822);
            this.ControlBox = false;
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbLoaiTK;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.CheckBox ckbDoThanThiet;
    }
}