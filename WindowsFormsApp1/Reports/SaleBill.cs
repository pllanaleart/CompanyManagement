using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Report
{
    public partial class SaleBill : MetroFramework.Forms.MetroForm
    {

        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);
        int invoice = Forms.SaleForm.invoiceno;
        public SaleBill()
        {
            InitializeComponent();
        }

        private void SaleBill_Load(object sender, EventArgs e)
        {
            load_bill();
            metroLabel1.Text = invoice.ToString();
        }
        void load_bill()
        {
            try
            {
                con.Close();
                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\SaleReport.rpt");


                string query1 = "Select * from Sale where Invoice="+invoice+" order by Invoice ";
                SqlCommand sq1 = new SqlCommand(query1, con);
                con.Open();
                SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                DataSet ds = new DataSet();
                sd1.Fill(ds,"Sale");
                rpt.SetDataSource(ds);

                salebillreport.ReportSource = rpt;

                salebillreport.Refresh();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
