
namespace QuanLyBanHangTaiPhucLong
{
    partial class FrmreportCN
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
            this.QUANLYBANHANGTAIPHUCLONGDataSet4 = new QuanLyBanHangTaiPhucLong.QUANLYBANHANGTAIPHUCLONGDataSet4();
            this.ChiNhanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChiNhanhTableAdapter = new QuanLyBanHangTaiPhucLong.QUANLYBANHANGTAIPHUCLONGDataSet4TableAdapters.ChiNhanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYBANHANGTAIPHUCLONGDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiNhanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet4";
            reportDataSource1.Value = this.ChiNhanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangTaiPhucLong.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // QUANLYBANHANGTAIPHUCLONGDataSet4
            // 
            this.QUANLYBANHANGTAIPHUCLONGDataSet4.DataSetName = "QUANLYBANHANGTAIPHUCLONGDataSet4";
            this.QUANLYBANHANGTAIPHUCLONGDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChiNhanhBindingSource
            // 
            this.ChiNhanhBindingSource.DataMember = "ChiNhanh";
            this.ChiNhanhBindingSource.DataSource = this.QUANLYBANHANGTAIPHUCLONGDataSet4;
            // 
            // ChiNhanhTableAdapter
            // 
            this.ChiNhanhTableAdapter.ClearBeforeFill = true;
            // 
            // FrmreportCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmreportCN";
            this.Text = "FrmreportCN";
            this.Load += new System.EventHandler(this.FrmreportCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYBANHANGTAIPHUCLONGDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChiNhanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChiNhanhBindingSource;
        private QUANLYBANHANGTAIPHUCLONGDataSet4 QUANLYBANHANGTAIPHUCLONGDataSet4;
        private QUANLYBANHANGTAIPHUCLONGDataSet4TableAdapters.ChiNhanhTableAdapter ChiNhanhTableAdapter;
    }
}