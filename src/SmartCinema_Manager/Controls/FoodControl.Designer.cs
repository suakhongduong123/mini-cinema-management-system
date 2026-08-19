namespace SmartCinema_Manager.Controls
{
    partial class FoodControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodControl));
            this.Pic_Food = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNameFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPriceFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnAddFood = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Food
            // 
            this.Pic_Food.ErrorImage = null;
            this.Pic_Food.FillColor = System.Drawing.Color.Transparent;
            this.Pic_Food.Image = ((System.Drawing.Image)(resources.GetObject("Pic_Food.Image")));
            this.Pic_Food.ImageRotate = 0F;
            this.Pic_Food.InitialImage = null;
            this.Pic_Food.Location = new System.Drawing.Point(2, 2);
            this.Pic_Food.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pic_Food.Name = "Pic_Food";
            this.Pic_Food.Size = new System.Drawing.Size(255, 120);
            this.Pic_Food.TabIndex = 2;
            this.Pic_Food.TabStop = false;
            // 
            // lblNameFood
            // 
            this.lblNameFood.BackColor = System.Drawing.Color.Transparent;
            this.lblNameFood.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFood.Location = new System.Drawing.Point(10, 128);
            this.lblNameFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblNameFood.Name = "lblNameFood";
            this.lblNameFood.Size = new System.Drawing.Size(105, 21);
            this.lblNameFood.TabIndex = 3;
            this.lblNameFood.Text = "Tên Thực Phẩm";
            // 
            // lblPriceFood
            // 
            this.lblPriceFood.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceFood.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceFood.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPriceFood.Location = new System.Drawing.Point(10, 153);
            this.lblPriceFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblPriceFood.Name = "lblPriceFood";
            this.lblPriceFood.Size = new System.Drawing.Size(57, 21);
            this.lblPriceFood.TabIndex = 4;
            this.lblPriceFood.Text = "Giá Tiền";
            // 
            // BtnAddFood
            // 
            this.BtnAddFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddFood.FillColor = System.Drawing.Color.Maroon;
            this.BtnAddFood.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddFood.ForeColor = System.Drawing.Color.White;
            this.BtnAddFood.Location = new System.Drawing.Point(221, 137);
            this.BtnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddFood.Name = "BtnAddFood";
            this.BtnAddFood.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnAddFood.Size = new System.Drawing.Size(36, 37);
            this.BtnAddFood.TabIndex = 5;
            this.BtnAddFood.Text = "+";
            this.BtnAddFood.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnAddFood.Click += new System.EventHandler(this.BtnAddFood_Click);
            // 
            // FoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAddFood);
            this.Controls.Add(this.lblPriceFood);
            this.Controls.Add(this.lblNameFood);
            this.Controls.Add(this.Pic_Food);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FoodControl";
            this.Size = new System.Drawing.Size(259, 183);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Pic_Food;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameFood;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPriceFood;
        private Guna.UI2.WinForms.Guna2CircleButton BtnAddFood;
    }
}
