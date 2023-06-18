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

namespace WindowsFormsApp1.Forms
{
    public partial class SaleForm : MetroFramework.Forms.MetroForm
    {


        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);
        public static int invoiceno = 1;
        public static int vendorid;
        string role = Project.LoginForm.useri;
        public static string nametext = "";
        public static bool valide = false;
        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            Newinvoice();
            bg_worker();
            bg_worker_costumername();
        }

        void Newinvoice()
        {

            try
            {
                con.Close();
                String query = "Select * from Sale order by Invoice desc";
                SqlCommand sq = new SqlCommand(query, con);

                SqlDataAdapter sd = new SqlDataAdapter(sq);
                con.Open();
                SqlDataReader sr;

                sr = sq.ExecuteReader();



                if (sr.Read())
                {

                    int ro = sr.GetInt32(sr.GetOrdinal("Invoice"));
                    invoicenotxt.Text = (ro + 1).ToString();

                }
                else
                {
                    invoicenotxt.Text = "1";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void namecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            String query = "Select * from Costumer where name ='" + namecmb.Text + "'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);


            vendorid = int.Parse(ds.Rows[0]["id"].ToString());
            con.Close();

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = null;
            metroGrid1.Rows.Clear();
            show_invoice();
            invoiceno = int.Parse(invoicenotxt.Text.Trim());
        }
        void show_invoice()
        {
            con.Close();
            String query = "Select Costumer.name,Sale.SaleDate,Sale.TotalAmount From Sale inner Join Costumer On Sale.CostumerName=Costumer.id WHERE Sale.Invoice='" + invoicenotxt.Text.Trim() + "'";

            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds9 = new DataTable();
            sd.Fill(ds9);
            if (ds9.Rows.Count > 0)
            {
                namecmb.Text = ds9.Rows[0]["name"].ToString();
                datecmb.Text = ds9.Rows[0]["SaleDate"].ToString();
                totalamttxt.Text = ds9.Rows[0]["TotalAmount"].ToString();
                con.Close();

            }
            else
            {
                MessageBox.Show("No invoice founded!!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



            String query1 = "Select  Products.pid as pid, Products.product as product, SaleItem.qty as qty, SaleItem.rate as rate, SaleItem.amount as amount From Products inner join SaleItem  on Products.pid = SaleItem.product Where SaleItem.invoice =" + invoicenotxt.Text + " ";



            SqlCommand sq1 = new SqlCommand(query1, con);
            con.Open();
            sq1.ExecuteNonQuery();
            SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
            DataSet ds = new DataSet();
            sd1.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int srn = 1;
                int d = metroGrid1.Rows.Count;
                if (d == 0)
                {

                }
                else
                {
                    srn = d;
                    string s = metroGrid1.Rows[d - 1].Cells[0].Value.ToString();
                    srn = int.Parse(s);
                    srn++;

                }

                metroGrid1.Rows.Add(srn, ds.Tables[0].Rows[i]["pid"].ToString(), ds.Tables[0].Rows[i]["product"].ToString(), ds.Tables[0].Rows[i]["qty"].ToString(), ds.Tables[0].Rows[i]["rate"].ToString(),
                    ds.Tables[0].Rows[i]["amount"].ToString());
                con.Close();
            }


        }
        void bg_worker()
        {
            productcmb.Items.Clear();

            try
            {
                String query = "Select * from Products order by product desc";
                SqlCommand sq = new SqlCommand(query, con);
                sq.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                con.Open();

                for (int i = 0; i < ds.Rows.Count; i++)
                {
                    productcmb.Items.Add(ds.Rows[i]["product"]).ToString();

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void bg_worker_costumername()
        {
            namecmb.Items.Clear();

            try
            {
                String query = "Select * from Costumer order by name desc";
                SqlCommand sq = new SqlCommand(query, con);
                sq.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                con.Open();

                for (int i = 0; i < ds.Rows.Count; i++)
                {


                    namecmb.Items.Add(ds.Rows[i]["name"]).ToString();

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void namecmb_Leave(object sender, EventArgs e)
        {
            con.Close();
            String query = "Select * from Costumer where name ='" + namecmb.Text + "'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            if (ds.Rows.Count > 0)
            {
                vendorid = int.Parse(ds.Rows[0]["id"].ToString());
            }
            else if (ds.Rows.Count < 1)
            {
                Project.PersonForm pf1 = new Project.PersonForm();
                valide = true;
                nametext = namecmb.Text;
                pf1.Show();
                
            }

            con.Close();
        }
        void select_costumerid()
        {
            con.Close();
            String query = "Select id from Costumer where name='"+namecmb.Text+"'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            vendorid = int.Parse(ds.Rows[0]["id"].ToString());
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (metroGrid1.Rows.Count > 0)
            {

                metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);
                total_amount();
            }

        }
        void total_amount()
        {
            double tamt = 0;
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                tamt = tamt + (double.Parse(metroGrid1.Rows[i].Cells[5].Value.ToString()));
            }
            totalamttxt.Text = tamt.ToString("00.00");
        }

        private void inbtn_Click(object sender, EventArgs e)
        {
            int srn = 1;
            int d = metroGrid1.Rows.Count;
            if (d == 0)
            {

            }
            else
            {
                srn = d;
                string s = metroGrid1.Rows[d - 1].Cells[0].Value.ToString();
                srn = int.Parse(s);
                srn++;

            }
            metroGrid1.Rows.Add(srn, productcodecmb.Text, productcmb.Text, qtytxt.Text, ratetxt.Text, amounttxt.Text);
            insert_product();
            cleart_txt();
            productcmb.Focus();
            total_amount();
        }
        void insert_product()
        {
            con.Close();
            String query = "Select * from Products where pid='" + productcodecmb.Text.Trim() + "'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            sd.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            con.Close();
            if (i > 0)
            {
            }
            else
            {

                String query1 = "Insert into Products (pid , product, rate, mrp) values ('" + productcodecmb.Text.Trim() + "','" + productcmb.Text.Trim() + "','" + ratetxt.Text.Trim() + "','" + ratetxt.Text.Trim() + "')";
                sq = new SqlCommand(query1, con);
                con.Open();

                sd = new SqlDataAdapter(sq);

                sd.Fill(dt);
                MessageBox.Show("New Product inserted!!", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
        }
        void cleart_txt()
        {
            productcodecmb.Text = "";
            productcmb.Text = "";
            qtytxt.Text = "";
            ratetxt.Text = "";
            amounttxt.Text = "";
        }

        private void productcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "Select * from Products WHERE  product='" + productcmb.Text.Trim() + "'";

                SqlCommand sq = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                SqlDataReader sr;
                sr = sq.ExecuteReader();



                if (sr.Read())
                {

                    productcodecmb.Text = sr.GetInt32(sr.GetOrdinal("pid")).ToString();

                    ratetxt.Text = sr.GetDouble(sr.GetOrdinal("rate")).ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ratetxt_TextChanged(object sender, EventArgs e)
        {
            amount_calculator();
        }
        void amount_calculator()
        {
            try
            {
                if (!string.IsNullOrEmpty(qtytxt.Text) && !string.IsNullOrEmpty(ratetxt.Text))
                {
                    amounttxt.Text = (double.Parse(qtytxt.Text) * double.Parse(ratetxt.Text)).ToString();
                }
                else if (!string.IsNullOrEmpty(qtytxt.Text) && string.IsNullOrEmpty(ratetxt.Text))
                {
                    amounttxt.Text = (double.Parse(qtytxt.Text) * 1).ToString();
                }
                else if (string.IsNullOrEmpty(qtytxt.Text) && !string.IsNullOrEmpty(ratetxt.Text))
                {
                    amounttxt.Text = (1 * double.Parse(ratetxt.Text)).ToString();
                }
                else
                {
                    amounttxt.Text = "";
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void qtytxt_TextChanged(object sender, EventArgs e)
        {
            amount_calculator();
        }

        private void qtytxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
            }
        }

        private void amounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void ratetxt_Click(object sender, EventArgs e)
        {

        }

        private void ratetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Project.MainForm mf = new Project.MainForm();
            mf.Show();
            this.Hide();
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            edit_grid();
            total_amount();
        }
        void edit_grid()
        {
            if (metroGrid1.Rows.Count > 0)
            {

                productcodecmb.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
                productcmb.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
                qtytxt.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
                ratetxt.Text = metroGrid1.SelectedRows[0].Cells[4].Value.ToString();
                amounttxt.Text = metroGrid1.SelectedRows[0].Cells[5].Value.ToString();
                metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);
            }
        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edit_grid();
            total_amount();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            select_costumerid();
            String query = "Insert into Sale (Invoice,CostumerName,SaleDate,TotalAmount) values ('" + invoicenotxt.Text.Trim() + "','" + vendorid + "','" + datecmb.Text.Trim() + "','" + totalamttxt.Text.Trim() + "')";
            SqlCommand sq = new SqlCommand(query, con);
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            MessageBox.Show("Invoice saved Succesfully!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            get_product_id();
            stock_add();
            income_add();
        }
        void income_add()
        {

            String query = "Insert into Income (intype,Costumerid,inDate,totalAmount) values ('"+ "sale Invoice " + invoicenotxt.Text.Trim() +"','" + vendorid + "','" + datecmb.Text.Trim() + "','" + totalamttxt.Text.Trim() + "')";
            SqlCommand sq = new SqlCommand(query, con);
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
        }
        void stock_add()
        {
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                con.Close();
                String query = "Select * from Stock where pid='" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "'";
                SqlCommand sq = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    con.Close();
                    String query1 = "Update Stock set qty= qty - " + metroGrid1.Rows[i].Cells["qty"].Value.ToString() + " where pid=" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "";
                    SqlCommand sq1 = new SqlCommand(query1, con);
                    con.Open();
                    SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                    DataTable ds1 = new DataTable();
                    sd1.Fill(ds1);
                    con.Close();
                    String query2 = "Update Stock set amount=amount - " + metroGrid1.Rows[i].Cells["amount"].Value.ToString() + " where pid=" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "";

                    sq1 = new SqlCommand(query2, con);
                    con.Open();
                    sd1 = new SqlDataAdapter(sq1);
                    ds1 = new DataTable();
                    sd1.Fill(ds1);
                    con.Close();

                }
                else
                {
                    con.Close();
                    String query1 = "Insert into Stock(pid,qty,amount) values(" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["qty"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["amount"].Value.ToString() + " )";
                    SqlCommand sq1 = new SqlCommand(query1, con);
                    con.Open();
                    SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                    DataTable ds1 = new DataTable();
                    sd1.Fill(ds1);


                }

            }
        }
        void get_product_id()
        {
            con.Close();
            try
            {
                for (int i = 0; i < metroGrid1.Rows.Count; i++)
                {


                    String query = "Select * from Products where product='" + metroGrid1.Rows[i].Cells["Product"].Value.ToString() + "'";
                    SqlCommand sq = new SqlCommand(query, con);
                    con.Open();
                    SqlDataAdapter sd = new SqlDataAdapter(sq);

                    SqlDataReader sr;

                    sr = sq.ExecuteReader();
                    if (sr.Read())
                    {

                        con.Close();
                        String query1 = "Insert into SaleItem(product,qty,amount,invoice,rate)values(" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["qty"].Value.ToString() + "," + metroGrid1.Rows[i].Cells["amount"].Value.ToString() + "," + invoicenotxt.Text.Trim() + "," + metroGrid1.Rows[i].Cells["rate"].Value.ToString() + ")";

                        sq = new SqlCommand(query1, con);
                        sd = new SqlDataAdapter(sq);
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        con.Close();

                    }
                }





            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            delete_invoice();
            metroGrid1.Rows.Clear();
            clear_txt2();

        }
        void clear_txt2()
        {
            namecmb.Text = "";
            datecmb.Value = DateTime.Today;
            totalamttxt.Text = "";
        }
        void delete_invoice()
        {

            con.Close();
            for (int i = 0; i < metroGrid1.Rows.Count; i++)
            {
                String query2 = "Update Stock set qty= qty + " + metroGrid1.Rows[i].Cells["qty"].Value.ToString() + " where pid=" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "";
                SqlCommand sq1 = new SqlCommand(query2, con);
                con.Open();
                SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                DataTable ds1 = new DataTable();
                sd1.Fill(ds1);
                con.Close();
                String query3 = "Update Stock set amount= amount + " + metroGrid1.Rows[i].Cells["amount"].Value.ToString() + " where pid=" + metroGrid1.Rows[i].Cells["productcode"].Value.ToString() + "";
                SqlCommand sq2 = new SqlCommand(query3, con);
                con.Open();
                SqlDataAdapter sd2 = new SqlDataAdapter(sq2);
                DataTable ds2 = new DataTable();
                sd2.Fill(ds2);
                con.Close();

            }
            String query = "Delete from SaleItem where invoice='" + invoicenotxt.Text + "'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            con.Close();

            String query1 = "Delete from Sale where Invoice='" + invoicenotxt.Text + "'";
            sq = new SqlCommand(query1, con);
            con.Open();
            sd = new SqlDataAdapter(sq);
            ds = new DataTable();
            sd.Fill(ds);
            con.Close();

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            invoiceno = int.Parse(invoicenotxt.Text.Trim());

            Report.SaleBill pb=new Report.SaleBill();
            pb.Show();
        }
    }
}
