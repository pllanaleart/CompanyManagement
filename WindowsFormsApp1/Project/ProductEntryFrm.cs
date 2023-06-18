using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Project
{
    public partial class ProductEntryFrm : MetroFramework.Forms.MetroForm
    {

        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);
        int id = 0;
        string role = LoginForm.useri;
      
        public ProductEntryFrm()
        {
            InitializeComponent();
        }

        private void ProductEntryFrm_Load(object sender, EventArgs e)
        {
            ViewData();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                String query = "EXECUTE AS USER='"+role+"' Insert into Products (pid,product,rate,mrp,role) values ('" + pidtxt.Text.Trim() + "','" + producttxt.Text.Trim() + "','" + ratetxt.Text.Trim() + "','" + mrptxt.Text.Trim() + "','"+role+"')";
                SqlCommand sq = new SqlCommand(query, con);
                sq.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                ViewData();
                pidtxt.Text = "";
                producttxt.Text = "";
                ratetxt.Text = "";
                mrptxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void ViewData() {
            con.Close();
            String query = " Select * from Products";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            con.Open();
            DataTable ds=new DataTable();
            sd.Fill(ds);
            dataGridView1.DataSource = ds;
            con.Close();

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            con.Close();
            String query = "Update [Products] set pid='"+pidtxt.Text+"', product='"+producttxt.Text.Trim()+"', rate='"+ratetxt.Text.Trim()+"',mrp='"+mrptxt.Text.Trim()+"' where id='"+id+"'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            con.Close();
            ViewData();
            pidtxt.Text = "";
            producttxt.Text = "";
            ratetxt.Text = "";
            mrptxt.Text = "";
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            con.Close();
            String query = "Select * from Products WHERE  product='"+searchtxt.Text.Trim()+"'";
            
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            SqlDataReader sr;
            sr = sq.ExecuteReader();
            DataTable ds = new DataTable();

            
            if (sr.Read())
            {
                id = sr.GetInt32(sr.GetOrdinal("id"));
                 pidtxt.Text =sr.GetInt32(sr.GetOrdinal("pid")).ToString();
                 producttxt.Text = sr.GetString(sr.GetOrdinal("product"));
                 ratetxt.Text = sr.GetDouble(sr.GetOrdinal("rate")).ToString();
                 mrptxt.Text= sr.GetDouble(sr.GetOrdinal("mrp")).ToString();
                searchtxt.Text = "";
                
                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {
                    if (dgr.Cells[0].Value.ToString() == id.ToString()) // your Condition
                    {
                        dataGridView1.ClearSelection();
                        dgr.Selected = true;

                        return;
                    }
                    

                    con.Close();
                    
                }
                
            }
            else
            {
                MessageBox.Show("Nuk ka Product te tille!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
           
            ViewData();
            
            

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
                String query = " Delete From Products where id="+id+"";
            SqlCommand sq = new SqlCommand(query, con);
            sq.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);
            ViewData();
            pidtxt.Text = "";
            producttxt.Text = "";
            ratetxt.Text = "";
            mrptxt.Text = "";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm mfr = new MainForm();
            
            mfr.Show();
            Visible = false;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void plrlbl_Click(object sender, EventArgs e)
        {
            Reports.Productlistfrm plr = new Reports.Productlistfrm();
            plr.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edit_grid();
        }
        void edit_grid()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                id = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                pidtxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                producttxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                ratetxt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                mrptxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }
    }
    
}
