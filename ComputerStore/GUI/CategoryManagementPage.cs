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
    public partial class CategoryManagementPage : UserControl
    {
        private bool isNew = false;

        public CategoryManagementPage()
        {
            InitializeComponent();
        }

        private void CategoryManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            isEnabled(false);
        }

        public void DisplayData()
        {
            // Load Data
            dgvCategories.DataSource = CategoriesBLL.Instance.GetAll();
        }

        private void isEnabled(bool enabled)
        {
            // Có hay Không cho phép nhập
            txtCategoryName.Enabled = enabled;
            txtDescription.Enabled = enabled;

            // Có hay Không cho phép nhấn
            btnAddCategory.Enabled = !enabled;
            btnDeleteCategory.Enabled = !enabled;
            btnEditCategory.Enabled = !enabled;
            btnSave.Enabled = enabled;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtCategoryName.Clear();
            txtDescription.Clear();
            txtCategoryName.Focus();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            txtCategoryName.Focus();
            isNew = false;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Delete
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa danh mục đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvCategories.CurrentRow.Index;
            int productID = Convert.ToInt32(dgvCategories.Rows[row].Cells[0].Value.ToString());
            CategoriesBLL.Instance.DeleteByCategoryID(Convert.ToInt32(productID));

            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNew == true)
            {
                if (txtCategoryName.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên cho danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CategoriesBLL.Instance.Insert(txtCategoryName.Text, txtDescription.Text);
            }
            else
            {
                int row = dgvCategories.CurrentRow.Index;
                int categoryID = Convert.ToInt32(dgvCategories.Rows[row].Cells[0].Value.ToString());
                CategoriesBLL.Instance.Update(categoryID, txtCategoryName.Text, txtDescription.Text);
            }


            DisplayData();
            isEnabled(false);
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            // Select with SearchString
            dgvCategories.DataSource = CategoriesBLL.Instance.GetCategoryBySearchString(txtSearchCategory.Text);
        }

        private void dgvCategories_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            txtCategoryName.Text = dgvCategories.Rows[row].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[row].Cells[2].Value.ToString();
        }
    }
}
