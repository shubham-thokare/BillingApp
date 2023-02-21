using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BillingApp
{
    public partial class addcompany_form : Form
    {
        private string connectionString;

        public addcompany_form()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            loadCompany_Table();
            Clear();
        }

       

        private void loadCompany_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // SqlCommand command = new SqlCommand("Select tbl_Product.product_Name AS Product_Name, tbl_SubCategory.subCategory_Name AS SubCategory_Name, tbl_SubCategory.pricePer_Unit AS PricePer_Unit, tbl_SubCategory.hsn_No AS HSN_No FROM tbl_SubCategory INNER JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.Product_Id", conn);
                SqlCommand command = new SqlCommand("SELECT customer_Name, site_Name ,contact_Person, contact_No, gst_No, pan_No, site_Address  FROM tbl_CompanyDetails", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                company_dGV.DataSource = dataTable;
            }
        }

        private void Clear()
        {
            customerName_tB.Text = "";
            siteName_tB.Text = "";
            contactPerson_tB.Text = "";
            contactNo_tB.Text = "";
            gstNo_tB.Text = "";
            panNo_tB.Text = "";
            siteAddress_tB.Text = "";
        }

        private void searchCustomer_pB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(searchCustomer_tB.Text))
                {
                    conn.Open();
                    //SqlCommand command = new SqlCommand("SELECT p.product_Name AS Product_Name, s.subCategory_Name AS SubCategory_Name,s.pricePer_Unit AS PricePer_Unit, s.hsn_No AS HSN_No FROM tbl_SubCategory s INNER JOIN tbl_Product p ON s.fk_Product_Id = p.Product_Id WHERE s.subCategory_Name LIKE '%@searchWord%' OR s.hsn_No LIKE '%@searchWord%' OR p.product_Name LIKE '%@searchWord%';", conn);
                    SqlCommand command = new SqlCommand("SELECT customer_Name, site_Name ,contact_Person, contact_No, gst_No, pan_No, site_Address  FROM tbl_CompanyDetails WHERE customer_Name LIKE '%' + @searchWord + '%' OR gst_No LIKE '%' + @searchWord + '%' OR pan_No LIKE '%' + @searchWord + '%';", conn);
                    command.Parameters.AddWithValue("@searchWord", searchCustomer_tB.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    company_dGV.DataSource = dataTable;
                }
                else
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT customer_Name, site_Name ,contact_Person, contact_No, gst_No, pan_No, site_Address  FROM tbl_CompanyDetails", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    company_dGV.DataSource = dataTable;

                }
            }
        }

        private void InsertCategory_btn_Click(object sender, EventArgs e)
        {
            if (
               !string.IsNullOrEmpty(customerName_tB.Text) &&
               !string.IsNullOrEmpty(siteName_tB.Text) &&
               !string.IsNullOrEmpty(contactPerson_tB.Text) &&
               !string.IsNullOrEmpty(contactNo_tB.Text) &&
               !string.IsNullOrEmpty(gstNo_tB.Text) &&
               !string.IsNullOrEmpty(panNo_tB.Text) &&
               !string.IsNullOrEmpty(siteAddress_tB.Text) 
                )
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbl_CompanyDetails(customer_Name, site_Name, contact_Person, contact_No, gst_No, pan_No, site_Address) VALUES(@customerName, @siteName, @contactPerson, @contactNo, @gstNo, @panNo, @siteAddress)", conn);
                        cmd.Parameters.AddWithValue("@customerName", customerName_tB.Text);
                        cmd.Parameters.AddWithValue("@siteName", siteName_tB.Text);
                        cmd.Parameters.AddWithValue("@contactPerson", contactPerson_tB.Text);
                        cmd.Parameters.AddWithValue("@contactNo", contactNo_tB.Text);
                        cmd.Parameters.AddWithValue("@gstNo", gstNo_tB.Text);
                        cmd.Parameters.AddWithValue("@panNo", panNo_tB.Text);
                        cmd.Parameters.AddWithValue("@siteAddress", siteAddress_tB.Text);
                  
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Data Inserted Successfully.");
                    Clear();
                }
            }
        }

        private void ClearCategory_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void UpdateCategory_btn_Click(object sender, EventArgs e)
       {
           if (
               !string.IsNullOrEmpty(customerName_tB.Text) &&
               !string.IsNullOrEmpty(siteName_tB.Text) &&
               !string.IsNullOrEmpty(contactPerson_tB.Text) &&
               !string.IsNullOrEmpty(contactNo_tB.Text) &&
               !string.IsNullOrEmpty(gstNo_tB.Text) &&
               !string.IsNullOrEmpty(panNo_tB.Text) &&
               !string.IsNullOrEmpty(siteAddress_tB.Text) 
              )
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                   SqlCommand cmd = new SqlCommand(" UPDATE tbl_CompanyDetails SET customer_Name = @customerName, site_Name = @siteName, contact_Person = @contactPerson, contact_No = @contactNo, gst_No = @gstNo, pan_No = @panNo, site_Address = @siteAddress WHERE  company_Id = @company_Id", conn);
                    cmd.Parameters.AddWithValue("@customerName", customerName_tB.Text);
                    cmd.Parameters.AddWithValue("@siteName", siteName_tB.Text);
                    cmd.Parameters.AddWithValue("@contactPerson", contactPerson_tB.Text);
                    cmd.Parameters.AddWithValue("@contactNo", contactNo_tB.Text);
                    cmd.Parameters.AddWithValue("@gstNo", gstNo_tB.Text);
                    cmd.Parameters.AddWithValue("@panNo", panNo_tB.Text);
                    cmd.Parameters.AddWithValue("@siteAddress", siteAddress_tB.Text);

                    // set the value of company_Id variable
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();                   
                    conn.Close();
                }

                catch (Exception ex)
                {

                }

                finally
                {
                    MessageBox.Show("Data Updated Successfully.");
                   
                    Clear();
                }
            }
        }


        private void DeleteCategory_btn_Click(object sender, EventArgs e)
        {

        }

        private void product_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

              
       
    }
}
