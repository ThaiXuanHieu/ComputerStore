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
            try
            {
                UsersDTO user = UsersBLL.Instance.Select(txtUsername.Text, txtPassword.Text);
                if (user.UserName.Equals("admin") && user.Password.Equals("123456"))
                {
                    frmAdmin admin = new frmAdmin(user.FullName);
                    admin.Show();
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
            try
            {
                UsersDTO user= UsersBLL.Instance.Select(txtUsernameNew.Text, txtPasswordNew.Text);
                if ((user.UserName.Equals(txtUsernameNew.Text) && user.Password.Equals(txtPasswordNew.Text)))
                {
                    MessageBox.Show("TÀI KHOẢN NÀY ĐÃ TỒN TÀI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                UsersBLL.Instance.Insert(txtFullName.Text, txtUsernameNew.Text, txtPasswordNew.Text);
                MessageBox.Show("ĐĂNG KÝ THÀNH CÔNG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
