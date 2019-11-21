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
using Common;

namespace GUI
{
    public partial class UsersManagementPage : UserControl
    {
        bool hidden;
        bool isNew = false;
        string imageLocation = "";


        public UsersManagementPage()
        {
            InitializeComponent();
            hidden = true;
        }

        private void UsersManagementPage_Load(object sender, EventArgs e)
        {
            DisplayData();
            isEnabled(false);
        }

        private void DisplayData()
        {
            dgvListUser.DataSource = UsersBLL.Instance.GetAll();
        }

        private void isEnabled(bool enabled)
        {
            txtFullName.Enabled = enabled;
            txtUserName.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtPhone.Enabled = enabled;
            txtEmail.Enabled = enabled;

            btnAddUser.Enabled = !enabled;
            btnEditUser.Enabled = !enabled;
            btnDeleteUser.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnChangeImage.Enabled = enabled;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = true;

            txtFullName.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            picAvatar.ImageLocation = "";
            txtFullName.Focus();
        }
        // Kiểm tra rd nào được Check
        private string IsChecked()
        {
            if (rdMale.Checked)
                return "Nam";
            else if (rdFemale.Checked)
                return "Nữ";
            else
                return "Khác";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên cho người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cho tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!PhoneNumberValidation.IsValid(txtPhone.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (picAvatar.ImageLocation == "")
            {
                MessageBox.Show("Vui lòng chọn ảnh cho người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(isNew == true)   // Nếu nhấn nút Thêm
            {
                DataTable dtUser = UsersBLL.Instance.GetUserByUserName(txtUserName.Text);
                if (dtUser.Rows.Count != 0)
                {
                    MessageBox.Show("Tài khoản này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                UsersBLL.Instance.Insert(txtFullName.Text, txtUserName.Text, Encryption.MD5Hash(txtPassword.Text), IsChecked(), txtEmail.Text, txtPhone.Text, imageLocation);
            }
            else // Nếu nhấn nút Sửa
            {
                txtPassword.Enabled = false;
                int row = dgvListUser.CurrentRow.Index;
                int userID = Convert.ToInt32(dgvListUser.Rows[row].Cells[0].Value.ToString());
                UsersBLL.Instance.UpdateProfile(userID, txtFullName.Text, txtUserName.Text, IsChecked(), txtEmail.Text, txtPhone.Text, imageLocation);
            }

            DisplayData();
            isEnabled(false);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            isEnabled(true);
            isNew = false;
            txtFullName.Focus();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Chắc chắn xóa người dùng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == System.Windows.Forms.DialogResult.No) return;

            int row = dgvListUser.CurrentRow.Index;
            int userID = Convert.ToInt32(dgvListUser.Rows[row].Cells[0].Value.ToString());
            UsersBLL.Instance.DeleteByUserID(userID);

            DisplayData();
        }

        
        private void btnSearchUser_Click(object sender, EventArgs e)
        {

        }

        private void dgvListUser_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtFullName.Text = dgvListUser.Rows[row].Cells[1].Value.ToString();
            txtUserName.Text = dgvListUser.Rows[row].Cells[2].Value.ToString();
            txtPassword.Text = dgvListUser.Rows[row].Cells[3].Value.ToString();

            switch (dgvListUser.Rows[row].Cells[4].Value.ToString())
            {
                case "Nam":
                    rdMale.Checked = true;
                    break;
                case "Nữ":
                    rdFemale.Checked = true;
                    break;
                default:
                    rdOrther.Checked = true;
                    break;
            }
            txtEmail.Text = dgvListUser.Rows[row].Cells[5].Value.ToString();
            txtPhone.Text = dgvListUser.Rows[row].Cells[6].Value.ToString();
            picAvatar.ImageLocation = dgvListUser.Rows[row].Cells[7].Value.ToString();
        }

        private void btnChangeImage_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."; ;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picAvatar.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi! Không thể tải ảnh lên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void llbRoleManagement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlRoleManagement.Width += 10;
                if (pnlRoleManagement.Width >= 1020)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlRoleManagement.Width -= 10;
                if (pnlRoleManagement.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        
    }
}
