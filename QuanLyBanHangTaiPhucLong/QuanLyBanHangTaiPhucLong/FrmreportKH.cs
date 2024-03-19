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
    public partial class FrmreportKH : Form
    {
        public FrmreportKH()
        {
            InitializeComponent();
        }

        modifi mo = new modifi();
        private void FrmreportKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYBANHANGTAIPHUCLONGDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.KhachHangTableAdapter.Fill(this.QUANLYBANHANGTAIPHUCLONGDataSet3.KhachHang);
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangTaiPhucLong.Report3.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "QUANLYBANHANGTAIPHUCLONGDataSet1";
            reportDataSource.Value = mo.table("select * from NhanVien");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
           
        }
    }
}
