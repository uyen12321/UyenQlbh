﻿
namespace QuanLyBanHangTaiPhucLong
{
    partial class FrmrepertNV
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
            this.NhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYBANHANGTAIPHUCLONGDataSet1 = new QuanLyBanHangTaiPhucLong.QUANLYBANHANGTAIPHUCLONGDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVienTableAdapter = new QuanLyBanHangTaiPhucLong.QUANLYBANHANGTAIPHUCLONGDataSet1TableAdapters.NhanVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYBANHANGTAIPHUCLONGDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // NhanVienBindingSource
            // 
            this.NhanVienBindingSource.DataMember = "NhanVien";
            this.NhanVienBindingSource.DataSource = this.QUANLYBANHANGTAIPHUCLONGDataSet1;
            // 
            // QUANLYBANHANGTAIPHUCLONGDataSet1
            // 
            this.QUANLYBANHANGTAIPHUCLONGDataSet1.DataSetName = "QUANLYBANHANGTAIPHUCLONGDataSet1";
            this.QUANLYBANHANGTAIPHUCLONGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NhanVienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangTaiPhucLong.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(901, 586);
            this.reportViewer1.TabIndex = 0;
            // 
            // NhanVienTableAdapter
            // 
            this.NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // FrmrepertNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 586);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmrepertNV";
            this.Text = "FrmreportNV";
            this.Load += new System.EventHandler(this.FrmrepertNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYBANHANGTAIPHUCLONGDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVienBindingSource;
        private QUANLYBANHANGTAIPHUCLONGDataSet1 QUANLYBANHANGTAIPHUCLONGDataSet1;
        private QUANLYBANHANGTAIPHUCLONGDataSet1TableAdapters.NhanVienTableAdapter NhanVienTableAdapter;
    }
}