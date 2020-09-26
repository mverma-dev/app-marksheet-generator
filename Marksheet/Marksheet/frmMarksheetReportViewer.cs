using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marksheet
{
    public partial class frmMarksheetReportViewer : Form
    {
        public List<MarksheetReport> MarksheetReportList { get; set; }
        public frmMarksheetReportViewer()
        {
            MarksheetReportList = new List<MarksheetReport>();
            InitializeComponent();
        }

        private void frmMarksheetReportViewer_Load(object sender, EventArgs e)
        {
            var report = new rptMarksheet();
            report.SetDataSource(MarksheetReportList);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }
    }
}
