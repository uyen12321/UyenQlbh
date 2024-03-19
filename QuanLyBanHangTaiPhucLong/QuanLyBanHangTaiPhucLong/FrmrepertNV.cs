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
    public partial class FrmrepertNV : Form
    {
        public FrmrepertNV()
        {
            InitializeComponent();
        }

        modifi mo = new modifi();
        private void FrmrepertNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QUANLYBANHANGTAIPHUCLONGDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.NhanVienTableAdapter.Fill(this.QUANLYBANHANGTAIPHUCLONGDataSet1.NhanVien);
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHangTaiPhucLong.Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "QUANLYBANHANGTAIPHUCLONGDataSet1";
            reportDataSource.Value = mo.table("select * from NhanVien");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();


        }
    }
}
