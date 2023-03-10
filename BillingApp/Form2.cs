using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerNameDataSet.tbl_CompanyDetails' table. You can move, or remove it, as needed.
            this.tbl_CompanyDetailsTableAdapter.Fill(this.customerNameDataSet.tbl_CompanyDetails);

        }
    }
}
