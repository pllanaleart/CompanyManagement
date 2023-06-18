namespace WindowsFormsApp1.Project
{
    partial class userform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.serialno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametxt = new MetroFramework.Controls.MetroTextBox();
            this.passwordtxt = new MetroFramework.Controls.MetroTextBox();
            this.namelbl = new MetroFramework.Controls.MetroLabel();
            this.passwordlbl = new MetroFramework.Controls.MetroLabel();
            this.registerbtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialno,
            this.name,
            this.role});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(16, 76);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(434, 150);
            this.metroGrid1.TabIndex = 0;
            // 
            // serialno
            // 
            this.serialno.HeaderText = "Serial No.";
            this.serialno.Name = "serialno";
            this.serialno.Width = 50;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // role
            // 
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            this.role.Width = 150;
            // 
            // nametxt
            // 
            // 
            // 
            // 
            this.nametxt.CustomButton.Image = null;
            this.nametxt.CustomButton.Location = new System.Drawing.Point(108, 1);
            this.nametxt.CustomButton.Name = "";
            this.nametxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nametxt.CustomButton.TabIndex = 1;
            this.nametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nametxt.CustomButton.UseSelectable = true;
            this.nametxt.CustomButton.Visible = false;
            this.nametxt.Lines = new string[0];
            this.nametxt.Location = new System.Drawing.Point(16, 261);
            this.nametxt.MaxLength = 32767;
            this.nametxt.Name = "nametxt";
            this.nametxt.PasswordChar = '\0';
            this.nametxt.PromptText = "type here...";
            this.nametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nametxt.SelectedText = "";
            this.nametxt.SelectionLength = 0;
            this.nametxt.SelectionStart = 0;
            this.nametxt.ShortcutsEnabled = true;
            this.nametxt.Size = new System.Drawing.Size(130, 23);
            this.nametxt.TabIndex = 1;
            this.nametxt.UseSelectable = true;
            this.nametxt.WaterMark = "type here...";
            this.nametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordtxt
            // 
            // 
            // 
            // 
            this.passwordtxt.CustomButton.Image = null;
            this.passwordtxt.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.passwordtxt.CustomButton.Name = "";
            this.passwordtxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwordtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordtxt.CustomButton.TabIndex = 1;
            this.passwordtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordtxt.CustomButton.UseSelectable = true;
            this.passwordtxt.CustomButton.Visible = false;
            this.passwordtxt.Lines = new string[0];
            this.passwordtxt.Location = new System.Drawing.Point(152, 261);
            this.passwordtxt.MaxLength = 32767;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '\0';
            this.passwordtxt.PromptText = "type here...";
            this.passwordtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.SelectionLength = 0;
            this.passwordtxt.SelectionStart = 0;
            this.passwordtxt.ShortcutsEnabled = true;
            this.passwordtxt.Size = new System.Drawing.Size(153, 23);
            this.passwordtxt.TabIndex = 2;
            this.passwordtxt.UseSelectable = true;
            this.passwordtxt.WaterMark = "type here...";
            this.passwordtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(16, 236);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(48, 19);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name:";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(152, 236);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(66, 19);
            this.passwordlbl.TabIndex = 4;
            this.passwordlbl.Text = "Password:";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(320, 261);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(107, 23);
            this.registerbtn.TabIndex = 5;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseSelectable = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // userform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.metroGrid1);
            this.Name = "userform";
            this.Text = "userform";
            this.Load += new System.EventHandler(this.userform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialno;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private MetroFramework.Controls.MetroTextBox nametxt;
        private MetroFramework.Controls.MetroTextBox passwordtxt;
        private MetroFramework.Controls.MetroLabel namelbl;
        private MetroFramework.Controls.MetroLabel passwordlbl;
        private MetroFramework.Controls.MetroButton registerbtn;
    }
}