using System;

namespace SmartCinema_Manager.Model
{
    // LOẠI SẢN PHẨM
    public static class LoaiSanPham
    {
        public const int Nuoc = 2;
        public const int Bap = 3;
        public const int ComboNuoc = 4;
    }

    // SẢN PHẨM
    public class SanPham
    {
        public string MaThucPham { get; set; }
        public string TenSanPham { get; set; }
        public decimal GiaTien { get; set; }
        public int Loai { get; set; }
        public string TrangThai { get; set; }
        public String HinhAnh { get; set; }
        public int SoLuong { get; set; }
        public override string ToString() => TenSanPham;
    }

    // HÓA ĐƠN
    public class BillItem
    {
        public string TenSanPham { get; set; }

        public decimal GiaTien { get; set; }

        public int SoLuong { get; set; }

        public decimal TongTien
        {
            get
            {
                return GiaTien * SoLuong;
            }
        }
    }

    // PHIM
    public class PhimIterm
    {
        public String MaPhim { get; set; }

        public string TenPhim { get; set; }

        public string TheLoai { get; set; }

        public int ThoiLuong { get; set; }

        public DateTime NgayKhoiChieu { get; set; }
        public string Mota { get; set; }
        public string TrangThai { get; set; }

        public string HinhAnh { get; set; }
    }
    //  PHONG CHIEU
    public class PhongChieu
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public int SoLuongGhe { get; set; }
        public override string ToString() => TenPhong;
    }
    //SUAT CHIEU 
    public class SuatChieuIterm
    {
        public String MaSuat { get; set; } //SC001 SC002 SC003
        public string MaPhim { get; set; } // Khoa ngoai
        public string MaPhong { get; set; } // Khoa ngoai
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
        public decimal GiaVe { get; set; }

        // tính từ GioBatDau - không lưu DB
        public DateTime NgayChieu => GioBatDau.Date;

        //Join từ bảng khác - không lưu DB
        public string TenPhim { get; set; } 
        public string TenPhong { get; set; } 
        public string TrangThai { get; set; }
    }

    // TÀI KHOẢN
    public class TaiKhoan
    {
        public int MaTK { get; set; }      
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int PhanLoai { get; set; }
        // PhanLoai: 1=Admin, 2=GiamSat, 3=NhanVien
        public DateTime NgayDK { get; set; }

        public bool IsAdmin => PhanLoai == 1;
        public bool IsGiamSat => PhanLoai == 2;
        public bool IsNhanVien => PhanLoai == 3;
    }
}