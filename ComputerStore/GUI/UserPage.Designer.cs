namespace GUI
{
    partial class UserPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPage));
            this.grbUserInfo = new System.Windows.Forms.GroupBox();
            this.grbChangePassword = new System.Windows.Forms.GroupBox();
            this.lblReEnterPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.grbMainInfo = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.rdOrther = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.grbAvatar = new System.Windows.Forms.GroupBox();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTitlePage = new System.Windows.Forms.Label();
            this.grbUserInfo.SuspendLayout();
            this.grbChangePassword.SuspendLayout();
            this.grbMainInfo.SuspendLayout();
            this.grbAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbUserInfo
            // 
            this.grbUserInfo.Controls.Add(this.grbChangePassword);
            this.grbUserInfo.Controls.Add(this.grbMainInfo);
            this.grbUserInfo.Controls.Add(this.grbAvatar);
            this.grbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUserInfo.Location = new System.Drawing.Point(15, 81);
            this.grbUserInfo.Name = "grbUserInfo";
            this.grbUserInfo.Size = new System.Drawing.Size(988, 551);
            this.grbUserInfo.TabIndex = 0;
            this.grbUserInfo.TabStop = false;
            this.grbUserInfo.Text = "Thông tin người dùng";
            // 
            // grbChangePassword
            // 
            this.grbChangePassword.Controls.Add(this.lblReEnterPassword);
            this.grbChangePassword.Controls.Add(this.button1);
            this.grbChangePassword.Controls.Add(this.lblNewPassword);
            this.grbChangePassword.Controls.Add(this.lblCurrentPassword);
            this.grbChangePassword.Controls.Add(this.txtPassword);
            this.grbChangePassword.Controls.Add(this.txtReEnterPassword);
            this.grbChangePassword.Controls.Add(this.txtNewPassword);
            this.grbChangePassword.Location = new System.Drawing.Point(513, 50);
            this.grbChangePassword.Name = "grbChangePassword";
            this.grbChangePassword.Size = new System.Drawing.Size(446, 495);
            this.grbChangePassword.TabIndex = 5;
            this.grbChangePassword.TabStop = false;
            this.grbChangePassword.Text = "Đổi mật khẩu";
            // 
            // lblReEnterPassword
            // 
            this.lblReEnterPassword.AutoSize = true;
            this.lblReEnterPassword.Location = new System.Drawing.Point(18, 215);
            this.lblReEnterPassword.Name = "lblReEnterPassword";
            this.lblReEnterPassword.Size = new System.Drawing.Size(262, 29);
            this.lblReEnterPassword.TabIndex = 4;
            this.lblReEnterPassword.Text = "Nhập lại mật khẩu mới :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::GUI.Properties.Resources.icons8_Save_26px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(23, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "     Thay đổi";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(18, 135);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(167, 29);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "Mật khẩu mới :";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(18, 55);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(204, 29);
            this.lblCurrentPassword.TabIndex = 4;
            this.lblCurrentPassword.Text = "Mật khẩu hiện tại :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(23, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 34);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Password";
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(23, 255);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(289, 34);
            this.txtReEnterPassword.TabIndex = 2;
            this.txtReEnterPassword.Text = "ReEnterPassword";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(23, 167);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(289, 34);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Text = "NewPassword";
            // 
            // grbMainInfo
            // 
            this.grbMainInfo.Controls.Add(this.lblEmail);
            this.grbMainInfo.Controls.Add(this.lblPhone);
            this.grbMainInfo.Controls.Add(this.lblGender);
            this.grbMainInfo.Controls.Add(this.lblFirstName);
            this.grbMainInfo.Controls.Add(this.lblLastName);
            this.grbMainInfo.Controls.Add(this.rdOrther);
            this.grbMainInfo.Controls.Add(this.rdFemale);
            this.grbMainInfo.Controls.Add(this.rdMale);
            this.grbMainInfo.Controls.Add(this.txtEmail);
            this.grbMainInfo.Controls.Add(this.txtPhone);
            this.grbMainInfo.Controls.Add(this.txtFirstName);
            this.grbMainInfo.Controls.Add(this.txtLastName);
            this.grbMainInfo.Location = new System.Drawing.Point(7, 256);
            this.grbMainInfo.Name = "grbMainInfo";
            this.grbMainInfo.Size = new System.Drawing.Size(500, 289);
            this.grbMainInfo.TabIndex = 1;
            this.grbMainInfo.TabStop = false;
            this.grbMainInfo.Text = "Thông tin chính";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 211);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(86, 29);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(17, 171);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(166, 29);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Số điện thoại :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 130);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(113, 29);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính :";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 91);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 29);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Tên :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 49);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(56, 29);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Họ :";
            // 
            // rdOrther
            // 
            this.rdOrther.AutoSize = true;
            this.rdOrther.Location = new System.Drawing.Point(390, 128);
            this.rdOrther.Name = "rdOrther";
            this.rdOrther.Size = new System.Drawing.Size(88, 33);
            this.rdOrther.TabIndex = 4;
            this.rdOrther.TabStop = true;
            this.rdOrther.Text = "Khác";
            this.rdOrther.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(302, 128);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(65, 33);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Nữ";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(201, 128);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(85, 33);
            this.rdMale.TabIndex = 2;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "Nam";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(201, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 34);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(201, 168);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(277, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(201, 88);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(277, 34);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(201, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(277, 34);
            this.txtLastName.TabIndex = 0;
            // 
            // grbAvatar
            // 
            this.grbAvatar.Controls.Add(this.btnChangeImage);
            this.grbAvatar.Controls.Add(this.pictureBox1);
            this.grbAvatar.Location = new System.Drawing.Point(7, 50);
            this.grbAvatar.Name = "grbAvatar";
            this.grbAvatar.Size = new System.Drawing.Size(500, 200);
            this.grbAvatar.TabIndex = 1;
            this.grbAvatar.TabStop = false;
            this.grbAvatar.Text = "Ảnh đại diện 3x4";
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.Location = new System.Drawing.Point(167, 153);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(120, 40);
            this.btnChangeImage.TabIndex = 1;
            this.btnChangeImage.Text = "Chỉnh sửa";
            this.btnChangeImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnSave.Location = new System.Drawing.Point(869, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "   Ghi";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // lblTitlePage
            // 
            this.lblTitlePage.AutoSize = true;
            this.lblTitlePage.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitlePage.Location = new System.Drawing.Point(461, 9);
            this.lblTitlePage.Name = "lblTitlePage";
            this.lblTitlePage.Size = new System.Drawing.Size(93, 38);
            this.lblTitlePage.TabIndex = 41;
            this.lblTitlePage.Text = "Hồ sơ";
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitlePage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbUserInfo);
            this.Name = "UserPage";
            this.Size = new System.Drawing.Size(1020, 684);
            this.grbUserInfo.ResumeLayout(false);
            this.grbChangePassword.ResumeLayout(false);
            this.grbChangePassword.PerformLayout();
            this.grbMainInfo.ResumeLayout(false);
            this.grbMainInfo.PerformLayout();
            this.grbAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUserInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitlePage;
        private System.Windows.Forms.GroupBox grbMainInfo;
        private System.Windows.Forms.RadioButton rdOrther;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox grbAvatar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grbChangePassword;
        private System.Windows.Forms.Label lblReEnterPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button button1;
    }
}
