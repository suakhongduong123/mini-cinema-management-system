namespace SmartCinema_Manager.UserControls
{
    partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInfoService = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLine = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chbStopSale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbSale = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.pic_UpLoad = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPic = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.SoLuongTP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDescribe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblService = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpDate = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFindStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFindWord = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDS = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgrView_Service = new Guna.UI2.WinForms.Guna2DataGridView();
            this.picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.combo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.types = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlInfoService.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTP)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrView_Service)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoService
            // 
            this.pnlInfoService.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlInfoService.BorderRadius = 3;
            this.pnlInfoService.BorderThickness = 2;
            this.pnlInfoService.Controls.Add(this.pnlDetail);
            this.pnlInfoService.Controls.Add(this.lblTitle1);
            this.pnlInfoService.Controls.Add(this.btnAdd);
            this.pnlInfoService.Controls.Add(this.btnClear);
            this.pnlInfoService.Controls.Add(this.btnRefresh);
            this.pnlInfoService.Controls.Add(this.btnUpDate);
            this.pnlInfoService.Location = new System.Drawing.Point(3, 3);
            this.pnlInfoService.Name = "pnlInfoService";
            this.pnlInfoService.Size = new System.Drawing.Size(302, 677);
            this.pnlInfoService.TabIndex = 1;
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlDetail.BorderThickness = 2;
            this.pnlDetail.Controls.Add(this.pnlLine);
            this.pnlDetail.Controls.Add(this.guna2HtmlLabel1);
            this.pnlDetail.Controls.Add(this.chbStopSale);
            this.pnlDetail.Controls.Add(this.chbSale);
            this.pnlDetail.Controls.Add(this.txtPrice);
            this.pnlDetail.Controls.Add(this.pic_UpLoad);
            this.pnlDetail.Controls.Add(this.lblPic);
            this.pnlDetail.Controls.Add(this.txtDescription);
            this.pnlDetail.Controls.Add(this.SoLuongTP);
            this.pnlDetail.Controls.Add(this.cbType);
            this.pnlDetail.Controls.Add(this.lblPrice);
            this.pnlDetail.Controls.Add(this.txtName);
            this.pnlDetail.Controls.Add(this.lblStatus);
            this.pnlDetail.Controls.Add(this.lblDescribe);
            this.pnlDetail.Controls.Add(this.lblAmount);
            this.pnlDetail.Controls.Add(this.lblService);
            this.pnlDetail.Controls.Add(this.lblName);
            this.pnlDetail.Location = new System.Drawing.Point(3, 37);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(296, 557);
            this.pnlDetail.TabIndex = 0;
            // 
            // pnlLine
            // 
            this.pnlLine.BackColor = System.Drawing.Color.Brown;
            this.pnlLine.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlLine.Location = new System.Drawing.Point(10, 28);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.Size = new System.Drawing.Size(274, 1);
            this.pnlLine.TabIndex = 20;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(10, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(282, 29);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "THÔNG TIN CHI TIẾT";
            // 
            // chbStopSale
            // 
            this.chbStopSale.AutoSize = true;
            this.chbStopSale.BackColor = System.Drawing.Color.Transparent;
            this.chbStopSale.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.chbStopSale.CheckedState.BorderRadius = 0;
            this.chbStopSale.CheckedState.BorderThickness = 0;
            this.chbStopSale.CheckedState.FillColor = System.Drawing.Color.Red;
            this.chbStopSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStopSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chbStopSale.Location = new System.Drawing.Point(10, 218);
            this.chbStopSale.Name = "chbStopSale";
            this.chbStopSale.Size = new System.Drawing.Size(87, 19);
            this.chbStopSale.TabIndex = 19;
            this.chbStopSale.Text = "Ngừng bán";
            this.chbStopSale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbStopSale.UncheckedState.BorderRadius = 0;
            this.chbStopSale.UncheckedState.BorderThickness = 0;
            this.chbStopSale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbStopSale.UseVisualStyleBackColor = false;
            // 
            // chbSale
            // 
            this.chbSale.AutoSize = true;
            this.chbSale.BackColor = System.Drawing.Color.Transparent;
            this.chbSale.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.chbSale.CheckedState.BorderRadius = 0;
            this.chbSale.CheckedState.BorderThickness = 0;
            this.chbSale.CheckedState.FillColor = System.Drawing.Color.Red;
            this.chbSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chbSale.Location = new System.Drawing.Point(10, 193);
            this.chbSale.Name = "chbSale";
            this.chbSale.Size = new System.Drawing.Size(80, 19);
            this.chbSale.TabIndex = 18;
            this.chbSale.Text = "Đang bán";
            this.chbSale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbSale.UncheckedState.BorderRadius = 0;
            this.chbSale.UncheckedState.BorderThickness = 0;
            this.chbSale.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbSale.UseVisualStyleBackColor = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPrice.Location = new System.Drawing.Point(171, 126);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(114, 36);
            this.txtPrice.TabIndex = 9;
            // 
            // pic_UpLoad
            // 
            this.pic_UpLoad.BackColor = System.Drawing.Color.White;
            this.pic_UpLoad.FillColor = System.Drawing.Color.Black;
            this.pic_UpLoad.Image = ((System.Drawing.Image)(resources.GetObject("pic_UpLoad.Image")));
            this.pic_UpLoad.ImageRotate = 0F;
            this.pic_UpLoad.Location = new System.Drawing.Point(33, 413);
            this.pic_UpLoad.Name = "pic_UpLoad";
            this.pic_UpLoad.Size = new System.Drawing.Size(230, 134);
            this.pic_UpLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UpLoad.TabIndex = 1;
            this.pic_UpLoad.TabStop = false;
            this.pic_UpLoad.Click += new System.EventHandler(this.pic_UpLoad_Click);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = false;
            this.lblPic.BackColor = System.Drawing.Color.Transparent;
            this.lblPic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblPic.Location = new System.Drawing.Point(10, 385);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(188, 32);
            this.lblPic.TabIndex = 8;
            this.lblPic.Text = "HÌNH ẢNH SẢN PHẨM";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(10, 266);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(276, 113);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // SoLuongTP
            // 
            this.SoLuongTP.BackColor = System.Drawing.Color.Transparent;
            this.SoLuongTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoLuongTP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SoLuongTP.Location = new System.Drawing.Point(171, 193);
            this.SoLuongTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SoLuongTP.Name = "SoLuongTP";
            this.SoLuongTP.Size = new System.Drawing.Size(114, 36);
            this.SoLuongTP.TabIndex = 1;
            this.SoLuongTP.UpDownButtonFillColor = System.Drawing.Color.Silver;
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "Combo bắp nước",
            "Bắp",
            "Nước"});
            this.cbType.Location = new System.Drawing.Point(10, 126);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(156, 36);
            this.cbType.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = false;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblPrice.Location = new System.Drawing.Point(171, 105);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 28);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "GIÁ BÁN (VND)";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtName.Location = new System.Drawing.Point(10, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(274, 36);
            this.txtName.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(10, 171);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(155, 32);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "TRẠNG THÁI";
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = false;
            this.lblDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lblDescribe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblDescribe.Location = new System.Drawing.Point(10, 243);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(188, 60);
            this.lblDescribe.TabIndex = 4;
            this.lblDescribe.Text = "MÔ TẢ CHI TIẾT";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = false;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblAmount.Location = new System.Drawing.Point(171, 171);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(150, 32);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "SỐ LƯỢNG TỒN";
            // 
            // lblService
            // 
            this.lblService.AutoSize = false;
            this.lblService.BackColor = System.Drawing.Color.Transparent;
            this.lblService.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblService.Location = new System.Drawing.Point(10, 105);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(156, 28);
            this.lblService.TabIndex = 2;
            this.lblService.Text = "LOẠI DỊCH VỤ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblName.Location = new System.Drawing.Point(10, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 35);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "TÊN COMBO&DỊCH VỤ";
            // 
            // lblTitle1
            // 
            this.lblTitle1.AutoSize = false;
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.lblTitle1.Location = new System.Drawing.Point(3, 9);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(296, 29);
            this.lblTitle1.TabIndex = 8;
            this.lblTitle1.Text = "Quản lý Dịch vụ & Combo";
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnAdd.BorderRadius = 2;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.btnAdd.Location = new System.Drawing.Point(163, 636);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnClear.BorderRadius = 2;
            this.btnClear.BorderThickness = 1;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.White;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.btnClear.Location = new System.Drawing.Point(32, 636);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 31);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Xóa";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnRefresh.BorderRadius = 2;
            this.btnRefresh.BorderThickness = 1;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Silver;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(163, 600);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpDate
            // 
            this.btnUpDate.BorderRadius = 2;
            this.btnUpDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.btnUpDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpDate.ForeColor = System.Drawing.Color.White;
            this.btnUpDate.Location = new System.Drawing.Point(32, 600);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(108, 31);
            this.btnUpDate.TabIndex = 3;
            this.btnUpDate.Text = "Cập nhật";
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlMenu.BorderRadius = 3;
            this.pnlMenu.BorderThickness = 2;
            this.pnlMenu.Controls.Add(this.cbTypes);
            this.pnlMenu.Controls.Add(this.cbFindStatus);
            this.pnlMenu.Controls.Add(this.txtFindWord);
            this.pnlMenu.Location = new System.Drawing.Point(308, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(626, 57);
            this.pnlMenu.TabIndex = 2;
            // 
            // cbTypes
            // 
            this.cbTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypes.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypes.ItemHeight = 30;
            this.cbTypes.Items.AddRange(new object[] {
            "Combo bắp nước",
            "Bắp",
            "Nước"});
            this.cbTypes.Location = new System.Drawing.Point(346, 10);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(144, 36);
            this.cbTypes.TabIndex = 20;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // cbFindStatus
            // 
            this.cbFindStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbFindStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbFindStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFindStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindStatus.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFindStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFindStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindStatus.ItemHeight = 30;
            this.cbFindStatus.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán"});
            this.cbFindStatus.Location = new System.Drawing.Point(495, 10);
            this.cbFindStatus.Name = "cbFindStatus";
            this.cbFindStatus.Size = new System.Drawing.Size(120, 36);
            this.cbFindStatus.TabIndex = 8;
            this.cbFindStatus.Tag = "";
            this.cbFindStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbFindStatus.SelectedIndexChanged += new System.EventHandler(this.cbFindStatus_SelectedIndexChanged);
            // 
            // txtFindWord
            // 
            this.txtFindWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindWord.DefaultText = "";
            this.txtFindWord.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindWord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindWord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindWord.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindWord.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFindWord.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFindWord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFindWord.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFindWord.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFindWord.IconRight = ((System.Drawing.Image)(resources.GetObject("txtFindWord.IconRight")));
            this.txtFindWord.Location = new System.Drawing.Point(10, 10);
            this.txtFindWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFindWord.Name = "txtFindWord";
            this.txtFindWord.PlaceholderText = " Tìm kiếm";
            this.txtFindWord.SelectedText = "";
            this.txtFindWord.Size = new System.Drawing.Size(317, 36);
            this.txtFindWord.TabIndex = 8;
            this.txtFindWord.TextChanged += new System.EventHandler(this.txtFindWord_TextChanged);
            // 
            // pnlDS
            // 
            this.pnlDS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlDS.BorderRadius = 3;
            this.pnlDS.BorderThickness = 2;
            this.pnlDS.Controls.Add(this.flowLayoutPanel1);
            this.pnlDS.Controls.Add(this.dgrView_Service);
            this.pnlDS.Location = new System.Drawing.Point(308, 66);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(626, 614);
            this.pnlDS.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(338, 264);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(6, 6);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // dgrView_Service
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_Service.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrView_Service.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrView_Service.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrView_Service.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrView_Service.ColumnHeadersHeight = 50;
            this.dgrView_Service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrView_Service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.picture,
            this.combo,
            this.price,
            this.types,
            this.status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrView_Service.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrView_Service.GridColor = System.Drawing.Color.Silver;
            this.dgrView_Service.Location = new System.Drawing.Point(2, 0);
            this.dgrView_Service.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrView_Service.Name = "dgrView_Service";
            this.dgrView_Service.RowHeadersVisible = false;
            this.dgrView_Service.RowHeadersWidth = 51;
            this.dgrView_Service.RowTemplate.Height = 35;
            this.dgrView_Service.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrView_Service.Size = new System.Drawing.Size(622, 612);
            this.dgrView_Service.TabIndex = 0;
            this.dgrView_Service.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgrView_Service.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_Service.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrView_Service.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrView_Service.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrView_Service.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrView_Service.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrView_Service.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgrView_Service.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.dgrView_Service.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgrView_Service.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrView_Service.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgrView_Service.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrView_Service.ThemeStyle.HeaderStyle.Height = 50;
            this.dgrView_Service.ThemeStyle.ReadOnly = false;
            this.dgrView_Service.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrView_Service.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrView_Service.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrView_Service.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgrView_Service.ThemeStyle.RowsStyle.Height = 35;
            this.dgrView_Service.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_Service.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgrView_Service.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrView_Service_CellClick);
            // 
            // picture
            // 
            this.picture.FillWeight = 82.13902F;
            this.picture.HeaderText = "HÌNH ẢNH";
            this.picture.MinimumWidth = 50;
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            // 
            // combo
            // 
            this.combo.FillWeight = 88.75648F;
            this.combo.HeaderText = "TÊN COMBO/DỊCH VỤ";
            this.combo.MinimumWidth = 6;
            this.combo.Name = "combo";
            // 
            // price
            // 
            this.price.FillWeight = 79.20386F;
            this.price.HeaderText = "GIÁ (VND)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // types
            // 
            this.types.FillWeight = 79.20386F;
            this.types.HeaderText = "Phân loại";
            this.types.Items.AddRange(new object[] {
            "Combo bắp nước",
            "Bắp",
            "Nước"});
            this.types.MinimumWidth = 6;
            this.types.Name = "types";
            // 
            // status
            // 
            this.status.FillWeight = 87.00695F;
            this.status.HeaderText = "TRẠNG THÁI";
            this.status.Items.AddRange(new object[] {
            "Đang bán",
            "Ngừng bán"});
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlDS);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInfoService);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(937, 683);
            this.MinimumSize = new System.Drawing.Size(937, 683);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(937, 683);
            this.pnlInfoService.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongTP)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrView_Service)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlInfoService;
        private Guna.UI2.WinForms.Guna2Panel pnlDetail;
        private Guna.UI2.WinForms.Guna2PictureBox pic_UpLoad;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Guna.UI2.WinForms.Guna2NumericUpDown SoLuongTP;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescribe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblService;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnUpDate;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2ComboBox cbFindStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtFindWord;
        private Guna.UI2.WinForms.Guna2Panel pnlDS;
        private Guna.UI2.WinForms.Guna2DataGridView dgrView_Service;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPic;
        private Guna.UI2.WinForms.Guna2CheckBox chbStopSale;
        private Guna.UI2.WinForms.Guna2CheckBox chbSale;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypes;
        private System.Windows.Forms.Panel pnlLine;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewImageColumn picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn combo;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewComboBoxColumn types;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
    }
}
