namespace WindowsFormsApp1.Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saletl = new MetroFramework.Controls.MetroTile();
            this.purchasetl = new MetroFramework.Controls.MetroTile();
            this.incometl = new MetroFramework.Controls.MetroTile();
            this.expensetl = new MetroFramework.Controls.MetroTile();
            this.salereporttl = new MetroFramework.Controls.MetroTile();
            this.purchasereporttl = new MetroFramework.Controls.MetroTile();
            this.userlbl = new MetroFramework.Controls.MetroLabel();
            this.welcomelbl = new MetroFramework.Controls.MetroLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bckrcvtl = new MetroFramework.Controls.MetroTile();
            this.persondtltl = new MetroFramework.Controls.MetroTile();
            this.stocktl = new MetroFramework.Controls.MetroTile();
            this.productregister = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saletl
            // 
            this.saletl.ActiveControl = null;
            this.saletl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saletl.BackColor = System.Drawing.Color.Firebrick;
            this.saletl.ForeColor = System.Drawing.Color.Snow;
            this.saletl.Location = new System.Drawing.Point(134, 89);
            this.saletl.Name = "saletl";
            this.saletl.Size = new System.Drawing.Size(91, 101);
            this.saletl.TabIndex = 0;
            this.saletl.Text = "Sale\r\nInvoice";
            this.saletl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saletl.TileImage = ((System.Drawing.Image)(resources.GetObject("saletl.TileImage")));
            this.saletl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saletl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.saletl.UseCustomBackColor = true;
            this.saletl.UseSelectable = true;
            this.saletl.UseTileImage = true;
            this.saletl.Click += new System.EventHandler(this.saletl_Click);
            // 
            // purchasetl
            // 
            this.purchasetl.ActiveControl = null;
            this.purchasetl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasetl.BackColor = System.Drawing.Color.Firebrick;
            this.purchasetl.Location = new System.Drawing.Point(34, 89);
            this.purchasetl.Name = "purchasetl";
            this.purchasetl.Size = new System.Drawing.Size(91, 101);
            this.purchasetl.TabIndex = 1;
            this.purchasetl.Text = "Purchase\r\nInvoice";
            this.purchasetl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.purchasetl.TileImage = ((System.Drawing.Image)(resources.GetObject("purchasetl.TileImage")));
            this.purchasetl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.purchasetl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.purchasetl.UseCustomBackColor = true;
            this.purchasetl.UseSelectable = true;
            this.purchasetl.UseTileImage = true;
            this.purchasetl.Click += new System.EventHandler(this.purchasetl_Click);
            // 
            // incometl
            // 
            this.incometl.ActiveControl = null;
            this.incometl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.incometl.BackColor = System.Drawing.Color.Firebrick;
            this.incometl.Location = new System.Drawing.Point(234, 30);
            this.incometl.Name = "incometl";
            this.incometl.Size = new System.Drawing.Size(91, 87);
            this.incometl.TabIndex = 2;
            this.incometl.Text = "Income";
            this.incometl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.incometl.TileImage = ((System.Drawing.Image)(resources.GetObject("incometl.TileImage")));
            this.incometl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.incometl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.incometl.UseCustomBackColor = true;
            this.incometl.UseSelectable = true;
            this.incometl.UseTileImage = true;
            this.incometl.Click += new System.EventHandler(this.incometl_Click);
            // 
            // expensetl
            // 
            this.expensetl.ActiveControl = null;
            this.expensetl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expensetl.BackColor = System.Drawing.Color.Firebrick;
            this.expensetl.Location = new System.Drawing.Point(334, 30);
            this.expensetl.Name = "expensetl";
            this.expensetl.Size = new System.Drawing.Size(91, 87);
            this.expensetl.TabIndex = 3;
            this.expensetl.Text = "Expense";
            this.expensetl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.expensetl.TileImage = ((System.Drawing.Image)(resources.GetObject("expensetl.TileImage")));
            this.expensetl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.expensetl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.expensetl.UseCustomBackColor = true;
            this.expensetl.UseSelectable = true;
            this.expensetl.UseTileImage = true;
            this.expensetl.Click += new System.EventHandler(this.expensetl_Click);
            // 
            // salereporttl
            // 
            this.salereporttl.ActiveControl = null;
            this.salereporttl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.salereporttl.BackColor = System.Drawing.Color.Firebrick;
            this.salereporttl.Location = new System.Drawing.Point(134, 201);
            this.salereporttl.Name = "salereporttl";
            this.salereporttl.Size = new System.Drawing.Size(91, 101);
            this.salereporttl.TabIndex = 4;
            this.salereporttl.Text = "Sale \r\nReport";
            this.salereporttl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.salereporttl.TileImage = ((System.Drawing.Image)(resources.GetObject("salereporttl.TileImage")));
            this.salereporttl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.salereporttl.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.salereporttl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.salereporttl.UseCustomBackColor = true;
            this.salereporttl.UseSelectable = true;
            this.salereporttl.UseTileImage = true;
            this.salereporttl.Click += new System.EventHandler(this.salereporttl_Click);
            // 
            // purchasereporttl
            // 
            this.purchasereporttl.ActiveControl = null;
            this.purchasereporttl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasereporttl.BackColor = System.Drawing.Color.Firebrick;
            this.purchasereporttl.Location = new System.Drawing.Point(34, 201);
            this.purchasereporttl.Name = "purchasereporttl";
            this.purchasereporttl.Size = new System.Drawing.Size(91, 101);
            this.purchasereporttl.TabIndex = 5;
            this.purchasereporttl.Text = "Purchase \r\nReport";
            this.purchasereporttl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.purchasereporttl.TileImage = ((System.Drawing.Image)(resources.GetObject("purchasereporttl.TileImage")));
            this.purchasereporttl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.purchasereporttl.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.purchasereporttl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.purchasereporttl.UseCustomBackColor = true;
            this.purchasereporttl.UseSelectable = true;
            this.purchasereporttl.UseTileImage = true;
            this.purchasereporttl.Click += new System.EventHandler(this.purchasereporttl_Click);
            // 
            // userlbl
            // 
            this.userlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userlbl.AutoSize = true;
            this.userlbl.BackColor = System.Drawing.Color.Transparent;
            this.userlbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userlbl.Location = new System.Drawing.Point(121, 49);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(44, 25);
            this.userlbl.TabIndex = 6;
            this.userlbl.Text = "user";
            this.userlbl.UseCustomBackColor = true;
            // 
            // welcomelbl
            // 
            this.welcomelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomelbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.welcomelbl.Location = new System.Drawing.Point(33, 49);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(91, 25);
            this.welcomelbl.TabIndex = 7;
            this.welcomelbl.Text = "Welcome: ";
            this.welcomelbl.UseCustomBackColor = true;
            // 
            // bckrcvtl
            // 
            this.bckrcvtl.ActiveControl = null;
            this.bckrcvtl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bckrcvtl.BackColor = System.Drawing.Color.Firebrick;
            this.bckrcvtl.Location = new System.Drawing.Point(334, 232);
            this.bckrcvtl.Name = "bckrcvtl";
            this.bckrcvtl.Size = new System.Drawing.Size(91, 70);
            this.bckrcvtl.TabIndex = 9;
            this.bckrcvtl.Text = "Backup Recovery";
            this.bckrcvtl.UseCustomBackColor = true;
            this.bckrcvtl.UseSelectable = true;
            this.bckrcvtl.Click += new System.EventHandler(this.bckrcvtl_Click);
            // 
            // persondtltl
            // 
            this.persondtltl.ActiveControl = null;
            this.persondtltl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.persondtltl.BackColor = System.Drawing.Color.Firebrick;
            this.persondtltl.Location = new System.Drawing.Point(334, 124);
            this.persondtltl.Name = "persondtltl";
            this.persondtltl.Size = new System.Drawing.Size(91, 101);
            this.persondtltl.TabIndex = 10;
            this.persondtltl.Text = "Manage\r\nCostumers";
            this.persondtltl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.persondtltl.TileImage = ((System.Drawing.Image)(resources.GetObject("persondtltl.TileImage")));
            this.persondtltl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.persondtltl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.persondtltl.UseCustomBackColor = true;
            this.persondtltl.UseSelectable = true;
            this.persondtltl.UseTileImage = true;
            this.persondtltl.Click += new System.EventHandler(this.persondtltl_Click);
            // 
            // stocktl
            // 
            this.stocktl.ActiveControl = null;
            this.stocktl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stocktl.BackColor = System.Drawing.Color.Firebrick;
            this.stocktl.Location = new System.Drawing.Point(234, 232);
            this.stocktl.Name = "stocktl";
            this.stocktl.Size = new System.Drawing.Size(91, 70);
            this.stocktl.TabIndex = 11;
            this.stocktl.Text = "Stock";
            this.stocktl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stocktl.TileImage = ((System.Drawing.Image)(resources.GetObject("stocktl.TileImage")));
            this.stocktl.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stocktl.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.stocktl.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.stocktl.UseCustomBackColor = true;
            this.stocktl.UseSelectable = true;
            this.stocktl.UseTileImage = true;
            this.stocktl.Click += new System.EventHandler(this.stocktl_Click);
            // 
            // productregister
            // 
            this.productregister.ActiveControl = null;
            this.productregister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productregister.BackColor = System.Drawing.Color.Firebrick;
            this.productregister.Location = new System.Drawing.Point(234, 124);
            this.productregister.Name = "productregister";
            this.productregister.Size = new System.Drawing.Size(91, 101);
            this.productregister.TabIndex = 12;
            this.productregister.Text = " Register\r\nProducts";
            this.productregister.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productregister.TileImage = ((System.Drawing.Image)(resources.GetObject("productregister.TileImage")));
            this.productregister.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.productregister.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.productregister.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.productregister.UseCustomBackColor = true;
            this.productregister.UseSelectable = true;
            this.productregister.UseTileImage = true;
            this.productregister.Click += new System.EventHandler(this.productregister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroTile1);
            this.groupBox1.Controls.Add(this.saletl);
            this.groupBox1.Controls.Add(this.purchasetl);
            this.groupBox1.Controls.Add(this.incometl);
            this.groupBox1.Controls.Add(this.expensetl);
            this.groupBox1.Controls.Add(this.salereporttl);
            this.groupBox1.Controls.Add(this.purchasereporttl);
            this.groupBox1.Controls.Add(this.userlbl);
            this.groupBox1.Controls.Add(this.welcomelbl);
            this.groupBox1.Controls.Add(this.bckrcvtl);
            this.groupBox1.Controls.Add(this.persondtltl);
            this.groupBox1.Controls.Add(this.stocktl);
            this.groupBox1.Controls.Add(this.productregister);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 326);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(134, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(75, 42);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(496, 406);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile saletl;
        private MetroFramework.Controls.MetroTile purchasetl;
        private MetroFramework.Controls.MetroTile incometl;
        private MetroFramework.Controls.MetroTile expensetl;
        private MetroFramework.Controls.MetroTile salereporttl;
        private MetroFramework.Controls.MetroTile purchasereporttl;
        private MetroFramework.Controls.MetroLabel userlbl;
        private MetroFramework.Controls.MetroLabel welcomelbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTile bckrcvtl;
        private MetroFramework.Controls.MetroTile persondtltl;
        private MetroFramework.Controls.MetroTile stocktl;
        private MetroFramework.Controls.MetroTile productregister;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}