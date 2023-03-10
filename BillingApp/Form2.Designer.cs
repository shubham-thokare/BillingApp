
namespace BillingApp
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.nav_menu_list = new System.Windows.Forms.MenuStrip();
            this.addProduct_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salesList_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuotation_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.homePage_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.siteAddress_tB = new System.Windows.Forms.TextBox();
            this.siteAddress_lbl = new System.Windows.Forms.Label();
            this.panNo_tB = new System.Windows.Forms.TextBox();
            this.panNo_lbl = new System.Windows.Forms.Label();
            this.gstNo_tB = new System.Windows.Forms.TextBox();
            this.gstNo_lbl = new System.Windows.Forms.Label();
            this.contactNo_tB = new System.Windows.Forms.TextBox();
            this.contactNo_lbl = new System.Windows.Forms.Label();
            this.InsertCategory_btn = new System.Windows.Forms.Button();
            this.customerName_lbl = new System.Windows.Forms.Label();
            this.contactPerson_tB = new System.Windows.Forms.TextBox();
            this.contactPerson_lbl = new System.Windows.Forms.Label();
            this.siteName_tB = new System.Windows.Forms.TextBox();
            this.siteName_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customerNameDataSet = new BillingApp.customerNameDataSet();
            this.tblCompanyDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CompanyDetailsTableAdapter = new BillingApp.customerNameDataSetTableAdapters.tbl_CompanyDetailsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.nav_menu_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 817);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nav_menu_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 24);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 793);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(234, 751);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 66);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.siteAddress_tB);
            this.panel5.Controls.Add(this.siteAddress_lbl);
            this.panel5.Controls.Add(this.panNo_tB);
            this.panel5.Controls.Add(this.panNo_lbl);
            this.panel5.Controls.Add(this.gstNo_tB);
            this.panel5.Controls.Add(this.gstNo_lbl);
            this.panel5.Controls.Add(this.contactNo_tB);
            this.panel5.Controls.Add(this.contactNo_lbl);
            this.panel5.Controls.Add(this.InsertCategory_btn);
            this.panel5.Controls.Add(this.customerName_lbl);
            this.panel5.Controls.Add(this.contactPerson_tB);
            this.panel5.Controls.Add(this.contactPerson_lbl);
            this.panel5.Controls.Add(this.siteName_tB);
            this.panel5.Controls.Add(this.siteName_lbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(234, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(774, 727);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 634);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 159);
            this.panel6.TabIndex = 0;
            // 
            // nav_menu_list
            // 
            this.nav_menu_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProduct_TSMI,
            this.salesList_TSMI,
            this.addQuotation_TSMI,
            this.homePage_TSMI});
            this.nav_menu_list.Location = new System.Drawing.Point(0, 0);
            this.nav_menu_list.Name = "nav_menu_list";
            this.nav_menu_list.Size = new System.Drawing.Size(1008, 24);
            this.nav_menu_list.TabIndex = 141;
            this.nav_menu_list.Text = "menuStrip";
            // 
            // addProduct_TSMI
            // 
            this.addProduct_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_TSMI.Name = "addProduct_TSMI";
            this.addProduct_TSMI.Size = new System.Drawing.Size(86, 20);
            this.addProduct_TSMI.Text = "Add Product";
            // 
            // salesList_TSMI
            // 
            this.salesList_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList_TSMI.Name = "salesList_TSMI";
            this.salesList_TSMI.Size = new System.Drawing.Size(67, 20);
            this.salesList_TSMI.Text = "Sales List";
            // 
            // addQuotation_TSMI
            // 
            this.addQuotation_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuotation_TSMI.Name = "addQuotation_TSMI";
            this.addQuotation_TSMI.Size = new System.Drawing.Size(98, 20);
            this.addQuotation_TSMI.Text = "Add Quotation";
            // 
            // homePage_TSMI
            // 
            this.homePage_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePage_TSMI.Name = "homePage_TSMI";
            this.homePage_TSMI.Size = new System.Drawing.Size(52, 20);
            this.homePage_TSMI.Text = "Home";
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 89);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(234, 545);
            this.panel8.TabIndex = 2;
            // 
            // siteAddress_tB
            // 
            this.siteAddress_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteAddress_tB.Location = new System.Drawing.Point(484, 107);
            this.siteAddress_tB.Margin = new System.Windows.Forms.Padding(2);
            this.siteAddress_tB.Multiline = true;
            this.siteAddress_tB.Name = "siteAddress_tB";
            this.siteAddress_tB.Size = new System.Drawing.Size(200, 66);
            this.siteAddress_tB.TabIndex = 34;
            // 
            // siteAddress_lbl
            // 
            this.siteAddress_lbl.AutoSize = true;
            this.siteAddress_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteAddress_lbl.Location = new System.Drawing.Point(370, 112);
            this.siteAddress_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.siteAddress_lbl.Name = "siteAddress_lbl";
            this.siteAddress_lbl.Size = new System.Drawing.Size(108, 20);
            this.siteAddress_lbl.TabIndex = 43;
            this.siteAddress_lbl.Text = "Site Address :";
            // 
            // panNo_tB
            // 
            this.panNo_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panNo_tB.Location = new System.Drawing.Point(484, 72);
            this.panNo_tB.Margin = new System.Windows.Forms.Padding(2);
            this.panNo_tB.Multiline = true;
            this.panNo_tB.Name = "panNo_tB";
            this.panNo_tB.Size = new System.Drawing.Size(200, 31);
            this.panNo_tB.TabIndex = 32;
            // 
            // panNo_lbl
            // 
            this.panNo_lbl.AutoSize = true;
            this.panNo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panNo_lbl.Location = new System.Drawing.Point(405, 77);
            this.panNo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panNo_lbl.Name = "panNo_lbl";
            this.panNo_lbl.Size = new System.Drawing.Size(73, 20);
            this.panNo_lbl.TabIndex = 42;
            this.panNo_lbl.Text = "PAN No :";
            // 
            // gstNo_tB
            // 
            this.gstNo_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstNo_tB.Location = new System.Drawing.Point(484, 37);
            this.gstNo_tB.Margin = new System.Windows.Forms.Padding(2);
            this.gstNo_tB.Multiline = true;
            this.gstNo_tB.Name = "gstNo_tB";
            this.gstNo_tB.Size = new System.Drawing.Size(200, 31);
            this.gstNo_tB.TabIndex = 31;
            // 
            // gstNo_lbl
            // 
            this.gstNo_lbl.AutoSize = true;
            this.gstNo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstNo_lbl.Location = new System.Drawing.Point(404, 42);
            this.gstNo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gstNo_lbl.Name = "gstNo_lbl";
            this.gstNo_lbl.Size = new System.Drawing.Size(74, 20);
            this.gstNo_lbl.TabIndex = 41;
            this.gstNo_lbl.Text = "GST No :";
            // 
            // contactNo_tB
            // 
            this.contactNo_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNo_tB.Location = new System.Drawing.Point(157, 142);
            this.contactNo_tB.Margin = new System.Windows.Forms.Padding(2);
            this.contactNo_tB.Multiline = true;
            this.contactNo_tB.Name = "contactNo_tB";
            this.contactNo_tB.Size = new System.Drawing.Size(200, 31);
            this.contactNo_tB.TabIndex = 28;
            // 
            // contactNo_lbl
            // 
            this.contactNo_lbl.AutoSize = true;
            this.contactNo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNo_lbl.Location = new System.Drawing.Point(54, 147);
            this.contactNo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactNo_lbl.Name = "contactNo_lbl";
            this.contactNo_lbl.Size = new System.Drawing.Size(97, 20);
            this.contactNo_lbl.TabIndex = 40;
            this.contactNo_lbl.Text = "Contact No :";
            // 
            // InsertCategory_btn
            // 
            this.InsertCategory_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.InsertCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCategory_btn.ForeColor = System.Drawing.Color.White;
            this.InsertCategory_btn.Location = new System.Drawing.Point(484, 177);
            this.InsertCategory_btn.Margin = new System.Windows.Forms.Padding(2);
            this.InsertCategory_btn.Name = "InsertCategory_btn";
            this.InsertCategory_btn.Size = new System.Drawing.Size(200, 36);
            this.InsertCategory_btn.TabIndex = 35;
            this.InsertCategory_btn.Text = "Select Company";
            this.InsertCategory_btn.UseVisualStyleBackColor = false;
            // 
            // customerName_lbl
            // 
            this.customerName_lbl.AutoSize = true;
            this.customerName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName_lbl.Location = new System.Drawing.Point(19, 42);
            this.customerName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerName_lbl.Name = "customerName_lbl";
            this.customerName_lbl.Size = new System.Drawing.Size(132, 20);
            this.customerName_lbl.TabIndex = 29;
            this.customerName_lbl.Text = "Customer Name :";
            // 
            // contactPerson_tB
            // 
            this.contactPerson_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPerson_tB.Location = new System.Drawing.Point(157, 107);
            this.contactPerson_tB.Margin = new System.Windows.Forms.Padding(2);
            this.contactPerson_tB.Multiline = true;
            this.contactPerson_tB.Name = "contactPerson_tB";
            this.contactPerson_tB.Size = new System.Drawing.Size(200, 31);
            this.contactPerson_tB.TabIndex = 27;
            // 
            // contactPerson_lbl
            // 
            this.contactPerson_lbl.AutoSize = true;
            this.contactPerson_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactPerson_lbl.Location = new System.Drawing.Point(24, 112);
            this.contactPerson_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contactPerson_lbl.Name = "contactPerson_lbl";
            this.contactPerson_lbl.Size = new System.Drawing.Size(127, 20);
            this.contactPerson_lbl.TabIndex = 33;
            this.contactPerson_lbl.Text = "Contact Person :";
            // 
            // siteName_tB
            // 
            this.siteName_tB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteName_tB.Location = new System.Drawing.Point(157, 72);
            this.siteName_tB.Margin = new System.Windows.Forms.Padding(2);
            this.siteName_tB.Multiline = true;
            this.siteName_tB.Name = "siteName_tB";
            this.siteName_tB.Size = new System.Drawing.Size(200, 31);
            this.siteName_tB.TabIndex = 26;
            // 
            // siteName_lbl
            // 
            this.siteName_lbl.AutoSize = true;
            this.siteName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteName_lbl.Location = new System.Drawing.Point(60, 77);
            this.siteName_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.siteName_lbl.Name = "siteName_lbl";
            this.siteName_lbl.Size = new System.Drawing.Size(91, 20);
            this.siteName_lbl.TabIndex = 30;
            this.siteName_lbl.Text = "Site Name :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "Company Details";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblCompanyDetailsBindingSource;
            this.comboBox1.DisplayMember = "customer_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "customer_Name";
            // 
            // customerNameDataSet
            // 
            this.customerNameDataSet.DataSetName = "customerNameDataSet";
            this.customerNameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCompanyDetailsBindingSource
            // 
            this.tblCompanyDetailsBindingSource.DataMember = "tbl_CompanyDetails";
            this.tblCompanyDetailsBindingSource.DataSource = this.customerNameDataSet;
            // 
            // tbl_CompanyDetailsTableAdapter
            // 
            this.tbl_CompanyDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 817);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.nav_menu_list.ResumeLayout(false);
            this.nav_menu_list.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerNameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompanyDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.MenuStrip nav_menu_list;
        private System.Windows.Forms.ToolStripMenuItem addProduct_TSMI;
        private System.Windows.Forms.ToolStripMenuItem salesList_TSMI;
        private System.Windows.Forms.ToolStripMenuItem addQuotation_TSMI;
        private System.Windows.Forms.ToolStripMenuItem homePage_TSMI;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox siteAddress_tB;
        private System.Windows.Forms.Label siteAddress_lbl;
        private System.Windows.Forms.TextBox panNo_tB;
        private System.Windows.Forms.Label panNo_lbl;
        private System.Windows.Forms.TextBox gstNo_tB;
        private System.Windows.Forms.Label gstNo_lbl;
        private System.Windows.Forms.TextBox contactNo_tB;
        private System.Windows.Forms.Label contactNo_lbl;
        private System.Windows.Forms.Button InsertCategory_btn;
        private System.Windows.Forms.Label customerName_lbl;
        private System.Windows.Forms.TextBox contactPerson_tB;
        private System.Windows.Forms.Label contactPerson_lbl;
        private System.Windows.Forms.TextBox siteName_tB;
        private System.Windows.Forms.Label siteName_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private customerNameDataSet customerNameDataSet;
        private System.Windows.Forms.BindingSource tblCompanyDetailsBindingSource;
        private customerNameDataSetTableAdapters.tbl_CompanyDetailsTableAdapter tbl_CompanyDetailsTableAdapter;
    }
}