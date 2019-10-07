namespace GUI
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.pnlSignin = new System.Windows.Forms.Panel();
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.lblSignup = new System.Windows.Forms.Label();
            this.llbBack = new System.Windows.Forms.LinkLabel();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtPasswordNew = new System.Windows.Forms.TextBox();
            this.txtUsernameNew = new System.Windows.Forms.TextBox();
            this.llbSignup = new System.Windows.Forms.LinkLabel();
            this.lblSignin = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlSignin.SuspendLayout();
            this.pnlSignup.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.pnlTop.Controls.Add(this.lbl);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(377, 61);
            this.pnlTop.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(75, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(225, 38);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Computer Store";
            // 
            // pnlSignin
            // 
            this.pnlSignin.Controls.Add(this.pnlSignup);
            this.pnlSignin.Controls.Add(this.llbSignup);
            this.pnlSignin.Controls.Add(this.lblSignin);
            this.pnlSignin.Controls.Add(this.btnSignin);
            this.pnlSignin.Controls.Add(this.txtPassword);
            this.pnlSignin.Controls.Add(this.txtUsername);
            this.pnlSignin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSignin.Location = new System.Drawing.Point(0, 61);
            this.pnlSignin.Name = "pnlSignin";
            this.pnlSignin.Size = new System.Drawing.Size(377, 369);
            this.pnlSignin.TabIndex = 9;
            // 
            // pnlSignup
            // 
            this.pnlSignup.Controls.Add(this.txtReEnterPassword);
            this.pnlSignup.Controls.Add(this.lblSignup);
            this.pnlSignup.Controls.Add(this.llbBack);
            this.pnlSignup.Controls.Add(this.btnSignup);
            this.pnlSignup.Controls.Add(this.txtPasswordNew);
            this.pnlSignup.Controls.Add(this.txtUsernameNew);
            this.pnlSignup.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSignup.Location = new System.Drawing.Point(0, 0);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(10, 369);
            this.pnlSignup.TabIndex = 17;
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReEnterPassword.Location = new System.Drawing.Point(42, 193);
            this.txtReEnterPassword.Multiline = true;
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.PasswordChar = '*';
            this.txtReEnterPassword.Size = new System.Drawing.Size(293, 41);
            this.txtReEnterPassword.TabIndex = 2;
            this.txtReEnterPassword.Text = "Nhập lại mật khẩu";
            // 
            // lblSignup
            // 
            this.lblSignup.AutoSize = true;
            this.lblSignup.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.lblSignup.Location = new System.Drawing.Point(126, 25);
            this.lblSignup.Name = "lblSignup";
            this.lblSignup.Size = new System.Drawing.Size(127, 41);
            this.lblSignup.TabIndex = 19;
            this.lblSignup.Text = "Đăng ký";
            // 
            // llbBack
            // 
            this.llbBack.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack.AutoSize = true;
            this.llbBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack.Location = new System.Drawing.Point(301, 12);
            this.llbBack.Name = "llbBack";
            this.llbBack.Size = new System.Drawing.Size(64, 28);
            this.llbBack.TabIndex = 18;
            this.llbBack.TabStop = true;
            this.llbBack.Text = "Trở về";
            this.llbBack.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbBack_LinkClicked);
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(82, 271);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(206, 44);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = false;
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordNew.Location = new System.Drawing.Point(42, 146);
            this.txtPasswordNew.Multiline = true;
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(293, 41);
            this.txtPasswordNew.TabIndex = 1;
            this.txtPasswordNew.Text = "Mật khẩu";
            // 
            // txtUsernameNew
            // 
            this.txtUsernameNew.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameNew.Location = new System.Drawing.Point(42, 99);
            this.txtUsernameNew.Multiline = true;
            this.txtUsernameNew.Name = "txtUsernameNew";
            this.txtUsernameNew.Size = new System.Drawing.Size(293, 41);
            this.txtUsernameNew.TabIndex = 0;
            this.txtUsernameNew.Text = "Tài khoản";
            // 
            // llbSignup
            // 
            this.llbSignup.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbSignup.AutoSize = true;
            this.llbSignup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbSignup.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbSignup.Location = new System.Drawing.Point(37, 318);
            this.llbSignup.Name = "llbSignup";
            this.llbSignup.Size = new System.Drawing.Size(132, 28);
            this.llbSignup.TabIndex = 2;
            this.llbSignup.TabStop = true;
            this.llbSignup.Text = "Đăng ký ngay";
            this.llbSignup.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.llbSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbSignup_LinkClicked);
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.lblSignin.Location = new System.Drawing.Point(105, 25);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(164, 41);
            this.lblSignin.TabIndex = 15;
            this.lblSignin.Text = "Đăng nhập";
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(190)))), ((int)(((byte)(68)))));
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(82, 226);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(206, 44);
            this.btnSignin.TabIndex = 0;
            this.btnSignin.Text = "Đăng nhập";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(42, 146);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(293, 41);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(42, 99);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(293, 41);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "Tài khoản";
            // 
            // Timer
            // 
            this.Timer.Interval = 30;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 430);
            this.Controls.Add(this.pnlSignin);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Store";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSignin.ResumeLayout(false);
            this.pnlSignin.PerformLayout();
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Panel pnlSignin;
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.Label lblSignup;
        private System.Windows.Forms.LinkLabel llbBack;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtPasswordNew;
        private System.Windows.Forms.TextBox txtUsernameNew;
        private System.Windows.Forms.LinkLabel llbSignup;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Timer Timer;
    }
}