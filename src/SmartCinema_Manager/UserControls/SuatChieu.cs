using SmartCinema_Manager.Model;
using SmartCinema_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SmartCinema_Manager.UserControls
{
    public partial class SuatChieu : UserControl
    {
        // INNER MODEL
        private class SuatChieuItem
        {
            public string MaSuat { get; set; }
            public string MaPhong { get; set; }
            public string MaPhim { get; set; }
            public string TenPhim { get; set; }
            public string TenPhong { get; set; }
            public DateTime NgayChieu { get; set; }
            public DateTime GioBatDau { get; set; }
            public DateTime GioKetThuc { get; set; }
            public decimal GiaVe { get; set; }
            public string TrangThai { get; set; }
        }

        // STATE
        private readonly List<SuatChieuItem> data = new List<SuatChieuItem>();
        private string selectedMaSuat = null;
        private Timer trangThaiTimer;
        private bool loaded = false;

        // CONSTRUCTOR
        public SuatChieu()
        {
            InitializeComponent();
            ConfigureGrid();
            SetupTrangThaiTimer();

            timeStart.ValueChanged += GioBatDau_ValueChanged;
            cbTenPhim.SelectedIndexChanged += CbTenPhim_SelectedIndexChanged;
            txtGiaVe.Leave += GiaVe_Leave;

            this.Load += (s, e) => LoadFromDb();
            this.VisibleChanged += (s, e) => { if (this.Visible && loaded) LoadFromDb(); };
        }

        // LOAD TỪ DB
        private void LoadFromDb()
        {
            try
            {
                data.Clear();
                CinemaRepository.DanhSachSuatChieu = SuatChieuRepository.GetAll();

                foreach (var sc in CinemaRepository.DanhSachSuatChieu)
                {
                    data.Add(new SuatChieuItem
                    {
                        MaSuat = sc.MaSuat,
                        MaPhim = sc.MaPhim,
                        MaPhong = sc.MaPhong,
                        TenPhim = sc.TenPhim,
                        TenPhong = sc.TenPhong,
                        NgayChieu = sc.NgayChieu,
                        GioBatDau = sc.GioBatDau,
                        GioKetThuc = sc.GioKetThuc,
                        GiaVe = sc.GiaVe,
                        TrangThai = sc.TrangThai
                    });
                }

                LoadAllComboBox();
                LoadGrid();
            }
            catch (Exception ex)
            {
                ShowWarn("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // TIMER TRẠNG THÁI
        private void SetupTrangThaiTimer()
        {
            trangThaiTimer = new Timer { Interval = 60000 };
            trangThaiTimer.Tick += (s, e) => RefreshTrangThai();
            trangThaiTimer.Start();
        }

        private string TinhTrangThai(SuatChieuItem item)
        {
            DateTime now = DateTime.Now;
            DateTime batDau = item.NgayChieu.Date + item.GioBatDau.TimeOfDay;
            DateTime ketThuc = item.NgayChieu.Date + item.GioKetThuc.TimeOfDay;

            if (now < batDau) return "Sắp Chiếu";
            if (now >= batDau && now <= ketThuc) return "Đang Chiếu";
            return "Đã Chiếu";
        }

        // Chỉ cập nhật hiển thị, không ghi DB (TrangThai tính theo thời gian thực)
        private void RefreshTrangThai()
        {
            foreach (var item in data)
                item.TrangThai = TinhTrangThai(item);
            LoadGrid();
        }

        // LOAD COMBOBOX
        private void LoadAllComboBox()
        {
            LoadPhimComboBox();
            LoadPhongChieuComboBox();
        }

        private void LoadPhimComboBox()
        {
            string current = cbTenPhim.Text;

            cbTenPhim.SelectedIndexChanged -= CbTenPhim_SelectedIndexChanged;
            cbTenPhim.Items.Clear();

            foreach (var p in CinemaRepository.DanhSachPhim)
                cbTenPhim.Items.Add(p.TenPhim);

            if (!string.IsNullOrEmpty(current))
                cbTenPhim.Text = current;

            cbTenPhim.SelectedIndexChanged += CbTenPhim_SelectedIndexChanged;
        }

        private void LoadPhongChieuComboBox()
        {
            string currentMa = (cbPhongChieu.SelectedItem as PhongChieu)?.MaPhong;

            cbPhongChieu.Items.Clear();
            CinemaRepository.DanhSachPhongChieu = PhongChieuRepository.GetAll();

            cbPhongChieu.DisplayMember = "TenPhong";
            cbPhongChieu.ValueMember = "MaPhong";

            foreach (var p in CinemaRepository.DanhSachPhongChieu)
                cbPhongChieu.Items.Add(p);

            if (!string.IsNullOrEmpty(currentMa))
            {
                for (int i = 0; i < cbPhongChieu.Items.Count; i++)
                {
                    if (cbPhongChieu.Items[i] is PhongChieu p && p.MaPhong == currentMa)
                    {
                        cbPhongChieu.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void CbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhVaHienThiGioKetThuc();
        }

        // CONFIG GRID
        private void ConfigureGrid()
        {
            dgr_DS_SuatChieu.AutoGenerateColumns = false;
            dgr_DS_SuatChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgr_DS_SuatChieu.MultiSelect = false;
            dgr_DS_SuatChieu.ReadOnly = true;
            dgr_DS_SuatChieu.AllowUserToAddRows = false;
            dgr_DS_SuatChieu.DataError += (s, e) => e.Cancel = true;
        }

        // LOAD GRID
        private void LoadGrid()
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            dgr_DS_SuatChieu.Rows.Clear();

            var results = data.Where(x => string.IsNullOrEmpty(keyword) || x.TenPhim.ToLower().Contains(keyword)).ToList();

            foreach (var item in results)
            {
                int i = dgr_DS_SuatChieu.Rows.Add(
                    item.MaSuat,
                    item.TenPhim,
                    item.TenPhong,
                    item.NgayChieu.ToString("dd/MM/yyyy"),
                    item.GioBatDau.ToString("HH:mm"),
                    item.GioKetThuc.ToString("HH:mm"),
                    item.GiaVe.ToString("#,##0") + " VNĐ",
                    item.TrangThai
                );
                dgr_DS_SuatChieu.Rows[i].Tag = item.MaSuat;
            }
        }

        // TÍNH GIỜ KẾT THÚC
        private void GioBatDau_ValueChanged(object sender, EventArgs e)
        {
            TinhVaHienThiGioKetThuc();
        }

        private void TinhVaHienThiGioKetThuc()
        {
            if (cbTenPhim.SelectedIndex < 0) return;

            var phim = CinemaRepository.DanhSachPhim.FirstOrDefault(p => p.TenPhim == cbTenPhim.Text);
            if (phim == null) return;

            timeEnd.Value = timeStart.Value.AddMinutes(phim.ThoiLuong);
        }

        // FORMAT GIÁ VÉ
        private void GiaVe_Leave(object sender, EventArgs e)
        {
            string raw = txtGiaVe.Text.Trim().Replace(".", "").Replace(",", "");
            if (decimal.TryParse(raw, out decimal gia) && gia > 0)txtGiaVe.Text = gia.ToString("#,##0");
        }

        // VALIDATION
        private bool ValidateForm(out string err)
        {
            err = string.Empty;

            if (cbTenPhim.SelectedIndex < 0)
            {
                err = "Vui lòng chọn tên phim!";
                return false;
            }

            if (cbPhongChieu.SelectedIndex < 0)
            {
                err = "Vui lòng chọn phòng chiếu!";
                return false;
            }

            var phim = CinemaRepository.DanhSachPhim
                .FirstOrDefault(p => p.TenPhim == cbTenPhim.Text);

            if (phim != null)
            {
                // Kiểm tra trạng thái phim (Ngừng Chiếu / Không Hoạt Động...)
                if (phim.TrangThai == "Ngừng Chiếu" || phim.TrangThai == "Không Hoạt Động")
                {
                    err = $"Phim \"{phim.TenPhim}\" đã ngừng chiếu, không thể tạo suất chiếu!";
                    return false;
                }

                // Kiểm tra ngày chiếu không trước ngày khởi chiếu
                if (dtNgayKhoiChieu.Value.Date < phim.NgayKhoiChieu.Date)
                {
                    err = $"Ngày chiếu không được trước ngày khởi chiếu ({phim.NgayKhoiChieu:dd/MM/yyyy})!";
                    return false;
                }
            }
            return true;
        }

        // BUILD ITEM
        private SuatChieuItem BuildItem(string maSuat)
        {
            string giaRaw = txtGiaVe.Text.Trim().Replace(".", "").Replace(",", "");
            decimal.TryParse(giaRaw, out decimal giaVe);

            var phong = cbPhongChieu.SelectedItem as PhongChieu;
            var phim = CinemaRepository.DanhSachPhim.FirstOrDefault(p => p.TenPhim == cbTenPhim.Text);

            DateTime gioBatDau = dtNgayKhoiChieu.Value.Date + timeStart.Value.TimeOfDay;
            DateTime gioKetThuc = dtNgayKhoiChieu.Value.Date + timeEnd.Value.TimeOfDay;

            var item = new SuatChieuItem
            {
                MaSuat = maSuat,
                MaPhim = phim?.MaPhim ?? "",
                TenPhim = cbTenPhim.Text,
                MaPhong = phong?.MaPhong ?? "",
                TenPhong = phong?.TenPhong ?? cbPhongChieu.Text,
                NgayChieu = dtNgayKhoiChieu.Value.Date,
                GioBatDau = gioBatDau,
                GioKetThuc = gioKetThuc,
                GiaVe = giaVe
            };

            item.TrangThai = TinhTrangThai(item);
            return item;
        }

        // HELPER — CONVERT SANG ITERM
        private SuatChieuIterm ToIterm(SuatChieuItem item)
        {
            return new SuatChieuIterm
            {
                MaSuat = item.MaSuat,
                MaPhim = item.MaPhim,
                MaPhong = item.MaPhong,
                TenPhim = item.TenPhim,
                TenPhong = item.TenPhong,
                GioBatDau = item.GioBatDau,
                GioKetThuc = item.GioKetThuc,
                GiaVe = item.GiaVe,
                TrangThai = item.TrangThai
            };
        }

        // THÊM MỚI
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(out string err)) { ShowWarn(err); return; }

            // Kiểm tra trùng lịch
            DateTime ngay = dtNgayKhoiChieu.Value.Date;
            DateTime batDauMoi = ngay + timeStart.Value.TimeOfDay;
            DateTime ketThucMoi = ngay + timeEnd.Value.TimeOfDay;
            string maPhongChon = (cbPhongChieu.SelectedItem as PhongChieu)?.MaPhong ?? "";

            bool trungLich = data.Any(x =>
                x.MaPhong == maPhongChon &&
                x.NgayChieu.Date == ngay &&
                batDauMoi < x.NgayChieu.Date + x.GioKetThuc.TimeOfDay &&
                ketThucMoi > x.NgayChieu.Date + x.GioBatDau.TimeOfDay
            );

            if (trungLich) { ShowWarn("Phòng chiếu này đã có suất chiếu trùng giờ!"); return; }

            string maMoi = SuatChieuRepository.SinhMaSuatMoi();
            var item = BuildItem(maMoi);

            // Ghi DB trước
            if (!SuatChieuRepository.Insert(ToIterm(item))) return;

            // Thành công → update memory
            data.Add(item);
            CinemaRepository.DanhSachSuatChieu.Add(ToIterm(item));

            LoadGrid();
            ClearForm();
            ShowInfo("Thêm suất chiếu thành công!");
        }

        // CẬP NHẬT
        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (selectedMaSuat == null) { ShowWarn("Vui lòng chọn suất chiếu cần cập nhật!"); return; }
            if (!ValidateForm(out string err)) { ShowWarn(err); return; }

            // Kiểm tra trùng lịch (bỏ qua chính nó)
            DateTime ngay = dtNgayKhoiChieu.Value.Date;
            DateTime batDauMoi = ngay + timeStart.Value.TimeOfDay;
            DateTime ketThucMoi = ngay + timeEnd.Value.TimeOfDay;
            string maPhongChon = (cbPhongChieu.SelectedItem as PhongChieu)?.MaPhong ?? "";

            bool trungLich = data.Any(x =>
                x.MaSuat != selectedMaSuat &&
                x.MaPhong == maPhongChon &&
                x.NgayChieu.Date == ngay &&
                batDauMoi < x.NgayChieu.Date + x.GioKetThuc.TimeOfDay &&
                ketThucMoi > x.NgayChieu.Date + x.GioBatDau.TimeOfDay
            );

            if (trungLich) { ShowWarn("Phòng chiếu này đã có suất chiếu trùng giờ!"); return; }

            int idx = data.FindIndex(x => x.MaSuat == selectedMaSuat);
            if (idx < 0) { ShowWarn("Không tìm thấy dữ liệu!"); return; }

            var updatedItem = BuildItem(selectedMaSuat);

            // Ghi DB trước
            if (!SuatChieuRepository.Update(ToIterm(updatedItem))) return;

            // Thành công → update memory
            data[idx] = updatedItem;

            int ri = CinemaRepository.DanhSachSuatChieu.FindIndex(x => x.MaSuat == selectedMaSuat);
            if (ri >= 0)
                CinemaRepository.DanhSachSuatChieu[ri] = ToIterm(updatedItem);

            LoadGrid();
            ClearForm();
            ShowInfo("Cập nhật suất chiếu thành công!");
        }

        // XÓA
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (selectedMaSuat == null) { ShowWarn("Vui lòng chọn suất chiếu cần xóa!"); return; }

            var item = data.FirstOrDefault(x => x.MaSuat == selectedMaSuat);
            string label = item != null ? $"{item.TenPhim} - {item.NgayChieu:dd/MM/yyyy} {item.GioBatDau:HH:mm}": "";

            if (MessageBox.Show($"Xác nhận xóa \"{label}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            // Ghi DB trước
            if (!SuatChieuRepository.Delete(selectedMaSuat)) return;

            // Thành công → xóa memory
            data.RemoveAll(x => x.MaSuat == selectedMaSuat);
            CinemaRepository.DanhSachSuatChieu.RemoveAll(x => x.MaSuat == selectedMaSuat);

            LoadGrid();
            ClearForm();
            ShowInfo("Xóa suất chiếu thành công!");
        }

        // LÀM MỚI
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            txtTimKiem.Clear();
            LoadFromDb();
        }

        // TÌM KIẾM
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        // CLICK DÒNG GRID
        private void dgr_DS_SuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgr_DS_SuatChieu.Rows[e.RowIndex];
            if (row.Tag is string ma)
                selectedMaSuat = ma;

            var item = data.FirstOrDefault(x => x.MaSuat == selectedMaSuat);
            if (item == null) return;

            cbTenPhim.Text = item.TenPhim;

            for (int i = 0; i < cbPhongChieu.Items.Count; i++)
            {
                if (cbPhongChieu.Items[i] is PhongChieu p && p.MaPhong == item.MaPhong)
                {
                    cbPhongChieu.SelectedIndex = i;
                    break;
                }
            }

            dtNgayKhoiChieu.Value = item.NgayChieu;

            // Tắt event tránh tính lại giờ kết thúc khi đang load
            timeStart.ValueChanged -= GioBatDau_ValueChanged;
            timeStart.Value = item.GioBatDau;
            timeEnd.Value = item.GioKetThuc;
            timeStart.ValueChanged += GioBatDau_ValueChanged;

            txtGiaVe.Text = item.GiaVe.ToString("#,##0");
        }

        // CLEAR FORM
        private void ClearForm()
        {
            selectedMaSuat = null;

            timeStart.ValueChanged -= GioBatDau_ValueChanged;
            cbTenPhim.SelectedIndexChanged -= CbTenPhim_SelectedIndexChanged;

            cbTenPhim.SelectedIndex = -1;
            cbPhongChieu.SelectedIndex = -1;
            dtNgayKhoiChieu.Value = DateTime.Now;
            timeStart.Value = DateTime.Now;
            timeEnd.Value = DateTime.Now;
            txtGiaVe.Text = string.Empty;
            dgr_DS_SuatChieu.ClearSelection();

            timeStart.ValueChanged += GioBatDau_ValueChanged;
            cbTenPhim.SelectedIndexChanged += CbTenPhim_SelectedIndexChanged;
        }

        // XUẤT EXCEL
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ShowInfo("Chức năng xuất Excel sẽ được tích hợp sau!");
        }

        // HELPERS
        private void ShowInfo(string msg) =>
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowWarn(string msg) =>
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}