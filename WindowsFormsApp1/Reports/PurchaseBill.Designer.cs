namespace WindowsFormsApp1.Report
{
    partial class PurchaseBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.purchasebillreport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // purchasebillreport
            // 
            this.purchasebillreport.ActiveViewIndex = -1;
            this.purchasebillreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchasebillreport.Cursor = System.Windows.Forms.Cursors.Default;
            this.purchasebillreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchasebillreport.Location = new System.Drawing.Point(20, 60);
            this.purchasebillreport.Name = "purchasebillreport";
            this.purchasebillreport.Size = new System.Drawing.Size(760, 370);
            this.purchasebillreport.TabIndex = 0;
            this.purchasebillreport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.purchasebillreport.Load += new System.EventHandler(this.purchasebillreport_Load);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(289, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // PurchaseBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.purchasebillreport);
            this.Name = "PurchaseBill";
            this.Text = "PurchaseBill";
            this.Load += new System.EventHandler(this.PurchaseBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer purchasebillreport;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}