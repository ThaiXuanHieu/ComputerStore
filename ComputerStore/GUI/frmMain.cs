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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            homePage.Visible = true;
            softwarePage.Visible = false;
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            homePage.Visible = true;
            softwarePage.Visible = false;
        }

        private void btnSoftwarePage_Click(object sender, EventArgs e)
        {
            softwarePage.Visible = true;
            homePage.Visible = false;
        }
    }
}
