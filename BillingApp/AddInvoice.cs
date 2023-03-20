using BillingApp.Properties;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class addInvoice_form : Form
    {
        private string connectionString;

        Int32 invoiceNo_id, Subid, p_quantity, company_id, subcategory_id, fkproduct_id;

        decimal lenghtValue, totalSqFt, widthValue, p_rate, p_Total, pLength, pWidth, servicePrice, grand_Total, paidAmount, balanceAmount, priceper_unit;
        Double length, width;
        Boolean Submit =false;

        string product_name = "";
        string side_service = "";
        string customer_name = "";
        string subcategory_name = "";
        string hsn_no = "";
        string site_name = "";
        string contact_person = "";
        string contact_no = "";
        string gst_no = "";
        string pan_no = "";
        string site_address = "";

        public addInvoice_form()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            SelectCompany_Table();
            SelectProduct_Table();
            Invoicenumber();
        }

        private void DelectSide_Service()
        {
            Submit = true;

            L1FR.Checked = false;
            L1HR.Checked = false;
            L1CH.Checked = false;
            L12CH.Checked = false;
            L1EP.Checked = false;
            L12EP.Checked = false;
            L1KM.Checked = false;
            L1GROOVE.Checked = false;

            L2FR.Checked = false;
            L2HR.Checked = false;
            L2CH.Checked = false;
            L22CH.Checked = false;
            L2EP.Checked = false;
            L22EP.Checked = false;
            L2KM.Checked = false;
            L2GROOVE.Checked = false;

            W1FR.Checked = false;
            W1HR.Checked = false;
            W1CH.Checked = false;
            W12CH.Checked = false;
            W1EP.Checked = false;
            W12EP.Checked = false;
            W1KM.Checked = false;
            HALFDP.Checked = false;
            FULLDP.Checked = false;

            W2FR.Checked = false;
            W2HR.Checked = false;
            W2CH.Checked = false;
            W22CH.Checked = false;
            W2EP.Checked = false;
            W22EP.Checked = false;
            W2KM.Checked = false;
           
            Submit = false;
        }

        private void SelectSide_Service()
        {
            List<string> designations = new List<string>();

            if (L1FR.Checked)       { designations.Add(L1FR.Text); }
            if (L1HR.Checked)       { designations.Add(L1HR.Text); }
            if (L1CH.Checked)       { designations.Add(L1CH.Text); }
            if (L12CH.Checked)      { designations.Add(L12CH.Text); }
            if (L1EP.Checked)       { designations.Add(L1EP.Text); }
            if (L12EP.Checked)      { designations.Add(L12EP.Text); }
            if (L1KM.Checked)       { designations.Add(L1KM.Text); }
            if (L1GROOVE.Checked)   { designations.Add(L1GROOVE.Text); }

            if (L2FR.Checked)       { designations.Add(L2FR.Text); }
            if (L2HR.Checked)       { designations.Add(L2HR.Text); }
            if (L2CH.Checked)       { designations.Add(L2CH.Text); }
            if (L22CH.Checked)      { designations.Add(L22CH.Text); }
            if (L2EP.Checked)       { designations.Add(L2EP.Text); }
            if (L22EP.Checked)      { designations.Add(L22EP.Text); }
            if (L2KM.Checked)       { designations.Add(L2KM.Text); }
            if (L2GROOVE.Checked)   { designations.Add(L2GROOVE.Text); }

            if (W1FR.Checked)       { designations.Add(W1FR.Text); }
            if (W1HR.Checked)       { designations.Add(W1HR.Text); }
            if (W1CH.Checked)       { designations.Add(W1CH.Text); }
            if (W12CH.Checked)      { designations.Add(W12CH.Text); }
            if (W1EP.Checked)       { designations.Add(W1EP.Text); }
            if (W12EP.Checked)      { designations.Add(W12EP.Text); }
            if (W1KM.Checked)       { designations.Add(W1KM.Text); }
            if (HALFDP.Checked)     { designations.Add(HALFDP.Text); }
            if (FULLDP.Checked)     { designations.Add(FULLDP.Text); }

            if (W2FR.Checked)       { designations.Add(W2FR.Text); }
            if (W2HR.Checked)       { designations.Add(W2HR.Text); }
            if (W2CH.Checked)       { designations.Add(W2CH.Text); }
            if (W22CH.Checked)      { designations.Add(W22CH.Text); }
            if (W2EP.Checked)       { designations.Add(W2EP.Text); }
            if (W22EP.Checked)      { designations.Add(W22EP.Text); }
            if (W2KM.Checked)       { designations.Add(W2KM.Text); }

            string sides = string.Join(",\n ", designations);
            sideService_tB.Text = sides;
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

        #region Top Bar
         private void AddCompany_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcompany_form addcompany = new addcompany_form();
            addcompany.Show();
        }

        private void AddProduct_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addproduct_form addproduct = new addproduct_form();
            addproduct.Show();
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

        private void AddQuotation_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addQuotation_form addQuotation = new addQuotation_form();
            addQuotation.Show();
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
                company_id = int.Parse(resultCustomerId_tB.Text);
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
                        customer_name = sdr.GetString(0);
                        site_name = sdr.GetString(1);
                        contact_person = sdr.GetString(2);
                        contact_no = sdr.GetString(3);
                        gst_no = sdr.GetString(4);
                        pan_no = sdr.GetString(5);
                        site_address = sdr.GetString(6);
                    }
                    conn.Close();
                }

                companyName_tB.Text = @customer_name;
                siteName_tB.Text = @site_name;
                contactPerson_tB.Text = @contact_person;
                contactNo_tb.Text = @contact_no;
                gstNo_tB.Text = @gst_no;
                panNo_tB.Text = @pan_no;
                siteAddress_tb.Text = @site_address;
            }
            else
            {
                companyName_tB.Text = "";
                siteName_tB.Text = "";
                contactPerson_tB.Text = "";
                contactNo_tb.Text = "";
                gstNo_tB.Text = "";
                panNo_tB.Text = "";
                siteAddress_tb.Text = "";
            }
        }

        #endregion

        #region Product Details

        private string GETSC_id(string subcategory_name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT subcategory_id FROM tbl_SubCategory WHERE subCategory_Name = '" + subcategory_name + "'";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Subid = reader.GetInt32(0);
                }

                reader.Close();
            }

            return Convert.ToString(Subid);
        }

        private void SelectProduct_btn_Click(object sender, EventArgs e)
        {
            DelectSide_Service();
            // Parse the product details from the textboxes
            product_name = catogeryProduct_tB.Text;
            subcategory_name = resultProduct_tB.Text;
            hsn_no = hsnNo_tB.Text;
            side_service = sideService_tB.Text;
            //decimal productTotal;

            if ( Submit==false && (
                !decimal.TryParse(rateProduct_tB.Text, out p_rate)
                || !decimal.TryParse(lengthProduct_tB.Text, out pLength)
                || !decimal.TryParse(widthProduct_tB.Text, out pWidth)
                || !int.TryParse(quantity_tB.Text, out p_quantity)
                ))
            {
                MessageBox.Show("Invalid input in one or more fields.");
                return;
            }


            // Add product to gridview
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(selectedProductList_dGV);

            newRow.Cells[0].Value = subcategory_name;
            newRow.Cells[1].Value = product_name;
            newRow.Cells[2].Value = hsn_no;
            newRow.Cells[3].Value = pWidth;
            newRow.Cells[4].Value = pLength;
            newRow.Cells[5].Value = totalSqFt;
            newRow.Cells[6].Value = p_quantity;
            newRow.Cells[7].Value = p_rate;
            newRow.Cells[8].Value = side_service;
            newRow.Cells[9].Value = servicePrice;
            newRow.Cells[10].Value = p_Total;

            selectedProductList_dGV.Rows.Add(newRow);

            // Calculate invoice total and display it
            decimal invoiceTotal = 0;
            foreach (DataGridViewRow invoiceRow in selectedProductList_dGV.Rows)
            {
                decimal productTotalAmount = Convert.ToDecimal(invoiceRow.Cells[10].Value);
                invoiceTotal += productTotalAmount;
            }
            grandTotal_tB.Text = Convert.ToString(invoiceTotal);

          //  Clear the product details textboxes.
          //  resultCustomerId_tB.Clear();
          //  catogeryProduct_tB.Clear();
          //  resultProduct_tB.Clear();
          //  rateProduct_tB.Clear();
            quantity_tB.Clear();
            widthProduct_tB.Clear();
            lengthProduct_tB.Clear();
            totalServiceSidesCharges_tB.Clear();
          //  hsnNo_tB.Clear();
          //  totalSqFtProduct_tB.Clear();
            totalAmount_tB.Clear();
            CALCULATED = 0;
            sideService_tB.Clear();
        }

        private void SearchProduct_pB_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(searchProductName_tB.Text))
                {
                    conn.Open();
                    //SqlCommand command = new SqlCommand("SELECT subCategory_Id, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' + @searchWord +  '%' OR hsn_No LIKE '%' + @searchWord + '%' OR tbl_Product.product_Name LIKE '%' + @searchWord + '%'", conn);

                    SqlCommand command = new SqlCommand("SELECT tbl_Product.product_Name, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id, subCategory_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' + @searchWord + '%' OR hsn_No LIKE '%' + @searchWord + '%' OR tbl_Product.product_Name LIKE '%' + @searchWord + '%'", conn);
                    command.Parameters.AddWithValue("@searchWord", searchProductName_tB.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable ProductCategorydataTable = new DataTable();
                    adapter.Fill(ProductCategorydataTable);

                    selectProduct_dGV.DataSource = ProductCategorydataTable;
                    searchProductName_tB.Text = "";
                }
                else
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT tbl_Product.product_Name, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id, subCategory_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' OR hsn_No LIKE '%' OR tbl_Product.product_Name LIKE '%'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable ProductCategorydataTable = new DataTable();
                    adapter.Fill(ProductCategorydataTable);

                    selectProduct_dGV.DataSource = ProductCategorydataTable;
                    searchProductName_tB.Text = "";
                }
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

        private void CatogeryProduct_tB_TextChanged(object sender, EventArgs e)
        {
            if (catogeryProduct_tB.Text == "Goods")
            {
                lengthProduct_tB.ReadOnly = true;
                widthProduct_tB.ReadOnly = true;
                selectService_btn.Visible = false;
                lengthProduct_tB.Text = Convert.ToString("");
                widthProduct_tB.Text = Convert.ToString("");
                sideService_tB.Text = Convert.ToString("");
            }
        }

        private void LengthProduct_tB_TextChanged(object sender, EventArgs e)
        {
            if (catogeryProduct_tB.Text == "Marble" || catogeryProduct_tB.Text == "Granite") 
            {
                if (!string.IsNullOrEmpty(lengthProduct_tB.Text))
                {
                    Decimal lenghtValue = Convert.ToDecimal(lengthProduct_tB.Text);
                    for (int i = 1; i < 10000; i++)
                    {
                        int j = 3;
                        int k = i * j;
                        if (lenghtValue <= k)
                        {
                            length = k;
                            //i = 10000;
                            break;
                        }
                    }
                    pLength = (decimal)length;
                 //   MessageBox.Show("Length = " + pLength);
                }
            }

            else if (catogeryProduct_tB.Text == "Stone" || catogeryProduct_tB.Text == "Kadappa")
            {
                if (decimal.TryParse(lengthProduct_tB.Text, out lenghtValue))
                {
                    decimal result = LengthRoundToMultipleOf6(lenghtValue);
                    pLength = result;
                    //essageBox.Show("Length= " + pLength);
                }
                else
                {
                    MessageBox.Show("enter valid length");
                }
            }

            else if (catogeryProduct_tB.Text == "Uncut")
            {
                if (decimal.TryParse(lengthProduct_tB.Text, out lenghtValue))
                {
                    // decimal result = lengthRoundToMultipleOf6(lenghtValue);
                    pLength = lenghtValue;
                    MessageBox.Show("Length= " + pLength);
                }
                else
                {
                    MessageBox.Show("enter valid length");
                }
            }


            if (!string.IsNullOrEmpty(widthProduct_tB.Text))
            {
                totalSqFt = (pLength / 12) * (pWidth / 12);
                totalSqFtProduct_tB.Text = Convert.ToString(totalSqFt);
            }
        }

        private decimal LengthRoundToMultipleOf6(decimal n)
        {
            double rou = (double)(n / 12);
            int integerPart = (int)Math.Floor(rou);
            double fractionalPart = rou - integerPart;

            if (fractionalPart <= 0.42)
            {
                fractionalPart = 0.41 + 0.09;
            }
            else if (fractionalPart <= 0.92)
            {
                fractionalPart = 0.91 + 0.09;
            }
            else if (fractionalPart > 0.92)
            {
                fractionalPart = 1.5;
            }

            decimal lenval = (decimal)((integerPart + fractionalPart) * 12);
            return lenval;
        }

        private void ResultProduct_tB_TextChanged(object sender, EventArgs e)
        {

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
                // handle the error here, e.g. display an error message
                MessageBox.Show(" handle the error here line:506 ");
            }
        }
   
        private void ClearProduct_btn_Click(object sender, EventArgs e)
        {
            resultCustomerId_tB.Clear();
            catogeryProduct_tB.Clear();
            resultProduct_tB.Clear();
            rateProduct_tB.Clear();
            quantity_tB.Clear();
            widthProduct_tB.Clear();
            lengthProduct_tB.Clear();
            totalServiceSidesCharges_tB.Clear();
            hsnNo_tB.Clear();
            totalSqFtProduct_tB.Clear();
            totalAmount_tB.Clear();
            CALCULATED = 0;
            sideService_tB.Clear();
        }
    
        private void EditProduct_btn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_btn_Click(object sender, EventArgs e)
        {

        }

        private void Quantity_tB_TextChanged(object sender, EventArgs e)
        {
            if(Submit==false && (!decimal.TryParse(rateProduct_tB.Text, out p_rate) ||
                !decimal.TryParse(lengthProduct_tB.Text, out pLength) ||
                !decimal.TryParse(widthProduct_tB.Text, out pWidth) ||
                !int.TryParse(quantity_tB.Text, out p_quantity)
              )  )
            {
                MessageBox.Show("Invalid input in one or more fields.");
                return;
            }
            if (!string.IsNullOrEmpty(quantity_tB.Text))
            {
                p_quantity = Convert.ToInt32(quantity_tB.Text);
            }
            if (catogeryProduct_tB.Text == "Goods")
            {
                p_Total = p_rate * p_quantity;
                totalAmount_tB.Text = Convert.ToString(p_Total);
            }
            else if (catogeryProduct_tB.Text == "Uncut")
            {
                p_Total = p_rate * p_quantity * totalSqFt;
                totalAmount_tB.Text = Convert.ToString(p_Total);
            }
            else if (catogeryProduct_tB.Text == "Marble" || catogeryProduct_tB.Text == "Granite" || catogeryProduct_tB.Text == "Stone" || catogeryProduct_tB.Text == "Kadappa")
            {
                if (!string.IsNullOrEmpty(totalServiceSidesCharges_tB.Text))
                {
                    servicePrice = Convert.ToDecimal(totalServiceSidesCharges_tB.Text);
                }
                else
                {
                    MessageBox.Show("Molding Not Selected");
                    servicePrice = 0;
                }
                p_Total = (p_rate * p_quantity * totalSqFt) + (p_quantity * servicePrice);
                totalAmount_tB.Text = Convert.ToString(p_Total);
            }
        }

        private void TotalSqFtProduct_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RateProduct_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void WidthProduct_tB_TextChanged(object sender, EventArgs e)
        {
            if (catogeryProduct_tB.Text == "Marble" || catogeryProduct_tB.Text == "Granite")
            {
                if (!string.IsNullOrEmpty(widthProduct_tB.Text))
                {
                    widthValue = Convert.ToDecimal(widthProduct_tB.Text);
                    for (int i = 1; i < 10000; i++)
                    {
                        int j = 3;
                        int k = i * j;
                        if (widthValue <= k)
                        {
                            width = k;
                            break;
                        }
                    }
                    pWidth = (decimal)width;
                    MessageBox.Show("Width= " + pWidth);
                }
            }

            else if (catogeryProduct_tB.Text == "Stone" || catogeryProduct_tB.Text == "Kadappa")
            {

                if (decimal.TryParse(widthProduct_tB.Text, out widthValue))
                {
                    decimal result = WidthRoundToMultipleOf6(widthValue);
                    pWidth = result;
                    MessageBox.Show("Width= " + pWidth);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number between 0.01 and 5.0.");
                }
            }

            else if (catogeryProduct_tB.Text == "Uncut")
            {

                if (decimal.TryParse(widthProduct_tB.Text, out widthValue))
                {
                    // decimal result = widthRoundToMultipleOf6(widthValue);
                    pWidth = widthValue;
                    MessageBox.Show("Width= " + pWidth);
                }
                else
                {
                    MessageBox.Show("Please enter a valid number between 0.01 and 5.0.");
                }
            }

            if (!string.IsNullOrEmpty(lengthProduct_tB.Text))
            {
                totalSqFt = (pLength / 12) * (pWidth / 12);
                totalSqFtProduct_tB.Text = Convert.ToString(totalSqFt);
            }
        }

        private decimal WidthRoundToMultipleOf6(decimal n)
        {
            double rou = (double)(n / 12);
            int integerPart = (int)Math.Floor(rou);
            double fractionalPart = rou - integerPart;

            if (fractionalPart <= 0.42)
            {
                fractionalPart = 0.41 + 0.09;
            }
            else if (fractionalPart <= 0.92)
            {
                fractionalPart = 0.91 + 0.09;
            }
            else if (fractionalPart > 0.92)
            {
                fractionalPart = 1.5;
            }
            decimal widval = (decimal)((integerPart + fractionalPart) * 12);
            return widval;
        }

        private void SideService_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalAmount_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addinvoice_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    if (!string.IsNullOrEmpty(paymentStatus_ctB.Text))
                    {
                        string invoiceSql = "INSERT INTO tbl_InvoiceDetails (fk_Company_Id, invoiceDate, dueDate, grandTotal, paymentStatus, paidAmount, balanceAmount) VALUES" +
                        " (@companyId, @invoiceDate, @dueDate, @grandTotal, '@paymentStatus', @paidAmount, @balanceAmount); SELECT SCOPE_IDENTITY() AS invoiceNoId";
                        SqlCommand invoiceCommand = new SqlCommand(invoiceSql, connection, transaction);
                        invoiceCommand.Parameters.AddWithValue("@companyId", company_id);
                        invoiceCommand.Parameters.AddWithValue("@invoiceDate", invoiceDate_dtP.Value.Date);
                        invoiceCommand.Parameters.AddWithValue("@dueDate", invoiceDate_dtP.Value.Date.AddDays(30));
                        invoiceCommand.Parameters.AddWithValue("@grandTotal", grand_Total);
                        invoiceCommand.Parameters.AddWithValue("@paymentStatus", paymentStatus_ctB.Text);
                        invoiceCommand.Parameters.AddWithValue("@paidAmount", paidAmount);
                        invoiceCommand.Parameters.AddWithValue("@balanceAmount", balanceAmount);

                        object invoiceResult = invoiceCommand.ExecuteScalar();
                        int invno = Convert.ToInt32(invoiceResult); // Convert object to int output
                        foreach (DataGridViewRow row in selectedProductList_dGV.Rows)
                        {
                            if (row.Index != selectedProductList_dGV.Rows.Count - 1) // Check if the row is not the last row
                            {
                                string productSql = "INSERT INTO dbo.tbl_InvoiceProductDetails (fk_InvoiceNo_Id, fk_Company_Id, fk_SubCategory_Id, quantity_Product, hsnNo, length_Product, width_Product, total_SqFt, side_Service, molding_Amount, total_Amount) VALUES (@invoiceNoId, @companyId, @subcategoryId, @quantityProduct, @hsnNo, @lengthProduct, @widthProduct, @totalSqFt, @sideService, @moldingAmount, @totalAmount)";
                                SqlCommand productCommand = new SqlCommand(productSql, connection, transaction);
                                subcategory_name = row.Cells["subcategoryName"].Value.ToString();
                                p_quantity = Convert.ToInt32(row.Cells["productQuantity"].Value);

                                subcategory_id = int.Parse(GETSC_id(subcategory_name));
                                productCommand.Parameters.AddWithValue("@invoiceNoId", invno);
                                productCommand.Parameters.AddWithValue("@companyId", company_id);
                                productCommand.Parameters.AddWithValue("@subcategoryId", subcategory_id);
                                productCommand.Parameters.AddWithValue("@hsnNo", row.Cells["hsnNo"].Value);
                                productCommand.Parameters.AddWithValue("@quantityProduct", p_quantity);
                                productCommand.Parameters.AddWithValue("@totalSqFt", totalSqFt);
                                productCommand.Parameters.AddWithValue("@lengthProduct", row.Cells["productLength"].Value);
                                productCommand.Parameters.AddWithValue("@widthProduct", row.Cells["productWidth"].Value);
                                productCommand.Parameters.AddWithValue("@sideService", row.Cells["serviceSides"].Value);
                                productCommand.Parameters.AddWithValue("@moldingAmount", row.Cells["moldingPrice"].Value);
                                productCommand.Parameters.AddWithValue("@totalAmount", row.Cells["productTotal"].Value);

                                productCommand.ExecuteNonQuery();
                            }

                        }

                        transaction.Commit();
                        MessageBox.Show("Data saved successfully");

                    }
                    else
                    {
                        MessageBox.Show("Fill Payment Details");
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        #endregion

        private void PrintInvoice_btn_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog PrintPreviewInvoice = new PrintPreviewDialog();
            PrintDocument InvoicePrint = new PrintDocument();
            InvoicePrint.PrintPage += new PrintPageEventHandler(InvoicePrint_printPage);
            PrintPreviewInvoice.Document = InvoicePrint;
            PrintPreviewInvoice.ShowDialog();
            InvoicePrint.Print();
        }

        private void InvoicePrint_printPage(object sender, PrintPageEventArgs e)
        {
            //Graphics Invoice_G = e.Graphics;
            Bitmap Invoice_bmp = new Bitmap(invoice_Pnl.Width, invoice_Pnl.Height);
            invoice_Pnl.DrawToBitmap(Invoice_bmp, new Rectangle(0, 0, Invoice_bmp.Width, Invoice_bmp.Height));

            e.Graphics.DrawImage(Invoice_bmp, 0, 0);

            e.HasMorePages = false;
        }

        private void SelectedProductList_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region List Services 

        ///Global Variable For Running Feet///
        Decimal CALCULATED = 0;
        /// <variable end>   /// 



        private void W1FR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_fr.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W1FR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W1FR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void W1HR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_hr.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W1HR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W1HR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                { }
            }
        }

        private void W1CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ch.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (W1CH.Checked)
                {

                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

                }
                else if (W1CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void W12CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ch.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W12CH.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W12CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void W1EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ep.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W1EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W1EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void W12EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ep.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W12EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W12EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void W1KM_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_km.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W1KM.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W1KM.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void W1RDP_CheckedChanged(object sender, EventArgs e)
        {
            //  Decimal val1 = Convert.ToDecimal(txt_rvertical.Text);
            //  Decimal val2 =  Convert.ToDecimal(Width);
            //  Decimal val3 = val1 * (val2 / 12);
            //
            //
            //  if (W1RDP.Checked)
            //  {
            //
            //      CALCULATED += val3;
            //      totalServiceSides_tB.Text = CALCULATED.ToString();
            //
            //  }
            //  else if (W1RDP.Checked == false)
            //  {
            //      CALCULATED = CALCULATED - val3;
            //      totalServiceSides_tB.Text = CALCULATED.ToString();
            //  }
            //  else
            //  {
            //
            //  }
        }

        private void W1LDP_CheckedChanged(object sender, EventArgs e)
        {
            //Decimal val1 = Convert.ToDecimal(txt_lvertical.Text);
            //Double val2 =  Convert.ToInt32(Width);
            //Decimal val3 = val1 * (val2 / 12);
            //
            //
            //if (W1LDP.Checked)
            //{
            //
            //    CALCULATED += val3;
            //    totalServiceSides_tB.Text = CALCULATED.ToString();
            //
            //}
            //else if (W1LDP.Checked == false)
            //{
            //    CALCULATED = CALCULATED - val3;
            //    totalServiceSides_tB.Text = CALCULATED.ToString();
            //}
            //else
            //{
            //
            //}
        }

        private void W2FR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_fr.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W2FR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W2FR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {
                
                }
            }
        }

        private void W2HR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_hr.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
                if (W2HR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W2HR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void W2CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ch.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false) { 
                if (W2CH.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W2CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void W22CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ch.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false) { 
            if (W22CH.Checked)
            {
                CALCULATED += val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W22CH.Checked == false)
            {
                CALCULATED -= val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
            }
        }

        private void W2EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ep.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (W2EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W2EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void W22EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ep.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (W22EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W22EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void W2KM_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_km.Text);
            Decimal val2 = Convert.ToDecimal(pWidth);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (W2KM.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (W2KM.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void FULLDP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal txt_fulldpval = Convert.ToDecimal(txt_fulldp.Text);
            if (Submit == false)
            {
                if (FULLDP.Checked)
                {
                    CALCULATED += txt_fulldpval;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (FULLDP.Checked == false)
                {
                    CALCULATED -= txt_fulldpval;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void HALFDP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal txt_2epval = Convert.ToDecimal(txt_2ep.Text);
            if (Submit == false)
            {
                if (HALFDP.Checked)
                {
                    CALCULATED += txt_2epval;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (HALFDP.Checked == false)
                {
                    CALCULATED -= txt_2epval;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L1FR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_fr.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L1FR.Checked == true)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L1FR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }

        }

        private void L1KM_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_km.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L1KM.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L1KM.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void L1HR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_hr.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L1HR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L1HR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void L1CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ch.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L1CH.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L1CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void L12CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ch.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L12CH.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L12CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void L1EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ep.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L1EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L1EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void printPreviewInvoice_Load(object sender, EventArgs e)
        {

        }

        private void other_TextChanged(object sender, EventArgs e)
        {

        }

        private void L12EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ep.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L12EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L12EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else { }
            }
        }

        private void L1GROOVE_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_groove.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L1GROOVE.Checked)
                {

                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

                }
                else if (L1GROOVE.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L2FR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_fr.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L2FR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L2FR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L2HR_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_hr.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L2HR.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L2HR.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L2CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ch.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L2CH.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L2CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L22CH_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ch.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);
            if (Submit == false)
            {
                if (L22CH.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L22CH.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L2EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_ep.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L2EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L2EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L22EP_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_2ep.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L22EP.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L22EP.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L2KM_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_km.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L2KM.Checked)
                {

                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

                }
                else if (L2KM.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }

        private void L2GROOVE_CheckedChanged(object sender, EventArgs e)
        {
            Decimal val1 = Convert.ToDecimal(txt_groove.Text);
            Decimal val2 = Convert.ToDecimal(pLength);
            Decimal val3 = val1 * (val2 / 12);

            if (Submit == false)
            {
                if (L2GROOVE.Checked)
                {
                    CALCULATED += val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else if (L2GROOVE.Checked == false)
                {
                    CALCULATED -= val3;
                    totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
                }
                else
                {

                }
            }
        }


        #endregion

        #region Sides Service

        private void SidesServicePnlClose_btn_Click(object sender, EventArgs e)
        {
            SelectSide_Service();
            selectedProductList_Pnl.BringToFront();
            selectedProductList_Pnl.Visible = true;
            sides_ServiceScrollPnl.Visible = false;
        }

        private void SelectService_btn_Click(object sender, EventArgs e)
        {
            sides_ServiceScrollPnl.BringToFront();
            sides_ServiceScrollPnl.Visible = true;
            selectedProductList_Pnl.Visible = false;
        }

        #endregion


        private void PaymentStatus_cB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentStatus_ctB.Text == "Paid")
            {
                paidAmount_tB.Text = Convert.ToString(grand_Total);
            }
            else if (paymentStatus_ctB.Text == "Unpaid")
            {
                paidAmount_tB.Text = Convert.ToString(0);
            }

        }

        private void PaidAmount_tB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(paidAmount_tB.Text))
            {
                paidAmount = Convert.ToDecimal(paidAmount_tB.Text);
                balanceAmount = grand_Total - paidAmount;
                balanceAmount_tB.Text = Convert.ToString(balanceAmount);
            }
        }

        private void GrandTotal_tB_TextChanged(object sender, EventArgs e)
        {
            grand_Total = Convert.ToDecimal(grandTotal_tB.Text);
        }

        private void BalanceAmount_tB_TextChanged(object sender, EventArgs e)
        {
            balanceAmount = Convert.ToDecimal(balanceAmount_tB.Text);
        }

        private void InvoiceNo_tB_TextChanged(object sender, EventArgs e)
        {

        }


    }
}