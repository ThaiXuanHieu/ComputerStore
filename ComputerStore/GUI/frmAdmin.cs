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
            //productManagementPage.Visible = true;
            //warehouseManagementPage.Visible = false;
            //customerManagementPage.Visible = false;
            //supplierManagementPage.Visible = false;
        }

        private void btnProductManagementPage_Click(object sender, EventArgs e)
        {
            //productManagementPage.Visible = true;
            //warehouseManagementPage.Visible = false;
            //customerManagementPage.Visible = false;
            //supplierManagementPage.Visible = false;
        }

        private void btnWarehouseManagementPage_Click(object sender, EventArgs e)
        {
            //warehouseManagementPage.Visible = true;
            //productManagementPage.Visible = false;
            //customerManagementPage.Visible = false;
            //supplierManagementPage.Visible = false;
        }

        private void btnCustomerManagementPage_Click(object sender, EventArgs e)
        {
            //customerManagementPage.Visible = true;
            //productManagementPage.Visible = false;
            //warehouseManagementPage.Visible = false;
            //supplierManagementPage.Visible = false;
        }

        private void btnSupplierManagementPage_Click(object sender, EventArgs e)
        {
            //supplierManagementPage.Visible = true;
            //productManagementPage.Visible = false;
            //warehouseManagementPage.Visible = false;
            //customerManagementPage.Visible = false;

        }
    }
}
