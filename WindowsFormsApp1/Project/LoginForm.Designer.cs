namespace WindowsFormsApp1.Project
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.loginbtn = new MetroFramework.Controls.MetroButton();
            this.exitbtn = new MetroFramework.Controls.MetroButton();
            this.passwordtxt = new MetroFramework.Controls.MetroTextBox();
            this.usernamelbl = new MetroFramework.Controls.MetroLabel();
            this.passwordlbl = new MetroFramework.Controls.MetroLabel();
            this.usernametxt = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroUserControl1
            // 
            resources.ApplyResources(this.metroUserControl1, "metroUserControl1");
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.UseSelectable = true;
            // 
            // loginbtn
            // 
            resources.ApplyResources(this.loginbtn, "loginbtn");
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.UseSelectable = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // exitbtn
            // 
            resources.ApplyResources(this.exitbtn, "exitbtn");
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.UseSelectable = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // passwordtxt
            // 
            // 
            // 
            // 
            this.passwordtxt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.passwordtxt.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.passwordtxt.CustomButton.Name = "";
            this.passwordtxt.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.passwordtxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordtxt.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.passwordtxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordtxt.CustomButton.UseSelectable = true;
            this.passwordtxt.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.passwordtxt.Lines = new string[0];
            resources.ApplyResources(this.passwordtxt, "passwordtxt");
            this.passwordtxt.MaxLength = 32767;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '\0';
            this.passwordtxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.SelectionLength = 0;
            this.passwordtxt.SelectionStart = 0;
            this.passwordtxt.ShortcutsEnabled = true;
            this.passwordtxt.UseSelectable = true;
            this.passwordtxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordtxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usernamelbl
            // 
            resources.ApplyResources(this.usernamelbl, "usernamelbl");
            this.usernamelbl.Name = "usernamelbl";
            // 
            // passwordlbl
            // 
            resources.ApplyResources(this.passwordlbl, "passwordlbl");
            this.passwordlbl.Name = "passwordlbl";
            // 
            // usernametxt
            // 
            // 
            // 
            // 
            this.usernametxt.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.usernametxt.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.usernametxt.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.usernametxt.CustomButton.Name = "";
            this.usernametxt.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.usernametxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernametxt.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.usernametxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernametxt.CustomButton.UseSelectable = true;
            this.usernametxt.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.usernametxt.Lines = new string[0];
            resources.ApplyResources(this.usernametxt, "usernametxt");
            this.usernametxt.MaxLength = 32767;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernametxt.SelectedText = "";
            this.usernametxt.SelectionLength = 0;
            this.usernametxt.SelectionStart = 0;
            this.usernametxt.ShortcutsEnabled = true;
            this.usernametxt.UseSelectable = true;
            this.usernametxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.usernametxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordtxt);
            this.groupBox1.Controls.Add(this.usernametxt);
            this.groupBox1.Controls.Add(this.exitbtn);
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.metroUserControl1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Name = "LoginForm";
            this.Resizable = false;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
        private MetroFramework.Controls.MetroButton loginbtn;
        private MetroFramework.Controls.MetroButton exitbtn;
        private MetroFramework.Controls.MetroTextBox passwordtxt;
        private MetroFramework.Controls.MetroLabel usernamelbl;
        private MetroFramework.Controls.MetroLabel passwordlbl;
        private MetroFramework.Controls.MetroTextBox usernametxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}