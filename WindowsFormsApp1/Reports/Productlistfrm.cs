using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Reports
{
    public partial class Productlistfrm : MetroFramework.Forms.MetroForm
    {
        public Productlistfrm()
        {
            InitializeComponent();
        }

        private void Productlistfrm_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\ProductlistReport.rpt");
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Project.ProductEntryFrm prf = new Project.ProductEntryFrm();
            prf.Show();
            this.Hide();
        }
    }
}
