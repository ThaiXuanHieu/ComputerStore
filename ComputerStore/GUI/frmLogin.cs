using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace GUI
{
    public partial class frmLogin : Form
    {
        bool hidden;
        bool hidden1;
        public frmLogin()
        {
            InitializeComponent();
            hidden = true;
            hidden1 = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlSignup.Width = pnlSignup.Width + 10;
                if (pnlSignup.Width >= 395)
                {
                    Timer.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                pnlSignup.Width = pnlSignup.Width - 10;
                if (pnlSignup.Width <= 10)
                {
                    Timer.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void llbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer.Start();
        }

        private void llbBack1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start();
        }

        private void llbForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timer1.Start();
            btnGenNewPassword.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (hidden1)
            {
                pnlRight.Width = pnlRight.Width + 10;
                if (pnlRight.Width >= 280)
                {
                    Timer1.Stop();
                    hidden1 = false;
                    this.Refresh();
                }

            }
            else
            {
                pnlRight.Width = pnlRight.Width - 10;
                if (pnlRight.Width <= 10)
                {
                    Timer1.Stop();
                    hidden1 = true;
                    this.Refresh();
                }
            }
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DataTable dtUsers = UsersBLL.Instance.GetByUerNameAndPassword(txtUsername.Text, txtPassword.Text);
            if (dtUsers.Rows.Count != 0)
            {
                //string fullName = dtUsers.Rows[0].Field<string>("FullName");
                UsersDTO user = UsersBLL.Instance.GetUser(txtUsername.Text, txtPassword.Text);
                this.Hide();
                frmAdmin admin = new frmAdmin(user);
                admin.ShowDialog();

            }
            else
            {
                MessageBox.Show("TÀI KHOẢN NÀY KHÔNG TỒN TẠI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUsernameNew.Text) || String.IsNullOrEmpty(txtPasswordNew.Text) || String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("BẠN PHẢI NHẬP ĐẨY ĐỦ THÔNG TIN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable dtUser = UsersBLL.Instance.GetUserByUserName(txtUsernameNew.Text);
            if (dtUser.Rows.Count != 0)
            {
                MessageBox.Show("TÀI KHOẢN NÀY ĐÃ TỒN TÀI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!txtPasswordNew.Text.Equals(txtReEnterPassword.Text))
            {
                MessageBox.Show("MẬT KHẨU KHÔNG KHỚP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UsersBLL.Instance.Insert(txtFullName.Text, txtUsernameNew.Text, txtPasswordNew.Text);
            MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("BẠN CHẮC CHẮN ĐÓNG ỨNG DỤNG KHÔNG?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Application.ExitThread();
        }

        private void btnGenNewPassword_Click(object sender, EventArgs e)
        {
            if(!EmailValidation.IsValid(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dtUsers = UsersBLL.Instance.GetByEmail(txtEmail.Text);
            if(dtUsers.Rows.Count != 0)// Nếu tồn tại bản ghi
            {
                // Phát sinh ngẫu nhiên mật khẩu mới
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                lblNewPassword.Text = new String(stringChars);
                // Không cho phép tạo mật khẩu mới nhiều lần
                btnGenNewPassword.Enabled = false;

                // Cập nhật lại mật khẩu cho người dùng
                int userID = dtUsers.Rows[0].Field<int>("UserID");
                UsersBLL.Instance.UpdatePassword(userID, lblNewPassword.Text);
                
            }
            else
            {
                MessageBox.Show("EMAIL NÀY KHÔNG TỒN TẠI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
