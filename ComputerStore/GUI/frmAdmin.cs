using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        public frmAdmin(string _fullName)
        {
            
            InitializeComponent();
            lblNameUser.Text = _fullName;
            ordersManagementPage.Visible = true;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnCreateOrdersPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = true;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnProductManagementPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = false;
            productManagementPage.Visible = true;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnCategoryManagementPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = true;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnWarehouseManagementPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = false;
            warehouseManagementPage.Visible = true;
            categoryManagementPage.Visible = false;
            productManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnCustomerManagementPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = false;
            customerManagementPage.Visible = true;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void btnSupplierManagementPage_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = true;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;
        }

        

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
