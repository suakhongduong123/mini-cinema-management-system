using System.Collections.Generic;
using SmartCinema_Manager.Model;


namespace SmartCinema_Manager.Repositories
{
    public static class CinemaRepository
    {
        public static List<SanPham> DanhSachSanPham = new List<SanPham>();
        public static List<SuatChieuIterm> DanhSachSuatChieu = new List<SuatChieuIterm>();
        public static List<PhimIterm> DanhSachPhim = new List<PhimIterm>();
        public static List<PhongChieu> DanhSachPhongChieu = new List<PhongChieu>();
        
        /// Gọi 1 lần khi app khởi động để load DB vào memory.
        public static void LoadFromDatabase()
        {
            DanhSachPhim = PhimRepository.GetAll();
            DanhSachPhongChieu = PhongChieuRepository.GetAll();
            DanhSachSuatChieu = SuatChieuRepository.GetAll();
            DanhSachSanPham = ThucPhamRepository.GetAll();
        }
    }
}