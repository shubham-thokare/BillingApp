namespace BillingApp
{
    partial class addproduct_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addproduct_form));
            this.product_dGV = new System.Windows.Forms.DataGridView();
            this.searchProduct_tB = new System.Windows.Forms.TextBox();
            this.searchTitle_Lbl = new System.Windows.Forms.Label();
            this.productMainPnl = new System.Windows.Forms.Panel();
            this.searchProduct_pB = new System.Windows.Forms.PictureBox();
            this.side_ProductPnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Add_Product_lbl = new System.Windows.Forms.Label();
            this.addProduct_Name_lbl = new System.Windows.Forms.Label();
            this.product_Name_tB = new System.Windows.Forms.TextBox();
            this.AddProduct_btn = new System.Windows.Forms.Button();
            this.logobig_pB = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hsnNo_tB = new System.Windows.Forms.TextBox();
            this.hsnNo_lbl = new System.Windows.Forms.Label();
            this.InsertCategory_btn = new System.Windows.Forms.Button();
            this.ClearCategory_btn = new System.Windows.Forms.Button();
            this.UpdateCategory_btn = new System.Windows.Forms.Button();
            this.productName_cB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.select_Product_lbl = new System.Windows.Forms.Label();
            this.pricePerUnit_tB = new System.Windows.Forms.TextBox();
            this.pricePerUnit_lbl = new System.Windows.Forms.Label();
            this.subCategoryName_tB = new System.Windows.Forms.TextBox();
            this.subCategory_lbl = new System.Windows.Forms.Label();
            this.subCategoryId_tB = new System.Windows.Forms.TextBox();
            this.DeleteCategory_btn = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.logosmall_pB = new System.Windows.Forms.PictureBox();
            this.GST_lbl = new System.Windows.Forms.Label();
            this.Contact_lbl = new System.Windows.Forms.Label();
            this.Address_lbl = new System.Windows.Forms.Label();
            this.AppStore_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nav_menu_list = new System.Windows.Forms.MenuStrip();
            this.addProduct_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompany_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuotationTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addInvoice_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salesList_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.homePage_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.product_dGV)).BeginInit();
            this.productMainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProduct_pB)).BeginInit();
            this.side_ProductPnl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobig_pB)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logosmall_pB)).BeginInit();
            this.panel1.SuspendLayout();
            this.nav_menu_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_dGV
            // 
            this.product_dGV.AllowUserToOrderColumns = true;
            this.product_dGV.BackgroundColor = System.Drawing.Color.White;
            this.product_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_dGV.Location = new System.Drawing.Point(420, 145);
            this.product_dGV.Name = "product_dGV";
            this.product_dGV.RowHeadersWidth = 62;
            this.product_dGV.Size = new System.Drawing.Size(644, 338);
            this.product_dGV.TabIndex = 0;
            this.product_dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_dGV_CellContentClick);
            // 
            // searchProduct_tB
            // 
            this.searchProduct_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProduct_tB.Location = new System.Drawing.Point(532, 103);
            this.searchProduct_tB.Name = "searchProduct_tB";
            this.searchProduct_tB.Size = new System.Drawing.Size(495, 26);
            this.searchProduct_tB.TabIndex = 8;
            // 
            // searchTitle_Lbl
            // 
            this.searchTitle_Lbl.AutoSize = true;
            this.searchTitle_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle_Lbl.Location = new System.Drawing.Point(433, 103);
            this.searchTitle_Lbl.Name = "searchTitle_Lbl";
            this.searchTitle_Lbl.Size = new System.Drawing.Size(76, 24);
            this.searchTitle_Lbl.TabIndex = 3;
            this.searchTitle_Lbl.Text = "Search";
            // 
            // productMainPnl
            // 
            this.productMainPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productMainPnl.Controls.Add(this.product_dGV);
            this.productMainPnl.Controls.Add(this.searchProduct_pB);
            this.productMainPnl.Controls.Add(this.side_ProductPnl);
            this.productMainPnl.Controls.Add(this.searchProduct_tB);
            this.productMainPnl.Controls.Add(this.searchTitle_Lbl);
            this.productMainPnl.Controls.Add(this.panel6);
            this.productMainPnl.Location = new System.Drawing.Point(8, 27);
            this.productMainPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productMainPnl.Name = "productMainPnl";
            this.productMainPnl.Size = new System.Drawing.Size(1071, 489);
            this.productMainPnl.TabIndex = 137;
            // 
            // searchProduct_pB
            // 
            this.searchProduct_pB.Image = ((System.Drawing.Image)(resources.GetObject("searchProduct_pB.Image")));
            this.searchProduct_pB.Location = new System.Drawing.Point(1033, 104);
            this.searchProduct_pB.Name = "searchProduct_pB";
            this.searchProduct_pB.Size = new System.Drawing.Size(24, 24);
            this.searchProduct_pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.searchProduct_pB.TabIndex = 4;
            this.searchProduct_pB.TabStop = false;
            this.searchProduct_pB.Click += new System.EventHandler(this.search_Product_pB_Click);
            // 
            // side_ProductPnl
            // 
            this.side_ProductPnl.AutoScroll = true;
            this.side_ProductPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.side_ProductPnl.Controls.Add(this.panel3);
            this.side_ProductPnl.Controls.Add(this.logobig_pB);
            this.side_ProductPnl.Controls.Add(this.panel2);
            this.side_ProductPnl.Location = new System.Drawing.Point(-2, 2);
            this.side_ProductPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.side_ProductPnl.Name = "side_ProductPnl";
            this.side_ProductPnl.Size = new System.Drawing.Size(414, 481);
            this.side_ProductPnl.TabIndex = 138;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Add_Product_lbl);
            this.panel3.Controls.Add(this.addProduct_Name_lbl);
            this.panel3.Controls.Add(this.product_Name_tB);
            this.panel3.Controls.Add(this.AddProduct_btn);
            this.panel3.Location = new System.Drawing.Point(8, 201);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 183);
            this.panel3.TabIndex = 137;
            // 
            // Add_Product_lbl
            // 
            this.Add_Product_lbl.AutoSize = true;
            this.Add_Product_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product_lbl.Location = new System.Drawing.Point(9, 7);
            this.Add_Product_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Add_Product_lbl.Name = "Add_Product_lbl";
            this.Add_Product_lbl.Size = new System.Drawing.Size(141, 25);
            this.Add_Product_lbl.TabIndex = 9;
            this.Add_Product_lbl.Text = "Add Product";
            // 
            // addProduct_Name_lbl
            // 
            this.addProduct_Name_lbl.AutoSize = true;
            this.addProduct_Name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_Name_lbl.Location = new System.Drawing.Point(11, 60);
            this.addProduct_Name_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addProduct_Name_lbl.Name = "addProduct_Name_lbl";
            this.addProduct_Name_lbl.Size = new System.Drawing.Size(110, 20);
            this.addProduct_Name_lbl.TabIndex = 4;
            this.addProduct_Name_lbl.Text = "Product Name";
            // 
            // product_Name_tB
            // 
            this.product_Name_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_Name_tB.Location = new System.Drawing.Point(143, 57);
            this.product_Name_tB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.product_Name_tB.Multiline = true;
            this.product_Name_tB.Name = "product_Name_tB";
            this.product_Name_tB.Size = new System.Drawing.Size(200, 31);
            this.product_Name_tB.TabIndex = 1;
            // 
            // AddProduct_btn
            // 
            this.AddProduct_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddProduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct_btn.ForeColor = System.Drawing.Color.White;
            this.AddProduct_btn.Location = new System.Drawing.Point(143, 107);
            this.AddProduct_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddProduct_btn.Name = "AddProduct_btn";
            this.AddProduct_btn.Size = new System.Drawing.Size(200, 36);
            this.AddProduct_btn.TabIndex = 2;
            this.AddProduct_btn.Text = "Add Product";
            this.AddProduct_btn.UseVisualStyleBackColor = false;
            this.AddProduct_btn.Click += new System.EventHandler(this.AddProduct_btn_Click);
            // 
            // logobig_pB
            // 
            this.logobig_pB.Image = ((System.Drawing.Image)(resources.GetObject("logobig_pB.Image")));
            this.logobig_pB.Location = new System.Drawing.Point(7, 19);
            this.logobig_pB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logobig_pB.Name = "logobig_pB";
            this.logobig_pB.Size = new System.Drawing.Size(383, 158);
            this.logobig_pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobig_pB.TabIndex = 0;
            this.logobig_pB.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.hsnNo_tB);
            this.panel2.Controls.Add(this.hsnNo_lbl);
            this.panel2.Controls.Add(this.InsertCategory_btn);
            this.panel2.Controls.Add(this.ClearCategory_btn);
            this.panel2.Controls.Add(this.UpdateCategory_btn);
            this.panel2.Controls.Add(this.productName_cB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.select_Product_lbl);
            this.panel2.Controls.Add(this.pricePerUnit_tB);
            this.panel2.Controls.Add(this.pricePerUnit_lbl);
            this.panel2.Controls.Add(this.subCategoryName_tB);
            this.panel2.Controls.Add(this.subCategory_lbl);
            this.panel2.Controls.Add(this.subCategoryId_tB);
            this.panel2.Controls.Add(this.DeleteCategory_btn);
            this.panel2.Location = new System.Drawing.Point(8, 394);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 363);
            this.panel2.TabIndex = 136;
            // 
            // hsnNo_tB
            // 
            this.hsnNo_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsnNo_tB.Location = new System.Drawing.Point(151, 201);
            this.hsnNo_tB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hsnNo_tB.Multiline = true;
            this.hsnNo_tB.Name = "hsnNo_tB";
            this.hsnNo_tB.Size = new System.Drawing.Size(200, 31);
            this.hsnNo_tB.TabIndex = 6;
            // 
            // hsnNo_lbl
            // 
            this.hsnNo_lbl.AutoSize = true;
            this.hsnNo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsnNo_lbl.Location = new System.Drawing.Point(17, 202);
            this.hsnNo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hsnNo_lbl.Name = "hsnNo_lbl";
            this.hsnNo_lbl.Size = new System.Drawing.Size(67, 20);
            this.hsnNo_lbl.TabIndex = 17;
            this.hsnNo_lbl.Text = "HSN No";
            // 
            // InsertCategory_btn
            // 
            this.InsertCategory_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCategory_btn.ForeColor = System.Drawing.Color.White;
            this.InsertCategory_btn.Location = new System.Drawing.Point(23, 254);
            this.InsertCategory_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InsertCategory_btn.Name = "InsertCategory_btn";
            this.InsertCategory_btn.Size = new System.Drawing.Size(148, 36);
            this.InsertCategory_btn.TabIndex = 7;
            this.InsertCategory_btn.Text = "Add";
            this.InsertCategory_btn.UseVisualStyleBackColor = false;
            this.InsertCategory_btn.Click += new System.EventHandler(this.InsertCategory_btn_Click);
            // 
            // ClearCategory_btn
            // 
            this.ClearCategory_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.ClearCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCategory_btn.ForeColor = System.Drawing.Color.White;
            this.ClearCategory_btn.Location = new System.Drawing.Point(23, 303);
            this.ClearCategory_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearCategory_btn.Name = "ClearCategory_btn";
            this.ClearCategory_btn.Size = new System.Drawing.Size(148, 36);
            this.ClearCategory_btn.TabIndex = 15;
            this.ClearCategory_btn.Text = "Clear";
            this.ClearCategory_btn.UseVisualStyleBackColor = false;
            this.ClearCategory_btn.Click += new System.EventHandler(this.ClearCategory_btn_Click);
            // 
            // UpdateCategory_btn
            // 
            this.UpdateCategory_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.UpdateCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCategory_btn.ForeColor = System.Drawing.Color.White;
            this.UpdateCategory_btn.Location = new System.Drawing.Point(203, 254);
            this.UpdateCategory_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateCategory_btn.Name = "UpdateCategory_btn";
            this.UpdateCategory_btn.Size = new System.Drawing.Size(148, 36);
            this.UpdateCategory_btn.TabIndex = 11;
            this.UpdateCategory_btn.Text = "Update";
            this.UpdateCategory_btn.UseVisualStyleBackColor = false;
            this.UpdateCategory_btn.Click += new System.EventHandler(this.UpdateCategory_btn_Click);
            // 
            // productName_cB
            // 
            this.productName_cB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName_cB.FormattingEnabled = true;
            this.productName_cB.Location = new System.Drawing.Point(151, 84);
            this.productName_cB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.productName_cB.Name = "productName_cB";
            this.productName_cB.Size = new System.Drawing.Size(200, 28);
            this.productName_cB.TabIndex = 3;
            this.productName_cB.SelectedIndexChanged += new System.EventHandler(this.productName_cB_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Add Category";
            // 
            // select_Product_lbl
            // 
            this.select_Product_lbl.AutoSize = true;
            this.select_Product_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Product_lbl.Location = new System.Drawing.Point(19, 88);
            this.select_Product_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.select_Product_lbl.Name = "select_Product_lbl";
            this.select_Product_lbl.Size = new System.Drawing.Size(110, 20);
            this.select_Product_lbl.TabIndex = 4;
            this.select_Product_lbl.Text = "Product Name";
            // 
            // pricePerUnit_tB
            // 
            this.pricePerUnit_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerUnit_tB.Location = new System.Drawing.Point(151, 162);
            this.pricePerUnit_tB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pricePerUnit_tB.Multiline = true;
            this.pricePerUnit_tB.Name = "pricePerUnit_tB";
            this.pricePerUnit_tB.Size = new System.Drawing.Size(200, 31);
            this.pricePerUnit_tB.TabIndex = 5;
            // 
            // pricePerUnit_lbl
            // 
            this.pricePerUnit_lbl.AutoSize = true;
            this.pricePerUnit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricePerUnit_lbl.Location = new System.Drawing.Point(17, 167);
            this.pricePerUnit_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pricePerUnit_lbl.Name = "pricePerUnit_lbl";
            this.pricePerUnit_lbl.Size = new System.Drawing.Size(105, 20);
            this.pricePerUnit_lbl.TabIndex = 6;
            this.pricePerUnit_lbl.Text = "Price Per Unit";
            // 
            // subCategoryName_tB
            // 
            this.subCategoryName_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCategoryName_tB.Location = new System.Drawing.Point(151, 123);
            this.subCategoryName_tB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subCategoryName_tB.Multiline = true;
            this.subCategoryName_tB.Name = "subCategoryName_tB";
            this.subCategoryName_tB.Size = new System.Drawing.Size(200, 31);
            this.subCategoryName_tB.TabIndex = 4;
            // 
            // subCategory_lbl
            // 
            this.subCategory_lbl.AutoSize = true;
            this.subCategory_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCategory_lbl.Location = new System.Drawing.Point(19, 128);
            this.subCategory_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subCategory_lbl.Name = "subCategory_lbl";
            this.subCategory_lbl.Size = new System.Drawing.Size(106, 20);
            this.subCategory_lbl.TabIndex = 5;
            this.subCategory_lbl.Text = "Sub Category";
            // 
            // subCategoryId_tB
            // 
            this.subCategoryId_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subCategoryId_tB.Location = new System.Drawing.Point(151, 44);
            this.subCategoryId_tB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subCategoryId_tB.Multiline = true;
            this.subCategoryId_tB.Name = "subCategoryId_tB";
            this.subCategoryId_tB.ReadOnly = true;
            this.subCategoryId_tB.Size = new System.Drawing.Size(200, 31);
            this.subCategoryId_tB.TabIndex = 13;
            // 
            // DeleteCategory_btn
            // 
            this.DeleteCategory_btn.BackColor = System.Drawing.Color.Red;
            this.DeleteCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCategory_btn.ForeColor = System.Drawing.Color.White;
            this.DeleteCategory_btn.Location = new System.Drawing.Point(203, 303);
            this.DeleteCategory_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteCategory_btn.Name = "DeleteCategory_btn";
            this.DeleteCategory_btn.Size = new System.Drawing.Size(148, 36);
            this.DeleteCategory_btn.TabIndex = 12;
            this.DeleteCategory_btn.Text = "Delete";
            this.DeleteCategory_btn.UseVisualStyleBackColor = false;
            this.DeleteCategory_btn.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.logosmall_pB);
            this.panel6.Controls.Add(this.GST_lbl);
            this.panel6.Controls.Add(this.Contact_lbl);
            this.panel6.Controls.Add(this.Address_lbl);
            this.panel6.Controls.Add(this.AppStore_lbl);
            this.panel6.Location = new System.Drawing.Point(420, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(644, 84);
            this.panel6.TabIndex = 135;
            // 
            // logosmall_pB
            // 
            this.logosmall_pB.Image = ((System.Drawing.Image)(resources.GetObject("logosmall_pB.Image")));
            this.logosmall_pB.Location = new System.Drawing.Point(2, 2);
            this.logosmall_pB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logosmall_pB.Name = "logosmall_pB";
            this.logosmall_pB.Size = new System.Drawing.Size(141, 77);
            this.logosmall_pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logosmall_pB.TabIndex = 56;
            this.logosmall_pB.TabStop = false;
            // 
            // GST_lbl
            // 
            this.GST_lbl.AutoSize = true;
            this.GST_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.GST_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GST_lbl.Location = new System.Drawing.Point(451, 3);
            this.GST_lbl.Name = "GST_lbl";
            this.GST_lbl.Size = new System.Drawing.Size(190, 15);
            this.GST_lbl.TabIndex = 55;
            this.GST_lbl.Text = "GST NO :27BJKPP0202P1ZZ";
            // 
            // Contact_lbl
            // 
            this.Contact_lbl.AutoSize = true;
            this.Contact_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.Contact_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact_lbl.Location = new System.Drawing.Point(148, 62);
            this.Contact_lbl.Name = "Contact_lbl";
            this.Contact_lbl.Size = new System.Drawing.Size(395, 16);
            this.Contact_lbl.TabIndex = 54;
            this.Contact_lbl.Text = "Mob.9890259665 EMAIL: krishnamarbleandceramics@gmail.com";
            this.Contact_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address_lbl
            // 
            this.Address_lbl.AutoSize = true;
            this.Address_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.Address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_lbl.Location = new System.Drawing.Point(197, 31);
            this.Address_lbl.Name = "Address_lbl";
            this.Address_lbl.Size = new System.Drawing.Size(303, 32);
            this.Address_lbl.TabIndex = 52;
            this.Address_lbl.Text = "SR NO 223, SUS NANDE ROAD, BHOTE WASTI,\r\nNEAR SUNNY\'S WORLD,SUS PUNE 411021";
            this.Address_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppStore_lbl
            // 
            this.AppStore_lbl.AutoSize = true;
            this.AppStore_lbl.BackColor = System.Drawing.SystemColors.Window;
            this.AppStore_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppStore_lbl.Location = new System.Drawing.Point(258, 7);
            this.AppStore_lbl.Name = "AppStore_lbl";
            this.AppStore_lbl.Size = new System.Drawing.Size(188, 24);
            this.AppStore_lbl.TabIndex = 53;
            this.AppStore_lbl.Text = "KRISHNA MARBLE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nav_menu_list);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 27);
            this.panel1.TabIndex = 141;
            // 
            // nav_menu_list
            // 
            this.nav_menu_list.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nav_menu_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProduct_TSMI,
            this.addCompany_TSMI,
            this.addQuotationTSMI,
            this.addInvoice_TSMI,
            this.salesList_TSMI,
            this.homePage_TSMI});
            this.nav_menu_list.Location = new System.Drawing.Point(0, 0);
            this.nav_menu_list.Name = "nav_menu_list";
            this.nav_menu_list.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.nav_menu_list.Size = new System.Drawing.Size(1079, 24);
            this.nav_menu_list.TabIndex = 3;
            this.nav_menu_list.Text = "menuStrip";
            // 
            // addProduct_TSMI
            // 
            this.addProduct_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_TSMI.Name = "addProduct_TSMI";
            this.addProduct_TSMI.Size = new System.Drawing.Size(86, 22);
            this.addProduct_TSMI.Text = "Add Product";
            this.addProduct_TSMI.Click += new System.EventHandler(this.AddProduct_TSMI_Click);
            // 
            // addCompany_TSMI
            // 
            this.addCompany_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompany_TSMI.Name = "addCompany_TSMI";
            this.addCompany_TSMI.Size = new System.Drawing.Size(95, 22);
            this.addCompany_TSMI.Text = "Add Company";
            this.addCompany_TSMI.Click += new System.EventHandler(this.AddCompany_TSMI_Click);
            // 
            // addQuotationTSMI
            // 
            this.addQuotationTSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.addQuotationTSMI.Name = "addQuotationTSMI";
            this.addQuotationTSMI.Size = new System.Drawing.Size(98, 22);
            this.addQuotationTSMI.Text = "Add Quotation";
            this.addQuotationTSMI.Click += new System.EventHandler(this.AddQuotationTSMI_Click);
            // 
            // addInvoice_TSMI
            // 
            this.addInvoice_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoice_TSMI.Name = "addInvoice_TSMI";
            this.addInvoice_TSMI.Size = new System.Drawing.Size(83, 22);
            this.addInvoice_TSMI.Text = "Add Invoice";
            this.addInvoice_TSMI.Click += new System.EventHandler(this.AddInvoice_TSMI_Click);
            // 
            // salesList_TSMI
            // 
            this.salesList_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList_TSMI.Name = "salesList_TSMI";
            this.salesList_TSMI.Size = new System.Drawing.Size(67, 22);
            this.salesList_TSMI.Text = "Sales List";
            this.salesList_TSMI.Click += new System.EventHandler(this.SalesList_TSMI_Click);
            // 
            // homePage_TSMI
            // 
            this.homePage_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.homePage_TSMI.Name = "homePage_TSMI";
            this.homePage_TSMI.Size = new System.Drawing.Size(52, 22);
            this.homePage_TSMI.Text = "Home";
            this.homePage_TSMI.Click += new System.EventHandler(this.HomePage_TSMI_Click);
            // 
            // addproduct_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1079, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productMainPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "addproduct_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Addproduct_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_dGV)).EndInit();
            this.productMainPnl.ResumeLayout(false);
            this.productMainPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProduct_pB)).EndInit();
            this.side_ProductPnl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobig_pB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logosmall_pB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.nav_menu_list.ResumeLayout(false);
            this.nav_menu_list.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView product_dGV;
        private System.Windows.Forms.TextBox searchProduct_tB;
        private System.Windows.Forms.Label searchTitle_Lbl;
        private System.Windows.Forms.PictureBox searchProduct_pB;
        private System.Windows.Forms.Panel productMainPnl;
        private System.Windows.Forms.Panel side_ProductPnl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Add_Product_lbl;
        private System.Windows.Forms.Label addProduct_Name_lbl;
        private System.Windows.Forms.TextBox product_Name_tB;
        private System.Windows.Forms.Button AddProduct_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox productName_cB;
        private System.Windows.Forms.Label select_Product_lbl;
        private System.Windows.Forms.TextBox pricePerUnit_tB;
        private System.Windows.Forms.Label pricePerUnit_lbl;
        private System.Windows.Forms.TextBox subCategoryName_tB;
        private System.Windows.Forms.Label subCategory_lbl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label GST_lbl;
        private System.Windows.Forms.PictureBox logobig_pB;
        private System.Windows.Forms.Label Contact_lbl;
        private System.Windows.Forms.Label Address_lbl;
        private System.Windows.Forms.Label AppStore_lbl;
        private System.Windows.Forms.PictureBox logosmall_pB;
        private System.Windows.Forms.Button DeleteCategory_btn;
        private System.Windows.Forms.Button UpdateCategory_btn;
        private System.Windows.Forms.TextBox subCategoryId_tB;
        private System.Windows.Forms.Button ClearCategory_btn;
        private System.Windows.Forms.Button InsertCategory_btn;
        private System.Windows.Forms.TextBox hsnNo_tB;
        private System.Windows.Forms.Label hsnNo_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip nav_menu_list;
        private System.Windows.Forms.ToolStripMenuItem addProduct_TSMI;
        private System.Windows.Forms.ToolStripMenuItem addCompany_TSMI;
        private System.Windows.Forms.ToolStripMenuItem addQuotationTSMI;
        private System.Windows.Forms.ToolStripMenuItem addInvoice_TSMI;
        private System.Windows.Forms.ToolStripMenuItem salesList_TSMI;
        private System.Windows.Forms.ToolStripMenuItem homePage_TSMI;
    }
}