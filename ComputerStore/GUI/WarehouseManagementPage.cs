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

        ReceiptsDTO receipts = new ReceiptsDTO();

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
            btnAddOrder.Enabled = false;
            btnDeleteOrder.Enabled = false;
            btnEditOrder.Enabled = false;
            btnSave.Enabled = false;
            cbProducts.Enabled = false;
            txtPrice.Enabled = false;
            txtQuantity.Enabled = false;
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

            // Load Data to cbSuppliers
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

        // Chuyện gì sẽ xảy ra khi value của Combobox được thay đổi
        private void cbCompanyName_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbCompanyName.SelectedValue != null)
            {
                //dgvListProductInventory.DataSource = WarehouseBLL.Instance.GetBySupplierID(Convert.ToInt32(cbCompanyName.SelectedValue.ToString()));
            }
        }

        // Chuyện gì sẽ xảy ra khi Button Tạo phiếu nhập được click
        private void btnCreateReceipts_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;
            btnPay.Enabled = true;
            btnPrinter.Enabled = true;
            lblAmount.Text = "";

            // Tạo một bản ghi cho bảng Phiếu nhập
            ReceiptsBLL.Instance.Insert(0, DateTime.Now, 0);
            receipts = ReceiptsBLL.Instance.GetFirstReceipts();// Lấy ra bản ghi vừa tạo

        }
        // Thêm mới bản ghi
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;
            txtQuantity.Clear();
            txtPrice.Clear();
        }
        // Sửa bản ghi
        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }
        // Xóa bản ghi
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {

        }
        // Lưu bản ghi
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Nếu Button Add Clicked
            if (isNew == true)
            {
                // 
                int productID = Convert.ToInt32(cbProducts.SelectedValue.ToString());
                double amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                // Insert to Chi tiết phiếu nhập
                ReceiptDetailsBLL.Instance.Insert(receipts.ReceiptID, productID, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                // Display
                dgvReceiptDetails.DataSource = ReceiptDetailsBLL.Instance.GetByReceiptID(receipts.ReceiptID);
            }
            // Nếu Button Edit Clicked
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
            dgvListProductInventory.DataSource = WarehouseBLL.Instance.GetProductBySearchString(txtSearchProduct.Text);
        }

        private void dgvReceiptDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbProducts.SelectedValue = dgvReceiptDetails.Rows[row].Cells[1].Value.ToString();
            txtQuantity.Text = dgvReceiptDetails.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvReceiptDetails.Rows[row].Cells[3].Value.ToString();
        }

        // Chuyện gì sẽ xảy ra khi LinkLable Xem danh sách phiếu nhập được click
        private void llbListReceipt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }
        // Chuyện gì sẽ xảy ra khi LinkLable Trở về được click
        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlListReceipt.Width = pnlListReceipt.Width + 10;
                if (pnlListReceipt.Width >= 1020)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlListReceipt.Width = pnlListReceipt.Width - 10;
                if (pnlListReceipt.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        
    }
}
