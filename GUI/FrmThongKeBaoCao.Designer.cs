namespace GUI
{
    partial class FrmThongKeBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDoanhThuNam = new System.Windows.Forms.Label();
            this.rbtThang = new System.Windows.Forms.RadioButton();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lbDoanhThuThang = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(374, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDoanhThuThang);
            this.groupBox1.Controls.Add(this.lbDoanhThuNam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(241, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Doanh thu năm : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Doanh thu tháng :";
            // 
            // btLamMoi
            // 
            this.btLamMoi.Location = new System.Drawing.Point(406, 36);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(117, 35);
            this.btLamMoi.TabIndex = 2;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = true;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.Location = new System.Drawing.Point(406, 82);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(117, 35);
            this.btThongKe.TabIndex = 3;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNam);
            this.groupBox2.Controls.Add(this.txtThang);
            this.groupBox2.Controls.Add(this.rbtNam);
            this.groupBox2.Controls.Add(this.rbtThang);
            this.groupBox2.Controls.Add(this.btThongKe);
            this.groupBox2.Controls.Add(this.btLamMoi);
            this.groupBox2.Location = new System.Drawing.Point(241, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 141);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // lbDoanhThuNam
            // 
            this.lbDoanhThuNam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDoanhThuNam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDoanhThuNam.Location = new System.Drawing.Point(238, 55);
            this.lbDoanhThuNam.Name = "lbDoanhThuNam";
            this.lbDoanhThuNam.Size = new System.Drawing.Size(271, 31);
            this.lbDoanhThuNam.TabIndex = 2;
            this.lbDoanhThuNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtThang
            // 
            this.rbtThang.AutoSize = true;
            this.rbtThang.Location = new System.Drawing.Point(34, 41);
            this.rbtThang.Name = "rbtThang";
            this.rbtThang.Size = new System.Drawing.Size(112, 25);
            this.rbtThang.TabIndex = 4;
            this.rbtThang.TabStop = true;
            this.rbtThang.Text = "Theo tháng";
            this.rbtThang.UseVisualStyleBackColor = true;
            this.rbtThang.CheckedChanged += new System.EventHandler(this.rbtThang_CheckedChanged);
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Location = new System.Drawing.Point(34, 87);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(103, 25);
            this.rbtNam.TabIndex = 5;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Theo năm";
            this.rbtNam.UseVisualStyleBackColor = true;
            this.rbtNam.CheckedChanged += new System.EventHandler(this.rbtNam_CheckedChanged);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(164, 40);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(218, 29);
            this.txtThang.TabIndex = 6;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(164, 86);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(218, 29);
            this.txtNam.TabIndex = 7;
            // 
            // lbDoanhThuThang
            // 
            this.lbDoanhThuThang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDoanhThuThang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDoanhThuThang.Location = new System.Drawing.Point(238, 110);
            this.lbDoanhThuThang.Name = "lbDoanhThuThang";
            this.lbDoanhThuThang.Size = new System.Drawing.Size(271, 31);
            this.lbDoanhThuThang.TabIndex = 4;
            this.lbDoanhThuThang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmThongKeBaoCao
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1085, 822);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmThongKeBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThongKeBaoCao1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDoanhThuNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.Button btThongKe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.RadioButton rbtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label lbDoanhThuThang;
    }
}