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

        CustomersDTO customer;
        OrdersDTO orders;

        double amount;
        double totalAmount = 0;

        public OrdersManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        private void OrdersManagementPage_Load(object sender, EventArgs e)
        {
            //DisplayData();
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            btnPay.Enabled = false;
            btnPrinter.Enabled = false;
            isEnabled(false);
        }

        public void DisplayData()
        {
            // Load Data
            //dgvProducts.DataSource = ProductsBLL.Instance.GetColumn();   
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            txtProductName.Enabled = enabled;
            txtProductID.Enabled = enabled;
            txtQuantity.Enabled = enabled;
            txtPrice.Enabled = enabled;
            txtUnit.Enabled = enabled;
            


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
            //CustomersBLL.Instance.Insert("", "", "", "", "");
            //customer = CustomersBLL.Instance.GetFirstCustomer();
            //OrdersBLL.Instance.Insert(customer.CustomerID, DateTime.Now, 0);
            //orders = OrdersBLL.Instance.GetFirstOrders();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            txtLastName.Enabled = true;
            txtFirstName.Enabled = true;

            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đầy đủ họ tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đầy đủ họ tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for(var row = 0; row < dgvOrderDetails.Rows.Count - 1; row++)
            {
                totalAmount += Convert.ToDouble(dgvOrderDetails.Rows[row].Cells["Amount"].Value.ToString());
            }
            lblAmount.Text = totalAmount.ToString();

            //OrdersBLL.Instance.Update(customer.CustomerID, orders.OrderID, DateTime.Now, Convert.ToDouble(lblAmount.Text));
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbListOrders_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
            ///dgvListOrders.DataSource = OrdersBLL.Instance.GetAll();
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

            txtProductName.Clear();
            txtProductID.Clear();
            txtQuantity.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtProductName.Focus();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            txtProductName.Focus();
            isNew = false;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            // Delete với id
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa ... đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvOrderDetails.CurrentRow.Index;
            int orderID = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells[0].Value.ToString());
            //OrderDetailsBLL.Instance.DeleteByOrderID(orderID);

            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thêm mới
            if (isNew == true)
            {
                if (txtProductName.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtQuantity.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtPrice.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập giá sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                //OrderDetailsBLL.Instance.Insert(orders.OrderID, Convert.ToInt32(txtProductID.Text), Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                //dgvOrderDetails.DataSource = OrderDetailsBLL.Instance.GetByOrderID(orders.OrderID);
            }
            else
            {
                // Sửa và lưu
                int row = dgvOrderDetails.CurrentRow.Index;
                int orderID = Convert.ToInt32(dgvOrderDetails.Rows[row].Cells[0].Value.ToString());
                int productID = Convert.ToInt32(txtProductID.Text);
                amount = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtQuantity.Text);
                //OrderDetailsBLL.Instance.Update(orderID, productID, Convert.ToInt32(txtQuantity.Text), Convert.ToDouble(txtPrice.Text), amount);
                
            }


            DisplayData();
            isEnabled(false);
        }

        // Tìm kiếm sản phẩm
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            //dgvProducts.DataSource = ProductsBLL.Instance.GetColumnProductBySearchString(txtSearchProduct.Text);
        }

        private void dgvProducts_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtProductID.Text = dgvProducts.Rows[row].Cells[0].Value.ToString();
            txtProductName.Text = dgvProducts.Rows[row].Cells[1].Value.ToString();
            txtUnit.Text = dgvProducts.Rows[row].Cells[2].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[row].Cells[3].Value.ToString();
        }

        private void dgvOrderDetails_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtProductID.Text = dgvOrderDetails.Rows[row].Cells[1].Value.ToString();
            txtQuantity.Text = dgvOrderDetails.Rows[row].Cells[2].Value.ToString();
        }

        private void btnAddOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
