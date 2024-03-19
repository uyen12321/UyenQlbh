using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace QuanLyBanHangTaiPhucLong
{
    public partial class FrmreportCN : Form
    {
        public FrmreportCN()
        {
            InitializeComponent();
        }
        modifi mo = new modifi();
        private void FrmreportCN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYBANHANGTAIPHUCLONGDataSet4.ChiNhanh' table. You can move, or remove it, as needed.
            this.ChiNhanhTableAdapter.Fill(this.QUANLYBANHANGTAIPHUCLONGDataSet4.ChiNhanh);
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangTaiPhucLong.Report4.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "QUANLYBANHANGTAIPHUCLONGDataSet4";
            reportDataSource.Value = mo.table("select * from ChiNhanh");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
