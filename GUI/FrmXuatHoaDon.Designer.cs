namespace GUI
{
    partial class FrmXuatHoaDon
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crpHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1102, 738);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // crpHoaDon
            // 
            this.crpHoaDon.ActiveViewIndex = 0;
            this.crpHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crpHoaDon.Name = "crpHoaDon";
            this.crpHoaDon.ReportSource = "C:\\Users\\ADMIN\\Desktop\\Code\\BTL_QuanLyKaraoke\\GUI\\XuatHoaDon.rpt";
            this.crpHoaDon.Size = new System.Drawing.Size(1102, 738);
            this.crpHoaDon.TabIndex = 1;
            // 
            // FrmXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 738);
            this.Controls.Add(this.crpHoaDon);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FrmXuatHoaDon";
            this.Text = "FrmXuatHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crpHoaDon;
    }
}