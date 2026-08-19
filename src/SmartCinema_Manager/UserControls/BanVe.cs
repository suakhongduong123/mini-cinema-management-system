using SmartCinema_Manager.Controls;
using SmartCinema_Manager.Model;
using SmartCinema_Manager.Repositories;
using SmartCinema_Manager.Repositories.Sql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartCinema_Manager.UserControls
{
    public partial class BanVe : UserControl
    {
        private SeatMapControl seatMap;
        private List<Model.SanPham> dsDichVu = new List<Model.SanPham>();
        private List<BillItem> dsBill = new List<BillItem>();

        public BanVe()
        {
            InitializeComponent();
            InitSeatMap();
            KhoiTaoGridMovie();
            KhoiTaoGridBill();

            SanPham.onDanhSachThayDoi += NhanDuLieuDichVu;
            this.VisibleChanged += (s, e) =>
            {
                if (!this.Visible) return;
                LoadSuatChieu();

                // Luôn load lại từ DB mỗi lần vào tab
                var dsFromDb = ThucPhamRepository.GetAll()
                    .Where(x => x.TrangThai == "Đang bán").ToList();
                dsDichVu = dsFromDb;
                LoadFoodControls(dsFromDb);
            };

        }

        // KHỞI TẠO SƠ ĐỒ GHẾ
        private void InitSeatMap()
        {
            seatMap = new SeatMapControl();
            seatMap.Dock = DockStyle.Fill;
            seatMap.BackColor = Color.White;
            pnlSeat.Controls.Add(seatMap);
            seatMap.LoadSeats();
            seatMap.SelectionChanged += SeatMap_SelectionChanged;
        }

        private void SeatMap_SelectionChanged(object sender, EventArgs e) { }

        public void LoadSeatMap(List<string> soldSeats) => seatMap.LoadSeats(soldSeats);

        // LOAD SUẤT CHIẾU
        private void LoadSuatChieu()
        {
            dgrView_movie.Rows.Clear();

            foreach (var sc in CinemaRepository.DanhSachSuatChieu)
            {
                var phim = CinemaRepository.DanhSachPhim.FirstOrDefault(p => p.TenPhim == sc.TenPhim);

                int rowIdx = dgrView_movie.Rows.Add(
                    sc.TenPhim,
                    sc.TenPhong,
                    sc.NgayChieu.ToString("dd/MM/yyyy"),
                    sc.GioBatDau.ToString("HH:mm"),
                    (phim?.ThoiLuong.ToString() ?? "?") + " phút",
                    sc.GiaVe.ToString("#,##0") + " VNĐ"
                );
                dgrView_movie.Rows[rowIdx].Tag = sc;
            }
        }

        // NHẬN DỮ LIỆU SẢN PHẨM sau đó  LOAD FOOD CONTROLS
        private void NhanDuLieuDichVu(List<Model.SanPham> ds)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<List<Model.SanPham>>(NhanDuLieuDichVu), ds);
                return;
            }

            dsDichVu = ds;
            LoadFoodControls(ds);
        }

        private void LoadFoodControls(List<Model.SanPham> ds)
        {
            pnlFood.Controls.Clear();

            if (pnlFood is FlowLayoutPanel flow)
            {
                flow.FlowDirection = FlowDirection.TopDown;  
                flow.WrapContents = false;                
                flow.AutoScroll = true;
            }

            var foods = ds.Where(x =>
                (x.Loai == LoaiSanPham.Nuoc ||
                 x.Loai == LoaiSanPham.Bap ||
                 x.Loai == LoaiSanPham.ComboNuoc) &&
                x.TrangThai == "Đang bán"
            ).ToList();

            int margin = 6;
            int itemW = pnlFood.ClientSize.Width - margin * 2; 
            int itemH = 225;

            foreach (var sp in foods)
            {
                var fc = new FoodControl();
                fc.LoadData(sp);
                fc.Size = new Size(itemW, itemH);
                fc.Margin = new Padding(margin, margin, margin, 0);

                fc.OnAddToCart += (s, sanPham) => ThemDichVuVaoBill(sanPham);
                pnlFood.Controls.Add(fc);
            }
        }
        // THÊM ĐỒ ĂN VÀO BILL
        private void ThemDichVuVaoBill(Model.SanPham sp)
        {
            // Nếu đã có trong bill thì tăng số lượng
            var existing = dsBill.FirstOrDefault(x => x.TenSanPham == sp.TenSanPham);
            if (existing != null)
            {
                existing.SoLuong++;
            }
            else
            {
                dsBill.Add(new BillItem
                {
                    TenSanPham = sp.TenSanPham,
                    GiaTien = sp.GiaTien,
                    SoLuong = 1
                });
            }

            RefreshGridViewBill();
        }

        // NÚT THÊM VÉ VÀO BILL
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgrView_movie.CurrentRow == null)
            {
                ShowWarn("Vui lòng chọn suất chiếu!");
                return;
            }

            List<string> dsGhe = seatMap.GetSelectedSeats();
            if (dsGhe == null || dsGhe.Count == 0)
            {
                ShowWarn("Vui lòng chọn ít nhất 1 ghế!");
                return;
            }

            var sc = dgrView_movie.CurrentRow.Tag as SuatChieuIterm;
            if (sc == null) return;

            // Xóa vé cũ nếu có (chọn lại suất chiếu)
            dsBill.RemoveAll(x => x.TenSanPham.StartsWith("Vé:"));

            dsBill.Insert(0, new BillItem
            {
                TenSanPham = $"Vé: {sc.TenPhim} [{string.Join(", ", dsGhe)}]",
                GiaTien = sc.GiaVe,
                SoLuong = dsGhe.Count
            });

            RefreshGridViewBill();
        }

        // HIỂN THỊ HÓA ĐƠN
        private void RefreshGridViewBill()
        {
            dgrBill_Movie.Rows.Clear();
            decimal tongTien = 0;

            foreach (var item in dsBill)
            {
                decimal thanhTien = item.GiaTien * item.SoLuong;
                tongTien += thanhTien;

                dgrBill_Movie.Rows.Add(
                    item.TenSanPham,
                    item.GiaTien.ToString("#,##0") + " VNĐ",
                    item.SoLuong,
                    thanhTien.ToString("#,##0") + " VNĐ"
                );
            }

            lblTitle1.Text = "Tổng tiền: " + tongTien.ToString("#,##0") + " VNĐ";
        }

        // THANH TOÁN
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dsBill.Count == 0) { ShowWarn("Hóa đơn đang trống!"); return; }
            if (string.IsNullOrEmpty(cbTypesPay.Text)) { ShowWarn("Vui lòng chọn phương thức thanh toán!"); return; }
            if (maSuatDangChon == null) { ShowWarn("Không xác định được suất chiếu!"); return; }

            // Lấy danh sách ghế từ bill (dòng bắt đầu bằng "Vé:")
            var veItem = dsBill.FirstOrDefault(x => x.TenSanPham.StartsWith("Vé:"));
            if (veItem == null) { ShowWarn("Chưa có vé trong hóa đơn!"); return; }

            // Parse ghế từ chuỗi "Vé: TênPhim [A1, B2, C3]"
            var dsGhe = seatMap.GetSelectedSeats();
            if (dsGhe.Count == 0) { ShowWarn("Không tìm thấy ghế đã chọn!"); return; }

            // Xác định loại vé theo ghế (J = VIP, A-D = Gray, còn lại = thường)
            // Lưu từng ghế vào VE_PHIM
            bool saved = VePhimRepository.InsertNhieuVe(
                maSuat: maSuatDangChon,
                maHD: null,        // nếu có bảng hóa đơn thì truyền mã HĐ vào đây
                dsGhe: dsGhe,
                loaiVe: "Thường"   // hoặc logic phân loại VIP/Thường tùy bạn
            );

            if (!saved) return; // InsertNhieuVe đã show lỗi rồi

            decimal tongTien = dsBill.Sum(x => x.GiaTien * x.SoLuong);
            ShowInfo(
                $"Thanh toán thành công!\n" +
                $"Tổng tiền: {tongTien:#,##0} VNĐ\n" +
                $"Phương thức: {cbTypesPay.Text}");

            // Reset bill
            dsBill.Clear();
            dgrBill_Movie.Rows.Clear();
            lblTitle1.Text = "Tổng tiền: 0 VNĐ";

            // Reload ma trận — dùng maSuatDangChon để hiển thị ghế vừa bán
            var soldSeats = VePhimRepository.GetSoldSeats(maSuatDangChon);
            seatMap.LoadSeats(soldSeats);
            // Không reset maSuatDangChon để user còn bán tiếp ghế khác cùng suất
        }

        // IN HÓA ĐƠN
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ShowInfo("Chức năng in hóa đơn sẽ được tích hợp sau!");
        }

        // CONFIG GRID
        private void KhoiTaoGridMovie()
        {
            dgrView_movie.AutoGenerateColumns = false;
            dgrView_movie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrView_movie.MultiSelect = false;
            dgrView_movie.ReadOnly = true;
            dgrView_movie.AllowUserToAddRows = false;
        }

        private void KhoiTaoGridBill()
        {
            dgrBill_Movie.AutoGenerateColumns = false;
            dgrBill_Movie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrBill_Movie.MultiSelect = false;
            dgrBill_Movie.ReadOnly = true;
            dgrBill_Movie.AllowUserToAddRows = false;
        }

        private void BanVeControl3_Load(object sender, EventArgs e) { }

        private void ShowInfo(string msg) =>
            MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowWarn(string msg) =>
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        // Thêm field này vào đầu class, cạnh các field hiện có
        private string maSuatDangChon = null;

        private void dgrView_movie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var sc = dgrView_movie.Rows[e.RowIndex].Tag as SuatChieuIterm;
            if (sc == null) return;

            // Lưu lại suất đang chọn
            maSuatDangChon = sc.MaSuat;

            // Load ghế đã bán từ DB theo suất này
            var soldSeats = VePhimRepository.GetSoldSeats(sc.MaSuat);
            seatMap.LoadSeats(soldSeats);

            // Xóa vé cũ trong bill khi đổi suất
            dsBill.RemoveAll(x => x.TenSanPham.StartsWith("Vé:"));
            RefreshGridViewBill();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            ShowInfo("Chức năng sẽ được tích hợp sau!");
        }
    }
}