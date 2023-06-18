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
    public partial class IncomeForm : MetroFramework.Forms.MetroForm
    {

        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);
        public static int costumerid=0;
        public static string nametext = "";
        public static bool valide = false;
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            bg_worker();
            show_income();
            searchtypecmb.SelectedIndex = 0;

        }
        void bg_worker()
        {
            costumercmb.Items.Clear();

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
                    costumercmb.Items.Add(ds.Rows[i]["name"]).ToString();

                }

                con.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void show_income()
        {
            metroGrid1.Rows.Clear();
            con.Close();
            String query1 = "Select Income.id,Income.intype,Costumer.name,Income.inDate,Income.totalAmount From Income Inner join Costumer on Income.Costumerid =Costumer.id order by Income.id desc ";
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

                metroGrid1.Rows.Add(srn, ds.Tables[0].Rows[i]["intype"].ToString(), ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["inDate"].ToString(), ds.Tables[0].Rows[i]["totalAmount"].ToString());
                con.Close();
            }
        }

        private void savbtn_Click(object sender, EventArgs e)
        {
            try
            {
              
                    con.Close();
                    String query1 = "Select id from Costumer where name='"+costumercmb.Text+"'";
                    SqlCommand sq1 = new SqlCommand(query1, con);
                    con.Open();
                    sq1.CommandType = CommandType.Text;
                    SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                    DataTable ds1 = new DataTable();
                    sd1.Fill(ds1);
                if (ds1.Rows.Count > 0)
                {

                    costumerid = int.Parse(ds1.Rows[0]["id"].ToString());
                    
                    con.Close();
                }
               
                con.Close();
                String query = "Insert into Income(intype, Costumerid,inDate,totalAmount) values('" + descriptiontxt.Text + "'," + costumerid + ",'" + datecmb.Text + "'," + totalamttxt.Text + ")";
                SqlCommand sq = new SqlCommand(query, con);
                con.Open();
                sq.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                clear_txt();
                show_income();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        void clear_txt()
        {
            descriptiontxt.Text = "";
            costumercmb.Text = "";
            totalamttxt.Text = "";
        }

        private void IncomeForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void costumercmb_Leave(object sender, EventArgs e)
        {
            if (costumercmb.Text =="") { }

            else
            {
                con.Close();
                String query = "Select * from Costumer where name ='" + costumercmb.Text + "'";
                SqlCommand sq = new SqlCommand(query, con);
                con.Open();
                sq.CommandType = CommandType.Text;
                SqlDataAdapter sd = new SqlDataAdapter(sq);
                DataTable ds = new DataTable();
                sd.Fill(ds);
                if (ds.Rows.Count > 0)
                {
                    costumerid = int.Parse(ds.Rows[0]["id"].ToString());
                }
                else if (ds.Rows.Count < 1)
                {
                    Project.PersonForm pf1 = new Project.PersonForm();
                    valide = true;
                    nametext = costumercmb.Text;
                    pf1.Show();

                }

                con.Close();
            }
        }

        private void tolbl_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datefromcmb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchtypecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchtypecmb.SelectedIndex == 0)
            {
                searchnametxt.Enabled = true;
                datefromcmb.Enabled = false;
                datetocmb.Enabled = false;
            }
            else if (searchtypecmb.SelectedIndex == 1)
            {
                datefromcmb.Enabled = true;
                datetocmb.Enabled = true;
                searchnametxt.Enabled = false;
            }
            else if (searchtypecmb.SelectedIndex == 2)
            {
                datefromcmb.Enabled = true;
                datetocmb.Enabled = true;
                searchnametxt.Enabled = true;
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
         if(searchtypecmb.SelectedIndex==0)
            {
                metroGrid1.Rows.Clear();
                show_byname();
                
            }
         else if (searchtypecmb.SelectedIndex == 1)
            {
                metroGrid1.Rows.Clear();
                show_bydate();
            }
         else if (searchtypecmb.SelectedIndex == 2)
            {
                metroGrid1.Rows.Clear();
                show_bynamedate();
            }
        }
        void show_byname()
        {
            
            con.Close();
            String query = "Select Income.intype,Costumer.name,Income.inDate,Income.totalAmount from Income inner join Costumer on Income.Costumerid=Costumer.id where Costumerid=(Select id From Costumer where name='"+searchnametxt.Text+"')";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            sd.Fill(ds,"Income");

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

                metroGrid1.Rows.Add(srn, ds.Tables[0].Rows[i]["intype"].ToString(), ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["inDate"].ToString(), ds.Tables[0].Rows[i]["totalAmount"].ToString());
                con.Close();
            }
        }

        void show_bydate()
        {

            con.Close();
            String query = "Select Income.intype,Costumer.name,Income.inDate,Income.totalAmount from Income inner join Costumer on Income.Costumerid=Costumer.id where inDate  between'"+datefromcmb.Text+"'and '"+datetocmb.Text+"'";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            for (int i = 0; i < ds.Rows.Count; i++)
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

                metroGrid1.Rows.Add(srn, ds.Rows[i]["intype"].ToString(), ds.Rows[i]["name"].ToString(), ds.Rows[i]["inDate"].ToString(), ds.Rows[i]["totalAmount"].ToString());
                con.Close();
            }
        }

        void show_bynamedate()
        {

            con.Close();
            String query = "Select Income.intype,Costumer.name,Income.inDate,Income.totalAmount from Income inner join Costumer on Income.Costumerid=Costumer.id where inDate  between'" + datefromcmb.Text + "'and '" + datetocmb.Text + "' and Income.Costumerid=(Select id From Costumer where name='" + searchnametxt.Text + "')";
            SqlCommand sq = new SqlCommand(query, con);
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter(sq);
            DataTable ds = new DataTable();
            sd.Fill(ds);

            for (int i = 0; i < ds.Rows.Count; i++)
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

                metroGrid1.Rows.Add(srn, ds.Rows[i]["intype"].ToString(), ds.Rows[i]["name"].ToString(), ds.Rows[i]["inDate"].ToString(), ds.Rows[i]["totalAmount"].ToString());
                con.Close();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Project.MainForm mf = new Project.MainForm();
            mf.Show();
            this.Visible = false;
        }
    }
}
