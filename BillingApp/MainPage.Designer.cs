namespace BillingApp
{
    partial class MainPage
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
            this.nav_menu_list = new System.Windows.Forms.MenuStrip();
            this.addProduct_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompany_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.addInvoice_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salesList_TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.main_Pnl = new System.Windows.Forms.Panel();
            this.mainBg_pB = new System.Windows.Forms.PictureBox();
            this.footer_Pnl = new System.Windows.Forms.Panel();
            this.nav_menu_list.SuspendLayout();
            this.main_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBg_pB)).BeginInit();
            this.SuspendLayout();
            // 
            // nav_menu_list
            // 
            this.nav_menu_list.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProduct_TSMI,
            this.addCompany_TSMI,
            this.addInvoice_TSMI,
            this.salesList_TSMI});
            this.nav_menu_list.Location = new System.Drawing.Point(0, 0);
            this.nav_menu_list.Name = "nav_menu_list";
            this.nav_menu_list.Size = new System.Drawing.Size(1174, 24);
            this.nav_menu_list.TabIndex = 0;
            this.nav_menu_list.Text = "menuStrip";
            // 
            // addProduct_TSMI
            // 
            this.addProduct_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProduct_TSMI.Name = "addProduct_TSMI";
            this.addProduct_TSMI.Size = new System.Drawing.Size(86, 20);
            this.addProduct_TSMI.Text = "Add Product";
            this.addProduct_TSMI.Click += new System.EventHandler(this.addProduct_TSMI_Click);
            // 
            // addCompany_TSMI
            // 
            this.addCompany_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompany_TSMI.Name = "addCompany_TSMI";
            this.addCompany_TSMI.Size = new System.Drawing.Size(95, 20);
            this.addCompany_TSMI.Text = "Add Company";
            this.addCompany_TSMI.Click += new System.EventHandler(this.addCompany_TSMI_Click);
            // 
            // addInvoice_TSMI
            // 
            this.addInvoice_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvoice_TSMI.Name = "addInvoice_TSMI";
            this.addInvoice_TSMI.Size = new System.Drawing.Size(83, 20);
            this.addInvoice_TSMI.Text = "Add Invoice";
            this.addInvoice_TSMI.Click += new System.EventHandler(this.addInvoice_TSMI_Click);
            // 
            // salesList_TSMI
            // 
            this.salesList_TSMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesList_TSMI.Name = "salesList_TSMI";
            this.salesList_TSMI.Size = new System.Drawing.Size(67, 20);
            this.salesList_TSMI.Text = "Sales List";
            this.salesList_TSMI.Click += new System.EventHandler(this.salesList_TSMI_Click);
            // 
            // main_Pnl
            // 
            this.main_Pnl.Controls.Add(this.mainBg_pB);
            this.main_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_Pnl.Location = new System.Drawing.Point(0, 24);
            this.main_Pnl.Name = "main_Pnl";
            this.main_Pnl.Size = new System.Drawing.Size(1174, 407);
            this.main_Pnl.TabIndex = 2;
            // 
            // mainBg_pB
            // 
            this.mainBg_pB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainBg_pB.Image = global::BillingApp.Properties.Resources.krishna;
            this.mainBg_pB.Location = new System.Drawing.Point(0, 0);
            this.mainBg_pB.Name = "mainBg_pB";
            this.mainBg_pB.Size = new System.Drawing.Size(1174, 407);
            this.mainBg_pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainBg_pB.TabIndex = 4;
            this.mainBg_pB.TabStop = false;
            // 
            // footer_Pnl
            // 
            this.footer_Pnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer_Pnl.Location = new System.Drawing.Point(0, 431);
            this.footer_Pnl.Name = "footer_Pnl";
            this.footer_Pnl.Size = new System.Drawing.Size(1174, 29);
            this.footer_Pnl.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 460);
            this.Controls.Add(this.main_Pnl);
            this.Controls.Add(this.footer_Pnl);
            this.Controls.Add(this.nav_menu_list);
            this.MainMenuStrip = this.nav_menu_list;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.nav_menu_list.ResumeLayout(false);
            this.nav_menu_list.PerformLayout();
            this.main_Pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainBg_pB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip nav_menu_list;
        private System.Windows.Forms.ToolStripMenuItem addProduct_TSMI;
        private System.Windows.Forms.ToolStripMenuItem addCompany_TSMI;
        private System.Windows.Forms.ToolStripMenuItem addInvoice_TSMI;
        private System.Windows.Forms.ToolStripMenuItem salesList_TSMI;
        private System.Windows.Forms.Panel main_Pnl;
        private System.Windows.Forms.PictureBox mainBg_pB;
        private System.Windows.Forms.Panel footer_Pnl;
    }
}

