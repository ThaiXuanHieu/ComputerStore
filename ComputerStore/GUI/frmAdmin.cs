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
        private StatisticalPage statisticalPage;
        private UsersManagementPage usersManagementPage;

        public frmAdmin(string _fullName)
        {
            
            InitializeComponent();
            AddStatisticalUC();
            AddUsersManagementlUC();
            lblNameUser.Text = _fullName;

            ordersManagementPage.Visible = true;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            usersManagementPage.Visible = false;
            userPage.Visible = false;
        }
        // Thêm UserControl Thống kê
        public void AddStatisticalUC()
        {
            statisticalPage = new StatisticalPage()
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Visible = false
            };
            pnlWrap.Controls.Add(statisticalPage);
            Button btnStatisticalPage = new Button()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68))))),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                //FlatAppearance.BorderSize = 0,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(7, 443),
                Size = new System.Drawing.Size(223, 50),
                Text = "Thống kê",
                UseVisualStyleBackColor = false
            };

            pnlLeft.Controls.Add(btnStatisticalPage);
            btnStatisticalPage.Click += BtnStatisticalPage_Click;
        }
        // Thêm UserControl Quản lý người dùng
        public void AddUsersManagementlUC()
        {
            usersManagementPage = new UsersManagementPage()
            {
                Dock = System.Windows.Forms.DockStyle.Fill,
                Visible = false
            };
            pnlWrap.Controls.Add(usersManagementPage);
            Button btnUsersManagementPage = new Button()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68))))),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                //FlatAppearance.BorderSize = 0,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(7, 493),
                Size = new System.Drawing.Size(223, 50),
                Text = "Quản lý người dùng",
                UseVisualStyleBackColor = false
            };

            pnlLeft.Controls.Add(btnUsersManagementPage);
            btnUsersManagementPage.Click += BtnUsersManagementPage_Click;
        }

        private void BtnUsersManagementPage_Click(object sender, EventArgs e)
        {
            usersManagementPage.Visible = true;
            statisticalPage.Visible = false;
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;
        }

        private void BtnStatisticalPage_Click(object sender, EventArgs e)
        {
            usersManagementPage.Visible = false;
            statisticalPage.Visible = true;
            ordersManagementPage.Visible = false;
            supplierManagementPage.Visible = false;
            productManagementPage.Visible = false;
            categoryManagementPage.Visible = false;
            warehouseManagementPage.Visible = false;
            customerManagementPage.Visible = false;
            userPage.Visible = false;

        }

        private void btnCreateOrdersPage_Click(object sender, EventArgs e)
        {
            usersManagementPage.Visible = false;
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
            usersManagementPage.Visible = false;
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
            usersManagementPage.Visible = false;
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
            usersManagementPage.Visible = false;
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
            usersManagementPage.Visible = false;
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
            usersManagementPage.Visible = false;
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
            usersManagementPage.Visible = false;
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
