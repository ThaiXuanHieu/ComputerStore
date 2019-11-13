namespace GUI
{
    partial class WarehouseManagementPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.btnPrinter = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.llbListReceipt = new System.Windows.Forms.LinkLabel();
            this.lblListProductInventory = new System.Windows.Forms.Label();
            this.dgvListProductInventory = new System.Windows.Forms.DataGridView();
            this.dgvReceiptDetails = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnCreateReceipts = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.grbInfoOrders = new System.Windows.Forms.GroupBox();
            this.cbProducts = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.cbCompanyName = new System.Windows.Forms.ComboBox();
            this.cbContactName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetails)).BeginInit();
            this.grbInfoOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(410, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(223, 38);
            this.lblTitlePage.TabIndex = 31;
            this.lblTitlePage.Text = "Nhập sản phẩm";
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrinter.FlatAppearance.BorderSize = 0;
            this.btnPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinter.ForeColor = System.Drawing.Color.White;
            this.btnPrinter.Image = global::GUI.Properties.Resources.icons8_Print_26px;
            this.btnPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinter.Location = new System.Drawing.Point(827, 641);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(176, 40);
            this.btnPrinter.TabIndex = 74;
            this.btnPrinter.Text = "      In hóa đơn";
            this.btnPrinter.UseVisualStyleBackColor = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(353, 641);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 32);
            this.lblAmount.TabIndex = 86;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(215, 644);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(130, 32);
            this.lblTotalAmount.TabIndex = 85;
            this.lblTotalAmount.Text = "Tổng tiền :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(504, 644);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(65, 32);
            this.lbl2.TabIndex = 84;
            this.lbl2.Text = "VND";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::GUI.Properties.Resources.icons8_Paper_Money_26px;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(16, 641);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(193, 40);
            this.btnPay.TabIndex = 73;
            this.btnPay.Text = "      Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // llbListReceipt
            // 
            this.llbListReceipt.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListReceipt.AutoSize = true;
            this.llbListReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbListReceipt.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListReceipt.Location = new System.Drawing.Point(13, 9);
            this.llbListReceipt.Name = "llbListReceipt";
            this.llbListReceipt.Size = new System.Drawing.Size(251, 25);
            this.llbListReceipt.TabIndex = 83;
            this.llbListReceipt.TabStop = true;
            this.llbListReceipt.Text = "Xem danh sách phiếu nhập";
            this.llbListReceipt.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llbListReceipt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbListReceipt_LinkClicked);
            // 
            // lblListProductInventory
            // 
            this.lblListProductInventory.AutoSize = true;
            this.lblListProductInventory.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListProductInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListProductInventory.Location = new System.Drawing.Point(562, 309);
            this.lblListProductInventory.Name = "lblListProductInventory";
            this.lblListProductInventory.Size = new System.Drawing.Size(398, 38);
            this.lblListProductInventory.TabIndex = 82;
            this.lblListProductInventory.Text = "Danh sách sản phẩm tồn kho";
            // 
            // dgvListProductInventory
            // 
            this.dgvListProductInventory.AllowUserToAddRows = false;
            this.dgvListProductInventory.AllowUserToDeleteRows = false;
            this.dgvListProductInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProductInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvListProductInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProductInventory.Location = new System.Drawing.Point(513, 350);
            this.dgvListProductInventory.Name = "dgvListProductInventory";
            this.dgvListProductInventory.ReadOnly = true;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProductInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvListProductInventory.RowTemplate.Height = 24;
            this.dgvListProductInventory.Size = new System.Drawing.Size(490, 286);
            this.dgvListProductInventory.TabIndex = 80;
            // 
            // dgvReceiptDetails
            // 
            this.dgvReceiptDetails.AllowUserToAddRows = false;
            this.dgvReceiptDetails.AllowUserToDeleteRows = false;
            this.dgvReceiptDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvReceiptDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptDetails.Location = new System.Drawing.Point(16, 350);
            this.dgvReceiptDetails.Name = "dgvReceiptDetails";
            this.dgvReceiptDetails.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvReceiptDetails.RowTemplate.Height = 24;
            this.dgvReceiptDetails.Size = new System.Drawing.Size(490, 286);
            this.dgvReceiptDetails.TabIndex = 81;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::GUI.Properties.Resources.icons8_Save_26px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(438, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOrderDetails.Location = new System.Drawing.Point(140, 309);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(268, 38);
            this.lblOrderDetails.TabIndex = 79;
            this.lblOrderDetails.Text = "Chi tiết phiếu nhập";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(132)))), ((int)(((byte)(150)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.Location = new System.Drawing.Point(852, 262);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(151, 40);
            this.btnSearchProduct.TabIndex = 72;
            this.btnSearchProduct.Text = "     Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtSearchProduct.Location = new System.Drawing.Point(578, 262);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(268, 40);
            this.txtSearchProduct.TabIndex = 78;
            this.txtSearchProduct.Text = "Nhập tên sản phẩm...";
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.FlatAppearance.BorderSize = 0;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Image = global::GUI.Properties.Resources.icons8_Trash_Can_26px;
            this.btnDeleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrder.Location = new System.Drawing.Point(298, 262);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(134, 40);
            this.btnDeleteOrder.TabIndex = 70;
            this.btnDeleteOrder.Text = "   Xóa";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.BackColor = System.Drawing.Color.Gold;
            this.btnEditOrder.FlatAppearance.BorderSize = 0;
            this.btnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.ForeColor = System.Drawing.Color.Black;
            this.btnEditOrder.Image = global::GUI.Properties.Resources.icons8_Edit_26px;
            this.btnEditOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditOrder.Location = new System.Drawing.Point(158, 262);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(134, 40);
            this.btnEditOrder.TabIndex = 69;
            this.btnEditOrder.Text = "   Sửa";
            this.btnEditOrder.UseVisualStyleBackColor = false;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnCreateReceipts
            // 
            this.btnCreateReceipts.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateReceipts.FlatAppearance.BorderSize = 0;
            this.btnCreateReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReceipts.ForeColor = System.Drawing.Color.White;
            this.btnCreateReceipts.Image = global::GUI.Properties.Resources.icons8_Purchase_Order_26px;
            this.btnCreateReceipts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReceipts.Location = new System.Drawing.Point(799, 20);
            this.btnCreateReceipts.Name = "btnCreateReceipts";
            this.btnCreateReceipts.Size = new System.Drawing.Size(204, 40);
            this.btnCreateReceipts.TabIndex = 77;
            this.btnCreateReceipts.Text = "      Tạo phiếu nhập";
            this.btnCreateReceipts.UseVisualStyleBackColor = false;
            this.btnCreateReceipts.Click += new System.EventHandler(this.btnCreateReceipts_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Image = global::GUI.Properties.Resources.icons8_Plus_Math_26px;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Location = new System.Drawing.Point(18, 262);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(134, 40);
            this.btnAddOrder.TabIndex = 68;
            this.btnAddOrder.Text = "   Thêm";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // grbInfoOrders
            // 
            this.grbInfoOrders.Controls.Add(this.cbContactName);
            this.grbInfoOrders.Controls.Add(this.cbCompanyName);
            this.grbInfoOrders.Controls.Add(this.lblCompanyName);
            this.grbInfoOrders.Controls.Add(this.lblContactName);
            this.grbInfoOrders.Controls.Add(this.cbProducts);
            this.grbInfoOrders.Controls.Add(this.lbl1);
            this.grbInfoOrders.Controls.Add(this.txtQuantity);
            this.grbInfoOrders.Controls.Add(this.txtPrice);
            this.grbInfoOrders.Controls.Add(this.lblQuantity);
            this.grbInfoOrders.Controls.Add(this.lblPrice);
            this.grbInfoOrders.Controls.Add(this.lblSupplier);
            this.grbInfoOrders.Controls.Add(this.lblProductName);
            this.grbInfoOrders.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoOrders.Location = new System.Drawing.Point(18, 66);
            this.grbInfoOrders.Name = "grbInfoOrders";
            this.grbInfoOrders.Size = new System.Drawing.Size(985, 178);
            this.grbInfoOrders.TabIndex = 76;
            this.grbInfoOrders.TabStop = false;
            this.grbInfoOrders.Text = "Thông tin hóa đơn";
            // 
            // cbProducts
            // 
            this.cbProducts.FormattingEnabled = true;
            this.cbProducts.Location = new System.Drawing.Point(188, 46);
            this.cbProducts.Name = "cbProducts";
            this.cbProducts.Size = new System.Drawing.Size(226, 36);
            this.cbProducts.TabIndex = 67;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(349, 133);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 32);
            this.lbl1.TabIndex = 66;
            this.lbl1.Text = "VND";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(188, 89);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(136, 34);
            this.txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(188, 131);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 34);
            this.txtPrice.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(6, 91);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(123, 32);
            this.lblQuantity.TabIndex = 62;
            this.lblQuantity.Text = "Số lượng :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(6, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(61, 32);
            this.lblPrice.TabIndex = 62;
            this.lblPrice.Text = "Giá :";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.Location = new System.Drawing.Point(698, 45);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(175, 32);
            this.lblSupplier.TabIndex = 55;
            this.lblSupplier.Text = "Nhà cung cấp :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(176, 32);
            this.lblProductName.TabIndex = 55;
            this.lblProductName.Text = "Tên sản phẩm :";
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(554, 91);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(152, 32);
            this.lblCompanyName.TabIndex = 69;
            this.lblCompanyName.Text = "Tên công ty :";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.Location = new System.Drawing.Point(554, 131);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(145, 32);
            this.lblContactName.TabIndex = 68;
            this.lblContactName.Text = "Tên liên hệ :";
            // 
            // cbCompanyName
            // 
            this.cbCompanyName.FormattingEnabled = true;
            this.cbCompanyName.Location = new System.Drawing.Point(704, 90);
            this.cbCompanyName.Name = "cbCompanyName";
            this.cbCompanyName.Size = new System.Drawing.Size(259, 36);
            this.cbCompanyName.TabIndex = 70;
            // 
            // cbContactName
            // 
            this.cbContactName.FormattingEnabled = true;
            this.cbContactName.Location = new System.Drawing.Point(704, 130);
            this.cbContactName.Name = "cbContactName";
            this.cbContactName.Size = new System.Drawing.Size(259, 36);
            this.cbContactName.TabIndex = 70;
            // 
            // WarehouseManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrinter);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.llbListReceipt);
            this.Controls.Add(this.lblListProductInventory);
            this.Controls.Add(this.dgvListProductInventory);
            this.Controls.Add(this.dgvReceiptDetails);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnCreateReceipts);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.grbInfoOrders);
            this.Controls.Add(this.lblTitlePage);
            this.Name = "WarehouseManagementPage";
            this.Size = new System.Drawing.Size(1020, 684);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProductInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetails)).EndInit();
            this.grbInfoOrders.ResumeLayout(false);
            this.grbInfoOrders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.Button btnPrinter;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.LinkLabel llbListReceipt;
        private System.Windows.Forms.Label lblListProductInventory;
        private System.Windows.Forms.DataGridView dgvListProductInventory;
        private System.Windows.Forms.DataGridView dgvReceiptDetails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnCreateReceipts;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.GroupBox grbInfoOrders;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.ComboBox cbCompanyName;
        private System.Windows.Forms.ComboBox cbContactName;
    }
}
