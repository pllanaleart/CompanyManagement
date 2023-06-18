using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Project
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public static bool salebool = false;
        public static bool purchasebool = false;
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userlbl.Text = LoginForm.useri;
            userlbl.Select();
        }

        private void expensetl_Click(object sender, EventArgs e)
        {
            Forms.Expense s = new Forms.Expense();
            s.Show();
            this.Hide();
           
        }

        private void productslbl_Click(object sender, EventArgs e)
        {
       
        }

        private void incometl_Click(object sender, EventArgs e)
        {
            Forms.IncomeForm inf = new Forms.IncomeForm();
            inf.Show();
            this.Hide();
        }

        private void saletl_Click(object sender, EventArgs e)
        {
            Forms.SaleForm sf = new Forms.SaleForm();
            sf.Show();
            this.Hide();
        }

        private void purchasetl_Click(object sender, EventArgs e)
        {
            Forms.PurchaseForm pf = new Forms.PurchaseForm();
            pf.Show();
            this.Hide();
        }

        private void persondtltl_Click(object sender, EventArgs e)
        {
            PersonForm pef = new PersonForm();
            pef.Show();
            this.Hide();
        }

        private void salereporttl_Click(object sender, EventArgs e)
        {
            Report.PurchaseReport sr = new Report.PurchaseReport();
            salebool = true;
            purchasebool = false;
            sr.Show();
            this.Hide();
        }

        private void purchasereporttl_Click(object sender, EventArgs e)
        {
            Report.PurchaseReport pr = new Report.PurchaseReport();
            purchasebool = true;
            salebool = false;
            pr.Show();
            this.Hide();
        }

        private void bckrcvtl_Click(object sender, EventArgs e)
        {
            BackupRecoveryForm brf = new BackupRecoveryForm();
            brf.Show();
            this.Hide();
        }

        private void stocktl_Click(object sender, EventArgs e)
        {
            Forms.StockForm stf = new Forms.StockForm();
            stf.Show();
            this.Hide();
        }

        private void userlbl_Click(object sender, EventArgs e)
        {

        }

        private void productregister_Click(object sender, EventArgs e)
        {
            ProductEntryFrm prf = new ProductEntryFrm();
            prf.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Project.userform uf = new Project.userform();
            uf.Show();
            this.Visible = false;
        }
    }
}
