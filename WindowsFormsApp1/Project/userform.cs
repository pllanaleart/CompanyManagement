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
    public partial class userform : MetroFramework.Forms.MetroForm
    {
        public static string useri = Project.LoginForm.useri;
        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True;MultipleActiveResultSets=true;User ID="+useri+";Password=Secret;";
        SqlConnection con = new SqlConnection(conString);
        
        public userform()
        {
            InitializeComponent();
        }

        private void userform_Load(object sender, EventArgs e)
        {
            show_users();
        }

 
        void show_users()
        {
            metroGrid1.Rows.Clear();
            con.Open();
            String query1 = " Select * from Person order by id asc ";
            SqlCommand sq1 = new SqlCommand(query1, con);
            
            sq1.ExecuteNonQuery();
            SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
            DataSet ds = new DataSet();
            sd1.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
             metroGrid1.Rows.Add(i+1, ds.Tables[0].Rows[i]["name"].ToString(), ds.Tables[0].Rows[i]["role"].ToString());
                con.Close();
            }
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                String query1 = " Execute InsertPerson @name='"+nametxt.Text+"',@password='"+passwordtxt.Text+"'";
                SqlCommand sq1 = new SqlCommand(query1, con);
                con.Open();
                SqlDataAdapter sd1 = new SqlDataAdapter(sq1);
                DataTable ds = new DataTable();
                sd1.Fill(ds);
                show_users();
                con.Close();
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error" + ex, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
