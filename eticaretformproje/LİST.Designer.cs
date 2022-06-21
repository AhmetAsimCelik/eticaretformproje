namespace eticaretformproje
{
    partial class LİST
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LİST));
            this.lstview_all = new System.Windows.Forms.ListView();
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PRİC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STOCKK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BRAND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ADDDATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_brands = new System.Windows.Forms.ListView();
            this.BRANDS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BRANDID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listview_category = new System.Windows.Forms.ListView();
            this.CATT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CATIDD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lstview_all
            // 
            this.lstview_all.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lstview_all.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NAME,
            this.PRİC,
            this.STOCKK,
            this.BRAND,
            this.ADDDATE});
            this.lstview_all.GridLines = true;
            this.lstview_all.HideSelection = false;
            this.lstview_all.Location = new System.Drawing.Point(12, 12);
            this.lstview_all.Name = "lstview_all";
            this.lstview_all.Size = new System.Drawing.Size(610, 348);
            this.lstview_all.TabIndex = 1;
            this.lstview_all.UseCompatibleStateImageBehavior = false;
            this.lstview_all.View = System.Windows.Forms.View.Details;
            // 
            // NAME
            // 
            this.NAME.Text = "NAME";
            this.NAME.Width = 173;
            // 
            // PRİC
            // 
            this.PRİC.Text = "PRİCE";
            this.PRİC.Width = 108;
            // 
            // STOCKK
            // 
            this.STOCKK.Text = "STOCK";
            this.STOCKK.Width = 70;
            // 
            // BRAND
            // 
            this.BRAND.Text = "BRAND";
            this.BRAND.Width = 71;
            // 
            // ADDDATE
            // 
            this.ADDDATE.Text = "ADDDATE";
            this.ADDDATE.Width = 223;
            // 
            // listview_brands
            // 
            this.listview_brands.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listview_brands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BRANDS,
            this.BRANDID});
            this.listview_brands.GridLines = true;
            this.listview_brands.HideSelection = false;
            this.listview_brands.Location = new System.Drawing.Point(652, 26);
            this.listview_brands.Name = "listview_brands";
            this.listview_brands.Size = new System.Drawing.Size(253, 147);
            this.listview_brands.TabIndex = 2;
            this.listview_brands.UseCompatibleStateImageBehavior = false;
            this.listview_brands.View = System.Windows.Forms.View.Details;
            // 
            // BRANDS
            // 
            this.BRANDS.Text = "BRAND";
            this.BRANDS.Width = 143;
            // 
            // BRANDID
            // 
            this.BRANDID.Text = "ID";
            this.BRANDID.Width = 158;
            // 
            // listview_category
            // 
            this.listview_category.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listview_category.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CATT,
            this.CATIDD});
            this.listview_category.GridLines = true;
            this.listview_category.HideSelection = false;
            this.listview_category.Location = new System.Drawing.Point(652, 194);
            this.listview_category.Name = "listview_category";
            this.listview_category.Size = new System.Drawing.Size(253, 154);
            this.listview_category.TabIndex = 3;
            this.listview_category.UseCompatibleStateImageBehavior = false;
            this.listview_category.View = System.Windows.Forms.View.Details;
            // 
            // CATT
            // 
            this.CATT.Text = "CATEGORY";
            this.CATT.Width = 143;
            // 
            // CATIDD
            // 
            this.CATIDD.Text = "ID";
            this.CATIDD.Width = 144;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(921, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "A.png");
            // 
            // LİST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listview_category);
            this.Controls.Add(this.listview_brands);
            this.Controls.Add(this.lstview_all);
            this.Name = "LİST";
            this.Text = "LİST";
            this.Load += new System.EventHandler(this.LİST_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstview_all;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader PRİC;
        private System.Windows.Forms.ColumnHeader STOCKK;
        private System.Windows.Forms.ColumnHeader BRAND;
        private System.Windows.Forms.ColumnHeader ADDDATE;
        private System.Windows.Forms.ListView listview_brands;
        private System.Windows.Forms.ColumnHeader BRANDS;
        private System.Windows.Forms.ColumnHeader BRANDID;
        private System.Windows.Forms.ListView listview_category;
        private System.Windows.Forms.ColumnHeader CATT;
        private System.Windows.Forms.ColumnHeader CATIDD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}