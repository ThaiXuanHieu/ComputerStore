namespace GUI
{
    partial class SupplierManagementPage
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
            this.dgvSuppliers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblListSupplier = new System.Windows.Forms.Label();
            this.txtSearchSupplier = new System.Windows.Forms.TextBox();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.btnSearchSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuppliers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSuppliers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.ColumnHeadersHeight = 40;
            this.dgvSuppliers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvSuppliers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSuppliers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSuppliers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvSuppliers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSuppliers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSuppliers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvSuppliers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSuppliers.CurrentTheme.Name = null;
            this.dgvSuppliers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSuppliers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvSuppliers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvSuppliers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvSuppliers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvSuppliers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvSuppliers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvSuppliers.HeaderForeColor = System.Drawing.Color.White;
            this.dgvSuppliers.Location = new System.Drawing.Point(18, 233);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.RowTemplate.Height = 40;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(985, 436);
            this.dgvSuppliers.TabIndex = 54;
            this.dgvSuppliers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // lblListSupplier
            // 
            this.lblListSupplier.AutoSize = true;
            this.lblListSupplier.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListSupplier.Location = new System.Drawing.Point(359, 172);
            this.lblListSupplier.Name = "lblListSupplier";
            this.lblListSupplier.Size = new System.Drawing.Size(312, 38);
            this.lblListSupplier.TabIndex = 53;
            this.lblListSupplier.Text = "Danh sách khách hàng";
            // 
            // txtSearchSupplier
            // 
            this.txtSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupplier.Location = new System.Drawing.Point(572, 108);
            this.txtSearchSupplier.Multiline = true;
            this.txtSearchSupplier.Name = "txtSearchSupplier";
            this.txtSearchSupplier.Size = new System.Drawing.Size(274, 40);
            this.txtSearchSupplier.TabIndex = 51;
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(371, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(300, 38);
            this.lblTitlePage.TabIndex = 47;
            this.lblTitlePage.Text = "Quản lý nhà cung cấp";
            // 
            // btnSearchSupplier
            // 
            this.btnSearchSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSearchSupplier.FlatAppearance.BorderSize = 0;
            this.btnSearchSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSearchSupplier.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSupplier.Location = new System.Drawing.Point(852, 108);
            this.btnSearchSupplier.Name = "btnSearchSupplier";
            this.btnSearchSupplier.Size = new System.Drawing.Size(151, 40);
            this.btnSearchSupplier.TabIndex = 52;
            this.btnSearchSupplier.Text = "     Tìm kiếm";
            this.btnSearchSupplier.UseVisualStyleBackColor = false;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.BackColor = System.Drawing.Color.Red;
            this.btnDeleteSupplier.FlatAppearance.BorderSize = 0;
            this.btnDeleteSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSupplier.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSupplier.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(298, 108);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteSupplier.TabIndex = 50;
            this.btnDeleteSupplier.Text = "   Sửa";
            this.btnDeleteSupplier.UseVisualStyleBackColor = false;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.Gold;
            this.btnEditSupplier.FlatAppearance.BorderSize = 0;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.ForeColor = System.Drawing.Color.Black;
            this.btnEditSupplier.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Location = new System.Drawing.Point(158, 108);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(134, 40);
            this.btnEditSupplier.TabIndex = 49;
            this.btnEditSupplier.Text = "   Sửa";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(18, 108);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(134, 40);
            this.btnAddSupplier.TabIndex = 48;
            this.btnAddSupplier.Text = "   Thêm";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // SupplierManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.lblListSupplier);
            this.Controls.Add(this.btnSearchSupplier);
            this.Controls.Add(this.txtSearchSupplier);
            this.Controls.Add(this.btnDeleteSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "SupplierManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView dgvSuppliers;
        private System.Windows.Forms.Label lblListSupplier;
        private System.Windows.Forms.Button btnSearchSupplier;
        private System.Windows.Forms.TextBox txtSearchSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblTitlePage;
    }
}
