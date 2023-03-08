using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BillingApp.Properties
{
    public partial class addSalesList_form : Form
    {
        private string connectionString;
        public addSalesList_form()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SelectInvoice_Table();
        }

        #region Top Bar

        private void AddProduct_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addproduct_form addproduct = new addproduct_form();
            addproduct.Show();
        }

        private void AddCompany_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcompany_form addcompany = new addcompany_form();
            addcompany.Show();
        }

        private void AddInvoice_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addInvoice_form addInvoice = new addInvoice_form();
            addInvoice.Show();
        }

        private void SalesList_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addSalesList_form addSalesList=new addSalesList_form();
            addSalesList.Show();
        }
        private void HomePage_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage_form addInvoice = new mainPage_form();
            addInvoice.Show();
        }

        private void AddQuotationTSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addQuotation_form addQuotation = new addQuotation_form();
            addQuotation.Show();
        }

        #endregion

        private void SelectInvoice_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT Invoice_No,Invoice_Date,Company_Name,Site_Address,Mob_No,Contact_Person,Grand_Total,Paid_Amount,Paid_Status,Balance_Amount FROM Invoice_Ledger", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable InvoiceLedgerdataTable = new DataTable();
                adapter.Fill(InvoiceLedgerdataTable);

                InvoiceLedger_dGV.DataSource = InvoiceLedgerdataTable;
            }
        }

    }
}
