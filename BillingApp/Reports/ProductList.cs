using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class productList_form : Form
    {
        private string connectionString;

        Int32 company_id;
        Int32 subcategory_id;
        Int32 fkproduct_id;
        Double rate;
        Double length;
        Double width;

        string product_name = "";
        string side_service = "";
        string customer_name = "";
        string subcategory_name = "";
        string quantity = "";
        string hsn_no = "";
        string priceper_unit = "";
        string site_name = "";
        string contact_person = "";
        string contact_no = "";
        string gst_no = "";
        string pan_no = "";
        string site_address = "";

        public productList_form()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            selectCompany_Table();
            selectProduct_Table();
            invoicenumber();
        }

        private void selectSide_Service()
        {
            List<string> designations = new List<string>();

            if (L1FR.Checked) { designations.Add(L1FR.Text); }
            if (L1HR.Checked) { designations.Add(L1HR.Text); }
            if (L1CH.Checked) { designations.Add(L1CH.Text); }
            if (L12CH.Checked) { designations.Add(L12CH.Text); }
            if (L1EP.Checked) { designations.Add(L1EP.Text); }
            if (L12EP.Checked) { designations.Add(L12EP.Text); }
            if (L1KM.Checked) { designations.Add(L1KM.Text); }
            if (L1GROOVE.Checked) { designations.Add(L1GROOVE.Text); }

            if (L2FR.Checked) { designations.Add(L2FR.Text); }
            if (L2HR.Checked) { designations.Add(L2HR.Text); }
            if (L2CH.Checked) { designations.Add(L2CH.Text); }
            if (L22CH.Checked) { designations.Add(L22CH.Text); }
            if (L2EP.Checked) { designations.Add(L2EP.Text); }
            if (L22EP.Checked) { designations.Add(L22EP.Text); }
            if (L2KM.Checked) { designations.Add(L2KM.Text); }
            if (L2GROOVE.Checked) { designations.Add(L2GROOVE.Text); }

            if (W1FR.Checked) { designations.Add(W1FR.Text); }
            if (W1HR.Checked) { designations.Add(W1HR.Text); }
            if (W1CH.Checked) { designations.Add(W1CH.Text); }
            if (W12CH.Checked) { designations.Add(W12CH.Text); }
            if (W1EP.Checked) { designations.Add(W1EP.Text); }
            if (W12EP.Checked) { designations.Add(W12EP.Text); }
            if (W1KM.Checked) { designations.Add(W1KM.Text); }
            if (HALFDP.Checked) { designations.Add(HALFDP.Text); }
            if (FULLDP.Checked) { designations.Add(FULLDP.Text); }

            if (W2FR.Checked) { designations.Add(W2FR.Text); }
            if (W2HR.Checked) { designations.Add(W2HR.Text); }
            if (W2CH.Checked) { designations.Add(W2CH.Text); }
            if (W22CH.Checked) { designations.Add(W22CH.Text); }
            if (W2EP.Checked) { designations.Add(W2EP.Text); }
            if (W22EP.Checked) { designations.Add(W22EP.Text); }
            if (W2KM.Checked) { designations.Add(W2KM.Text); }

            string sides = string.Join(", ", designations);

            if (invoiceNo_tB.Text != "" && companyName_tB.Text != "" && invoiceDate_dtP.Text != "")
            {
                //  cmd.Parameters.AddWithValue("@state", txt_State.Text);
                //  cmd.ExecuteNonQuery(); 
                //  MessageBox.Show("Record Updated Successfully");
                //  conn.Close();

                if (!string.IsNullOrEmpty(sides))
                {
                    sideServiceSides_tB.Text = sides;//sideServiceString;
                }
                else
                {
                    MessageBox.Show("Select services!!!!!!");
                }
            }
            else
            {
                MessageBox.Show("Select Company Name!!!!!!");
            }
        }

        public void invoicenumber()
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
        }

        #region Top Bar

        private void addProduct_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addproduct_form addproduct = new addproduct_form();
            addproduct.Show();
        }

        private void addCompany_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addcompany_form addcompany = new addcompany_form();
            addcompany.Show();
        }

        private void addInvoice_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            addInvoice_form addInvoice = new addInvoice_form();
            addInvoice.Show();
        }

        private void salesList_TSMI_Click(object sender, EventArgs e)
        {

        }
        private void homePage_TSMI_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainPage_form addInvoice = new mainPage_form();
            addInvoice.Show();
        }



        #endregion

        #region Company Details

        private void selectCompany_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // SqlCommand command = new SqlCommand("Select tbl_Product.product_Name AS Product_Name, tbl_SubCategory.subCategory_Name AS SubCategory_Name, tbl_SubCategory.pricePer_Unit AS PricePer_Unit, tbl_SubCategory.hsn_No AS HSN_No FROM tbl_SubCategory INNER JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.Product_Id", conn);
                SqlCommand command = new SqlCommand("SELECT company_Id,customer_Name  FROM tbl_CompanyDetails", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                selectCompany_dGV.DataSource = dataTable;
            }
        }

        private void selectCompany_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void searchCustomer_pB_Click(object sender, EventArgs e)
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

        private void clearCustomer_btn_Click(object sender, EventArgs e)
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
                    SqlDataReader sdr   = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        customer_name   = sdr.GetString(0);
                        site_name       = sdr.GetString(1);
                        contact_person  = sdr.GetString(2);
                        contact_no      = sdr.GetString(3);
                        gst_no          = sdr.GetString(4);
                        pan_no          = sdr.GetString(5);
                        site_address    = sdr.GetString(6);

                    }
                    conn.Close();
                }

                companyName_tB.Text    = @customer_name;
                siteName_tB.Text       = @site_name;
                contactPerson_tB.Text  = @contact_person;
                contactNo_tb.Text      = @contact_no;
                gstNo_tB.Text          = @gst_no;
                panNo_tB.Text          = @pan_no;
                siteAddress_tb.Text    = @site_address;

            }
            else
            {
                companyName_tB.Text    = "";
                siteName_tB.Text       = "";
                contactPerson_tB.Text  = "";
                contactNo_tb.Text      = "";
                gstNo_tB.Text          = "";
                panNo_tB.Text          = "";
                siteAddress_tb.Text    = "";
            }

        }


        #endregion

        #region Product Details

        private void searchProduct_pB_btn_Click(object sender, EventArgs e)
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

        private void selectProduct_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                //  SqlCommand command = new SqlCommand("SELECT subCategory_Id, subCategory_Name  FROM tbl_SubCategory", conn);
                SqlCommand command = new SqlCommand("SELECT tbl_Product.product_Name, subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id, subCategory_Id FROM tbl_SubCategory LEFT JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.product_Id WHERE subCategory_Name LIKE '%' OR hsn_No LIKE '%' OR tbl_Product.product_Name LIKE '%'", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable ProductCategorydataTable = new DataTable();
                adapter.Fill(ProductCategorydataTable);

                selectProduct_dGV.DataSource = ProductCategorydataTable;
            }
        }

        private void selectProduct_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                // handle the error here, e.g. display an error message
                MessageBox.Show(" handle the error here ");
            }
        }

        /*private void selectProduct_btn_Click(object sender, EventArgs e)
        {
            DataTable selectedProductList_dt = new DataTable();
            selectedProductList_dt.Columns.Add("SubcategoryName");
            selectedProductList_dt.Columns.Add("ProductName");
            selectedProductList_dt.Columns.Add("HSNNo");
            selectedProductList_dt.Columns.Add("ProductPrice", typeof(decimal));
            selectedProductList_dt.Columns.Add("MoldingPrice", typeof(decimal));
            selectedProductList_dt.Columns.Add("Length", typeof(decimal));
            selectedProductList_dt.Columns.Add("Width", typeof(decimal));

            DataRow selectedProductList_row = selectedProductList_dt.NewRow();

            selectedProductList_row["SubcategoryName"] = resultProduct_tB.Text;
            selectedProductList_row["ProductName"] = catogeryProduct_tB.Text;
            selectedProductList_row["HSNNo"] = hsnNo_tB.Text;
            selectedProductList_row["ProductPrice"] = Convert.ToDecimal(rateProduct_tB.Text);
            selectedProductList_row["MoldingPrice"] = Convert.ToDecimal(rateProduct_tB.Text);
            selectedProductList_row["Length"] = Convert.ToDecimal(lengthProduct_tB.Text);
            selectedProductList_row["Width"] = Convert.ToDecimal(widthProduct_tB.Text);

            selectedProductList_dt.Rows.Add(selectedProductList_row);

            selectedProductList_dGV.DataSource = selectedProductList_dt;
        }*/


        private void ClearProduct_btn_Click(object sender, EventArgs e)
        {

        }

        private void EditProduct_btn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteProduct_btn_Click(object sender, EventArgs e)
        {

        }
        
        private void widthProduct_tB_TextChanged(object sender, EventArgs e)
        {

        }

        private void lengthProduct_tB_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region List Services 

        ///Global Variable For Running Feet///
        Double CALCULATED = 0;
        /// <variable end>   /// 



        private void L1FR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_fr.Text);
            Double val2 = Convert.ToDouble(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L1FR.Checked == true)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L1FR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L1KM_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_km.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L1KM.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L1KM.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L1HR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_hr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L1HR.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L1HR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L1CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L1CH.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L1CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L12CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L12CH.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L12CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L1EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L1EP.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L1EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L12EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L12EP.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L12EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void L1GROOVE_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_groove.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L1GROOVE.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (L1GROOVE.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L2FR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_fr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L2FR.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L2FR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L2HR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_hr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L2HR.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L2HR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L2CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L2CH.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (L2CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L22CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L22CH.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (L22CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L2EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L2EP.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (L2EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L22EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L22EP.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (L22EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L2KM_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_km.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (L2KM.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (L2KM.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void L2GROOVE_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_groove.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (L2GROOVE.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (L2GROOVE.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W1FR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_fr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (W1FR.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W1FR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W1HR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_hr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W1HR.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W1HR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W1CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W1CH.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W1CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void W12CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W12CH.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W12CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W1EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W1EP.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W1EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W12EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W12EP.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W12EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W1KM_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_km.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W1KM.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W1KM.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void HALFDP_CheckedChanged(object sender, EventArgs e)
        {
            Double txt_2epval = Convert.ToDouble(txt_2ep.Text);
            if (HALFDP.Checked)
            {

                CALCULATED = CALCULATED + txt_2epval;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (HALFDP.Checked == false)
            {
                CALCULATED = CALCULATED - txt_2epval;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void FULLDP_CheckedChanged(object sender, EventArgs e)
        {
            Double txt_fulldpval = Convert.ToDouble(txt_fulldp.Text);

            if (FULLDP.Checked)
            {
                CALCULATED = CALCULATED + txt_fulldpval;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (FULLDP.Checked == false)
            {
                CALCULATED = CALCULATED - txt_fulldpval;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W1RDP_CheckedChanged(object sender, EventArgs e)
        {
            //  Double val1 = Convert.ToDouble(txt_rvertical.Text);
            //  Double val2 =  Convert.ToInt32(lengthProduct_tB.Text);
            //  Double val3 = val1 * (val2 / 12);
            //
            //
            //  if (W1RDP.Checked)
            //  {
            //
            //      CALCULATED = CALCULATED + val3;
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
            //Double val1 = Convert.ToDouble(txt_lvertical.Text);
            //Double val2 =  Convert.ToInt32(lengthProduct_tB.Text);
            //Double val3 = val1 * (val2 / 12);
            //
            //
            //if (W1LDP.Checked)
            //{
            //
            //    CALCULATED = CALCULATED + val3;
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
            Double val1 = Convert.ToDouble(txt_fr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W2FR.Checked)
            {

                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();

            }
            else if (W2FR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else
            {

            }
        }

        private void W2HR_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_hr.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W2HR.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W2HR.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void W2CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);


            if (W2CH.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W2CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void W22CH_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ch.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (W22CH.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W22CH.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void W2EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (W2EP.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W2EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void W22EP_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_2ep.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (W22EP.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W22EP.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        private void W2KM_CheckedChanged(object sender, EventArgs e)
        {
            Double val1 = Convert.ToDouble(txt_km.Text);
            Double val2 = Convert.ToInt32(lengthProduct_tB.Text);
            Double val3 = val1 * (val2 / 12);

            if (W2KM.Checked)
            {
                CALCULATED = CALCULATED + val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else if (W2KM.Checked == false)
            {
                CALCULATED = CALCULATED - val3;
                totalServiceSidesCharges_tB.Text = CALCULATED.ToString();
            }
            else { }
        }

        #endregion 

        #region Sides Service

        private void addSidesService_btn_Click(object sender, EventArgs e)
        {
            selectSide_Service();
        }

        private void sidesServicePnlClose_btn_Click(object sender, EventArgs e)
        {
            this.selectedProductList_Pnl.Location = new System.Drawing.Point(7, 14);
            this.selectedProductList_Pnl.Size = new System.Drawing.Size(700, 380);
            this.sides_ServiceScrollPnl.Location = new System.Drawing.Point(7, 7);
            this.sides_ServiceScrollPnl.Size = new System.Drawing.Size(10, 10);
        }

        private void selectService_btn_Click(object sender, EventArgs e)
        {
            this.sides_ServiceScrollPnl.Location = new System.Drawing.Point(7, 14);
            this.sides_ServiceScrollPnl.Size = new System.Drawing.Size(700, 380);
            this.selectedProductList_Pnl.Location = new System.Drawing.Point(695, 7);
            this.selectedProductList_Pnl.Size = new System.Drawing.Size(10, 10);
        }

        #endregion

        private void selectProduct_btn_Click(object sender, EventArgs e)
        {
            // Check if all required textboxes are filled
            if (string.IsNullOrWhiteSpace(catogeryProduct_tB.Text) ||
                string.IsNullOrWhiteSpace(resultProduct_tB.Text) ||
                string.IsNullOrWhiteSpace(hsnNo_tB.Text) ||
                string.IsNullOrWhiteSpace(rateProduct_tB.Text) ||
                string.IsNullOrWhiteSpace(lengthProduct_tB.Text) ||
                string.IsNullOrWhiteSpace(widthProduct_tB.Text) ||
                string.IsNullOrWhiteSpace(quantity_tB.Text))
            {
                MessageBox.Show("Please enter all the required information.");
                return;
            }

            // Parse the product details from the textboxes
            string subcategoryName = catogeryProduct_tB.Text;
            string productName = resultProduct_tB.Text;
            string hsnNo = hsnNo_tB.Text;
            decimal productPrice, moldingPrice, lengthProduct, widthProduct, productTotal;
            int productQuantity;
            if (!decimal.TryParse(rateProduct_tB.Text, out productPrice) ||
                !decimal.TryParse(totalServiceSidesCharges_tB.Text, out moldingPrice) ||
                !decimal.TryParse(lengthProduct_tB.Text, out lengthProduct) ||
                !decimal.TryParse(widthProduct_tB.Text, out widthProduct) ||
                !int.TryParse(quantity_tB.Text, out productQuantity))
            {
                MessageBox.Show("Invalid input in one or more fields.");
                return;
            }

            // Calculate product total
            productTotal = productPrice * productQuantity;
            totalServiceCharges_tB.Text = productTotal.ToString();

            // Add product to gridview
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(selectedProductList_dGV);
            newRow.Cells[0].Value = subcategoryName;
            newRow.Cells[1].Value = productName;
            newRow.Cells[2].Value = productPrice;
            newRow.Cells[3].Value = hsnNo;
            newRow.Cells[4].Value = moldingPrice;
            newRow.Cells[5].Value = lengthProduct;
            newRow.Cells[6].Value = widthProduct;
            newRow.Cells[7].Value = productQuantity;
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = productTotal });
            selectedProductList_dGV.Rows.Add(newRow);

            // Calculate invoice total and display it
            decimal invoiceTotal = 0;
            foreach (DataGridViewRow invoiceRow in selectedProductList_dGV.Rows)
            {
                decimal productTotalAmount = Convert.ToDecimal(invoiceRow.Cells[8].Value);
                invoiceTotal += productTotalAmount;
            }
            grandTotal_tB.Text = invoiceTotal.ToString("C");

            // Clear the product details textboxes.
            catogeryProduct_tB.Clear();
            resultProduct_tB.Clear();
            hsnNo_tB.Clear();
            rateProduct_tB.Clear();
            lengthProduct_tB.Clear();
            widthProduct_tB.Clear();
            quantity_tB.Clear();
            totalServiceSidesCharges_tB.Clear();
        }

        private void selectedProductList_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

