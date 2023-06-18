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
    public partial class PurchaseReport : MetroFramework.Forms.MetroForm
    {

        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);


        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            choicecmb.SelectedIndex = 1;
            purchaserbtn.Checked = Project.MainForm.purchasebool;
            salerbtn.Checked = Project.MainForm.salebool;
            namesearchtxt.Focus();
            if (purchaserbtn.Checked)
            {
                showpurchase();
            }
            else if (salerbtn.Checked)
            {
                showsale();
            }

        }
        void showpurchase()
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\PurchaseReport.rpt");

            String query = "select top 20 *  from Purchase order by Invoice desc";
            con.Close();
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Purchase");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }

        }
        void showsale()
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\SaleReport1.rpt");

            String query = "select top 20 *  from Sale order by Invoice desc";
            con.Close();
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Sale");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            if (purchaserbtn.Checked)
            {
                if (choicecmb.SelectedIndex == 1)
                {
                    view_purchaseReport_byName();
                    
                    
                }

                else if (choicecmb.SelectedIndex == 0)
                {
                    view_purchaseReport_byDate();
                }
                else if (choicecmb.SelectedIndex == 2)
                {
                    view_purchaseReport_byNameDate();
                    
                    //MessageBox.Show("MIre", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Can't do any Search", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (salerbtn.Checked)
            {
                if (choicecmb.SelectedIndex == 1)
                {

                    view_saleReport_byName();

                }

                else if (choicecmb.SelectedIndex == 0)
                {
                    view_saleReport_byDate();
                }
                else if (choicecmb.SelectedIndex == 2)
                {


                    view_saleReport_byNameDate();

                }
                else
                {
                    MessageBox.Show("Can't do any Search", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please Select an Option", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void view_purchaseReport_byDate()
        {


            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\PurchaseReport.rpt");

     String query = "select * from Purchase where PurchaseDate between '"+datefromcmb.Text+"' and '"+datetocmb.Text+"'";
            con.Close();
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq); 
            DataSet ds = new DataSet();
            sd.Fill(ds, "Purchase");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("No Invoice founded!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        void view_purchaseReport_byName()
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\PurchaseReport.rpt");

            String query = "select * from Purchase where VendorName=(select id from Vendor where name='"+namesearchtxt.Text+"')";

            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Purchase");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("No Invoice founded!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        void view_purchaseReport_byNameDate() {
  

    ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\PurchaseReport.rpt");

            String query = "select * from Purchase where PurchaseDate between '"+datefromcmb.Text+"' and '"+datetocmb.Text+ "' and VendorName=(select id from Vendor where name='" + namesearchtxt.Text + "')";
            con.Close();
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Purchase");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("No Invoice founded!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
        void view_saleReport_byName()
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\SaleReport1.rpt");

            String query = "select * from Sale where CostumerName=(select id from Costumer where name='" + namesearchtxt.Text + "')";

            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Sale");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("No Invoice founded!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        void view_saleReport_byDate()
        {


            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\SaleReport1.rpt");

            String query = "select * from Sale where SaleDate between '" + datefromcmb.Text + "' and '" + datetocmb.Text + "'";
            con.Close();
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Sale");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("No Invoice founded!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        void view_saleReport_byNameDate()
        {


            ReportDocument rpt = new ReportDocument();
            rpt.Load(@"C:\Users\pllan\source\repos\WindowsFormsApp1\WindowsFormsApp1\Crystal Reports\SaleReport1.rpt");

            String query = "select * from Sale where SaleDate between '" + datefromcmb.Text + "' and '" + datetocmb.Text + "' and CostumerName=(select id from Costumer where name='" + namesearchtxt.Text + "')";
            con.Close();
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds, "Sale");
            if (ds.Tables[0].Rows.Count > 0)
            {
                rpt.SetDataSource(ds);
                PurchaseReportview.ReportSource = rpt;
                PurchaseReportview.Refresh();
                con.Close();
            }
            else
            {
                MessageBox.Show("No Invoice founded!!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }

        private void datefromcmb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Project.MainForm mf = new Project.MainForm();
            mf.Show();
            this.Hide();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void explainlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
