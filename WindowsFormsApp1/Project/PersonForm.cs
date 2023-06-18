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

namespace WindowsFormsApp1.Project
{
    public partial class PersonForm : MetroFramework.Forms.MetroForm
    {

        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true";
        SqlConnection con = new SqlConnection(conString);
        public PersonForm()
        {
            InitializeComponent();
        }


       
        private void PersonForm_Load(object sender, EventArgs e)
        {
            if (Forms.SaleForm.nametext != "")
            {
                costumerrbtn.Checked = Forms.SaleForm.valide;
                nametxt.Text = Forms.SaleForm.nametext;
                new_costumer();
            }
            else if (Forms.PurchaseForm.nametext != "")
            {
                vendorrbtn.Checked = Forms.PurchaseForm.valide;
                nametxt.Text = Forms.PurchaseForm.nametext;
                new_vendor();
            }
            else if (Forms.IncomeForm.nametext != "")
            {
                costumerrbtn.Checked = Forms.IncomeForm.valide;
                nametxt.Text = Forms.IncomeForm.nametext;
                new_costumer();
            }
            else if (Forms.Expense.nametext != "") {
                vendorrbtn.Checked = Forms.Expense.valide;
                nametxt.Text = Forms.Expense.nametext;
                new_vendor();

            }
           
        }
        void new_vendor()
        {
            metroGrid1.Rows.Clear();
            con.Close();
            String query = "Select * from Vendor order by id asc";
            SqlCommand sq = new SqlCommand(query, con);

            SqlDataAdapter sd = new SqlDataAdapter(sq);
            con.Open();
            DataTable ds = new DataTable();
            sd.Fill(ds);

            for (int i = 0; i < ds.Rows.Count; i++) {
                metroGrid1.Rows.Add(ds.Rows[i][0].ToString(), ds.Rows[i][1].ToString(), ds.Rows[i][2].ToString(), ds.Rows[i][3].ToString());
                    }

        }

        void new_costumer()
        {
            metroGrid1.Rows.Clear();
            con.Close();
            String query = "Select * from Costumer order by id asc";
            SqlCommand sq = new SqlCommand(query, con);

            SqlDataAdapter sd = new SqlDataAdapter(sq);
            con.Open();
            DataTable ds = new DataTable();
            sd.Fill(ds);

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                metroGrid1.Rows.Add(ds.Rows[i][0].ToString(), ds.Rows[i][1].ToString(), ds.Rows[i][2].ToString(), ds.Rows[i][3].ToString());
            }

        }
        void register_vendor() {

            con.Close();
            String query = "Insert into Vendor(name,address,phone_number) values('"+nametxt.Text+"','"+addresstxt.Text+"','"+pnumbertxt.Text+"')";
            SqlCommand sq = new SqlCommand(query, con);

            SqlDataAdapter sd = new SqlDataAdapter(sq);
            con.Open();
            DataTable ds = new DataTable();
            sd.Fill(ds);

        }
        void text_clear()
        {
            nametxt.Text = "";
            addresstxt.Text = "";
            pnumbertxt.Text = "";
        }
        void register_costumer()
        {

            con.Close();
            String query = "Insert into Costumer(name,address,phone_number) values('" + nametxt.Text + "','" + addresstxt.Text + "','" + pnumbertxt.Text + "')";
            SqlCommand sq = new SqlCommand(query, con);

            SqlDataAdapter sd = new SqlDataAdapter(sq);
            con.Open();
            DataTable ds = new DataTable();
            sd.Fill(ds);

        }
        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (costumerrbtn.Checked)
            {
                register_costumer();
                new_costumer();
                text_clear();

            }
            else if (vendorrbtn.Checked)
            {
                register_vendor();
                new_vendor();
                text_clear();
            }
        }

        private void vendorrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (vendorrbtn.Checked)
            {
                metroGrid1.Rows.Clear();
                new_vendor();
            }
            else { 
            }
        }

        private void costumerrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (costumerrbtn.Checked)
            {
                metroGrid1.Rows.Clear();
                new_costumer();
            }
            else
            {

            }
        }

        private void costumerrbtn_Validated(object sender, EventArgs e)
        {
            
        }

        private void vendorrbtn_Validated(object sender, EventArgs e)
        {
           
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string tablesearch = "";
            metroGrid1.Rows.Clear();
            con.Close();
            if (costumerrbtn.Checked)
            {
                tablesearch = "Costumer";
            }
            else if (vendorrbtn.Checked)
            {
                tablesearch = "Vendor";
            }
            String query = "Select * from "+tablesearch+" where name='"+searchtxt.Text+"'";
            SqlCommand sq = new SqlCommand(query, con);

            SqlDataAdapter sd = new SqlDataAdapter(sq);
            con.Open();
            DataTable ds = new DataTable();
            sd.Fill(ds);

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                metroGrid1.Rows.Add(ds.Rows[i][0].ToString(), ds.Rows[i][1].ToString(), ds.Rows[i][2].ToString(), ds.Rows[i][3].ToString());
            }
        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            edit_grid();
        }
        void edit_grid()
        {
            if (metroGrid1.Rows.Count > 0)
            {

               nametxt.Text = metroGrid1.SelectedRows[0].Cells[1].Value.ToString();
                addresstxt.Text = metroGrid1.SelectedRows[0].Cells[2].Value.ToString();
                pnumbertxt.Text = metroGrid1.SelectedRows[0].Cells[3].Value.ToString();
                metroGrid1.Rows.Remove(metroGrid1.SelectedRows[0]);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }
    }

}
