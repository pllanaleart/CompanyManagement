namespace WindowsFormsApp1.Forms
{
    partial class SaleForm
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
            this.viewwindow = new MetroFramework.Controls.MetroPanel();
            this.printbtn = new MetroFramework.Controls.MetroButton();
            this.deletebtn = new MetroFramework.Controls.MetroButton();
            this.productcodecmb = new MetroFramework.Controls.MetroTextBox();
            this.namecmb = new System.Windows.Forms.ComboBox();
            this.productcmb = new System.Windows.Forms.ComboBox();
            this.inbtn = new MetroFramework.Controls.MetroButton();
            this.backbtn = new MetroFramework.Controls.MetroButton();
            this.updatebtn = new MetroFramework.Controls.MetroButton();
            this.savebtn = new MetroFramework.Controls.MetroButton();
            this.totalamttxt = new MetroFramework.Controls.MetroTextBox();
            this.totalamountlbl = new MetroFramework.Controls.MetroLabel();
            this.editbtn = new MetroFramework.Controls.MetroButton();
            this.removebtn = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.serialno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecmb = new MetroFramework.Controls.MetroDateTime();
            this.amounttxt = new MetroFramework.Controls.MetroTextBox();
            this.ratetxt = new MetroFramework.Controls.MetroTextBox();
            this.qtytxt = new MetroFramework.Controls.MetroTextBox();
            this.showbtn = new MetroFramework.Controls.MetroButton();
            this.invoicenotxt = new MetroFramework.Controls.MetroTextBox();
            this.ratelbl = new MetroFramework.Controls.MetroLabel();
            this.qtylbl = new MetroFramework.Controls.MetroLabel();
            this.productlbl = new MetroFramework.Controls.MetroLabel();
            this.productcodelbl = new MetroFramework.Controls.MetroLabel();
            this.amountlbl = new MetroFramework.Controls.MetroLabel();
            this.datelbl = new MetroFramework.Controls.MetroLabel();
            this.namelbl = new MetroFramework.Controls.MetroLabel();
            this.invocenolbl = new MetroFramework.Controls.MetroLabel();
            this.viewwindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewwindow
            // 
            this.viewwindow.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.viewwindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewwindow.Controls.Add(this.printbtn);
            this.viewwindow.Controls.Add(this.deletebtn);
            this.viewwindow.Controls.Add(this.productcodecmb);
            this.viewwindow.Controls.Add(this.namecmb);
            this.viewwindow.Controls.Add(this.productcmb);
            this.viewwindow.Controls.Add(this.inbtn);
            this.viewwindow.Controls.Add(this.backbtn);
            this.viewwindow.Controls.Add(this.updatebtn);
            this.viewwindow.Controls.Add(this.savebtn);
            this.viewwindow.Controls.Add(this.totalamttxt);
            this.viewwindow.Controls.Add(this.totalamountlbl);
            this.viewwindow.Controls.Add(this.editbtn);
            this.viewwindow.Controls.Add(this.removebtn);
            this.viewwindow.Controls.Add(this.metroGrid1);
            this.viewwindow.Controls.Add(this.datecmb);
            this.viewwindow.Controls.Add(this.amounttxt);
            this.viewwindow.Controls.Add(this.ratetxt);
            this.viewwindow.Controls.Add(this.qtytxt);
            this.viewwindow.Controls.Add(this.showbtn);
            this.viewwindow.Controls.Add(this.invoicenotxt);
            this.viewwindow.Controls.Add(this.ratelbl);
            this.viewwindow.Controls.Add(this.qtylbl);
            this.viewwindow.Controls.Add(this.productlbl);
            this.viewwindow.Controls.Add(this.productcodelbl);
            this.viewwindow.Controls.Add(this.amountlbl);
            this.viewwindow.Controls.Add(this.datelbl);
            this.viewwindow.Controls.Add(this.namelbl);
            this.viewwindow.Controls.Add(this.invocenolbl);
            this.viewwindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewwindow.HorizontalScrollbarBarColor = true;
            this.viewwindow.HorizontalScrollbarHighlightOnWheel = false;
            this.viewwindow.HorizontalScrollbarSize = 10;
            this.viewwindow.Location = new System.Drawing.Point(20, 60);
            this.viewwindow.Name = "viewwindow";
            this.viewwindow.Size = new System.Drawing.Size(760, 397);
            this.viewwindow.TabIndex = 1;
            this.viewwindow.VerticalScrollbarBarColor = true;
            this.viewwindow.VerticalScrollbarHighlightOnWheel = false;
            this.viewwindow.VerticalScrollbarSize = 10;
            // 
            // printbtn
            // 
            this.printbtn.Location = new System.Drawing.Point(125, 357);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(75, 23);
            this.printbtn.TabIndex = 37;
            this.printbtn.Text = "Print";
            this.printbtn.UseSelectable = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(399, 358);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 36;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseSelectable = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // productcodecmb
            // 
            // 
            // 
            // 
            this.productcodecmb.CustomButton.Image = null;
            this.productcodecmb.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.productcodecmb.CustomButton.Name = "";
            this.productcodecmb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.productcodecmb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.productcodecmb.CustomButton.TabIndex = 1;
            this.productcodecmb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.productcodecmb.CustomButton.UseSelectable = true;
            this.productcodecmb.CustomButton.Visible = false;
            this.productcodecmb.Lines = new string[0];
            this.productcodecmb.Location = new System.Drawing.Point(15, 223);
            this.productcodecmb.MaxLength = 32767;
            this.productcodecmb.Name = "productcodecmb";
            this.productcodecmb.PasswordChar = '\0';
            this.productcodecmb.PromptText = "Product Code";
            this.productcodecmb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.productcodecmb.SelectedText = "";
            this.productcodecmb.SelectionLength = 0;
            this.productcodecmb.SelectionStart = 0;
            this.productcodecmb.ShortcutsEnabled = true;
            this.productcodecmb.Size = new System.Drawing.Size(94, 23);
            this.productcodecmb.TabIndex = 35;
            this.productcodecmb.UseSelectable = true;
            this.productcodecmb.WaterMark = "Product Code";
            this.productcodecmb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.productcodecmb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // namecmb
            // 
            this.namecmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.namecmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.namecmb.FormattingEnabled = true;
            this.namecmb.Location = new System.Drawing.Point(213, 38);
            this.namecmb.Name = "namecmb";
            this.namecmb.Size = new System.Drawing.Size(364, 21);
            this.namecmb.TabIndex = 34;
            this.namecmb.SelectedIndexChanged += new System.EventHandler(this.namecmb_SelectedIndexChanged);
            this.namecmb.Leave += new System.EventHandler(this.namecmb_Leave);
            // 
            // productcmb
            // 
            this.productcmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productcmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productcmb.FormattingEnabled = true;
            this.productcmb.Location = new System.Drawing.Point(125, 223);
            this.productcmb.Name = "productcmb";
            this.productcmb.Size = new System.Drawing.Size(121, 21);
            this.productcmb.TabIndex = 32;
            this.productcmb.SelectedIndexChanged += new System.EventHandler(this.productcmb_SelectedIndexChanged);
            // 
            // inbtn
            // 
            this.inbtn.Location = new System.Drawing.Point(611, 223);
            this.inbtn.Name = "inbtn";
            this.inbtn.Size = new System.Drawing.Size(51, 23);
            this.inbtn.TabIndex = 31;
            this.inbtn.Text = "In";
            this.inbtn.UseSelectable = true;
            this.inbtn.Click += new System.EventHandler(this.inbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(611, 358);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 30;
            this.backbtn.Text = "Back";
            this.backbtn.UseSelectable = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(318, 358);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 29;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseSelectable = true;
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(489, 358);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(114, 23);
            this.savebtn.TabIndex = 28;
            this.savebtn.Text = "Save";
            this.savebtn.UseSelectable = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // totalamttxt
            // 
            // 
            // 
            // 
            this.totalamttxt.CustomButton.Image = null;
            this.totalamttxt.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.totalamttxt.CustomButton.Name = "";
            this.totalamttxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.totalamttxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.totalamttxt.CustomButton.TabIndex = 1;
            this.totalamttxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.totalamttxt.CustomButton.UseSelectable = true;
            this.totalamttxt.CustomButton.Visible = false;
            this.totalamttxt.Lines = new string[0];
            this.totalamttxt.Location = new System.Drawing.Point(15, 358);
            this.totalamttxt.MaxLength = 32767;
            this.totalamttxt.Name = "totalamttxt";
            this.totalamttxt.PasswordChar = '\0';
            this.totalamttxt.PromptText = "Total Amount";
            this.totalamttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.totalamttxt.SelectedText = "";
            this.totalamttxt.SelectionLength = 0;
            this.totalamttxt.SelectionStart = 0;
            this.totalamttxt.ShortcutsEnabled = true;
            this.totalamttxt.Size = new System.Drawing.Size(94, 23);
            this.totalamttxt.TabIndex = 27;
            this.totalamttxt.UseSelectable = true;
            this.totalamttxt.WaterMark = "Total Amount";
            this.totalamttxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.totalamttxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // totalamountlbl
            // 
            this.totalamountlbl.AutoSize = true;
            this.totalamountlbl.Location = new System.Drawing.Point(15, 336);
            this.totalamountlbl.Name = "totalamountlbl";
            this.totalamountlbl.Size = new System.Drawing.Size(87, 19);
            this.totalamountlbl.TabIndex = 26;
            this.totalamountlbl.Text = "Total Amount";
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(635, 151);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(51, 23);
            this.editbtn.TabIndex = 25;
            this.editbtn.Text = "Edit";
            this.editbtn.UseSelectable = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(635, 108);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(51, 25);
            this.removebtn.TabIndex = 24;
            this.removebtn.Text = "Remove";
            this.removebtn.UseSelectable = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            this.serialno,
            this.productcode,
            this.product,
            this.qty,
            this.rate,
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
            this.metroGrid1.Location = new System.Drawing.Point(15, 74);
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
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(614, 100);
            this.metroGrid1.TabIndex = 23;
            this.metroGrid1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseDoubleClick);
            // 
            // serialno
            // 
            this.serialno.HeaderText = "Serial No.";
            this.serialno.Name = "serialno";
            this.serialno.ReadOnly = true;
            this.serialno.Width = 70;
            // 
            // productcode
            // 
            this.productcode.HeaderText = "Product Code";
            this.productcode.Name = "productcode";
            this.productcode.ReadOnly = true;
            this.productcode.Width = 70;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 220;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 70;
            // 
            // rate
            // 
            this.rate.HeaderText = "Rate";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Width = 70;
            // 
            // amount
            // 
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            this.amount.Width = 70;
            // 
            // datecmb
            // 
            this.datecmb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datecmb.Location = new System.Drawing.Point(587, 30);
            this.datecmb.MinimumSize = new System.Drawing.Size(0, 29);
            this.datecmb.Name = "datecmb";
            this.datecmb.Size = new System.Drawing.Size(99, 29);
            this.datecmb.TabIndex = 22;
            // 
            // amounttxt
            // 
            // 
            // 
            // 
            this.amounttxt.CustomButton.Image = null;
            this.amounttxt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.amounttxt.CustomButton.Name = "";
            this.amounttxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.amounttxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amounttxt.CustomButton.TabIndex = 1;
            this.amounttxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amounttxt.CustomButton.UseSelectable = true;
            this.amounttxt.CustomButton.Visible = false;
            this.amounttxt.Lines = new string[0];
            this.amounttxt.Location = new System.Drawing.Point(528, 223);
            this.amounttxt.MaxLength = 32767;
            this.amounttxt.Name = "amounttxt";
            this.amounttxt.PasswordChar = '\0';
            this.amounttxt.PromptText = "Amount";
            this.amounttxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amounttxt.SelectedText = "";
            this.amounttxt.SelectionLength = 0;
            this.amounttxt.SelectionStart = 0;
            this.amounttxt.ShortcutsEnabled = true;
            this.amounttxt.Size = new System.Drawing.Size(75, 23);
            this.amounttxt.TabIndex = 21;
            this.amounttxt.UseSelectable = true;
            this.amounttxt.WaterMark = "Amount";
            this.amounttxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.amounttxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.amounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amounttxt_KeyPress);
            // 
            // ratetxt
            // 
            // 
            // 
            // 
            this.ratetxt.CustomButton.Image = null;
            this.ratetxt.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.ratetxt.CustomButton.Name = "";
            this.ratetxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ratetxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ratetxt.CustomButton.TabIndex = 1;
            this.ratetxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ratetxt.CustomButton.UseSelectable = true;
            this.ratetxt.CustomButton.Visible = false;
            this.ratetxt.Lines = new string[0];
            this.ratetxt.Location = new System.Drawing.Point(420, 223);
            this.ratetxt.MaxLength = 32767;
            this.ratetxt.Name = "ratetxt";
            this.ratetxt.PasswordChar = '\0';
            this.ratetxt.PromptText = "Rate";
            this.ratetxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ratetxt.SelectedText = "";
            this.ratetxt.SelectionLength = 0;
            this.ratetxt.SelectionStart = 0;
            this.ratetxt.ShortcutsEnabled = true;
            this.ratetxt.Size = new System.Drawing.Size(75, 23);
            this.ratetxt.TabIndex = 20;
            this.ratetxt.UseSelectable = true;
            this.ratetxt.WaterMark = "Rate";
            this.ratetxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ratetxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ratetxt.TextChanged += new System.EventHandler(this.ratetxt_TextChanged);
            this.ratetxt.Click += new System.EventHandler(this.ratetxt_Click);
            this.ratetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratetxt_KeyPress);
            // 
            // qtytxt
            // 
            // 
            // 
            // 
            this.qtytxt.CustomButton.Image = null;
            this.qtytxt.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.qtytxt.CustomButton.Name = "";
            this.qtytxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.qtytxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.qtytxt.CustomButton.TabIndex = 1;
            this.qtytxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.qtytxt.CustomButton.UseSelectable = true;
            this.qtytxt.CustomButton.Visible = false;
            this.qtytxt.Lines = new string[0];
            this.qtytxt.Location = new System.Drawing.Point(323, 223);
            this.qtytxt.MaxLength = 32767;
            this.qtytxt.Name = "qtytxt";
            this.qtytxt.PasswordChar = '\0';
            this.qtytxt.PromptText = "Qty";
            this.qtytxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.qtytxt.SelectedText = "";
            this.qtytxt.SelectionLength = 0;
            this.qtytxt.SelectionStart = 0;
            this.qtytxt.ShortcutsEnabled = true;
            this.qtytxt.Size = new System.Drawing.Size(69, 23);
            this.qtytxt.TabIndex = 19;
            this.qtytxt.UseSelectable = true;
            this.qtytxt.WaterMark = "Qty";
            this.qtytxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.qtytxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.qtytxt.TextChanged += new System.EventHandler(this.qtytxt_TextChanged);
            this.qtytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qtytxt_KeyPress);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(147, 38);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(59, 23);
            this.showbtn.TabIndex = 16;
            this.showbtn.Text = "Show";
            this.showbtn.UseSelectable = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // invoicenotxt
            // 
            // 
            // 
            // 
            this.invoicenotxt.CustomButton.Image = null;
            this.invoicenotxt.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.invoicenotxt.CustomButton.Name = "";
            this.invoicenotxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.invoicenotxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.invoicenotxt.CustomButton.TabIndex = 1;
            this.invoicenotxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.invoicenotxt.CustomButton.UseSelectable = true;
            this.invoicenotxt.CustomButton.Visible = false;
            this.invoicenotxt.Lines = new string[0];
            this.invoicenotxt.Location = new System.Drawing.Point(15, 38);
            this.invoicenotxt.MaxLength = 32767;
            this.invoicenotxt.Name = "invoicenotxt";
            this.invoicenotxt.PasswordChar = '\0';
            this.invoicenotxt.PromptText = "Invoice No.";
            this.invoicenotxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.invoicenotxt.SelectedText = "";
            this.invoicenotxt.SelectionLength = 0;
            this.invoicenotxt.SelectionStart = 0;
            this.invoicenotxt.ShortcutsEnabled = true;
            this.invoicenotxt.Size = new System.Drawing.Size(126, 23);
            this.invoicenotxt.TabIndex = 15;
            this.invoicenotxt.UseSelectable = true;
            this.invoicenotxt.WaterMark = "Invoice No.";
            this.invoicenotxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.invoicenotxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Location = new System.Drawing.Point(420, 189);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(35, 19);
            this.ratelbl.TabIndex = 10;
            this.ratelbl.Text = "Rate";
            // 
            // qtylbl
            // 
            this.qtylbl.AutoSize = true;
            this.qtylbl.Location = new System.Drawing.Point(323, 189);
            this.qtylbl.Name = "qtylbl";
            this.qtylbl.Size = new System.Drawing.Size(30, 19);
            this.qtylbl.TabIndex = 9;
            this.qtylbl.Text = "Qty";
            // 
            // productlbl
            // 
            this.productlbl.AutoSize = true;
            this.productlbl.Location = new System.Drawing.Point(125, 189);
            this.productlbl.Name = "productlbl";
            this.productlbl.Size = new System.Drawing.Size(55, 19);
            this.productlbl.TabIndex = 8;
            this.productlbl.Text = "Product";
            // 
            // productcodelbl
            // 
            this.productcodelbl.AutoSize = true;
            this.productcodelbl.Location = new System.Drawing.Point(13, 189);
            this.productcodelbl.Name = "productcodelbl";
            this.productcodelbl.Size = new System.Drawing.Size(88, 19);
            this.productcodelbl.TabIndex = 7;
            this.productcodelbl.Text = "Product code";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Location = new System.Drawing.Point(521, 189);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(56, 19);
            this.amountlbl.TabIndex = 6;
            this.amountlbl.Text = "Amount";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(587, 7);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(36, 19);
            this.datelbl.TabIndex = 4;
            this.datelbl.Text = "Date";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(212, 16);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(45, 19);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name";
            // 
            // invocenolbl
            // 
            this.invocenolbl.AutoSize = true;
            this.invocenolbl.Location = new System.Drawing.Point(15, 16);
            this.invocenolbl.Name = "invocenolbl";
            this.invocenolbl.Size = new System.Drawing.Size(71, 19);
            this.invocenolbl.TabIndex = 2;
            this.invocenolbl.Text = "Invoce No.";
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.viewwindow);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.viewwindow.ResumeLayout(false);
            this.viewwindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel viewwindow;
        private MetroFramework.Controls.MetroButton printbtn;
        private MetroFramework.Controls.MetroButton deletebtn;
        private MetroFramework.Controls.MetroTextBox productcodecmb;
        private System.Windows.Forms.ComboBox namecmb;
        private System.Windows.Forms.ComboBox productcmb;
        private MetroFramework.Controls.MetroButton inbtn;
        private MetroFramework.Controls.MetroButton backbtn;
        private MetroFramework.Controls.MetroButton updatebtn;
        private MetroFramework.Controls.MetroButton savebtn;
        private MetroFramework.Controls.MetroTextBox totalamttxt;
        private MetroFramework.Controls.MetroLabel totalamountlbl;
        private MetroFramework.Controls.MetroButton editbtn;
        private MetroFramework.Controls.MetroButton removebtn;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialno;
        private System.Windows.Forms.DataGridViewTextBoxColumn productcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private MetroFramework.Controls.MetroDateTime datecmb;
        private MetroFramework.Controls.MetroTextBox amounttxt;
        private MetroFramework.Controls.MetroTextBox ratetxt;
        private MetroFramework.Controls.MetroTextBox qtytxt;
        private MetroFramework.Controls.MetroButton showbtn;
        private MetroFramework.Controls.MetroTextBox invoicenotxt;
        private MetroFramework.Controls.MetroLabel ratelbl;
        private MetroFramework.Controls.MetroLabel qtylbl;
        private MetroFramework.Controls.MetroLabel productlbl;
        private MetroFramework.Controls.MetroLabel productcodelbl;
        private MetroFramework.Controls.MetroLabel amountlbl;
        private MetroFramework.Controls.MetroLabel datelbl;
        private MetroFramework.Controls.MetroLabel namelbl;
        private MetroFramework.Controls.MetroLabel invocenolbl;
    }
}