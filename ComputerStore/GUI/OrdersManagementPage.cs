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
    public partial class OrdersManagementPage : UserControl
    {
        private bool hidden;

        private bool isNew = false;

        CustomersDTO customer= new CustomersDTO();
        OrdersDTO orders = new OrdersDTO();

        double amount;
        double totalAmount = 0;

        public OrdersManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        private void OrdersManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            btnPay.Enabled = false;
            btnPrinter.Enabled = false;
            btnAddOrder.Enabled = false;
            btnEditOrder.Enabled = false;
            btnDeleteOrder.Enabled = false;
            btnSave.Enabled = false;
            cbProducts.Enabled = false;
            txtQuantity.Enabled = false;
            txtPrice.Enabled = false;
        }

        public void DisplayData()
        {
            // Load Data
            dgvProducts.DataSource = ProductsBLL.Instance.GetColumn();

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

        private void btnCreateOrders_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;
            btnPay.Enabled = true;
            btnPrinter.Enabled = true;
            lblAmount.Text = "";
            txtPhone.Clear();
            txtAddress.Clear();
            txtFullName.Clear();
            dgvOrderDetails.DataSource = null;
            CustomersBLL.Instance.Insert("", "", "", "", "");
            customer = CustomersBLL.Instance.GetFirstCustomer();
            OrdersBLL.Instance.Insert(customer.CustomerID, DateTime.Now, 0);
            orders = OrdersBLL.Instance.GetFirstOrders();
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbListOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
            dgvListOrders.DataSource = OrdersBLL.Instance.GetAll();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(hidden)
            {
                pnlListOrders.Width += 10;
                if(pnlListOrders.Width >= 1020)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlListOrders.Width -= 10;
                if(pnlListOrders.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

            isEnabled(true);
            isNew = true;

            txtQuantity.Clear();
            txtFullName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            cbProducts.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thêm mới
            if (isNew == true)
            {
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                OrderDetailsBLL.Instance.Insert(orders.OrderID, Convert.ToInt32(cbProducts.SelectedValue.ToString()), Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            }
            else
            {
                // Sửa và lưu
                int row = dgvOrderDetails.CurrentRow.Index;
                int productID = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells[1].Value.ToString());
                amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                // Update By ProductID
                OrderDetailsBLL.Instance.Update(productID, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            }

            DisplayData();
            
            isEnabled(false);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            txtFullName.Enabled = true;
            txtAddress.Enabled = true;

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtPhone.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Tách Họ và tên
            string[] strs = txtFullName.Text.Split(' ');
            string firstName = "";
            string lastName = strs[strs.Length - 1];
            for (int i = 0; i < strs.Length - 1; i++)
            {
                firstName += strs[i] + " ";
            }
            // Tính tổng tiền
            for (var row = 0; row < dgvOrderDetails.Rows.Count; row++)
            {
                totalAmount += Convert.ToDouble(dgvOrderDetails.Rows[row].Cells["Amount"].Value.ToString());
            }
            lblAmount.Text = totalAmount.ToString();
            // Cập nhật khách hàng
            CustomersBLL.Instance.Update(customer.CustomerID, firstName.Trim(), lastName.Trim(), txtAddress.Text, txtPhone.Text, "");
            // Cập nhật lại Hóa đơn
            OrdersBLL.Instance.Update(customer.CustomerID, orders.OrderID, DateTime.Now, Convert.ToDouble(lblAmount.Text));
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            cbProducts.Focus();
            isNew = false;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Delete với id
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa bản ghi đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvOrderDetails.CurrentRow.Index;
            int productID = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells[1].Value.ToString());
            OrderDetailsBLL.Instance.DeleteByProductID(productID);

            // Hiển thị dữ liệu
            dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            DisplayData();
        }

        // Tìm kiếm sản phẩm
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = ProductsBLL.Instance.GetColumnProductBySearchString(txtSearchProduct.Text);
        }

        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            cbProducts.SelectedValue = dgvProducts.Rows[row].Cells[0].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[row].Cells[3].Value.ToString();
        }

        private void dgvOrderDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            cbProducts.SelectedValue = dgvOrderDetails.Rows[row].Cells[1].Value.ToString();
            txtQuantity.Text = dgvOrderDetails.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvOrderDetails.Rows[row].Cells[3].Value.ToString();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa bản ghi đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;
            int orderID = Convert.ToInt32(dgvListOrders.SelectedCells[0].OwningRow.Cells["OrderID"].Value.ToString());
            OrdersBLL.Instance.DeleteByOrderID(orderID);

            dgvListOrders.DataSource = OrdersBLL.Instance.GetAll();
            DisplayData();
        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog  = new PrintDialog();
            printDialog.ShowDialog();
        }
    }
}
