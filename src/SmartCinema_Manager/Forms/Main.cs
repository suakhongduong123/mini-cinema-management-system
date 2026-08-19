using SmartCinema_Manager.Models;
using SmartCinema_Manager.UserControls;
using System;
using System.Windows.Forms;

namespace SmartCinema_Manager.Forms
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
            ApplyPermissions();
        }

        // PHÂN QUYỀN — hiện thông báo thay vì ẩn btn
        private bool canService = false;
        private bool canMovie = false;
        private bool canSchedule = false;
        private bool canEmployee = false;
        private bool canCustomer = false;
        private bool canBCTK = false;
        private bool canSale = false;

        private void ApplyPermissions()
        {
            var user = SessionManager.CurrentUser;
            if (user == null) return;

            switch (user.PhanLoai)
            {
                case 1: // Admin — full quyền
                    canService = canMovie = canSchedule = true;
                    canEmployee = canCustomer = canBCTK = canSale = true;
                    break;

                case 2: // Giám sát
                    canMovie = canSchedule = canSale = canBCTK = true;
                    break;

                case 3: // Nhân viên
                    canSale = true;
                    break;
            }
        }

        private void ShowNoPermission()
        {
            MessageBox.Show(
                "Bạn không có quyền truy cập chức năng này!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // LOAD
        private void frMain_Load(object sender, EventArgs e) { }

        // USERCONTROLS
        Phim lichChieu = new Phim();
        SanPham dichvu = new SanPham();
        BanVe banVe = new BanVe();
        SuatChieu suatChieu = new SuatChieu();
        BaoCaoThongKe bctk = new BaoCaoThongKe();   // ← thêm UserControl BCTK

        private void ShowPanel(UserControl uc)
        {
            pnlShow.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlShow.Controls.Add(uc);
        }
        private void btnMovie_Click(object sender, EventArgs e)
        {
            if (!canMovie) { ShowNoPermission(); return; }
            ShowPanel(lichChieu);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            if (!canService) { ShowNoPermission(); return; }
            ShowPanel(dichvu);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (!canSale) { ShowNoPermission(); return; }
            ShowPanel(banVe);
        }

        private void btnMovieSchedule_Click(object sender, EventArgs e)
        {
            if (!canSchedule) { ShowNoPermission(); return; }
            ShowPanel(suatChieu);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (!canEmployee) { ShowNoPermission(); return; }
            // ShowPanel(nhanVien); // thêm khi có UC
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (!canCustomer) { ShowNoPermission(); return; }
            // ShowPanel(khachHang);
        }

        private void btnBCTK_Click(object sender, EventArgs e)
        {
            if (!canBCTK) { ShowNoPermission(); return; }
            ShowPanel(bctk);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;

            SessionManager.Logout();
            new login().Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc muốn thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;

            Application.Exit();
        }
    }
}