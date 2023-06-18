namespace WindowsFormsApp1.Report
{
    partial class SaleBill
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
            this.salebillreport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // salebillreport
            // 
            this.salebillreport.ActiveViewIndex = -1;
            this.salebillreport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salebillreport.Cursor = System.Windows.Forms.Cursors.Default;
            this.salebillreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salebillreport.Location = new System.Drawing.Point(20, 60);
            this.salebillreport.Name = "salebillreport";
            this.salebillreport.Size = new System.Drawing.Size(760, 370);
            this.salebillreport.TabIndex = 0;
            this.salebillreport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(223, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // SaleBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.salebillreport);
            this.Name = "SaleBill";
            this.Text = "SaleBill";
            this.Load += new System.EventHandler(this.SaleBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer salebillreport;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}