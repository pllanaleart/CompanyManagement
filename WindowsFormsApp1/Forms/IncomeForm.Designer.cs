namespace WindowsFormsApp1.Forms
{
    partial class IncomeForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.srnubmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costumercmb = new System.Windows.Forms.ComboBox();
            this.descriptiontxt = new MetroFramework.Controls.MetroTextBox();
            this.datecmb = new MetroFramework.Controls.MetroDateTime();
            this.totalamttxt = new MetroFramework.Controls.MetroTextBox();
            this.descriptionlbl = new MetroFramework.Controls.MetroLabel();
            this.namelbl = new MetroFramework.Controls.MetroLabel();
            this.tamountlbl = new MetroFramework.Controls.MetroLabel();
            this.savbtn = new MetroFramework.Controls.MetroButton();
            this.backbtn = new MetroFramework.Controls.MetroButton();
            this.searchtypecmb = new MetroFramework.Controls.MetroComboBox();
            this.searchtypelbl = new MetroFramework.Controls.MetroLabel();
            this.datefromcmb = new MetroFramework.Controls.MetroDateTime();
            this.datetocmb = new MetroFramework.Controls.MetroDateTime();
            this.dafromlbl = new MetroFramework.Controls.MetroLabel();
            this.tolbl = new MetroFramework.Controls.MetroLabel();
            this.searchnametxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.showbtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.Gray;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srnubmer,
            this.type,
            this.name,
            this.date,
            this.amount});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(6, 81);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(553, 150);
            this.metroGrid1.TabIndex = 0;
            // 
            // srnubmer
            // 
            this.srnubmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.srnubmer.HeaderText = "Sr.Number";
            this.srnubmer.Name = "srnubmer";
            this.srnubmer.ReadOnly = true;
            this.srnubmer.Width = 30;
            // 
            // type
            // 
            this.type.HeaderText = "Description";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 70;
            // 
            // amount
            // 
            this.amount.HeaderText = "Total Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 60;
            // 
            // costumercmb
            // 
            this.costumercmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.costumercmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.costumercmb.FormattingEnabled = true;
            this.costumercmb.Location = new System.Drawing.Point(211, 267);
            this.costumercmb.Name = "costumercmb";
            this.costumercmb.Size = new System.Drawing.Size(158, 21);
            this.costumercmb.TabIndex = 1;
            this.costumercmb.Leave += new System.EventHandler(this.costumercmb_Leave);
            // 
            // descriptiontxt
            // 
            // 
            // 
            // 
            this.descriptiontxt.CustomButton.Image = null;
            this.descriptiontxt.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.descriptiontxt.CustomButton.Name = "";
            this.descriptiontxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.descriptiontxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptiontxt.CustomButton.TabIndex = 1;
            this.descriptiontxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptiontxt.CustomButton.UseSelectable = true;
            this.descriptiontxt.CustomButton.Visible = false;
            this.descriptiontxt.Lines = new string[0];
            this.descriptiontxt.Location = new System.Drawing.Point(13, 267);
            this.descriptiontxt.MaxLength = 32767;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.PasswordChar = '\0';
            this.descriptiontxt.PromptText = "type here...";
            this.descriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptiontxt.SelectedText = "";
            this.descriptiontxt.SelectionLength = 0;
            this.descriptiontxt.SelectionStart = 0;
            this.descriptiontxt.ShortcutsEnabled = true;
            this.descriptiontxt.Size = new System.Drawing.Size(192, 23);
            this.descriptiontxt.TabIndex = 2;
            this.descriptiontxt.UseSelectable = true;
            this.descriptiontxt.WaterMark = "type here...";
            this.descriptiontxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptiontxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datecmb
            // 
            this.datecmb.CustomFormat = "yyyy-MM-dd";
            this.datecmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datecmb.Location = new System.Drawing.Point(359, 46);
            this.datecmb.MinimumSize = new System.Drawing.Size(0, 29);
            this.datecmb.Name = "datecmb";
            this.datecmb.Size = new System.Drawing.Size(200, 29);
            this.datecmb.TabIndex = 3;
            // 
            // totalamttxt
            // 
            // 
            // 
            // 
            this.totalamttxt.CustomButton.Image = null;
            this.totalamttxt.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.totalamttxt.CustomButton.Name = "";
            this.totalamttxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalamttxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalamttxt.CustomButton.TabIndex = 1;
            this.totalamttxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalamttxt.CustomButton.UseSelectable = true;
            this.totalamttxt.CustomButton.Visible = false;
            this.totalamttxt.Lines = new string[0];
            this.totalamttxt.Location = new System.Drawing.Point(375, 267);
            this.totalamttxt.MaxLength = 32767;
            this.totalamttxt.Name = "totalamttxt";
            this.totalamttxt.PasswordChar = '\0';
            this.totalamttxt.PromptText = "0.00";
            this.totalamttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalamttxt.SelectedText = "";
            this.totalamttxt.SelectionLength = 0;
            this.totalamttxt.SelectionStart = 0;
            this.totalamttxt.ShortcutsEnabled = true;
            this.totalamttxt.Size = new System.Drawing.Size(91, 23);
            this.totalamttxt.TabIndex = 4;
            this.totalamttxt.UseSelectable = true;
            this.totalamttxt.WaterMark = "0.00";
            this.totalamttxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalamttxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Location = new System.Drawing.Point(10, 245);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(74, 19);
            this.descriptionlbl.TabIndex = 5;
            this.descriptionlbl.Text = "Description";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(209, 244);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 19);
            this.namelbl.TabIndex = 6;
            this.namelbl.Text = "Name";
            // 
            // tamountlbl
            // 
            this.tamountlbl.AutoSize = true;
            this.tamountlbl.Location = new System.Drawing.Point(372, 244);
            this.tamountlbl.Name = "tamountlbl";
            this.tamountlbl.Size = new System.Drawing.Size(87, 19);
            this.tamountlbl.TabIndex = 7;
            this.tamountlbl.Text = "Total Amount";
            // 
            // savbtn
            // 
            this.savbtn.Location = new System.Drawing.Point(473, 266);
            this.savbtn.Name = "savbtn";
            this.savbtn.Size = new System.Drawing.Size(75, 23);
            this.savbtn.TabIndex = 8;
            this.savbtn.Text = "Save";
            this.savbtn.UseSelectable = true;
            this.savbtn.Click += new System.EventHandler(this.savbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(473, 388);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 9;
            this.backbtn.Text = "Back";
            this.backbtn.UseSelectable = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // searchtypecmb
            // 
            this.searchtypecmb.FormattingEnabled = true;
            this.searchtypecmb.ItemHeight = 23;
            this.searchtypecmb.Items.AddRange(new object[] {
            "Search By Name",
            "Search By Date",
            "Search By Name&Date"});
            this.searchtypecmb.Location = new System.Drawing.Point(23, 353);
            this.searchtypecmb.Name = "searchtypecmb";
            this.searchtypecmb.Size = new System.Drawing.Size(171, 29);
            this.searchtypecmb.TabIndex = 10;
            this.searchtypecmb.UseSelectable = true;
            this.searchtypecmb.SelectedIndexChanged += new System.EventHandler(this.searchtypecmb_SelectedIndexChanged);
            // 
            // searchtypelbl
            // 
            this.searchtypelbl.AutoSize = true;
            this.searchtypelbl.Location = new System.Drawing.Point(34, 328);
            this.searchtypelbl.Name = "searchtypelbl";
            this.searchtypelbl.Size = new System.Drawing.Size(123, 19);
            this.searchtypelbl.TabIndex = 11;
            this.searchtypelbl.Text = "Choose search type";
            // 
            // datefromcmb
            // 
            this.datefromcmb.CustomFormat = "yyyy-MM-dd";
            this.datefromcmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefromcmb.Location = new System.Drawing.Point(212, 331);
            this.datefromcmb.MinimumSize = new System.Drawing.Size(0, 29);
            this.datefromcmb.Name = "datefromcmb";
            this.datefromcmb.Size = new System.Drawing.Size(109, 29);
            this.datefromcmb.TabIndex = 12;
            this.datefromcmb.ValueChanged += new System.EventHandler(this.datefromcmb_ValueChanged);
            // 
            // datetocmb
            // 
            this.datetocmb.CustomFormat = "yyyy-MM-dd";
            this.datetocmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetocmb.Location = new System.Drawing.Point(327, 331);
            this.datetocmb.MinimumSize = new System.Drawing.Size(0, 29);
            this.datetocmb.Name = "datetocmb";
            this.datetocmb.Size = new System.Drawing.Size(114, 29);
            this.datetocmb.TabIndex = 13;
            this.datetocmb.ValueChanged += new System.EventHandler(this.metroDateTime2_ValueChanged);
            // 
            // dafromlbl
            // 
            this.dafromlbl.AutoSize = true;
            this.dafromlbl.Location = new System.Drawing.Point(210, 309);
            this.dafromlbl.Name = "dafromlbl";
            this.dafromlbl.Size = new System.Drawing.Size(75, 19);
            this.dafromlbl.TabIndex = 14;
            this.dafromlbl.Text = "Date From:";
            this.dafromlbl.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.BackColor = System.Drawing.Color.Transparent;
            this.tolbl.Location = new System.Drawing.Point(327, 310);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(56, 19);
            this.tolbl.TabIndex = 15;
            this.tolbl.Text = "Date To:";
            this.tolbl.UseCustomBackColor = true;
            this.tolbl.Click += new System.EventHandler(this.tolbl_Click);
            // 
            // searchnametxt
            // 
            // 
            // 
            // 
            this.searchnametxt.CustomButton.Image = null;
            this.searchnametxt.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.searchnametxt.CustomButton.Name = "";
            this.searchnametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchnametxt.CustomButton.TabIndex = 1;
            this.searchnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchnametxt.CustomButton.UseSelectable = true;
            this.searchnametxt.CustomButton.Visible = false;
            this.searchnametxt.Lines = new string[0];
            this.searchnametxt.Location = new System.Drawing.Point(212, 388);
            this.searchnametxt.MaxLength = 32767;
            this.searchnametxt.Name = "searchnametxt";
            this.searchnametxt.PasswordChar = '\0';
            this.searchnametxt.PromptText = "type here...";
            this.searchnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchnametxt.SelectedText = "";
            this.searchnametxt.SelectionLength = 0;
            this.searchnametxt.SelectionStart = 0;
            this.searchnametxt.ShortcutsEnabled = true;
            this.searchnametxt.Size = new System.Drawing.Size(247, 23);
            this.searchnametxt.TabIndex = 16;
            this.searchnametxt.UseSelectable = true;
            this.searchnametxt.WaterMark = "type here...";
            this.searchnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(212, 363);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 17;
            this.metroLabel1.Text = "Search name:";
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(447, 359);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(101, 23);
            this.showbtn.TabIndex = 18;
            this.showbtn.Text = "Show";
            this.showbtn.UseSelectable = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel2.Location = new System.Drawing.Point(13, 299);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(537, 2);
            this.metroLabel2.TabIndex = 19;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 293);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Search";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 421);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.searchnametxt);
            this.Controls.Add(this.tolbl);
            this.Controls.Add(this.dafromlbl);
            this.Controls.Add(this.datetocmb);
            this.Controls.Add(this.datefromcmb);
            this.Controls.Add(this.searchtypelbl);
            this.Controls.Add(this.searchtypecmb);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.savbtn);
            this.Controls.Add(this.tamountlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.descriptionlbl);
            this.Controls.Add(this.totalamttxt);
            this.Controls.Add(this.datecmb);
            this.Controls.Add(this.descriptiontxt);
            this.Controls.Add(this.costumercmb);
            this.Controls.Add(this.metroGrid1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Activated += new System.EventHandler(this.IncomeForm_Activated);
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srnubmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.ComboBox costumercmb;
        private MetroFramework.Controls.MetroTextBox descriptiontxt;
        private MetroFramework.Controls.MetroDateTime datecmb;
        private MetroFramework.Controls.MetroTextBox totalamttxt;
        private MetroFramework.Controls.MetroLabel descriptionlbl;
        private MetroFramework.Controls.MetroLabel namelbl;
        private MetroFramework.Controls.MetroLabel tamountlbl;
        private MetroFramework.Controls.MetroButton savbtn;
        private MetroFramework.Controls.MetroButton backbtn;
        private MetroFramework.Controls.MetroComboBox searchtypecmb;
        private MetroFramework.Controls.MetroLabel searchtypelbl;
        private MetroFramework.Controls.MetroDateTime datefromcmb;
        private MetroFramework.Controls.MetroDateTime datetocmb;
        private MetroFramework.Controls.MetroLabel dafromlbl;
        private MetroFramework.Controls.MetroLabel tolbl;
        private MetroFramework.Controls.MetroTextBox searchnametxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton showbtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}