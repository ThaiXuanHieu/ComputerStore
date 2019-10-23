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
    public partial class ProductManagementPage : UserControl
    {
        public ProductManagementPage()
        {
            InitializeComponent();
            DisplayData();
        }

        public void DisplayData()
        {
            dgvProducts.DataSource = ProductsBLL.Instance.Select();
            
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            txtProductName.Text = "";
            txtPrice.Text = "";
            txtUnit.Text = "";
            picImageProduct.Image = null;
            txtProductName.Focus();

            // Load data ComboBox Categories
            List<CategoriesDTO> categories = new List<CategoriesDTO>();
            DataTable dataTableCategories = CategoriesBLL.Instance.Select();
            foreach (DataRow dataRow in dataTableCategories.Rows)
            {
                CategoriesDTO category = new CategoriesDTO();
                category.CategoryID = Int32.Parse(dataRow["CategoryID"].ToString());
                category.CategoryName = dataRow["CategoryName"].ToString();
                category.Description = dataRow["Description"].ToString();

                categories.Add(category);
            }
            cbCategories.DataSource = categories;
            cbCategories.DisplayMember = "CategoryName";

            // Load data ComboBox Supplier

            List<SuppliersDTO> suppliers = new List<SuppliersDTO>();
            DataTable dataTableSuppliers = SuppliersBLL.Instance.Select();
            foreach(DataRow dataRow in dataTableSuppliers.Rows)
            {
                SuppliersDTO supplier = new SuppliersDTO();
                supplier.SupplierID = Int32.Parse(dataRow["SupplierID"].ToString());
                supplier.CompanyName = dataRow["CompanyName"].ToString();
                supplier.ContactName = dataRow["ContactName"].ToString();
                supplier.Address = dataRow["Address"].ToString();
                supplier.Phone = dataRow["Phone"].ToString();
                supplier.Email = dataRow["Email"].ToString();

                suppliers.Add(supplier);
            }
            cbSupplier.DataSource = suppliers;
            cbSupplier.DisplayMember = "CompanyName";


        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
