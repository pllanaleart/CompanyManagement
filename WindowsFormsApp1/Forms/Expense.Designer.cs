namespace WindowsFormsApp1.Forms
{
    partial class Expense
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.showbtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.searchnametxt = new MetroFramework.Controls.MetroTextBox();
            this.tolbl = new MetroFramework.Controls.MetroLabel();
            this.dafromlbl = new MetroFramework.Controls.MetroLabel();
            this.datetocmb = new MetroFramework.Controls.MetroDateTime();
            this.datefromcmb = new MetroFramework.Controls.MetroDateTime();
            this.searchtypelbl = new MetroFramework.Controls.MetroLabel();
            this.searchtypecmb = new MetroFramework.Controls.MetroComboBox();
            this.backbtn = new MetroFramework.Controls.MetroButton();
            this.savbtn = new MetroFramework.Controls.MetroButton();
            this.tamountlbl = new MetroFramework.Controls.MetroLabel();
            this.namelbl = new MetroFramework.Controls.MetroLabel();
            this.descriptionlbl = new MetroFramework.Controls.MetroLabel();
            this.totalamttxt = new MetroFramework.Controls.MetroTextBox();
            this.datecmb = new MetroFramework.Controls.MetroDateTime();
            this.descriptiontxt = new MetroFramework.Controls.MetroTextBox();
            this.costumercmb = new System.Windows.Forms.ComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.srnubmer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 359);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 20);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Search";
            // 
            // metroLabel2
            // 
            this.metroLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroLabel2.Location = new System.Drawing.Point(16, 367);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(716, 2);
            this.metroLabel2.TabIndex = 40;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(595, 441);
            this.showbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(135, 28);
            this.showbtn.TabIndex = 39;
            this.showbtn.Text = "Show";
            this.showbtn.UseSelectable = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(281, 446);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 20);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Search name:";
            // 
            // searchnametxt
            // 
            // 
            // 
            // 
            this.searchnametxt.CustomButton.Image = null;
            this.searchnametxt.CustomButton.Location = new System.Drawing.Point(404, 2);
            this.searchnametxt.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchnametxt.CustomButton.Name = "";
            this.searchnametxt.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.searchnametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchnametxt.CustomButton.TabIndex = 1;
            this.searchnametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchnametxt.CustomButton.UseSelectable = true;
            this.searchnametxt.CustomButton.Visible = false;
            this.searchnametxt.Lines = new string[0];
            this.searchnametxt.Location = new System.Drawing.Point(281, 476);
            this.searchnametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchnametxt.MaxLength = 32767;
            this.searchnametxt.Name = "searchnametxt";
            this.searchnametxt.PasswordChar = '\0';
            this.searchnametxt.PromptText = "type here...";
            this.searchnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchnametxt.SelectedText = "";
            this.searchnametxt.SelectionLength = 0;
            this.searchnametxt.SelectionStart = 0;
            this.searchnametxt.ShortcutsEnabled = true;
            this.searchnametxt.Size = new System.Drawing.Size(329, 28);
            this.searchnametxt.TabIndex = 37;
            this.searchnametxt.UseSelectable = true;
            this.searchnametxt.WaterMark = "type here...";
            this.searchnametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchnametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tolbl
            // 
            this.tolbl.AutoSize = true;
            this.tolbl.BackColor = System.Drawing.Color.Transparent;
            this.tolbl.Location = new System.Drawing.Point(435, 380);
            this.tolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tolbl.Name = "tolbl";
            this.tolbl.Size = new System.Drawing.Size(59, 20);
            this.tolbl.TabIndex = 36;
            this.tolbl.Text = "Date To:";
            this.tolbl.UseCustomBackColor = true;
            // 
            // dafromlbl
            // 
            this.dafromlbl.AutoSize = true;
            this.dafromlbl.Location = new System.Drawing.Point(279, 379);
            this.dafromlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dafromlbl.Name = "dafromlbl";
            this.dafromlbl.Size = new System.Drawing.Size(77, 20);
            this.dafromlbl.TabIndex = 35;
            this.dafromlbl.Text = "Date From:";
            // 
            // datetocmb
            // 
            this.datetocmb.CustomFormat = "yyyy-MM-dd";
            this.datetocmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetocmb.Location = new System.Drawing.Point(435, 406);
            this.datetocmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datetocmb.MinimumSize = new System.Drawing.Size(0, 30);
            this.datetocmb.Name = "datetocmb";
            this.datetocmb.Size = new System.Drawing.Size(151, 30);
            this.datetocmb.TabIndex = 34;
            // 
            // datefromcmb
            // 
            this.datefromcmb.CustomFormat = "yyyy-MM-dd";
            this.datefromcmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datefromcmb.Location = new System.Drawing.Point(281, 406);
            this.datefromcmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datefromcmb.MinimumSize = new System.Drawing.Size(0, 30);
            this.datefromcmb.Name = "datefromcmb";
            this.datefromcmb.Size = new System.Drawing.Size(144, 30);
            this.datefromcmb.TabIndex = 33;
            // 
            // searchtypelbl
            // 
            this.searchtypelbl.AutoSize = true;
            this.searchtypelbl.Location = new System.Drawing.Point(44, 402);
            this.searchtypelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchtypelbl.Name = "searchtypelbl";
            this.searchtypelbl.Size = new System.Drawing.Size(132, 20);
            this.searchtypelbl.TabIndex = 32;
            this.searchtypelbl.Text = "Choose search type";
            // 
            // searchtypecmb
            // 
            this.searchtypecmb.FormattingEnabled = true;
            this.searchtypecmb.ItemHeight = 24;
            this.searchtypecmb.Items.AddRange(new object[] {
            "Search By Name",
            "Search By Date",
            "Search By Name&Date"});
            this.searchtypecmb.Location = new System.Drawing.Point(29, 433);
            this.searchtypecmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchtypecmb.Name = "searchtypecmb";
            this.searchtypecmb.Size = new System.Drawing.Size(227, 30);
            this.searchtypecmb.TabIndex = 31;
            this.searchtypecmb.UseSelectable = true;
            this.searchtypecmb.SelectedIndexChanged += new System.EventHandler(this.searchtypecmb_SelectedIndexChanged);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(629, 476);
            this.backbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 28);
            this.backbtn.TabIndex = 30;
            this.backbtn.Text = "Back";
            this.backbtn.UseSelectable = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // savbtn
            // 
            this.savbtn.Location = new System.Drawing.Point(629, 326);
            this.savbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savbtn.Name = "savbtn";
            this.savbtn.Size = new System.Drawing.Size(100, 28);
            this.savbtn.TabIndex = 29;
            this.savbtn.Text = "Save";
            this.savbtn.UseSelectable = true;
            this.savbtn.Click += new System.EventHandler(this.savbtn_Click);
            // 
            // tamountlbl
            // 
            this.tamountlbl.AutoSize = true;
            this.tamountlbl.Location = new System.Drawing.Point(495, 299);
            this.tamountlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tamountlbl.Name = "tamountlbl";
            this.tamountlbl.Size = new System.Drawing.Size(90, 20);
            this.tamountlbl.TabIndex = 28;
            this.tamountlbl.Text = "Total Amount";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(277, 299);
            this.namelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(47, 20);
            this.namelbl.TabIndex = 27;
            this.namelbl.Text = "Name";
            // 
            // descriptionlbl
            // 
            this.descriptionlbl.AutoSize = true;
            this.descriptionlbl.Location = new System.Drawing.Point(12, 300);
            this.descriptionlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionlbl.Name = "descriptionlbl";
            this.descriptionlbl.Size = new System.Drawing.Size(79, 20);
            this.descriptionlbl.TabIndex = 26;
            this.descriptionlbl.Text = "Description";
            // 
            // totalamttxt
            // 
            // 
            // 
            // 
            this.totalamttxt.CustomButton.Image = null;
            this.totalamttxt.CustomButton.Location = new System.Drawing.Point(127, 2);
            this.totalamttxt.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalamttxt.CustomButton.Name = "";
            this.totalamttxt.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.totalamttxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalamttxt.CustomButton.TabIndex = 1;
            this.totalamttxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalamttxt.CustomButton.UseSelectable = true;
            this.totalamttxt.CustomButton.Visible = false;
            this.totalamttxt.Lines = new string[0];
            this.totalamttxt.Location = new System.Drawing.Point(499, 327);
            this.totalamttxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalamttxt.MaxLength = 32767;
            this.totalamttxt.Name = "totalamttxt";
            this.totalamttxt.PasswordChar = '\0';
            this.totalamttxt.PromptText = "0.00";
            this.totalamttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalamttxt.SelectedText = "";
            this.totalamttxt.SelectionLength = 0;
            this.totalamttxt.SelectionStart = 0;
            this.totalamttxt.ShortcutsEnabled = true;
            this.totalamttxt.Size = new System.Drawing.Size(121, 28);
            this.totalamttxt.TabIndex = 25;
            this.totalamttxt.UseSelectable = true;
            this.totalamttxt.WaterMark = "0.00";
            this.totalamttxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalamttxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datecmb
            // 
            this.datecmb.CustomFormat = "yyyy-MM-dd";
            this.datecmb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datecmb.Location = new System.Drawing.Point(477, 55);
            this.datecmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.datecmb.MinimumSize = new System.Drawing.Size(0, 30);
            this.datecmb.Name = "datecmb";
            this.datecmb.Size = new System.Drawing.Size(265, 30);
            this.datecmb.TabIndex = 24;
            // 
            // descriptiontxt
            // 
            // 
            // 
            // 
            this.descriptiontxt.CustomButton.Image = null;
            this.descriptiontxt.CustomButton.Location = new System.Drawing.Point(307, 2);
            this.descriptiontxt.CustomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptiontxt.CustomButton.Name = "";
            this.descriptiontxt.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.descriptiontxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptiontxt.CustomButton.TabIndex = 1;
            this.descriptiontxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptiontxt.CustomButton.UseSelectable = true;
            this.descriptiontxt.CustomButton.Visible = false;
            this.descriptiontxt.Lines = new string[0];
            this.descriptiontxt.Location = new System.Drawing.Point(16, 327);
            this.descriptiontxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptiontxt.MaxLength = 32767;
            this.descriptiontxt.Name = "descriptiontxt";
            this.descriptiontxt.PasswordChar = '\0';
            this.descriptiontxt.PromptText = "type here...";
            this.descriptiontxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptiontxt.SelectedText = "";
            this.descriptiontxt.SelectionLength = 0;
            this.descriptiontxt.SelectionStart = 0;
            this.descriptiontxt.ShortcutsEnabled = true;
            this.descriptiontxt.Size = new System.Drawing.Size(256, 28);
            this.descriptiontxt.TabIndex = 23;
            this.descriptiontxt.UseSelectable = true;
            this.descriptiontxt.WaterMark = "type here...";
            this.descriptiontxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptiontxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // costumercmb
            // 
            this.costumercmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.costumercmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.costumercmb.FormattingEnabled = true;
            this.costumercmb.Location = new System.Drawing.Point(280, 327);
            this.costumercmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.costumercmb.Name = "costumercmb";
            this.costumercmb.Size = new System.Drawing.Size(209, 24);
            this.costumercmb.TabIndex = 22;
            this.costumercmb.Leave += new System.EventHandler(this.costumercmb_Leave);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srnubmer,
            this.type,
            this.name,
            this.date,
            this.amount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(7, 98);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(737, 185);
            this.metroGrid1.TabIndex = 21;
            // 
            // srnubmer
            // 
            this.srnubmer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.srnubmer.HeaderText = "Sr.Number";
            this.srnubmer.MinimumWidth = 6;
            this.srnubmer.Name = "srnubmer";
            this.srnubmer.ReadOnly = true;
            this.srnubmer.Width = 30;
            // 
            // type
            // 
            this.type.HeaderText = "Description";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 150;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 70;
            // 
            // amount
            // 
            this.amount.HeaderText = "Total Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 60;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 517);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Expense";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton showbtn;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox searchnametxt;
        private MetroFramework.Controls.MetroLabel tolbl;
        private MetroFramework.Controls.MetroLabel dafromlbl;
        private MetroFramework.Controls.MetroDateTime datetocmb;
        private MetroFramework.Controls.MetroDateTime datefromcmb;
        private MetroFramework.Controls.MetroLabel searchtypelbl;
        private MetroFramework.Controls.MetroComboBox searchtypecmb;
        private MetroFramework.Controls.MetroButton backbtn;
        private MetroFramework.Controls.MetroButton savbtn;
        private MetroFramework.Controls.MetroLabel tamountlbl;
        private MetroFramework.Controls.MetroLabel namelbl;
        private MetroFramework.Controls.MetroLabel descriptionlbl;
        private MetroFramework.Controls.MetroTextBox totalamttxt;
        private MetroFramework.Controls.MetroDateTime datecmb;
        private MetroFramework.Controls.MetroTextBox descriptiontxt;
        private System.Windows.Forms.ComboBox costumercmb;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srnubmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}