using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BillingApp
{
    public partial class mainPage_form : Form
    {
        public mainPage_form()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        #region TopBar

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

        #endregion        


    }
}
