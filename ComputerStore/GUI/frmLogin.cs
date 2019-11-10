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
            if(hidden)
            {
                pnlSignup.Width = pnlSignup.Width + 10;
                if(pnlSignup.Width >= 395)
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
            try
            {
                UsersDTO user = UsersBLL.Instance.GetByUerNameAndPassword(txtUsername.Text, txtPassword.Text);
                if (user.UserName.Equals("admin") && user.Password.Equals("123456"))
                {
                    frmAdmin admin = new frmAdmin(user.FullName);
                    admin.ShowDialog();
                    
                }
                else if (user.UserName.Equals(txtUsername.Text) && user.Password.Equals(txtPassword.Text))
                {
                    frmCustomer customer = new frmCustomer(user.FullName);
                    customer.Show();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("TÀI KHOẢN NÀY KHÔNG TỒN TẠI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    UsersDTO user= UsersBLL.Instance.GetByUerNameAndPassword(txtUsernameNew.Text, txtPasswordNew.Text);
            //    if ((user.UserName.Equals(txtUsernameNew.Text) && user.Password.Equals(txtPasswordNew.Text)))
            //    {
            //        MessageBox.Show("TÀI KHOẢN NÀY ĐÃ TỒN TÀI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception)
            //{
            //    UsersBLL.Instance.Insert(txtFullName.Text, txtUsernameNew.Text, txtPasswordNew.Text);
            //    MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            if(String.IsNullOrEmpty(txtUsernameNew.Text) || String.IsNullOrEmpty(txtPasswordNew.Text) || String.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("BẠN PHẢI NHẬP ĐẨY ĐỦ THÔNG TIN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(UsersBLL.Instance.GetUserByUserName(txtUsernameNew.Text) != null)
            {
                MessageBox.Show("TÀI KHOẢN NÀY ĐÃ TỒN TÀI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(!txtPassword.Text.Equals(txtReEnterPassword.Text))
            {
                MessageBox.Show("MẬT KHẨU KHÔNG KHỚP", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UsersBLL.Instance.Insert(txtFullName.Text, txtUsernameNew.Text, txtPasswordNew.Text);
            MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
