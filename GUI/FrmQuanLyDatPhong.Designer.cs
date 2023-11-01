namespace GUI
{
    partial class FrmQuanLyDatPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhongHat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbKHTT = new System.Windows.Forms.CheckBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbNVPT = new System.Windows.Forms.ComboBox();
            this.dtpTimeDatPhong = new System.Windows.Forms.DateTimePicker();
            this.cbPhongDat = new System.Windows.Forms.ComboBox();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCTPH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(406, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐẶT PHÒNG";
            // 
            // dgvPhongHat
            // 
            this.dgvPhongHat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPhongHat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongHat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhongHat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongHat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhongHat.Location = new System.Drawing.Point(16, 33);
            this.dgvPhongHat.Name = "dgvPhongHat";
            this.dgvPhongHat.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhongHat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhongHat.RowTemplate.Height = 30;
            this.dgvPhongHat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongHat.Size = new System.Drawing.Size(283, 271);
            this.dgvPhongHat.TabIndex = 1;
            this.dgvPhongHat.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhongHat_CellFormatting);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phòng đặt :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thời gian đặt phòng :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhân viên phụ trách :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.ckbKHTT);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(363, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 158);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // ckbKHTT
            // 
            this.ckbKHTT.AutoSize = true;
            this.ckbKHTT.Location = new System.Drawing.Point(124, 122);
            this.ckbKHTT.Name = "ckbKHTT";
            this.ckbKHTT.Size = new System.Drawing.Size(189, 25);
            this.ckbKHTT.TabIndex = 9;
            this.ckbKHTT.Text = "Khách hàng thân thiết";
            this.ckbKHTT.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(183, 72);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(219, 29);
            this.txtSDT.TabIndex = 6;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(183, 28);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(219, 29);
            this.txtTenKH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên khách hàng :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.dgvPhongHat);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 325);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phòng hát";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cbNVPT);
            this.groupBox3.Controls.Add(this.dtpTimeDatPhong);
            this.groupBox3.Controls.Add(this.cbPhongDat);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(363, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 149);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt phòng";
            // 
            // cbNVPT
            // 
            this.cbNVPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbNVPT.FormattingEnabled = true;
            this.cbNVPT.Location = new System.Drawing.Point(202, 103);
            this.cbNVPT.Name = "cbNVPT";
            this.cbNVPT.Size = new System.Drawing.Size(200, 29);
            this.cbNVPT.TabIndex = 7;
            // 
            // dtpTimeDatPhong
            // 
            this.dtpTimeDatPhong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpTimeDatPhong.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpTimeDatPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeDatPhong.Location = new System.Drawing.Point(202, 68);
            this.dtpTimeDatPhong.Name = "dtpTimeDatPhong";
            this.dtpTimeDatPhong.Size = new System.Drawing.Size(200, 29);
            this.dtpTimeDatPhong.TabIndex = 6;
            this.dtpTimeDatPhong.Value = new System.DateTime(2023, 10, 27, 13, 14, 43, 0);
            // 
            // cbPhongDat
            // 
            this.cbPhongDat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbPhongDat.FormattingEnabled = true;
            this.cbPhongDat.Location = new System.Drawing.Point(202, 33);
            this.cbPhongDat.Name = "cbPhongDat";
            this.cbPhongDat.Size = new System.Drawing.Size(200, 29);
            this.cbPhongDat.TabIndex = 5;
            // 
            // btLamMoi
            // 
            this.btLamMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLamMoi.Location = new System.Drawing.Point(20, 31);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(155, 65);
            this.btLamMoi.TabIndex = 14;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.Location = new System.Drawing.Point(20, 135);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(155, 63);
            this.btAdd.TabIndex = 15;
            this.btAdd.Text = "Đặt phòng";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDel.Location = new System.Drawing.Point(20, 241);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(155, 63);
            this.btDel.TabIndex = 17;
            this.btDel.Text = "Xoá phòng đã đặt";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.btDel);
            this.groupBox4.Controls.Add(this.btLamMoi);
            this.groupBox4.Controls.Add(this.btAdd);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(839, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 325);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // dgvCTPH
            // 
            this.dgvCTPH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCTPH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTPH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPH.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTPH.Location = new System.Drawing.Point(43, 464);
            this.dgvCTPH.Name = "dgvCTPH";
            this.dgvCTPH.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPH.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTPH.RowTemplate.Height = 30;
            this.dgvCTPH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPH.Size = new System.Drawing.Size(991, 306);
            this.dgvCTPH.TabIndex = 19;
            this.dgvCTPH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPH_CellClick);
            this.dgvCTPH.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCTPH_CellFormatting);
            // 
            // FrmQuanLyDatPhong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1085, 822);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCTPH);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuanLyDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đặt phòng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhongHat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbKHTT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpTimeDatPhong;
        private System.Windows.Forms.ComboBox cbPhongDat;
        private System.Windows.Forms.ComboBox cbNVPT;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCTPH;
    }
}