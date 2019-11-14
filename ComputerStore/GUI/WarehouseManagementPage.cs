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
using DTO;

namespace GUI
{
    public partial class WarehouseManagementPage : UserControl
    {
        private bool hidden;
        private bool isNew = false;

        ReceiptsDTO receipts;

        public WarehouseManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        private void WarehouseManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnPay.Enabled = false;
            btnPrinter.Enabled = false;
            isEnabled(false);
        }

        public void DisplayData()
        {
            // Load Data
            dgvListProductInventory.DataSource = WarehouseBLL.Instance.GetAll();

            // Load Data to cbProducts
            DataTable dtProducts = ProductsBLL.Instance.GetAll();
            cbProducts.DataSource = dtProducts;
            cbProducts.DisplayMember = "ProductName";
            cbProducts.ValueMember = "ProductID";

            // Load Data to cbProducts
            DataTable dtSuppliers = SuppliersBLL.Instance.GetAll();
            cbCompanyName.DataSource = dtSuppliers;
            cbCompanyName.DisplayMember = "CompanyName";
            cbCompanyName.ValueMember = "SupplierID";
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

        

        private void llbListReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnCreateReceipts_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;
            btnPay.Enabled = true;
            btnPrinter.Enabled = true;
            lblAmount.Text = "";

            ReceiptsBLL.Instance.Insert(0, DateTime.Now, 0);
            receipts = ReceiptsBLL.Instance.GetFirstReceipts();

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(isNew == true)
            {
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // 
                int productID = Convert.ToInt32(cbProducts.SelectedValue.ToString());
                double amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                // Insert
                ReceiptDetailsBLL.Instance.Insert(receipts.ReceiptID, productID, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                // Display
                dgvReceiptDetails.DataSource = ReceiptDetailsBLL.Instance.GetByReceiptID(receipts.ReceiptID);
            }
            else
            {
                int row = dgvReceiptDetails.CurrentRow.Index;
                int receiptID = Convert.ToInt32(dgvReceiptDetails.Rows[row].Cells[0].Value.ToString());
                int productID = Convert.ToInt32(dgvReceiptDetails.Rows[row].Cells[1].Value.ToString());
                double amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                // Update By ProductID
                ReceiptDetailsBLL.Instance.Update(productID, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                // Display
                dgvReceiptDetails.DataSource = ReceiptDetailsBLL.Instance.GetByReceiptID(receiptID);
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void dgvReceiptDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbProducts.SelectedValue = dgvReceiptDetails.Rows[row].Cells[1].Value.ToString();
            txtQuantity.Text = dgvReceiptDetails.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvReceiptDetails.Rows[row].Cells[3].Value.ToString();
        }
    }
}
