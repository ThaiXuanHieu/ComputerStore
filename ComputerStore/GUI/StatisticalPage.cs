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
    public partial class StatisticalPage : UserControl
    {
        public StatisticalPage()
        {
            InitializeComponent();
        }

        private void StatisticalPage_Load(object sender, EventArgs e)
        {

            // Load dgv
            dgvProductsSold.DataSource = OrdersBLL.Instance.GetAll();


            // Load Chart
            chartlProductsSold.DataSource = OrdersBLL.Instance.Statistical();
            chartlProductsSold.Series["Tổng tiền"].XValueMember = "Month";
            chartlProductsSold.Series["Tổng tiền"].YValueMembers = "Tổng tiền";
        }
    }
}
