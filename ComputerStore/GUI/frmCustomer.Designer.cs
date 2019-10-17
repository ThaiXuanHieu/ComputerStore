namespace GUI
{
    partial class frmCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.Separator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnSoftwarePage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnComponentsPage = new System.Windows.Forms.Button();
            this.btnAccessoriesPage = new System.Windows.Forms.Button();
            this.btnLaptopPage = new System.Windows.Forms.Button();
            this.btnComputerPage = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlWrap = new System.Windows.Forms.Panel();
            this.softwarePage = new GUI.SoftwarePage();
            this.componentsPage = new GUI.ComponentsPage();
            this.accessoriesPage = new GUI.AccessoriesPage();
            this.laptopPage = new GUI.LaptopPage();
            this.computerPage = new GUI.ComputerPage();
            this.homePage = new GUI.HomePage();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.pnlWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.btnSearchProduct);
            this.pnlTop.Controls.Add(this.txtSearchProduct);
            this.pnlTop.Controls.Add(this.btnMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1337, 46);
            this.pnlTop.TabIndex = 0;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.btnSearchProduct.FlatAppearance.BorderSize = 0;
            this.btnSearchProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduct.ForeColor = System.Drawing.Color.White;
            this.btnSearchProduct.Image = global::GUI.Properties.Resources.icons8_Search_26px;
            this.btnSearchProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProduct.Location = new System.Drawing.Point(600, 3);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(151, 38);
            this.btnSearchProduct.TabIndex = 21;
            this.btnSearchProduct.Text = "     Tìm kiếm";
            this.btnSearchProduct.UseVisualStyleBackColor = false;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(317, 3);
            this.txtSearchProduct.Multiline = true;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(274, 38);
            this.txtSearchProduct.TabIndex = 20;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(12, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(55, 40);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 3;
            this.btnMenu.TabStop = false;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.Separator3);
            this.pnlLeft.Controls.Add(this.btnSoftwarePage);
            this.pnlLeft.Controls.Add(this.btnLogout);
            this.pnlLeft.Controls.Add(this.btnProfile);
            this.pnlLeft.Controls.Add(this.btnComponentsPage);
            this.pnlLeft.Controls.Add(this.btnAccessoriesPage);
            this.pnlLeft.Controls.Add(this.btnLaptopPage);
            this.pnlLeft.Controls.Add(this.btnComputerPage);
            this.pnlLeft.Controls.Add(this.btnHomePage);
            this.pnlLeft.Controls.Add(this.lblNameCustomer);
            this.pnlLeft.Controls.Add(this.picAvatar);
            this.pnlLeft.Controls.Add(this.Separator2);
            this.pnlLeft.Controls.Add(this.Separator1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(317, 727);
            this.pnlLeft.TabIndex = 1;
            // 
            // Separator3
            // 
            this.Separator3.BackColor = System.Drawing.Color.Transparent;
            this.Separator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator3.LineThickness = 1;
            this.Separator3.Location = new System.Drawing.Point(10, 461);
            this.Separator3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(297, 43);
            this.Separator3.TabIndex = 12;
            this.Separator3.Transparency = 255;
            this.Separator3.Vertical = false;
            // 
            // btnSoftwarePage
            // 
            this.btnSoftwarePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSoftwarePage.FlatAppearance.BorderSize = 0;
            this.btnSoftwarePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftwarePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftwarePage.ForeColor = System.Drawing.Color.White;
            this.btnSoftwarePage.Location = new System.Drawing.Point(12, 393);
            this.btnSoftwarePage.Name = "btnSoftwarePage";
            this.btnSoftwarePage.Size = new System.Drawing.Size(295, 61);
            this.btnSoftwarePage.TabIndex = 11;
            this.btnSoftwarePage.Text = "Phần mềm";
            this.btnSoftwarePage.UseVisualStyleBackColor = false;
            this.btnSoftwarePage.Click += new System.EventHandler(this.btnSoftwarePage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(167, 675);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(12, 674);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(140, 40);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Hồ sơ";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // btnComponentsPage
            // 
            this.btnComponentsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnComponentsPage.FlatAppearance.BorderSize = 0;
            this.btnComponentsPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComponentsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComponentsPage.ForeColor = System.Drawing.Color.White;
            this.btnComponentsPage.Location = new System.Drawing.Point(12, 335);
            this.btnComponentsPage.Name = "btnComponentsPage";
            this.btnComponentsPage.Size = new System.Drawing.Size(295, 61);
            this.btnComponentsPage.TabIndex = 8;
            this.btnComponentsPage.Text = "Linh kiện máy tính";
            this.btnComponentsPage.UseVisualStyleBackColor = false;
            this.btnComponentsPage.Click += new System.EventHandler(this.btnComponentsPage_Click);
            // 
            // btnAccessoriesPage
            // 
            this.btnAccessoriesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnAccessoriesPage.FlatAppearance.BorderSize = 0;
            this.btnAccessoriesPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessoriesPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessoriesPage.ForeColor = System.Drawing.Color.White;
            this.btnAccessoriesPage.Location = new System.Drawing.Point(12, 277);
            this.btnAccessoriesPage.Name = "btnAccessoriesPage";
            this.btnAccessoriesPage.Size = new System.Drawing.Size(295, 61);
            this.btnAccessoriesPage.TabIndex = 7;
            this.btnAccessoriesPage.Text = "Gaming gear - Phụ kiện";
            this.btnAccessoriesPage.UseVisualStyleBackColor = false;
            this.btnAccessoriesPage.Click += new System.EventHandler(this.btnAccessoriesPage_Click);
            // 
            // btnLaptopPage
            // 
            this.btnLaptopPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnLaptopPage.FlatAppearance.BorderSize = 0;
            this.btnLaptopPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaptopPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaptopPage.ForeColor = System.Drawing.Color.White;
            this.btnLaptopPage.Location = new System.Drawing.Point(12, 219);
            this.btnLaptopPage.Name = "btnLaptopPage";
            this.btnLaptopPage.Size = new System.Drawing.Size(295, 61);
            this.btnLaptopPage.TabIndex = 6;
            this.btnLaptopPage.Text = "Laptop - Macbook";
            this.btnLaptopPage.UseVisualStyleBackColor = false;
            this.btnLaptopPage.Click += new System.EventHandler(this.btnLaptopPage_Click);
            // 
            // btnComputerPage
            // 
            this.btnComputerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnComputerPage.FlatAppearance.BorderSize = 0;
            this.btnComputerPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputerPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputerPage.ForeColor = System.Drawing.Color.White;
            this.btnComputerPage.Location = new System.Drawing.Point(12, 161);
            this.btnComputerPage.Name = "btnComputerPage";
            this.btnComputerPage.Size = new System.Drawing.Size(295, 61);
            this.btnComputerPage.TabIndex = 5;
            this.btnComputerPage.Text = "PC - Workstation";
            this.btnComputerPage.UseVisualStyleBackColor = false;
            this.btnComputerPage.Click += new System.EventHandler(this.btnComputerPage_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.ForeColor = System.Drawing.Color.White;
            this.btnHomePage.Location = new System.Drawing.Point(12, 103);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(295, 61);
            this.btnHomePage.TabIndex = 4;
            this.btnHomePage.Text = "Trang chủ";
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblNameCustomer.Location = new System.Drawing.Point(82, 16);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(206, 38);
            this.lblNameCustomer.TabIndex = 3;
            this.lblNameCustomer.Text = "Thái Xuân Hiếu";
            // 
            // picAvatar
            // 
            this.picAvatar.Image = ((System.Drawing.Image)(resources.GetObject("picAvatar.Image")));
            this.picAvatar.Location = new System.Drawing.Point(13, 6);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(63, 55);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // Separator2
            // 
            this.Separator2.BackColor = System.Drawing.Color.Transparent;
            this.Separator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator2.LineThickness = 1;
            this.Separator2.Location = new System.Drawing.Point(13, 641);
            this.Separator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(297, 43);
            this.Separator2.TabIndex = 1;
            this.Separator2.Transparency = 255;
            this.Separator2.Vertical = false;
            // 
            // Separator1
            // 
            this.Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separator1.LineThickness = 1;
            this.Separator1.Location = new System.Drawing.Point(13, 52);
            this.Separator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(297, 43);
            this.Separator1.TabIndex = 0;
            this.Separator1.Transparency = 255;
            this.Separator1.Vertical = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlBottom.Controls.Add(this.lblCopyright);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(317, 730);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1020, 43);
            this.pnlBottom.TabIndex = 2;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.White;
            this.lblCopyright.Location = new System.Drawing.Point(438, 6);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(183, 28);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Designed by XTeam";
            // 
            // pnlWrap
            // 
            this.pnlWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlWrap.Controls.Add(this.homePage);
            this.pnlWrap.Controls.Add(this.computerPage);
            this.pnlWrap.Controls.Add(this.laptopPage);
            this.pnlWrap.Controls.Add(this.accessoriesPage);
            this.pnlWrap.Controls.Add(this.componentsPage);
            this.pnlWrap.Controls.Add(this.softwarePage);
            this.pnlWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrap.Location = new System.Drawing.Point(317, 46);
            this.pnlWrap.Name = "pnlWrap";
            this.pnlWrap.Size = new System.Drawing.Size(1020, 684);
            this.pnlWrap.TabIndex = 3;
            // 
            // softwarePage
            // 
            this.softwarePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.softwarePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.softwarePage.Location = new System.Drawing.Point(0, 0);
            this.softwarePage.Name = "softwarePage";
            this.softwarePage.Size = new System.Drawing.Size(1020, 684);
            this.softwarePage.TabIndex = 0;
            // 
            // componentsPage
            // 
            this.componentsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.componentsPage.Location = new System.Drawing.Point(0, 0);
            this.componentsPage.Name = "componentsPage";
            this.componentsPage.Size = new System.Drawing.Size(1020, 684);
            this.componentsPage.TabIndex = 1;
            // 
            // accessoriesPage
            // 
            this.accessoriesPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accessoriesPage.Location = new System.Drawing.Point(0, 0);
            this.accessoriesPage.Name = "accessoriesPage";
            this.accessoriesPage.Size = new System.Drawing.Size(1020, 684);
            this.accessoriesPage.TabIndex = 2;
            // 
            // laptopPage
            // 
            this.laptopPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laptopPage.Location = new System.Drawing.Point(0, 0);
            this.laptopPage.Name = "laptopPage";
            this.laptopPage.Size = new System.Drawing.Size(1020, 684);
            this.laptopPage.TabIndex = 3;
            // 
            // computerPage
            // 
            this.computerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.computerPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computerPage.Location = new System.Drawing.Point(0, 0);
            this.computerPage.Name = "computerPage";
            this.computerPage.Size = new System.Drawing.Size(1020, 684);
            this.computerPage.TabIndex = 4;
            // 
            // homePage
            // 
            this.homePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage.Location = new System.Drawing.Point(0, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1020, 684);
            this.homePage.TabIndex = 5;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 773);
            this.Controls.Add(this.pnlWrap);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlWrap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Panel pnlWrap;
        private Bunifu.Framework.UI.BunifuSeparator Separator2;
        private Bunifu.Framework.UI.BunifuSeparator Separator1;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Button btnComponentsPage;
        private System.Windows.Forms.Button btnAccessoriesPage;
        private System.Windows.Forms.Button btnLaptopPage;
        private System.Windows.Forms.Button btnComputerPage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnSoftwarePage;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private Bunifu.Framework.UI.BunifuSeparator Separator3;
        private SoftwarePage softwarePage;
        private ComponentsPage componentsPage;
        private AccessoriesPage accessoriesPage;
        private LaptopPage laptopPage;
        private ComputerPage computerPage;
        private HomePage homePage;
    }
}

