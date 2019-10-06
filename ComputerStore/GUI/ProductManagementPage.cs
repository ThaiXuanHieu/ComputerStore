﻿using System;
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
    public partial class ProductManagementPage : UserControl
    {
        public ProductManagementPage()
        {
            InitializeComponent();
        }

        private void ProductManagementPage_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = ProductsBLL.Instance.Select();
        }
    }
}
