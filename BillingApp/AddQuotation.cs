using BillingApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class addQuotation_form : Form
    {

        private string connectionString;

        Int32 invoiceNo_id,company_id;
        Int32 subcategory_id;
        Int32 fkproduct_id;
        Double rate;
       

        string product_name = "";
        string customer_name = "";
        string subcategory_name = "";
        string hsn_no = "";
        string priceper_unit = "";
        string site_name = "";
        string contact_person = "";
        string contact_no = "";
        string gst_no = "";
        string pan_no = "";
        string site_address = "";

        public addQuotation_form()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SelectCompany_Table();
            SelectProduct_Table();
            Invoicenumber();
        }


        public void Invoicenumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    int a;
                    string query = "Select Max(invoiceNo_Id) from tbl_InvoiceDetails";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string val = dr[0].ToString();
                        if (val == "")
                        {
                            invoiceNo_tB.Text = "1";
                        }
                        else
                        {
                            a = Convert.ToInt32(dr[0].ToString());
                            a++;
                            invoiceNo_tB.Text = a.ToString();
                        }
                    }
                    dr.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }
                finally
                {
                    invoiceNo_id = Convert.ToInt32(invoiceNo_tB.Text);
                }
        }

        private void SelectProduct_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT tbl_Product.product_Name, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id, subCategory_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' OR hsn_No LIKE '%' OR tbl_Product.product_Name LIKE '%'", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ProductCategorydataTable = new DataTable();
                adapter.Fill(ProductCategorydataTable);

                selectProduct_dGV.DataSource = ProductCategorydataTable;
            }
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
            addSalesList_form addSalesList = new addSalesList_form();
            addSalesList.Show();
        }
        private void HomePage_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage_form addInvoice = new mainPage_form();
            addInvoice.Show();
        }



        #endregion

        #region Company Details

        private void SelectCompany_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT company_Id,customer_Name  FROM tbl_CompanyDetails", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                selectCompany_dGV.DataSource = dataTable;
            }
        }

        private void SelectCompany_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row index of the clicked cell
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < selectCompany_dGV.Rows.Count)
            {
                // Retrieve the data from the selected row
                DataGridViewRow row = selectCompany_dGV.Rows[rowIndex];
                company_id = Convert.ToInt32(row.Cells["company_Id"].Value);
                customer_name = row.Cells["customer_Name"].Value.ToString();

                resultCustomerId_tB.Text = Convert.ToString(@company_id);
                resultCustomer_tB.Text = @customer_name;

                MessageBox.Show("Customer Selected Successfully.");

            }
        }

        private void SearchCustomer_pB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(searchCustomer_tB.Text))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT company_Id,customer_Name  FROM tbl_CompanyDetails where customer_Name like '%'+@searchword+'%' or contact_Person like '%'+@searchword+'%' or gst_No like '%'+@searchword+'%' ", conn);

                    //SqlCommand command = new SqlCommand("SELECT subCategory_Id, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' + @searchWord +  '%' OR hsn_No LIKE '%' + @searchWord + '%' OR tbl_Product.product_Name LIKE '%' + @searchWord + '%'", conn);
                    command.Parameters.AddWithValue("@searchWord", searchProductName_tB.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable CompanydataTable = new DataTable();
                    adapter.Fill(CompanydataTable);

                    selectCompany_dGV.DataSource = CompanydataTable;
                }
                else
                {
                    conn.Open();
                    //    SqlCommand command = new SqlCommand("SELECT subCategory_Id, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' OR hsn_No LIKE '%' OR tbl_Product.product_Name LIKE '%'", conn);
                    SqlCommand command = new SqlCommand("SELECT company_Id,customer_Name  FROM tbl_CompanyDetails", conn);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable CompanydataTable = new DataTable();
                    adapter.Fill(CompanydataTable);

                    selectCompany_dGV.DataSource = CompanydataTable;
                    searchCustomer_tB.Text = "";
                }
            }
        }

        private void ClearCustomer_btn_Click(object sender, EventArgs e)
        {
            resultCustomer_tB.Text = "";
            resultCustomerId_tB.Text = "";
            companyName_tB.Text = "";
            siteName_tB.Text = "";
            contactPerson_tB.Text = "";
            contactNo_tb.Text = "";
            gstNo_tB.Text = "";
            panNo_tB.Text = "";
            siteAddress_tb.Text = "";
        }
        private void SelectCustomer_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultCustomerId_tB.Text))
            {
              int company_id = int.Parse(resultCustomerId_tB.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT customer_Name, site_Name, contact_Person, contact_No, gst_No, pan_No, site_Address FROM tbl_CompanyDetails WHERE company_Id = @company_id", conn);
                    cmd.Parameters.AddWithValue("@company_id", company_id);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    { 

                    }
                    conn.Close();
                }

              
            }
            else
            {
               
            }

        }
        #endregion

        private void PrintQuotation_btn_Click(object sender, EventArgs e)
        {
            PrintDocument QuotationPrint = new PrintDocument();
            QuotationPrint.PrintPage += new PrintPageEventHandler(QuoTationPrint_printPage);

            QuotationPrint.Print();
        }

        private void QuoTationPrint_printPage(object sender, PrintPageEventArgs e)
        {
            //Graphics Quotation_G = e.Graphics;
            Bitmap Quotation_bmp = new Bitmap(quotation_Pnl.Width, quotation_Pnl.Height);
            quotation_Pnl.DrawToBitmap(Quotation_bmp, new  Rectangle(0,0, Quotation_bmp.Width, Quotation_bmp.Height));


            e.HasMorePages = false;
        }

        private void addQuotation_form_Load(object sender, EventArgs e)
        {
           //Image backgroundImage = Image.FromFile("path/to/image.png");
           //
           //quotation_Pnl.BackgroundImage = backgroundImage;
        }


        private void SelectProduct_btn_Click(object sender, EventArgs e)
        {
            // Parse the product details from the textboxes
            product_name = catogeryProduct_tB.Text;
            subcategory_name = resultProduct_tB.Text;
            hsn_no = hsnNo_tB.Text;
            decimal p_rate = Convert.ToDecimal(rateProduct_tB.Text);
           
            // Add product to gridview
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(selectedProductList_dGV);
            newRow.Cells[0].Value = subcategory_name;
            newRow.Cells[1].Value = product_name;
            newRow.Cells[2].Value = hsn_no;
            newRow.Cells[3].Value = p_rate;           

            selectedProductList_dGV.Rows.Add(newRow);
            resultCustomerId_tB.Clear();
            catogeryProduct_tB.Clear();
            resultProduct_tB.Clear();
            rateProduct_tB.Clear();
            hsnNo_tB.Clear();
        }

        private void SelectProduct_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row index of the clicked cell
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0 && rowIndex < selectProduct_dGV.Rows.Count)
            {
                // Retrieve the data from the selected row
                DataGridViewRow row = selectProduct_dGV.Rows[rowIndex];

                resultProduct_tB.Text = row.Cells["subCategory_Name"].Value.ToString();
                hsnNo_tB.Text = row.Cells["hsn_No"].Value.ToString();
                rateProduct_tB.Text = row.Cells["pricePer_Unit"].Value.ToString();
                //var fkproduct_id
                fkproduct_id = Convert.ToInt32(row.Cells["fk_Product_Id"].Value);
                resultProductId_tB.Text = Convert.ToString(row.Cells["subCategory_Id"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT product_Name FROM tbl_Product WHERE product_Id = @fkproduct_id", conn);
                    cmd.Parameters.AddWithValue("@fkproduct_id", fkproduct_id);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        product_name = sdr.GetString(0);
                    }
                    conn.Close();
                }
                catogeryProduct_tB.Text = @product_name;
                MessageBox.Show("Product Selected Successfully.");
            }
            else
            {
                MessageBox.Show(" handle the error here line:506 ");
            }
        }

    }
}
