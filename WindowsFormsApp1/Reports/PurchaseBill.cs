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
    public partial class PurchaseBill : MetroFramework.Forms.MetroForm
    {
        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);
        int invoice=Forms.PurchaseForm.invoiceno;
        public PurchaseBill()
        {
            InitializeComponent();
        }

        private void PurchaseBill_Load(object sender, EventArgs e)
        {
            load_bill();
            metroLabel1.Text = invoice.ToString();
        }

        void load_bill()
        {
            try
            {

                ReportDocument rpt = new ReportDocument();
                rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\purchasebill.rpt");


                string query1 = "Select * from Purchase where Invoice="+invoice+" order by Invoice"; 
                SqlCommand sq1 = new SqlCommand(query1, con);
                con.Open();
                SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                DataSet ds = new DataSet();
                sd1.Fill(ds, "Purchase");
                rpt.SetDataSource(ds);

                purchasebillreport.ReportSource = rpt;

                purchasebillreport.Refresh();

                con.Close();
              /*  string query2 = "Select * from PurchaseItem";
                SqlCommand sq2 = new SqlCommand(query2, con);
                con.Open();
             
                SqlDataAdapter sd2 = new SqlDataAdapter(sq2);
                DataSet ds2 = new DataSet();
                sd1.Fill(ds2);
                rpt.SetDataSource(ds2);
                con.Close();
                string query3 = "Select * from Products";
                SqlCommand sq3 = new SqlCommand(query3, con);
                con.Open();
               
                SqlDataAdapter sd3 = new SqlDataAdapter(sq3);
                DataSet ds3 = new DataSet();
                sd1.Fill(ds3);
                rpt.SetDataSource(ds3);*/
               
                
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void purchasebillreport_Load(object sender, EventArgs e)
        {

        }
    }
}
