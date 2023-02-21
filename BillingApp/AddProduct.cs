using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class addproduct_form : Form
    {
        private string connectionString;


        Int32 product_id;
        string product_name = "";
        Int32 subcategory_id;
        string subcategory_name = "";
        Int32 fkproduct_id;

        public addproduct_form()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            loadProduct_Name();
            loadProduct_Table();
            productName_cB.Text = "";
        }

        private void loadProduct_Table()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

               // SqlCommand command = new SqlCommand("Select tbl_Product.product_Name AS Product_Name, tbl_SubCategory.subCategory_Name AS SubCategory_Name, tbl_SubCategory.pricePer_Unit AS PricePer_Unit, tbl_SubCategory.hsn_No AS HSN_No FROM tbl_SubCategory INNER JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.Product_Id", conn);
                SqlCommand command = new SqlCommand("SELECT tbl_SubCategory.subCategory_Name AS SubCategory_Name, tbl_Product.product_Name AS Product_Name,  tbl_SubCategory.pricePer_Unit AS PricePer_Unit, tbl_SubCategory.hsn_No AS HSN_No, tbl_Product.product_Id AS Product_Id, tbl_SubCategory.subCategory_Id AS SubCategory_Id FROM tbl_SubCategory INNER JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.Product_Id", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                product_dGV.DataSource = dataTable;
            }
        }

        private void search_Product_pB_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (!string.IsNullOrEmpty(searchProduct_tB.Text))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT s.subCategory_Name AS SubCategory_Name, p.product_Name AS Product_Name,  s.pricePer_Unit AS PricePer_Unit, s.hsn_No AS HSN_No, p.product_Id AS Product_Id, s.subCategory_Id AS SubCategory_Id FROM tbl_SubCategory s INNER JOIN tbl_Product p ON s.fk_Product_Id = p.Product_Id WHERE s.subCategory_Name LIKE '%' + @searchWord + '%' OR s.hsn_No LIKE '%' + @searchWord + '%' OR p.product_Name LIKE '%' + @searchWord + '%';", conn);
                    command.Parameters.AddWithValue("@searchWord", searchProduct_tB.Text); 
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    product_dGV.DataSource = dataTable;
                    searchProduct_tB.Text = "";
                }
                else
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT tbl_SubCategory.subCategory_Name AS SubCategory_Name, tbl_Product.product_Name AS Product_Name,  tbl_SubCategory.pricePer_Unit AS PricePer_Unit, tbl_SubCategory.hsn_No AS HSN_No, tbl_Product.product_Id AS Product_Id, tbl_SubCategory.subCategory_Id AS SubCategory_Id FROM tbl_SubCategory INNER JOIN tbl_Product ON tbl_SubCategory.fk_Product_Id = tbl_Product.Product_Id", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    product_dGV.DataSource = dataTable;
                
                }
            }

        }

        private void loadProduct_Name()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT product_name FROM tbl_Product", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    productName_cB.Items.Add(sdr.GetString(0));
                }
                sdr.Close();
            }
            
        }

        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(product_Name_tB.Text))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Product(product_name) VALUES(@ProductName)", conn);
                        cmd.Parameters.AddWithValue("@ProductName", product_Name_tB.Text);
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
                    product_Name_tB.Text = "";
                    loadProduct_Name();
                }
            }
        }

        private void productName_cB_SelectedIndexChanged(object sender, EventArgs e)
        {//product id 
            if (!string.IsNullOrEmpty(productName_cB.Text))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Select product_Id from tbl_Product where product_Name='" + productName_cB.Text + "'", conn);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            product_id = sdr.GetInt32(0);
                        }
                        sdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message);
                }
                finally
                {
                    
                }
            }
        }

        private void InsertCategory_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(subCategoryName_tB.Text) &&
                !string.IsNullOrEmpty(pricePerUnit_tB.Text) &&
                !string.IsNullOrEmpty(hsnNo_tB.Text))
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbl_SubCategory(subCategory_Name, pricePer_Unit, hsn_No, fk_Product_Id) VALUES ('" + subCategoryName_tB.Text + "','" + pricePerUnit_tB.Text + "','" + hsnNo_tB.Text + "','" + @product_id + "')", conn);

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
                    product_id = 0;
                }
            }
        }

        private void ClearCategory_btn_Click(object sender, EventArgs e)
        {
            clear();
        }
        
        private void product_dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the row index of the clicked cell
            int rowIndex = e.RowIndex;

            // Retrieve the data from the selected row
            DataGridViewRow row = product_dGV.Rows[rowIndex];
            subcategory_id = Convert.ToInt32(row.Cells["subCategory_Id"].Value);
            product_name = row.Cells["product_Name"].Value.ToString();
            string subCategoryName = row.Cells["subCategory_Name"].Value.ToString();
            string pricePerUnit = row.Cells["pricePer_Unit"].Value.ToString();
            string hsnNo = row.Cells["hsn_No"].Value.ToString();

            //product id set
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Select product_Id from tbl_Product where product_Name='" + @product_name + "'", conn);

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }                
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    product_id = sdr.GetInt32(0);
                }
            }
            //

            // Set the retrieved data to the appropriate controls

            subCategoryId_tB.Text = Convert.ToString(@subcategory_id);
            productName_cB.Text = @product_name;
            subCategoryName_tB.Text = @subCategoryName;
            pricePerUnit_tB.Text = @pricePerUnit;
            hsnNo_tB.Text = @hsnNo;                       
        }


      private void UpdateCategory_btn_Click(object sender, EventArgs e)
       {
           if (!string.IsNullOrEmpty(subCategoryName_tB.Text) &&
                !string.IsNullOrEmpty(pricePerUnit_tB.Text) &&
                !string.IsNullOrEmpty(hsnNo_tB.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE tbl_SubCategory SET subCategory_Name = @subCategoryName, pricePer_Unit = @pricePerUnit, hsn_no = @hsnNo, fk_Product_Id=@fkproduct_id WHERE subCategory_Id = @subcategory_id", conn);
                    cmd.Parameters.AddWithValue("@subcategory_id", subCategoryId_tB.Text);
                    cmd.Parameters.AddWithValue("@subCategoryName", hsnNo_tB.Text);
                    cmd.Parameters.AddWithValue("@pricePerUnit", pricePerUnit_tB.Text);
                    cmd.Parameters.AddWithValue("@fkproduct_id", product_id);
                    cmd.Parameters.AddWithValue("@hsnNo", hsnNo_tB.Text);

                    // set the value of subCategoryId variable
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
                    MessageBox.Show("Data Inserted Successfully.");
                    loadProduct_Table();
                    clear();
                }
            }
        }


      private void clear()
      {
          subCategoryId_tB.Text = "";
          productName_cB.Text = "";
          subCategoryName_tB.Text = "";
          hsnNo_tB.Text = "";
          pricePerUnit_tB.Text = "";
          hsnNo_tB.Text = "";
      }    
    }
}
