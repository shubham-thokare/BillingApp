namespace BillingApp.Properties
{
    partial class addSalesList_form

        
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.nav_menu_list = new System.Windows.Forms.MenuStrip();
            this.addProduct_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompany_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuotationTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addInvoice_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salesList_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.homePage_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.searchInvoiceMain_Pnl = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchInvoice_pB_btn = new System.Windows.Forms.PictureBox();
            this.searchInvoice_tB = new System.Windows.Forms.TextBox();
            this.selectProductTitle_lbl = new System.Windows.Forms.Label();
            this.searchProductName_lbl = new System.Windows.Forms.Label();
            this.InvoiceLedger_dGV = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceSide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.nav_menu_list.SuspendLayout();
            this.searchInvoiceMain_Pnl.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInvoice_pB_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceLedger_dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nav_menu_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1869, 42);
            this.panel2.TabIndex = 2;
            // 
            // nav_menu_list
            // 
            this.nav_menu_list.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
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
            this.nav_menu_list.Size = new System.Drawing.Size(1869, 33);
            this.nav_menu_list.TabIndex = 3;
            this.nav_menu_list.Text = "menuStrip";
            // 
            // addProduct_TSMI
            // 
            this.addProduct_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_TSMI.Name = "addProduct_TSMI";
            this.addProduct_TSMI.Size = new System.Drawing.Size(133, 29);
            this.addProduct_TSMI.Text = "Add Product";
            this.addProduct_TSMI.Click += new System.EventHandler(this.AddProduct_TSMI_Click);
            // 
            // addCompany_TSMI
            // 
            this.addCompany_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompany_TSMI.Name = "addCompany_TSMI";
            this.addCompany_TSMI.Size = new System.Drawing.Size(145, 29);
            this.addCompany_TSMI.Text = "Add Company";
            this.addCompany_TSMI.Click += new System.EventHandler(this.AddCompany_TSMI_Click);
            // 
            // addQuotationTSMI
            // 
            this.addQuotationTSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.addQuotationTSMI.Name = "addQuotationTSMI";
            this.addQuotationTSMI.Size = new System.Drawing.Size(153, 29);
            this.addQuotationTSMI.Text = "Add Quotation";
            this.addQuotationTSMI.Click += new System.EventHandler(this.AddQuotationTSMI_Click);
            // 
            // addInvoice_TSMI
            // 
            this.addInvoice_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoice_TSMI.Name = "addInvoice_TSMI";
            this.addInvoice_TSMI.Size = new System.Drawing.Size(126, 29);
            this.addInvoice_TSMI.Text = "Add Invoice";
            this.addInvoice_TSMI.Click += new System.EventHandler(this.AddInvoice_TSMI_Click);
            // 
            // salesList_TSMI
            // 
            this.salesList_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList_TSMI.Name = "salesList_TSMI";
            this.salesList_TSMI.Size = new System.Drawing.Size(104, 29);
            this.salesList_TSMI.Text = "Sales List";
            this.salesList_TSMI.Click += new System.EventHandler(this.SalesList_TSMI_Click);
            // 
            // homePage_TSMI
            // 
            this.homePage_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.homePage_TSMI.Name = "homePage_TSMI";
            this.homePage_TSMI.Size = new System.Drawing.Size(78, 29);
            this.homePage_TSMI.Text = "Home";
            this.homePage_TSMI.Click += new System.EventHandler(this.HomePage_TSMI_Click);
            // 
            // searchInvoiceMain_Pnl
            // 
            this.searchInvoiceMain_Pnl.Controls.Add(this.panel3);
            this.searchInvoiceMain_Pnl.Controls.Add(this.panel1);
            this.searchInvoiceMain_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchInvoiceMain_Pnl.Location = new System.Drawing.Point(0, 42);
            this.searchInvoiceMain_Pnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchInvoiceMain_Pnl.Name = "searchInvoiceMain_Pnl";
            this.searchInvoiceMain_Pnl.Size = new System.Drawing.Size(1869, 756);
            this.searchInvoiceMain_Pnl.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(953, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 756);
            this.panel3.TabIndex = 39;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productType,
            this.serviceSide,
            this.serviceCharge,
            this.productQuantity,
            this.rateProduct,
            this.totalAmount});
            this.dataGridView2.Location = new System.Drawing.Point(9, 192);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(891, 548);
            this.dataGridView2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchInvoice_pB_btn);
            this.panel1.Controls.Add(this.searchInvoice_tB);
            this.panel1.Controls.Add(this.selectProductTitle_lbl);
            this.panel1.Controls.Add(this.searchProductName_lbl);
            this.panel1.Controls.Add(this.InvoiceLedger_dGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 756);
            this.panel1.TabIndex = 38;
            // 
            // searchInvoice_pB_btn
            // 
            this.searchInvoice_pB_btn.Image = global::BillingApp.Properties.Resources.search;
            this.searchInvoice_pB_btn.Location = new System.Drawing.Point(797, 102);
            this.searchInvoice_pB_btn.Name = "searchInvoice_pB_btn";
            this.searchInvoice_pB_btn.Size = new System.Drawing.Size(46, 46);
            this.searchInvoice_pB_btn.TabIndex = 43;
            this.searchInvoice_pB_btn.TabStop = false;
            // 
            // searchInvoice_tB
            // 
            this.searchInvoice_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInvoice_tB.Location = new System.Drawing.Point(49, 99);
            this.searchInvoice_tB.Multiline = true;
            this.searchInvoice_tB.Name = "searchInvoice_tB";
            this.searchInvoice_tB.Size = new System.Drawing.Size(742, 46);
            this.searchInvoice_tB.TabIndex = 42;
            // 
            // selectProductTitle_lbl
            // 
            this.selectProductTitle_lbl.AutoSize = true;
            this.selectProductTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectProductTitle_lbl.Location = new System.Drawing.Point(41, 13);
            this.selectProductTitle_lbl.Name = "selectProductTitle_lbl";
            this.selectProductTitle_lbl.Size = new System.Drawing.Size(226, 37);
            this.selectProductTitle_lbl.TabIndex = 41;
            this.selectProductTitle_lbl.Text = "Select Invoice";
            // 
            // searchProductName_lbl
            // 
            this.searchProductName_lbl.AutoSize = true;
            this.searchProductName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchProductName_lbl.Location = new System.Drawing.Point(43, 66);
            this.searchProductName_lbl.Name = "searchProductName_lbl";
            this.searchProductName_lbl.Size = new System.Drawing.Size(143, 29);
            this.searchProductName_lbl.TabIndex = 40;
            this.searchProductName_lbl.Text = "Find Invoice";
            // 
            // InvoiceLedger_dGV
            // 
            this.InvoiceLedger_dGV.BackgroundColor = System.Drawing.Color.White;
            this.InvoiceLedger_dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceLedger_dGV.Location = new System.Drawing.Point(31, 195);
            this.InvoiceLedger_dGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InvoiceLedger_dGV.Name = "InvoiceLedger_dGV";
            this.InvoiceLedger_dGV.RowHeadersWidth = 62;
            this.InvoiceLedger_dGV.Size = new System.Drawing.Size(891, 548);
            this.InvoiceLedger_dGV.TabIndex = 39;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Category Name";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            // 
            // productType
            // 
            this.productType.HeaderText = "Product Type";
            this.productType.MinimumWidth = 8;
            this.productType.Name = "productType";
            this.productType.Width = 150;
            // 
            // serviceSide
            // 
            this.serviceSide.HeaderText = "Mold Type";
            this.serviceSide.MinimumWidth = 8;
            this.serviceSide.Name = "serviceSide";
            this.serviceSide.Width = 160;
            // 
            // serviceCharge
            // 
            this.serviceCharge.HeaderText = "Mold Char.";
            this.serviceCharge.MinimumWidth = 8;
            this.serviceCharge.Name = "serviceCharge";
            this.serviceCharge.Width = 90;
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.MinimumWidth = 8;
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Width = 70;
            // 
            // rateProduct
            // 
            this.rateProduct.HeaderText = "Rate";
            this.rateProduct.MinimumWidth = 8;
            this.rateProduct.Name = "rateProduct";
            this.rateProduct.Width = 60;
            // 
            // totalAmount
            // 
            this.totalAmount.HeaderText = "Total";
            this.totalAmount.MinimumWidth = 8;
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Width = 60;
            // 
            // addSalesList_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1869, 798);
            this.Controls.Add(this.searchInvoiceMain_Pnl);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addSalesList_form";
            this.Text = "AddQuotation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.nav_menu_list.ResumeLayout(false);
            this.nav_menu_list.PerformLayout();
            this.searchInvoiceMain_Pnl.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchInvoice_pB_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceLedger_dGV)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panel2;
            private System.Windows.Forms.MenuStrip nav_menu_list;
            private System.Windows.Forms.ToolStripMenuItem addProduct_TSMI;
            private System.Windows.Forms.ToolStripMenuItem addCompany_TSMI;
            private System.Windows.Forms.ToolStripMenuItem addInvoice_TSMI;
            private System.Windows.Forms.ToolStripMenuItem salesList_TSMI;
            private System.Windows.Forms.ToolStripMenuItem homePage_TSMI;
            private System.Windows.Forms.Panel searchInvoiceMain_Pnl;
            private System.Windows.Forms.ToolStripMenuItem addQuotationTSMI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox searchInvoice_pB_btn;
        private System.Windows.Forms.TextBox searchInvoice_tB;
        private System.Windows.Forms.Label selectProductTitle_lbl;
        private System.Windows.Forms.Label searchProductName_lbl;
        private System.Windows.Forms.DataGridView InvoiceLedger_dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productType;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceSide;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmount;
    }
    }