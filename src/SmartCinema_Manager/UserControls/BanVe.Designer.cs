namespace SmartCinema_Manager.UserControls
{
    partial class BanVe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPickMovie = new System.Windows.Forms.Panel();
            this.lblTitle3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgrView_movie = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tenphim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaychieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPickChair = new System.Windows.Forms.Panel();
            this.pnlSeat = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTypesDoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.pnlFood = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbTypesPay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle2 = new System.Windows.Forms.Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgrBill_Movie = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nameService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPickMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrView_movie)).BeginInit();
            this.pnlPickChair.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.lblTitle2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBill_Movie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPickMovie
            // 
            this.pnlPickMovie.Controls.Add(this.lblTitle3);
            this.pnlPickMovie.Controls.Add(this.dgrView_movie);
            this.pnlPickMovie.Location = new System.Drawing.Point(4, 4);
            this.pnlPickMovie.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPickMovie.Name = "pnlPickMovie";
            this.pnlPickMovie.Size = new System.Drawing.Size(664, 312);
            this.pnlPickMovie.TabIndex = 0;
            // 
            // lblTitle3
            // 
            this.lblTitle3.AutoSize = false;
            this.lblTitle3.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblTitle3.Location = new System.Drawing.Point(235, 2);
            this.lblTitle3.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitle3.Name = "lblTitle3";
            this.lblTitle3.Size = new System.Drawing.Size(315, 34);
            this.lblTitle3.TabIndex = 25;
            this.lblTitle3.Text = "Phim đang chiếu";
            // 
            // dgrView_movie
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrView_movie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrView_movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrView_movie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrView_movie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrView_movie.ColumnHeadersHeight = 45;
            this.dgrView_movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrView_movie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenphim,
            this.Phong,
            this.ngaychieu,
            this.GioChieu,
            this.thoiluong,
            this.giaVe});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrView_movie.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgrView_movie.GridColor = System.Drawing.Color.Silver;
            this.dgrView_movie.Location = new System.Drawing.Point(4, 42);
            this.dgrView_movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrView_movie.Name = "dgrView_movie";
            this.dgrView_movie.RowHeadersVisible = false;
            this.dgrView_movie.RowHeadersWidth = 51;
            this.dgrView_movie.RowTemplate.Height = 35;
            this.dgrView_movie.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrView_movie.Size = new System.Drawing.Size(657, 292);
            this.dgrView_movie.TabIndex = 1;
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
            // Phong
            // 
            this.Phong.HeaderText = "Phòng chiếu";
            this.Phong.MinimumWidth = 6;
            this.Phong.Name = "Phong";
            // 
            // ngaychieu
            // 
            this.ngaychieu.HeaderText = "Ngày chiếu";
            this.ngaychieu.MinimumWidth = 6;
            this.ngaychieu.Name = "ngaychieu";
            // 
            // GioChieu
            // 
            this.GioChieu.HeaderText = "Giờ Chiếu";
            this.GioChieu.MinimumWidth = 6;
            this.GioChieu.Name = "GioChieu";
            // 
            // thoiluong
            // 
            this.thoiluong.FillWeight = 60F;
            this.thoiluong.HeaderText = "Thời lượng";
            this.thoiluong.MinimumWidth = 6;
            this.thoiluong.Name = "thoiluong";
            // 
            // giaVe
            // 
            this.giaVe.HeaderText = "Giá Vé";
            this.giaVe.MinimumWidth = 6;
            this.giaVe.Name = "giaVe";
            // 
            // pnlPickChair
            // 
            this.pnlPickChair.Controls.Add(this.pnlSeat);
            this.pnlPickChair.Controls.Add(this.lblTypesDoc);
            this.pnlPickChair.Location = new System.Drawing.Point(4, 363);
            this.pnlPickChair.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPickChair.Name = "pnlPickChair";
            this.pnlPickChair.Size = new System.Drawing.Size(664, 474);
            this.pnlPickChair.TabIndex = 1;
            // 
            // pnlSeat
            // 
            this.pnlSeat.Location = new System.Drawing.Point(4, 44);
            this.pnlSeat.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(656, 438);
            this.pnlSeat.TabIndex = 24;
            // 
            // lblTypesDoc
            // 
            this.lblTypesDoc.AutoSize = false;
            this.lblTypesDoc.BackColor = System.Drawing.Color.Transparent;
            this.lblTypesDoc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypesDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblTypesDoc.Location = new System.Drawing.Point(264, 4);
            this.lblTypesDoc.Margin = new System.Windows.Forms.Padding(4);
            this.lblTypesDoc.Name = "lblTypesDoc";
            this.lblTypesDoc.Size = new System.Drawing.Size(219, 34);
            this.lblTypesDoc.TabIndex = 23;
            this.lblTypesDoc.Text = "SƠ ĐỒ GHẾ";
            // 
            // pnlPayment
            // 
            this.pnlPayment.Controls.Add(this.pnlFood);
            this.pnlPayment.Controls.Add(this.btnClear);
            this.pnlPayment.Controls.Add(this.btnPrint);
            this.pnlPayment.Controls.Add(this.lblTitle1);
            this.pnlPayment.Controls.Add(this.cbTypesPay);
            this.pnlPayment.Controls.Add(this.btnPayment);
            this.pnlPayment.Controls.Add(this.lblTitle2);
            this.pnlPayment.Location = new System.Drawing.Point(672, 7);
            this.pnlPayment.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Size = new System.Drawing.Size(573, 830);
            this.pnlPayment.TabIndex = 2;
            // 
            // pnlFood
            // 
            this.pnlFood.AutoScroll = true;
            this.pnlFood.Location = new System.Drawing.Point(4, 4);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(566, 270);
            this.pnlFood.TabIndex = 28;
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
            this.btnClear.ForeColor = System.Drawing.Color.Maroon;
            this.btnClear.Location = new System.Drawing.Point(285, 767);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(284, 59);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Hủy Đơn";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.btnPrint.BorderRadius = 2;
            this.btnPrint.BorderThickness = 1;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.Silver;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(4, 767);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(278, 59);
            this.btnPrint.TabIndex = 26;
            this.btnPrint.Text = "In Vé";
            // 
            // lblTitle1
            // 
            this.lblTitle1.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(94)))), ((int)(((byte)(96)))));
            this.lblTitle1.Location = new System.Drawing.Point(0, 627);
            this.lblTitle1.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitle1.Name = "lblTitle1";
            this.lblTitle1.Size = new System.Drawing.Size(214, 27);
            this.lblTitle1.TabIndex = 25;
            this.lblTitle1.Text = "Phương thức thanh toán";
            // 
            // cbTypesPay
            // 
            this.cbTypesPay.BackColor = System.Drawing.Color.Transparent;
            this.cbTypesPay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbTypesPay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypesPay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypesPay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypesPay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypesPay.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypesPay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypesPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypesPay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbTypesPay.ItemHeight = 30;
            this.cbTypesPay.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản",
            "PayCard"});
            this.cbTypesPay.Location = new System.Drawing.Point(4, 658);
            this.cbTypesPay.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypesPay.Name = "cbTypesPay";
            this.cbTypesPay.Size = new System.Drawing.Size(566, 36);
            this.cbTypesPay.TabIndex = 9;
            this.cbTypesPay.Tag = "";
            this.cbTypesPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayment
            // 
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(4, 702);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(565, 58);
            this.btnPayment.TabIndex = 7;
            this.btnPayment.Text = "Thanh Toán";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.Controls.Add(this.dgrBill_Movie);
            this.lblTitle2.Location = new System.Drawing.Point(3, 281);
            this.lblTitle2.Margin = new System.Windows.Forms.Padding(4);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(566, 348);
            this.lblTitle2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(0)))), ((int)(((byte)(3)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(8, 320);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(657, 35);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgrBill_Movie
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrBill_Movie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgrBill_Movie.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrBill_Movie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrBill_Movie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgrBill_Movie.ColumnHeadersHeight = 45;
            this.dgrBill_Movie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrBill_Movie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameService,
            this.price,
            this.Amount,
            this.total});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrBill_Movie.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgrBill_Movie.GridColor = System.Drawing.Color.Silver;
            this.dgrBill_Movie.Location = new System.Drawing.Point(2, 2);
            this.dgrBill_Movie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrBill_Movie.Name = "dgrBill_Movie";
            this.dgrBill_Movie.RowHeadersVisible = false;
            this.dgrBill_Movie.RowHeadersWidth = 51;
            this.dgrBill_Movie.RowTemplate.Height = 35;
            this.dgrBill_Movie.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrBill_Movie.Size = new System.Drawing.Size(561, 340);
            this.dgrBill_Movie.TabIndex = 1;
            this.dgrBill_Movie.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Red;
            this.dgrBill_Movie.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrBill_Movie.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgrBill_Movie.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgrBill_Movie.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgrBill_Movie.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgrBill_Movie.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(197)))), ((int)(((byte)(207)))));
            this.dgrBill_Movie.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.dgrBill_Movie.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(0)))), ((int)(((byte)(7)))));
            this.dgrBill_Movie.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgrBill_Movie.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrBill_Movie.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgrBill_Movie.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgrBill_Movie.ThemeStyle.HeaderStyle.Height = 45;
            this.dgrBill_Movie.ThemeStyle.ReadOnly = false;
            this.dgrBill_Movie.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgrBill_Movie.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgrBill_Movie.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrBill_Movie.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgrBill_Movie.ThemeStyle.RowsStyle.Height = 35;
            this.dgrBill_Movie.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.dgrBill_Movie.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // nameService
            // 
            this.nameService.HeaderText = "Tên mặt hàng";
            this.nameService.MinimumWidth = 6;
            this.nameService.Name = "nameService";
            this.nameService.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Số lượng";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Thành Tiền";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // BanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlPayment);
            this.Controls.Add(this.pnlPickChair);
            this.Controls.Add(this.pnlPickMovie);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1249, 841);
            this.MinimumSize = new System.Drawing.Size(1249, 841);
            this.Name = "BanVe";
            this.Size = new System.Drawing.Size(1249, 841);
            this.Load += new System.EventHandler(this.BanVeControl3_Load);
            this.pnlPickMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrView_movie)).EndInit();
            this.pnlPickChair.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.lblTitle2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrBill_Movie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPickMovie;
        private System.Windows.Forms.Panel pnlPickChair;
        private System.Windows.Forms.Panel pnlPayment;
        private System.Windows.Forms.Panel lblTitle2;
        private Guna.UI2.WinForms.Guna2Panel pnlSeat;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTypesDoc;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypesPay;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2DataGridView dgrBill_Movie;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgrView_movie;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenphim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaychieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameService;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.FlowLayoutPanel pnlFood;
    }
}
