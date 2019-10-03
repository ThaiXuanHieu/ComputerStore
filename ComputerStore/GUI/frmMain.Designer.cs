namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnSoftwarePage = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnComponentsPage = new System.Windows.Forms.Button();
            this.btnAccessoriesPage = new System.Windows.Forms.Button();
            this.btnLaptopPage = new System.Windows.Forms.Button();
            this.btnComputerPage = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.lblNameAdmin = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.Separator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.pnlWrap = new System.Windows.Forms.Panel();
            this.softwarePage = new GUI.SoftwarePage();
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
            this.pnlTop.Controls.Add(this.btnMenu);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1337, 46);
            this.pnlTop.TabIndex = 0;
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
            this.pnlLeft.Controls.Add(this.btnSoftwarePage);
            this.pnlLeft.Controls.Add(this.btnHelp);
            this.pnlLeft.Controls.Add(this.btnInfo);
            this.pnlLeft.Controls.Add(this.btnComponentsPage);
            this.pnlLeft.Controls.Add(this.btnAccessoriesPage);
            this.pnlLeft.Controls.Add(this.btnLaptopPage);
            this.pnlLeft.Controls.Add(this.btnComputerPage);
            this.pnlLeft.Controls.Add(this.btnHomePage);
            this.pnlLeft.Controls.Add(this.lblNameAdmin);
            this.pnlLeft.Controls.Add(this.picAvatar);
            this.pnlLeft.Controls.Add(this.Separator2);
            this.pnlLeft.Controls.Add(this.Separator1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 46);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(317, 727);
            this.pnlLeft.TabIndex = 1;
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
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(167, 675);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(140, 40);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Location = new System.Drawing.Point(12, 674);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(140, 40);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.UseVisualStyleBackColor = false;
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
            // lblNameAdmin
            // 
            this.lblNameAdmin.AutoSize = true;
            this.lblNameAdmin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAdmin.ForeColor = System.Drawing.Color.Black;
            this.lblNameAdmin.Location = new System.Drawing.Point(82, 16);
            this.lblNameAdmin.Name = "lblNameAdmin";
            this.lblNameAdmin.Size = new System.Drawing.Size(206, 38);
            this.lblNameAdmin.TabIndex = 3;
            this.lblNameAdmin.Text = "Thái Xuân Hiếu";
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
            this.lblCopyright.Location = new System.Drawing.Point(473, 6);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(183, 28);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Designed by XTeam";
            // 
            // pnlWrap
            // 
            this.pnlWrap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlWrap.Controls.Add(this.homePage);
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
            // homePage
            // 
            this.homePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage.Location = new System.Drawing.Point(0, 0);
            this.homePage.Name = "homePage";
            this.homePage.Size = new System.Drawing.Size(1020, 684);
            this.homePage.TabIndex = 1;
            // 
            // frmMain
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
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.pnlTop.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNameAdmin;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Button btnComponentsPage;
        private System.Windows.Forms.Button btnAccessoriesPage;
        private System.Windows.Forms.Button btnLaptopPage;
        private System.Windows.Forms.Button btnComputerPage;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnSoftwarePage;
        private SoftwarePage softwarePage;
        private HomePage homePage;
    }
}

