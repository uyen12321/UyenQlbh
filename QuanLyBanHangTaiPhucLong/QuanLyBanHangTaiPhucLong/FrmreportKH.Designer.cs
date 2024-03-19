
namespace QuanLyBanHangTaiPhucLong
{
    partial class FrmreportKH
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QUANLYBANHANGTAIPHUCLONGDataSet3 = new QuanLyBanHangTaiPhucLong.QUANLYBANHANGTAIPHUCLONGDataSet3();
            this.KhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KhachHangTableAdapter = new QuanLyBanHangTaiPhucLong.QUANLYBANHANGTAIPHUCLONGDataSet3TableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYBANHANGTAIPHUCLONGDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet3";
            reportDataSource1.Value = this.KhachHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangTaiPhucLong.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QUANLYBANHANGTAIPHUCLONGDataSet3
            // 
            this.QUANLYBANHANGTAIPHUCLONGDataSet3.DataSetName = "QUANLYBANHANGTAIPHUCLONGDataSet3";
            this.QUANLYBANHANGTAIPHUCLONGDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KhachHangBindingSource
            // 
            this.KhachHangBindingSource.DataMember = "KhachHang";
            this.KhachHangBindingSource.DataSource = this.QUANLYBANHANGTAIPHUCLONGDataSet3;
            // 
            // KhachHangTableAdapter
            // 
            this.KhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmreportKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmreportKH";
            this.Text = "FrmreportKH";
            this.Load += new System.EventHandler(this.FrmreportKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYBANHANGTAIPHUCLONGDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KhachHangBindingSource;
        private QUANLYBANHANGTAIPHUCLONGDataSet3 QUANLYBANHANGTAIPHUCLONGDataSet3;
        private QUANLYBANHANGTAIPHUCLONGDataSet3TableAdapters.KhachHangTableAdapter KhachHangTableAdapter;
    }
}