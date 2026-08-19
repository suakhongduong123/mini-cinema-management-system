namespace SmartCinema_Manager.UserControls
{
    partial class Phim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phim));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlInfoMovie = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlPoster = new Guna.UI2.WinForms.Guna2Panel();
            this.dtMovieStar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pic_UpLoad = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.MovieTime = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDescribe = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTypes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpDate = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.cbFindStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbFindTypes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlDS = new Guna.UI2.WinForms.Guna2Panel();
            this.dgrView_movie = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKhoiChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlInfoMovie.SuspendLayout();
            this.pnlPoster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieTime)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrView_movie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInfoMovie
            // 
            this.pnlInfoMovie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlInfoMovie.BorderRadius = 3;
            this.pnlInfoMovie.BorderThickness = 2;
            this.pnlInfoMovie.Controls.Add(this.pnlPoster);
            this.pnlInfoMovie.Controls.Add(this.guna2HtmlLabel1);
            this.pnlInfoMovie.Controls.Add(this.btnAdd);
            this.pnlInfoMovie.Controls.Add(this.btnClear);
            this.pnlInfoMovie.Controls.Add(this.btnRefresh);
            this.pnlInfoMovie.Controls.Add(this.btnUpDate);
            this.pnlInfoMovie.Location = new System.Drawing.Point(3, 3);
            this.pnlInfoMovie.Name = "pnlInfoMovie";
            this.pnlInfoMovie.Size = new System.Drawing.Size(302, 677);
            this.pnlInfoMovie.TabIndex = 0;
            // 
            // pnlPoster
            // 
            this.pnlPoster.BackColor = System.Drawing.Color.White;
            this.pnlPoster.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlPoster.BorderThickness = 2;
            this.pnlPoster.Controls.Add(this.dtMovieStar);
            this.pnlPoster.Controls.Add(this.pic_UpLoad);
            this.pnlPoster.Controls.Add(this.txtDescription);
            this.pnlPoster.Controls.Add(this.MovieTime);
            this.pnlPoster.Controls.Add(this.cbType);
            this.pnlPoster.Controls.Add(this.cbStatus);
            this.pnlPoster.Controls.Add(this.lblTime);
            this.pnlPoster.Controls.Add(this.txtName);
            this.pnlPoster.Controls.Add(this.lblStatus);
            this.pnlPoster.Controls.Add(this.lblDescribe);
            this.pnlPoster.Controls.Add(this.lblDate);
            this.pnlPoster.Controls.Add(this.lblTypes);
            this.pnlPoster.Controls.Add(this.lblName);
            this.pnlPoster.Location = new System.Drawing.Point(3, 37);
            this.pnlPoster.Name = "pnlPoster";
            this.pnlPoster.Size = new System.Drawing.Size(296, 547);
            this.pnlPoster.TabIndex = 0;
            // 
            // dtMovieStar
            // 
            this.dtMovieStar.BorderColor = System.Drawing.Color.White;
            this.dtMovieStar.Checked = true;
            this.dtMovieStar.FillColor = System.Drawing.Color.White;
            this.dtMovieStar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtMovieStar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtMovieStar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMovieStar.Location = new System.Drawing.Point(10, 361);
            this.dtMovieStar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtMovieStar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtMovieStar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtMovieStar.Name = "dtMovieStar";
            this.dtMovieStar.Size = new System.Drawing.Size(143, 29);
            this.dtMovieStar.TabIndex = 1;
            this.dtMovieStar.Value = new System.DateTime(2026, 5, 23, 11, 13, 22, 20);
            // 
            // pic_UpLoad
            // 
            this.pic_UpLoad.BackColor = System.Drawing.Color.White;
            this.pic_UpLoad.FillColor = System.Drawing.Color.Black;
            this.pic_UpLoad.Image = ((System.Drawing.Image)(resources.GetObject("pic_UpLoad.Image")));
            this.pic_UpLoad.ImageRotate = 0F;
            this.pic_UpLoad.Location = new System.Drawing.Point(76, 15);
            this.pic_UpLoad.Name = "pic_UpLoad";
            this.pic_UpLoad.Size = new System.Drawing.Size(122, 179);
            this.pic_UpLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_UpLoad.TabIndex = 1;
            this.pic_UpLoad.TabStop = false;
            this.pic_UpLoad.Click += new System.EventHandler(this.pic_UpLoad_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(10, 425);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(276, 113);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Text = "";
            // 
            // MovieTime
            // 
            this.MovieTime.BackColor = System.Drawing.Color.Transparent;
            this.MovieTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MovieTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MovieTime.Location = new System.Drawing.Point(164, 293);
            this.MovieTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MovieTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.MovieTime.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MovieTime.Name = "MovieTime";
            this.MovieTime.Size = new System.Drawing.Size(121, 36);
            this.MovieTime.TabIndex = 1;
            this.MovieTime.UpDownButtonFillColor = System.Drawing.Color.Silver;
            this.MovieTime.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
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
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "Hành động",
            "Kinh dị",
            "Viễn tưởng",
            "Trinh thám",
            "Hoạt hình",
            "Tình Cảm"});
            this.cbType.Location = new System.Drawing.Point(10, 292);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(120, 36);
            this.cbType.TabIndex = 7;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStatus.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "Đang chiếu",
            "Sắp chiếu",
            "Ngừng chiếu"});
            this.cbStatus.Location = new System.Drawing.Point(165, 362);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 36);
            this.cbStatus.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = false;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblTime.Location = new System.Drawing.Point(165, 269);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(120, 28);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Thời lượng (Phút)";
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
            this.txtName.Location = new System.Drawing.Point(10, 223);
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
            this.lblStatus.Location = new System.Drawing.Point(164, 336);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(142, 32);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = false;
            this.lblDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lblDescribe.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblDescribe.Location = new System.Drawing.Point(10, 400);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(188, 60);
            this.lblDescribe.TabIndex = 4;
            this.lblDescribe.Text = "Mô tả phim";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = false;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblDate.Location = new System.Drawing.Point(10, 336);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(174, 32);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Ngày khởi chiếu";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = false;
            this.lblTypes.BackColor = System.Drawing.Color.Transparent;
            this.lblTypes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblTypes.Location = new System.Drawing.Point(10, 269);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(127, 28);
            this.lblTypes.TabIndex = 2;
            this.lblTypes.Text = "Thể loại";
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblName.Location = new System.Drawing.Point(10, 198);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 35);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên phim";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 9);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(206, 29);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "THÔNG TIN PHIM";
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
            this.pnlMenu.Controls.Add(this.cbFindStatus);
            this.pnlMenu.Controls.Add(this.cbFindTypes);
            this.pnlMenu.Controls.Add(this.txtFind);
            this.pnlMenu.Location = new System.Drawing.Point(308, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(626, 57);
            this.pnlMenu.TabIndex = 1;
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
            this.cbFindStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbFindStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFindStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindStatus.ItemHeight = 30;
            this.cbFindStatus.Items.AddRange(new object[] {
            "Đang chiếu",
            "Sắp chiếu",
            "Ngừng chiếu"});
            this.cbFindStatus.Location = new System.Drawing.Point(503, 9);
            this.cbFindStatus.Name = "cbFindStatus";
            this.cbFindStatus.Size = new System.Drawing.Size(121, 36);
            this.cbFindStatus.TabIndex = 8;
            this.cbFindStatus.SelectedIndexChanged += new System.EventHandler(this.cbFindStatus_SelectedIndexChanged);
            // 
            // cbFindTypes
            // 
            this.cbFindTypes.BackColor = System.Drawing.Color.Transparent;
            this.cbFindTypes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbFindTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFindTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindTypes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindTypes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindTypes.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindTypes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFindTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFindTypes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFindTypes.ItemHeight = 30;
            this.cbFindTypes.Items.AddRange(new object[] {
            "Hành động",
            "Kinh dị",
            "Viễn tưởng",
            "Trinh thám",
            "Hoạt hình",
            "Tình cảm"});
            this.cbFindTypes.Location = new System.Drawing.Point(378, 10);
            this.cbFindTypes.Name = "cbFindTypes";
            this.cbFindTypes.Size = new System.Drawing.Size(120, 36);
            this.cbFindTypes.TabIndex = 8;
            this.cbFindTypes.Tag = "";
            this.cbFindTypes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbFindTypes.SelectedIndexChanged += new System.EventHandler(this.cbFindTypes_SelectedIndexChanged);
            // 
            // txtFind
            // 
            this.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFind.DefaultText = "";
            this.txtFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFind.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFind.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFind.IconRight = ((System.Drawing.Image)(resources.GetObject("txtFind.IconRight")));
            this.txtFind.Location = new System.Drawing.Point(10, 10);
            this.txtFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFind.Name = "txtFind";
            this.txtFind.PlaceholderText = " Tìm kiếm";
            this.txtFind.SelectedText = "";
            this.txtFind.Size = new System.Drawing.Size(317, 36);
            this.txtFind.TabIndex = 8;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // pnlDS
            // 
            this.pnlDS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pnlDS.BorderRadius = 3;
            this.pnlDS.BorderThickness = 2;
            this.pnlDS.Controls.Add(this.dgrView_movie);
            this.pnlDS.Location = new System.Drawing.Point(308, 66);
            this.pnlDS.Name = "pnlDS";
            this.pnlDS.Size = new System.Drawing.Size(626, 614);
            this.pnlDS.TabIndex = 2;
            // 
            // dgrView_movie
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_movie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrView_movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrView_movie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrView_movie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrView_movie.ColumnHeadersHeight = 45;
            this.dgrView_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrView_movie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenphim,
            this.theloai,
            this.thoiluong,
            this.NgayKhoiChieu,
            this.trangthai});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrView_movie.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrView_movie.GridColor = System.Drawing.Color.Silver;
            this.dgrView_movie.Location = new System.Drawing.Point(2, 0);
            this.dgrView_movie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrView_movie.Name = "dgrView_movie";
            this.dgrView_movie.RowHeadersVisible = false;
            this.dgrView_movie.RowHeadersWidth = 51;
            this.dgrView_movie.RowTemplate.Height = 35;
            this.dgrView_movie.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrView_movie.Size = new System.Drawing.Size(622, 612);
            this.dgrView_movie.TabIndex = 0;
            this.dgrView_movie.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgrView_movie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_movie.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrView_movie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrView_movie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrView_movie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrView_movie.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrView_movie.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgrView_movie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.dgrView_movie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgrView_movie.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrView_movie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgrView_movie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrView_movie.ThemeStyle.HeaderStyle.Height = 45;
            this.dgrView_movie.ThemeStyle.ReadOnly = false;
            this.dgrView_movie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrView_movie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrView_movie.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrView_movie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgrView_movie.ThemeStyle.RowsStyle.Height = 35;
            this.dgrView_movie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_movie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgrView_movie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrView_movie_CellClick);
            // 
            // tenphim
            // 
            this.tenphim.FillWeight = 140F;
            this.tenphim.HeaderText = "Tên Phim";
            this.tenphim.MinimumWidth = 6;
            this.tenphim.Name = "tenphim";
            // 
            // theloai
            // 
            this.theloai.HeaderText = "Thể loại";
            this.theloai.MinimumWidth = 6;
            this.theloai.Name = "theloai";
            // 
            // thoiluong
            // 
            this.thoiluong.FillWeight = 60F;
            this.thoiluong.HeaderText = "Thời lượng";
            this.thoiluong.MinimumWidth = 6;
            this.thoiluong.Name = "thoiluong";
            // 
            // NgayKhoiChieu
            // 
            this.NgayKhoiChieu.HeaderText = "Ngày khởi chiếu";
            this.NgayKhoiChieu.MinimumWidth = 6;
            this.NgayKhoiChieu.Name = "NgayKhoiChieu";
            // 
            // trangthai
            // 
            this.trangthai.FillWeight = 90F;
            this.trangthai.HeaderText = "trạng thái";
            this.trangthai.Items.AddRange(new object[] {
            "Đang chiếu",
            "Sắp chiếu",
            "Ngừng chiếu"});
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            // 
            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlDS);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInfoMovie);
            this.MaximumSize = new System.Drawing.Size(937, 683);
            this.MinimumSize = new System.Drawing.Size(937, 683);
            this.Name = "Phim";
            this.Size = new System.Drawing.Size(937, 683);
            this.pnlInfoMovie.ResumeLayout(false);
            this.pnlPoster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_UpLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieTime)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrView_movie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlInfoMovie;
        private Guna.UI2.WinForms.Guna2Panel pnlPoster;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescribe;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTypes;
        private Guna.UI2.WinForms.Guna2ComboBox cbStatus;
        private Guna.UI2.WinForms.Guna2NumericUpDown MovieTime;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.RichTextBox txtDescription;
        private Guna.UI2.WinForms.Guna2PictureBox pic_UpLoad;
        private Guna.UI2.WinForms.Guna2Button btnUpDate;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFind;
        private Guna.UI2.WinForms.Guna2ComboBox cbFindStatus;
        private Guna.UI2.WinForms.Guna2ComboBox cbFindTypes;
        private Guna.UI2.WinForms.Guna2Panel pnlDS;
        private Guna.UI2.WinForms.Guna2DataGridView dgrView_movie;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtMovieStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKhoiChieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn trangthai;
    }
}
