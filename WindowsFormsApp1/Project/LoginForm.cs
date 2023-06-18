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

using System.Data.OleDb;
using System.Configuration;


namespace WindowsFormsApp1.Project
{

    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static string conString = "Data Source=DESKTOP-2CF203L;Initial Catalog=AccountDB;Integrated Security=True";
        public static string useri="a";



        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(usernametxt.Text))
            {
                MessageBox.Show("Please enter Username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernametxt.Focus();
                return;
            }
            try {
                SqlConnection con = new SqlConnection(conString);
               String query = "Select * from [Person] where name ='"+usernametxt.Text.Trim()+"'and password = '"+passwordtxt.Text.Trim()+"'";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sd.Fill(dtbl);
                if (dtbl.Rows.Count==1)
                    {
                    MainForm mfr = new MainForm();
                    useri = usernametxt.Text;
                    mfr.Show();

                    this.Hide();
                }
                    else
                    {
                        MessageBox.Show("Please enter Username and password correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
