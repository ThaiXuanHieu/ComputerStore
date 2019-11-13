using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class WarehouseManagementPage : UserControl
    {
        private bool hidden;

        private bool isNew = false;

        public WarehouseManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        public void DisplayData()
        {
            // Load Data
            //dgvListProductInventory.DataSource = WarehouseBLL.Instance.GetAll();

            // Load Data to cbProducts

            DataTable dtProducts = ProductsBLL.Instance.GetAll();
            cbProducts.DataSource = dtProducts;
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            cbProducts.Enabled = enabled;
            txtQuantity.Enabled = enabled;
            txtPrice.Enabled = enabled;

            // Có hay Không cho phép nhấn
            btnAddOrder.Enabled = !enabled;
            btnDeleteOrder.Enabled = !enabled;
            btnEditOrder.Enabled = !enabled;
            btnSave.Enabled = enabled;

        }

        private void btnCreateReceipts_Click(object sender, EventArgs e)
        {

        }

        private void llbListReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
