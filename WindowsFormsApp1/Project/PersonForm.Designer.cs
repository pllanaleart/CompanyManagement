namespace WindowsFormsApp1.Project
{
    partial class PersonForm
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
            this.nametxt = new MetroFramework.Controls.MetroTextBox();
            this.addresstxt = new MetroFramework.Controls.MetroTextBox();
            this.pnumbertxt = new MetroFramework.Controls.MetroTextBox();
            this.registerbtn = new MetroFramework.Controls.MetroButton();
            this.namelbl = new MetroFramework.Controls.MetroLabel();
            this.addresslbl = new MetroFramework.Controls.MetroLabel();
            this.phonelbl = new MetroFramework.Controls.MetroLabel();
            this.costumerrbtn = new MetroFramework.Controls.MetroRadioButton();
            this.vendorrbtn = new MetroFramework.Controls.MetroRadioButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.searchtxt = new MetroFramework.Controls.MetroTextBox();
            this.searchbtn = new MetroFramework.Controls.MetroButton();
            this.backbtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            // 
            // 
            // 
            this.nametxt.CustomButton.Image = null;
            this.nametxt.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.nametxt.CustomButton.Name = "";
            this.nametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nametxt.CustomButton.TabIndex = 1;
            this.nametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nametxt.CustomButton.UseSelectable = true;
            this.nametxt.CustomButton.Visible = false;
            this.nametxt.Lines = new string[0];
            this.nametxt.Location = new System.Drawing.Point(24, 286);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PromptText = "Enter name";
            this.nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nametxt.SelectedText = "";
            this.nametxt.SelectionLength = 0;
            this.nametxt.SelectionStart = 0;
            this.nametxt.ShortcutsEnabled = true;
            this.nametxt.Size = new System.Drawing.Size(127, 23);
            this.nametxt.TabIndex = 1;
            this.nametxt.UseSelectable = true;
            this.nametxt.WaterMark = "Enter name";
            this.nametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addresstxt
            // 
            // 
            // 
            // 
            this.addresstxt.CustomButton.Image = null;
            this.addresstxt.CustomButton.Location = new System.Drawing.Point(88, 1);
            this.addresstxt.CustomButton.Name = "";
            this.addresstxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.addresstxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addresstxt.CustomButton.TabIndex = 1;
            this.addresstxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addresstxt.CustomButton.UseSelectable = true;
            this.addresstxt.CustomButton.Visible = false;
            this.addresstxt.Lines = new string[0];
            this.addresstxt.Location = new System.Drawing.Point(168, 286);
            this.addresstxt.MaxLength = 32767;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.PasswordChar = '\0';
            this.addresstxt.PromptText = "Enter Address";
            this.addresstxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addresstxt.SelectedText = "";
            this.addresstxt.SelectionLength = 0;
            this.addresstxt.SelectionStart = 0;
            this.addresstxt.ShortcutsEnabled = true;
            this.addresstxt.Size = new System.Drawing.Size(110, 23);
            this.addresstxt.TabIndex = 2;
            this.addresstxt.UseSelectable = true;
            this.addresstxt.WaterMark = "Enter Address";
            this.addresstxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.addresstxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnumbertxt
            // 
            // 
            // 
            // 
            this.pnumbertxt.CustomButton.Image = null;
            this.pnumbertxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.pnumbertxt.CustomButton.Name = "";
            this.pnumbertxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pnumbertxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pnumbertxt.CustomButton.TabIndex = 1;
            this.pnumbertxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pnumbertxt.CustomButton.UseSelectable = true;
            this.pnumbertxt.CustomButton.Visible = false;
            this.pnumbertxt.Lines = new string[0];
            this.pnumbertxt.Location = new System.Drawing.Point(303, 286);
            this.pnumbertxt.MaxLength = 32767;
            this.pnumbertxt.Name = "pnumbertxt";
            this.pnumbertxt.PasswordChar = '\0';
            this.pnumbertxt.PromptText = "Phone number";
            this.pnumbertxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pnumbertxt.SelectedText = "";
            this.pnumbertxt.SelectionLength = 0;
            this.pnumbertxt.SelectionStart = 0;
            this.pnumbertxt.ShortcutsEnabled = true;
            this.pnumbertxt.Size = new System.Drawing.Size(130, 23);
            this.pnumbertxt.TabIndex = 3;
            this.pnumbertxt.UseSelectable = true;
            this.pnumbertxt.WaterMark = "Phone number";
            this.pnumbertxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pnumbertxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(459, 286);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(113, 23);
            this.registerbtn.TabIndex = 4;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseSelectable = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(24, 261);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 19);
            this.namelbl.TabIndex = 5;
            this.namelbl.Text = "Name";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(168, 261);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(56, 19);
            this.addresslbl.TabIndex = 6;
            this.addresslbl.Text = "Address";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(303, 261);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(96, 19);
            this.phonelbl.TabIndex = 7;
            this.phonelbl.Text = "Phone number";
            // 
            // costumerrbtn
            // 
            this.costumerrbtn.AutoSize = true;
            this.costumerrbtn.Location = new System.Drawing.Point(24, 60);
            this.costumerrbtn.Name = "costumerrbtn";
            this.costumerrbtn.Size = new System.Drawing.Size(75, 15);
            this.costumerrbtn.TabIndex = 8;
            this.costumerrbtn.Text = "Costumer";
            this.costumerrbtn.UseSelectable = true;
            this.costumerrbtn.CheckedChanged += new System.EventHandler(this.costumerrbtn_CheckedChanged);
            this.costumerrbtn.Validated += new System.EventHandler(this.costumerrbtn_Validated);
            // 
            // vendorrbtn
            // 
            this.vendorrbtn.AutoSize = true;
            this.vendorrbtn.Location = new System.Drawing.Point(116, 60);
            this.vendorrbtn.Name = "vendorrbtn";
            this.vendorrbtn.Size = new System.Drawing.Size(60, 15);
            this.vendorrbtn.TabIndex = 9;
            this.vendorrbtn.Text = "Vendor";
            this.vendorrbtn.UseSelectable = true;
            this.vendorrbtn.CheckedChanged += new System.EventHandler(this.vendorrbtn_CheckedChanged);
            this.vendorrbtn.Validated += new System.EventHandler(this.vendorrbtn_Validated);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.Silver;
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
            this.id,
            this.name,
            this.address,
            this.phonenumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.Silver;
            this.metroGrid1.Location = new System.Drawing.Point(14, 96);
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
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(592, 150);
            this.metroGrid1.TabIndex = 10;
            this.metroGrid1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 175;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "Phone Number";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            this.phonenumber.Width = 175;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchtxt
            // 
            // 
            // 
            // 
            this.searchtxt.CustomButton.Image = null;
            this.searchtxt.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.searchtxt.CustomButton.Name = "";
            this.searchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchtxt.CustomButton.TabIndex = 1;
            this.searchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchtxt.CustomButton.UseSelectable = true;
            this.searchtxt.CustomButton.Visible = false;
            this.searchtxt.Lines = new string[0];
            this.searchtxt.Location = new System.Drawing.Point(236, 52);
            this.searchtxt.MaxLength = 32767;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.PromptText = "Search by name";
            this.searchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchtxt.SelectedText = "";
            this.searchtxt.SelectionLength = 0;
            this.searchtxt.SelectionStart = 0;
            this.searchtxt.ShortcutsEnabled = true;
            this.searchtxt.Size = new System.Drawing.Size(222, 23);
            this.searchtxt.TabIndex = 12;
            this.searchtxt.UseSelectable = true;
            this.searchtxt.WaterMark = "Search by name";
            this.searchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(484, 52);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 13;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseSelectable = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(459, 316);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(113, 23);
            this.backbtn.TabIndex = 14;
            this.backbtn.Text = "Back";
            this.backbtn.UseSelectable = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 352);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.vendorrbtn);
            this.Controls.Add(this.costumerrbtn);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.pnumbertxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.nametxt);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox nametxt;
        private MetroFramework.Controls.MetroTextBox addresstxt;
        private MetroFramework.Controls.MetroTextBox pnumbertxt;
        private MetroFramework.Controls.MetroButton registerbtn;
        private MetroFramework.Controls.MetroLabel namelbl;
        private MetroFramework.Controls.MetroLabel addresslbl;
        private MetroFramework.Controls.MetroLabel phonelbl;
        private MetroFramework.Controls.MetroRadioButton costumerrbtn;
        private MetroFramework.Controls.MetroRadioButton vendorrbtn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox searchtxt;
        private MetroFramework.Controls.MetroButton searchbtn;
        private MetroFramework.Controls.MetroButton backbtn;
    }
}