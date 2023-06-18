namespace WindowsFormsApp1.Report
{
    partial class PurchaseReport
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
            this.viewbtn = new MetroFramework.Controls.MetroButton();
            this.backbtn = new MetroFramework.Controls.MetroButton();
            this.datefromlbl = new MetroFramework.Controls.MetroLabel();
            this.datetolbl = new MetroFramework.Controls.MetroLabel();
            this.datefromcmb = new MetroFramework.Controls.MetroDateTime();
            this.datetocmb = new MetroFramework.Controls.MetroDateTime();
            this.PurchaseReportview = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.salerbtn = new MetroFramework.Controls.MetroRadioButton();
            this.bilancerbtn = new MetroFramework.Controls.MetroRadioButton();
            this.purchaserbtn = new MetroFramework.Controls.MetroRadioButton();
            this.explainlbl = new MetroFramework.Controls.MetroLabel();
            this.choicecmb = new MetroFramework.Controls.MetroComboBox();
            this.namesearchtxt = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // viewbtn
            // 
            this.viewbtn.Location = new System.Drawing.Point(557, 81);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(75, 23);
            this.viewbtn.TabIndex = 0;
            this.viewbtn.Text = "View";
            this.viewbtn.UseSelectable = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(649, 81);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 0;
            this.backbtn.Text = "Back";
            this.backbtn.UseSelectable = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // datefromlbl
            // 
            this.datefromlbl.AutoSize = true;
            this.datefromlbl.Location = new System.Drawing.Point(23, 81);
            this.datefromlbl.Name = "datefromlbl";
            this.datefromlbl.Size = new System.Drawing.Size(75, 19);
            this.datefromlbl.TabIndex = 1;
            this.datefromlbl.Text = "Date From:";
            // 
            // datetolbl
            // 
            this.datetolbl.AutoSize = true;
            this.datetolbl.Location = new System.Drawing.Point(23, 112);
            this.datetolbl.Name = "datetolbl";
            this.datetolbl.Size = new System.Drawing.Size(56, 19);
            this.datetolbl.TabIndex = 1;
            this.datetolbl.Text = "Date To:";
            // 
            // datefromcmb
            // 
            this.datefromcmb.CustomFormat = "yyyy-MM-dd";
            this.datefromcmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefromcmb.Location = new System.Drawing.Point(104, 81);
            this.datefromcmb.MinimumSize = new System.Drawing.Size(0, 29);
            this.datefromcmb.Name = "datefromcmb";
            this.datefromcmb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datefromcmb.Size = new System.Drawing.Size(182, 29);
            this.datefromcmb.TabIndex = 2;
            this.datefromcmb.Value = new System.DateTime(2020, 4, 9, 18, 32, 30, 0);
            this.datefromcmb.ValueChanged += new System.EventHandler(this.datefromcmb_ValueChanged);
            // 
            // datetocmb
            // 
            this.datetocmb.CustomFormat = "yyyy-MM-dd";
            this.datetocmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetocmb.Location = new System.Drawing.Point(104, 116);
            this.datetocmb.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetocmb.Name = "datetocmb";
            this.datetocmb.Size = new System.Drawing.Size(182, 29);
            this.datetocmb.TabIndex = 2;
            this.datetocmb.Value = new System.DateTime(2020, 4, 9, 17, 5, 8, 0);
            // 
            // PurchaseReportview
            // 
            this.PurchaseReportview.ActiveViewIndex = -1;
            this.PurchaseReportview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PurchaseReportview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseReportview.Cursor = System.Windows.Forms.Cursors.Default;
            this.PurchaseReportview.Location = new System.Drawing.Point(9, 165);
            this.PurchaseReportview.Name = "PurchaseReportview";
            this.PurchaseReportview.Size = new System.Drawing.Size(726, 205);
            this.PurchaseReportview.TabIndex = 3;
            this.PurchaseReportview.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // salerbtn
            // 
            this.salerbtn.AutoSize = true;
            this.salerbtn.Location = new System.Drawing.Point(311, 60);
            this.salerbtn.Name = "salerbtn";
            this.salerbtn.Size = new System.Drawing.Size(44, 15);
            this.salerbtn.TabIndex = 4;
            this.salerbtn.Text = "Sale";
            this.salerbtn.UseSelectable = true;
            // 
            // bilancerbtn
            // 
            this.bilancerbtn.AutoSize = true;
            this.bilancerbtn.Location = new System.Drawing.Point(438, 60);
            this.bilancerbtn.Name = "bilancerbtn";
            this.bilancerbtn.Size = new System.Drawing.Size(61, 15);
            this.bilancerbtn.TabIndex = 4;
            this.bilancerbtn.Text = "Bilance";
            this.bilancerbtn.UseSelectable = true;
            // 
            // purchaserbtn
            // 
            this.purchaserbtn.AutoSize = true;
            this.purchaserbtn.Location = new System.Drawing.Point(361, 60);
            this.purchaserbtn.Name = "purchaserbtn";
            this.purchaserbtn.Size = new System.Drawing.Size(71, 15);
            this.purchaserbtn.TabIndex = 4;
            this.purchaserbtn.Text = "Purchase";
            this.purchaserbtn.UseSelectable = true;
            // 
            // explainlbl
            // 
            this.explainlbl.AutoSize = true;
            this.explainlbl.Location = new System.Drawing.Point(340, 38);
            this.explainlbl.Name = "explainlbl";
            this.explainlbl.Size = new System.Drawing.Size(127, 19);
            this.explainlbl.TabIndex = 1;
            this.explainlbl.Text = "Choose report type:";
            // 
            // choicecmb
            // 
            this.choicecmb.FormattingEnabled = true;
            this.choicecmb.ItemHeight = 23;
            this.choicecmb.Items.AddRange(new object[] {
            "By Date",
            "By Name ",
            "By Name&Date"});
            this.choicecmb.Location = new System.Drawing.Point(311, 82);
            this.choicecmb.Name = "choicecmb";
            this.choicecmb.Size = new System.Drawing.Size(188, 29);
            this.choicecmb.TabIndex = 5;
            this.choicecmb.UseSelectable = true;
            this.choicecmb.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // namesearchtxt
            // 
            // 
            // 
            // 
            this.namesearchtxt.CustomButton.Image = null;
            this.namesearchtxt.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.namesearchtxt.CustomButton.Name = "";
            this.namesearchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.namesearchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.namesearchtxt.CustomButton.TabIndex = 1;
            this.namesearchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.namesearchtxt.CustomButton.UseSelectable = true;
            this.namesearchtxt.CustomButton.Visible = false;
            this.namesearchtxt.Lines = new string[0];
            this.namesearchtxt.Location = new System.Drawing.Point(311, 121);
            this.namesearchtxt.MaxLength = 32767;
            this.namesearchtxt.Name = "namesearchtxt";
            this.namesearchtxt.PasswordChar = '\0';
            this.namesearchtxt.PromptText = "Search by name";
            this.namesearchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.namesearchtxt.SelectedText = "";
            this.namesearchtxt.SelectionLength = 0;
            this.namesearchtxt.SelectionStart = 0;
            this.namesearchtxt.ShortcutsEnabled = true;
            this.namesearchtxt.Size = new System.Drawing.Size(243, 23);
            this.namesearchtxt.TabIndex = 6;
            this.namesearchtxt.UseSelectable = true;
            this.namesearchtxt.WaterMark = "Search by name";
            this.namesearchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.namesearchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PurchaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.namesearchtxt);
            this.Controls.Add(this.choicecmb);
            this.Controls.Add(this.purchaserbtn);
            this.Controls.Add(this.bilancerbtn);
            this.Controls.Add(this.salerbtn);
            this.Controls.Add(this.PurchaseReportview);
            this.Controls.Add(this.datetocmb);
            this.Controls.Add(this.datefromcmb);
            this.Controls.Add(this.explainlbl);
            this.Controls.Add(this.datetolbl);
            this.Controls.Add(this.datefromlbl);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.viewbtn);
            this.Name = "PurchaseReport";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.PurchaseReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton viewbtn;
        private MetroFramework.Controls.MetroButton backbtn;
        private MetroFramework.Controls.MetroLabel datefromlbl;
        private MetroFramework.Controls.MetroLabel datetolbl;
        private MetroFramework.Controls.MetroDateTime datetocmb;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer PurchaseReportview;
        private MetroFramework.Controls.MetroRadioButton salerbtn;
        private MetroFramework.Controls.MetroRadioButton bilancerbtn;
        private MetroFramework.Controls.MetroRadioButton purchaserbtn;
        private MetroFramework.Controls.MetroLabel explainlbl;
        private MetroFramework.Controls.MetroDateTime datefromcmb;
        private MetroFramework.Controls.MetroComboBox choicecmb;
        private MetroFramework.Controls.MetroTextBox namesearchtxt;
    }
}