namespace SmartCinema_Manager.Forms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pic_Cinema = new System.Windows.Forms.PictureBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnl_pass = new System.Windows.Forms.Panel();
            this.lblForgotPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPassWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.chb_RemenberPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.lblCine_logo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMini_logo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cinema)).BeginInit();
            this.pnlEmail.SuspendLayout();
            this.pnl_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Cinema
            // 
            this.pic_Cinema.ErrorImage = null;
            this.pic_Cinema.Image = ((System.Drawing.Image)(resources.GetObject("pic_Cinema.Image")));
            this.pic_Cinema.Location = new System.Drawing.Point(500, -14);
            this.pic_Cinema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_Cinema.Name = "pic_Cinema";
            this.pic_Cinema.Size = new System.Drawing.Size(559, 681);
            this.pic_Cinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Cinema.TabIndex = 1;
            this.pic_Cinema.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtEmail.BorderRadius = 4;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtEmail.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.txtEmail.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.txtEmail.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.txtEmail.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtEmail.IconLeft")));
            this.txtEmail.Location = new System.Drawing.Point(4, 23);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.txtEmail.PlaceholderText = "name@gmail.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(395, 48);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextOffset = new System.Drawing.Point(4, 0);
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(53, 287);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(431, 80);
            this.pnlEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = false;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(0, -2);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(296, 21);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblWelcome.Location = new System.Drawing.Point(57, 156);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(436, 50);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome Back";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = false;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPass.Location = new System.Drawing.Point(0, -2);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(296, 21);
            this.lblPass.TabIndex = 13;
            this.lblPass.Text = "Password";
            // 
            // pnl_pass
            // 
            this.pnl_pass.Controls.Add(this.lblForgotPass);
            this.pnl_pass.Controls.Add(this.lblPass);
            this.pnl_pass.Controls.Add(this.txtPassWord);
            this.pnl_pass.Location = new System.Drawing.Point(53, 394);
            this.pnl_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_pass.Name = "pnl_pass";
            this.pnl_pass.Size = new System.Drawing.Size(423, 80);
            this.pnl_pass.TabIndex = 15;
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = false;
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.lblForgotPass.Location = new System.Drawing.Point(280, 4);
            this.lblForgotPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(271, 16);
            this.lblForgotPass.TabIndex = 14;
            this.lblForgotPass.Text = "Forgot Password ?";
            // 
            // txtPassWord
            // 
            this.txtPassWord.BackColor = System.Drawing.Color.Transparent;
            this.txtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(61)))), ((int)(((byte)(62)))));
            this.txtPassWord.BorderRadius = 4;
            this.txtPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassWord.DefaultText = "";
            this.txtPassWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassWord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(7)))), ((int)(((byte)(8)))));
            this.txtPassWord.FocusedState.BorderColor = System.Drawing.Color.Red;
            this.txtPassWord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.txtPassWord.HoverState.BorderColor = System.Drawing.Color.Red;
            this.txtPassWord.HoverState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(170)))));
            this.txtPassWord.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassWord.IconLeft")));
            this.txtPassWord.Location = new System.Drawing.Point(4, 23);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.txtPassWord.PlaceholderText = "";
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.Size = new System.Drawing.Size(395, 48);
            this.txtPassWord.TabIndex = 9;
            this.txtPassWord.TextOffset = new System.Drawing.Point(4, 0);
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BorderRadius = 5;
            this.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(20)))), ((int)(((byte)(25)))));
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_login.ImageSize = new System.Drawing.Size(17, 10);
            this.btn_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_login.Location = new System.Drawing.Point(53, 537);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(399, 53);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "Login";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chb_RemenberPass
            // 
            this.chb_RemenberPass.AutoSize = true;
            this.chb_RemenberPass.BackColor = System.Drawing.Color.Transparent;
            this.chb_RemenberPass.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.chb_RemenberPass.CheckedState.BorderRadius = 0;
            this.chb_RemenberPass.CheckedState.BorderThickness = 0;
            this.chb_RemenberPass.CheckedState.FillColor = System.Drawing.Color.Red;
            this.chb_RemenberPass.ForeColor = System.Drawing.Color.MistyRose;
            this.chb_RemenberPass.Location = new System.Drawing.Point(57, 480);
            this.chb_RemenberPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_RemenberPass.Name = "chb_RemenberPass";
            this.chb_RemenberPass.Size = new System.Drawing.Size(119, 20);
            this.chb_RemenberPass.TabIndex = 17;
            this.chb_RemenberPass.Text = "Remember me";
            this.chb_RemenberPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_RemenberPass.UncheckedState.BorderRadius = 0;
            this.chb_RemenberPass.UncheckedState.BorderThickness = 0;
            this.chb_RemenberPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chb_RemenberPass.UseVisualStyleBackColor = false;
            // 
            // lblCine_logo
            // 
            this.lblCine_logo.AutoSize = false;
            this.lblCine_logo.BackColor = System.Drawing.Color.Transparent;
            this.lblCine_logo.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCine_logo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCine_logo.Location = new System.Drawing.Point(161, 47);
            this.lblCine_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCine_logo.Name = "lblCine_logo";
            this.lblCine_logo.Size = new System.Drawing.Size(300, 34);
            this.lblCine_logo.TabIndex = 18;
            this.lblCine_logo.Text = "CINEMA";
            // 
            // lblMini_logo
            // 
            this.lblMini_logo.AutoSize = false;
            this.lblMini_logo.BackColor = System.Drawing.Color.Transparent;
            this.lblMini_logo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMini_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.lblMini_logo.Location = new System.Drawing.Point(69, 40);
            this.lblMini_logo.Margin = new System.Windows.Forms.Padding(4);
            this.lblMini_logo.Name = "lblMini_logo";
            this.lblMini_logo.Size = new System.Drawing.Size(188, 47);
            this.lblMini_logo.TabIndex = 22;
            this.lblMini_logo.Text = "MINI";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1055, 662);
            this.Controls.Add(this.lblCine_logo);
            this.Controls.Add(this.lblMini_logo);
            this.Controls.Add(this.chb_RemenberPass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pnl_pass);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pic_Cinema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1055, 662);
            this.MinimumSize = new System.Drawing.Size(1055, 662);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Cinema)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnl_pass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_Cinema;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPass;
        private System.Windows.Forms.Panel pnl_pass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblForgotPass;
        private Guna.UI2.WinForms.Guna2TextBox txtPassWord;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2CheckBox chb_RemenberPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCine_logo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMini_logo;
    }
}

