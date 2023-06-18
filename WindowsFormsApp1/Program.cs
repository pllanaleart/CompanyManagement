using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Project.MainForm());
            //Application.Run(new Project.LoginForm());
            //Application.Run(new Forms.SaleForm());
            // Application.Run(new Project.ProductEntryFrm());
            //Application.Run(new Project.userform());
            // Application.Run(new Reports.Productlistfrm());
            // Application.Run(new Forms.PurchaseForm());
            //Application.Run(new Report.PurchaseReport());

        }
    }
}
