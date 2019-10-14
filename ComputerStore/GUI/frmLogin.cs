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
        public frmLogin()
        {
            InitializeComponent();
            hidden = true;
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

        private void btnSignin_Click(object sender, EventArgs e)
        {
            UsersDTO user =  UsersBLL.Instance.Select(txtUsername.Text, txtPassword.Text);
            if (user.UserName.Equals("admin") && user.Password.Equals("123456"))
            {
                frmAdmin admin = new frmAdmin(user.FullName);
                admin.Show();
            }
            else if(user.UserName.Equals(txtUsername.Text) && user.Password.Equals(txtPassword.Text))
            {
                frmCustomer customer = new frmCustomer(user.FullName);
                customer.Show();
            }
            else if(user == null)
            {
                MessageBox.Show("Tài khoản này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPasswordNew.Text.Equals(txtReEnterPassword.Text))
            {
                UsersBLL.Instance.Insert(txtFullName.Text, txtUsernameNew.Text, txtPasswordNew.Text);
                MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ĐĂNG KÝ KHÔNG THÀNH CÔNG\nMẬT KHẨU XÁC THỰC PHẢI KHỚP VỚI MẬT KHẨU", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
