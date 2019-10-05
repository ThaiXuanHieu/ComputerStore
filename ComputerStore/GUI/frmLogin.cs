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
    }
}
