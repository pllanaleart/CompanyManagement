namespace WindowsFormsApp1.Project
{
    partial class ProductEntryFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pidlbl = new MetroFramework.Controls.MetroLabel();
            this.productlbl = new MetroFramework.Controls.MetroLabel();
            this.ratelbl = new MetroFramework.Controls.MetroLabel();
            this.savebtn = new MetroFramework.Controls.MetroButton();
            this.updatebtn = new MetroFramework.Controls.MetroButton();
            this.deletebtn = new MetroFramework.Controls.MetroButton();
            this.pidtxt = new MetroFramework.Controls.MetroTextBox();
            this.producttxt = new MetroFramework.Controls.MetroTextBox();
            this.ratetxt = new MetroFramework.Controls.MetroTextBox();
            this.mrptxt = new MetroFramework.Controls.MetroTextBox();
            this.mrplbl = new MetroFramework.Controls.MetroLabel();
            this.backbtn = new MetroFramework.Controls.MetroButton();
            this.searchtxt = new MetroFramework.Controls.MetroTextBox();
            this.searchbtn = new MetroFramework.Controls.MetroButton();
            this.plrlbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(440, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // pidlbl
            // 
            this.pidlbl.AutoSize = true;
            this.pidlbl.Location = new System.Drawing.Point(8, 232);
            this.pidlbl.Name = "pidlbl";
            this.pidlbl.Size = new System.Drawing.Size(71, 19);
            this.pidlbl.TabIndex = 1;
            this.pidlbl.Text = "Product ID";
            // 
            // productlbl
            // 
            this.productlbl.AutoSize = true;
            this.productlbl.Location = new System.Drawing.Point(113, 232);
            this.productlbl.Name = "productlbl";
            this.productlbl.Size = new System.Drawing.Size(95, 19);
            this.productlbl.TabIndex = 2;
            this.productlbl.Text = "Product Name";
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Location = new System.Drawing.Point(232, 232);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(35, 19);
            this.ratelbl.TabIndex = 3;
            this.ratelbl.Text = "Rate";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(7, 309);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "Save";
            this.savebtn.UseSelectable = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(112, 309);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 5;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseSelectable = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(218, 309);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 6;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseSelectable = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // pidtxt
            // 
            // 
            // 
            // 
            this.pidtxt.CustomButton.Image = null;
            this.pidtxt.CustomButton.Location = new System.Drawing.Point(69, 1);
            this.pidtxt.CustomButton.Name = "";
            this.pidtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pidtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pidtxt.CustomButton.TabIndex = 1;
            this.pidtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pidtxt.CustomButton.UseSelectable = true;
            this.pidtxt.CustomButton.Visible = false;
            this.pidtxt.Lines = new string[0];
            this.pidtxt.Location = new System.Drawing.Point(6, 259);
            this.pidtxt.MaxLength = 32767;
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.PasswordChar = '\0';
            this.pidtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pidtxt.SelectedText = "";
            this.pidtxt.SelectionLength = 0;
            this.pidtxt.SelectionStart = 0;
            this.pidtxt.ShortcutsEnabled = true;
            this.pidtxt.Size = new System.Drawing.Size(91, 23);
            this.pidtxt.TabIndex = 7;
            this.pidtxt.UseSelectable = true;
            this.pidtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pidtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // producttxt
            // 
            // 
            // 
            // 
            this.producttxt.CustomButton.Image = null;
            this.producttxt.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.producttxt.CustomButton.Name = "";
            this.producttxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.producttxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.producttxt.CustomButton.TabIndex = 1;
            this.producttxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.producttxt.CustomButton.UseSelectable = true;
            this.producttxt.CustomButton.Visible = false;
            this.producttxt.Lines = new string[0];
            this.producttxt.Location = new System.Drawing.Point(113, 259);
            this.producttxt.MaxLength = 32767;
            this.producttxt.Name = "producttxt";
            this.producttxt.PasswordChar = '\0';
            this.producttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.producttxt.SelectedText = "";
            this.producttxt.SelectionLength = 0;
            this.producttxt.SelectionStart = 0;
            this.producttxt.ShortcutsEnabled = true;
            this.producttxt.Size = new System.Drawing.Size(99, 23);
            this.producttxt.TabIndex = 8;
            this.producttxt.UseSelectable = true;
            this.producttxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.producttxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ratetxt
            // 
            // 
            // 
            // 
            this.ratetxt.CustomButton.Image = null;
            this.ratetxt.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.ratetxt.CustomButton.Name = "";
            this.ratetxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ratetxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ratetxt.CustomButton.TabIndex = 1;
            this.ratetxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ratetxt.CustomButton.UseSelectable = true;
            this.ratetxt.CustomButton.Visible = false;
            this.ratetxt.Lines = new string[0];
            this.ratetxt.Location = new System.Drawing.Point(232, 259);
            this.ratetxt.MaxLength = 32767;
            this.ratetxt.Name = "ratetxt";
            this.ratetxt.PasswordChar = '\0';
            this.ratetxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ratetxt.SelectedText = "";
            this.ratetxt.SelectionLength = 0;
            this.ratetxt.SelectionStart = 0;
            this.ratetxt.ShortcutsEnabled = true;
            this.ratetxt.Size = new System.Drawing.Size(94, 23);
            this.ratetxt.TabIndex = 9;
            this.ratetxt.UseSelectable = true;
            this.ratetxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ratetxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mrptxt
            // 
            // 
            // 
            // 
            this.mrptxt.CustomButton.Image = null;
            this.mrptxt.CustomButton.Location = new System.Drawing.Point(75, 1);
            this.mrptxt.CustomButton.Name = "";
            this.mrptxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mrptxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mrptxt.CustomButton.TabIndex = 1;
            this.mrptxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mrptxt.CustomButton.UseSelectable = true;
            this.mrptxt.CustomButton.Visible = false;
            this.mrptxt.Lines = new string[0];
            this.mrptxt.Location = new System.Drawing.Point(349, 259);
            this.mrptxt.MaxLength = 32767;
            this.mrptxt.Name = "mrptxt";
            this.mrptxt.PasswordChar = '\0';
            this.mrptxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mrptxt.SelectedText = "";
            this.mrptxt.SelectionLength = 0;
            this.mrptxt.SelectionStart = 0;
            this.mrptxt.ShortcutsEnabled = true;
            this.mrptxt.Size = new System.Drawing.Size(97, 23);
            this.mrptxt.TabIndex = 10;
            this.mrptxt.UseSelectable = true;
            this.mrptxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mrptxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mrplbl
            // 
            this.mrplbl.AutoSize = true;
            this.mrplbl.Location = new System.Drawing.Point(347, 232);
            this.mrplbl.Name = "mrplbl";
            this.mrplbl.Size = new System.Drawing.Size(37, 19);
            this.mrplbl.TabIndex = 11;
            this.mrplbl.Text = "MRP";
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(370, 309);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 12;
            this.backbtn.Text = "Back";
            this.backbtn.UseSelectable = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // searchtxt
            // 
            // 
            // 
            // 
            this.searchtxt.CustomButton.Image = null;
            this.searchtxt.CustomButton.Location = new System.Drawing.Point(167, 1);
            this.searchtxt.CustomButton.Name = "";
            this.searchtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.searchtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchtxt.CustomButton.TabIndex = 1;
            this.searchtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchtxt.CustomButton.UseSelectable = true;
            this.searchtxt.CustomButton.Visible = false;
            this.searchtxt.Lines = new string[0];
            this.searchtxt.Location = new System.Drawing.Point(176, 29);
            this.searchtxt.MaxLength = 32767;
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.PasswordChar = '\0';
            this.searchtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchtxt.SelectedText = "";
            this.searchtxt.SelectionLength = 0;
            this.searchtxt.SelectionStart = 0;
            this.searchtxt.ShortcutsEnabled = true;
            this.searchtxt.Size = new System.Drawing.Size(189, 23);
            this.searchtxt.TabIndex = 13;
            this.searchtxt.UseSelectable = true;
            this.searchtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(371, 29);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 15;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseSelectable = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // plrlbl
            // 
            this.plrlbl.AutoSize = true;
            this.plrlbl.Location = new System.Drawing.Point(6, 345);
            this.plrlbl.Name = "plrlbl";
            this.plrlbl.Size = new System.Drawing.Size(122, 19);
            this.plrlbl.TabIndex = 16;
            this.plrlbl.Text = "Product List Report";
            this.plrlbl.Click += new System.EventHandler(this.plrlbl_Click);
            // 
            // ProductEntryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 367);
            this.Controls.Add(this.plrlbl);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.mrplbl);
            this.Controls.Add(this.mrptxt);
            this.Controls.Add(this.ratetxt);
            this.Controls.Add(this.producttxt);
            this.Controls.Add(this.pidtxt);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.ratelbl);
            this.Controls.Add(this.productlbl);
            this.Controls.Add(this.pidlbl);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(453, 367);
            this.MinimumSize = new System.Drawing.Size(453, 367);
            this.Name = "ProductEntryFrm";
            this.Text = "Product Entry";
            this.Load += new System.EventHandler(this.ProductEntryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel pidlbl;
        private MetroFramework.Controls.MetroLabel productlbl;
        private MetroFramework.Controls.MetroLabel ratelbl;
        private MetroFramework.Controls.MetroButton savebtn;
        private MetroFramework.Controls.MetroButton updatebtn;
        private MetroFramework.Controls.MetroButton deletebtn;
        private MetroFramework.Controls.MetroTextBox pidtxt;
        private MetroFramework.Controls.MetroTextBox producttxt;
        private MetroFramework.Controls.MetroTextBox ratetxt;
        private MetroFramework.Controls.MetroTextBox mrptxt;
        private MetroFramework.Controls.MetroLabel mrplbl;
        private MetroFramework.Controls.MetroButton backbtn;
        private MetroFramework.Controls.MetroTextBox searchtxt;
        private MetroFramework.Controls.MetroButton searchbtn;
        private MetroFramework.Controls.MetroLabel plrlbl;
    }
}