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
    public partial class frmCustomer : Form
    {
        public frmCustomer(string _fullName)
        {
            InitializeComponent();
            lblNameCustomer.Text = _fullName;
            homePage.Visible = true;
            softwarePage.Visible = false;
            computerPage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            homePage.Visible = true;
            softwarePage.Visible = false;
            computerPage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnSoftwarePage_Click(object sender, EventArgs e)
        {
            softwarePage.Visible = true;
            homePage.Visible = false;
            computerPage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnComputerPage_Click(object sender, EventArgs e)
        {
            computerPage.Visible = true;
            softwarePage.Visible = false;
            homePage.Visible = false;
            laptopPage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;

        }

        private void btnLaptopPage_Click(object sender, EventArgs e)
        {
            laptopPage.Visible = true;
            computerPage.Visible = false;
            softwarePage.Visible = false;
            homePage.Visible = false;
            accessoriesPage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnAccessoriesPage_Click(object sender, EventArgs e)
        {
            accessoriesPage.Visible = true;
            laptopPage.Visible = false;
            computerPage.Visible = false;
            softwarePage.Visible = false;
            homePage.Visible = false;
            componentsPage.Visible = false;
        }

        private void btnComponentsPage_Click(object sender, EventArgs e)
        {
            componentsPage.Visible = true;
            accessoriesPage.Visible = false;
            laptopPage.Visible = false;
            computerPage.Visible = false;
            softwarePage.Visible = false;
            homePage.Visible = false;

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        

        
    }
}
