namespace GUI
{
    partial class CustomerManagementPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblListCustomer = new System.Windows.Forms.Label();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.ColumnHeadersHeight = 40;
            this.dgvCustomers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvCustomers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCustomers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCustomers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCustomers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomers.CurrentTheme.Name = null;
            this.dgvCustomers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCustomers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCustomers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCustomers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCustomers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCustomers.Location = new System.Drawing.Point(18, 233);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowTemplate.Height = 40;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(985, 436);
            this.dgvCustomers.TabIndex = 46;
            this.dgvCustomers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblListCustomer
            // 
            this.lblListCustomer.AutoSize = true;
            this.lblListCustomer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListCustomer.Location = new System.Drawing.Point(359, 172);
            this.lblListCustomer.Name = "lblListCustomer";
            this.lblListCustomer.Size = new System.Drawing.Size(312, 38);
            this.lblListCustomer.TabIndex = 45;
            this.lblListCustomer.Text = "Danh sách khách hàng";
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(572, 108);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(274, 40);
            this.txtSearchCustomer.TabIndex = 43;
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(368, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(278, 38);
            this.lblTitlePage.TabIndex = 39;
            this.lblTitlePage.Text = "Quản lý khách hàng";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(852, 108);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(151, 40);
            this.btnSearchCustomer.TabIndex = 44;
            this.btnSearchCustomer.Text = "     Tìm kiếm";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.FlatAppearance.BorderSize = 0;
            this.btnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(298, 108);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteCustomer.TabIndex = 42;
            this.btnDeleteCustomer.Text = "   Sửa";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.Gold;
            this.btnEditCustomer.FlatAppearance.BorderSize = 0;
            this.btnEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnEditCustomer.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCustomer.Location = new System.Drawing.Point(158, 108);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(134, 40);
            this.btnEditCustomer.TabIndex = 41;
            this.btnEditCustomer.Text = "   Sửa";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCustomer.Location = new System.Drawing.Point(18, 108);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(134, 40);
            this.btnAddCustomer.TabIndex = 40;
            this.btnAddCustomer.Text = "   Thêm";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // CustomerManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblListCustomer);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "CustomerManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvCustomers;
        private System.Windows.Forms.Label lblListCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblTitlePage;
    }
}
