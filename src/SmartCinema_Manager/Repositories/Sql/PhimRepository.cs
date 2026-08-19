using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using SmartCinema_Manager.Model;

namespace SmartCinema_Manager.Repositories
{
    internal class PhimRepository
    {
        public static List<PhimIterm> GetAll()
        {
            var list = new List<PhimIterm>();

            using (var conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT MaPhim, TenPhim, TheLoai,
                           NgayKhoiChieu, DoTuoi, MoTa,
                           ThoiLuong, HinhAnh
                    FROM PHIM";

                using (var cmd = new SqlCommand(sql, conn))
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        var item = new PhimIterm
                        {
                            MaPhim = rd["MaPhim"].ToString(),
                            TenPhim = rd["TenPhim"].ToString(),
                            TheLoai = rd["TheLoai"] == DBNull.Value
                                                ? "" : rd["TheLoai"].ToString(),
                            NgayKhoiChieu = rd["NgayKhoiChieu"] == DBNull.Value
                                                ? DateTime.Now
                                                : Convert.ToDateTime(rd["NgayKhoiChieu"]),
                            ThoiLuong = rd["ThoiLuong"] == DBNull.Value
                                                ? 0
                                                : Convert.ToInt32(rd["ThoiLuong"]),
                            Mota = rd["MoTa"] == DBNull.Value
                                                ? "" : rd["MoTa"].ToString(),
                            // DB chưa có TrangThai → mặc định
                            TrangThai = "Đang chiếu",
                            HinhAnh = rd["HinhAnh"] == DBNull.Value ? null : rd["HinhAnh"].ToString()
                        };
                        list.Add(item);
                    }
                }
            }

            return list;
        }

        // INSERT
        public static bool Insert(PhimIterm p)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO PHIM
                            (MaPhim, TenPhim, TheLoai,
                             NgayKhoiChieu, DoTuoi, MoTa,
                             ThoiLuong, HinhAnh,TrangThai)
                        VALUES
                            (@MaPhim, @TenPhim, @TheLoai,
                             @NgayKhoiChieu, @DoTuoi, @MoTa,
                             @ThoiLuong, @HinhAnh, @TrangThai)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhim", p.MaPhim);
                        cmd.Parameters.AddWithValue("@TenPhim", p.TenPhim);
                        cmd.Parameters.AddWithValue("@TheLoai", (object)p.TheLoai ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgayKhoiChieu", (object)p.NgayKhoiChieu ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@DoTuoi", DBNull.Value); 
                        cmd.Parameters.AddWithValue("@MoTa", (object)p.Mota ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ThoiLuong", p.ThoiLuong == 0? (object)DBNull.Value: (object)p.ThoiLuong);
                        cmd.Parameters.AddWithValue("@HinhAnh", (object)p.HinhAnh ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TrangThai", (object)p.TrangThai ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi thêm phim: " + ex.Message, "DB Error");
                return false;
            }
        }

        // UPDATE
        public static bool Update(PhimIterm p)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE PHIM SET
                            TenPhim       = @TenPhim,
                            TheLoai       = @TheLoai,
                            NgayKhoiChieu = @NgayKhoiChieu,
                            MoTa          = @MoTa,
                            ThoiLuong     = @ThoiLuong,
                            HinhAnh       = @HinhAnh,
                            TrangThai     = @TrangThai
                        WHERE MaPhim = @MaPhim";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhim", p.MaPhim);
                        cmd.Parameters.AddWithValue("@TenPhim", p.TenPhim);
                        cmd.Parameters.AddWithValue("@TheLoai", (object)p.TheLoai ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@NgayKhoiChieu", (object)p.NgayKhoiChieu ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@MoTa", (object)p.Mota ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@ThoiLuong", p.ThoiLuong == 0 ? (object)DBNull.Value : (object)p.ThoiLuong);
                        cmd.Parameters.AddWithValue("@HinhAnh", (object)p.HinhAnh ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@TrangThai", (object)p.TrangThai ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi cập nhật phim: " + ex.Message, "DB Error");
                return false;
            }
        }

        // DELETE
        public static bool Delete(string maPhim)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM PHIM WHERE MaPhim = @MaPhim";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhim", maPhim);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi xóa phim: " + ex.Message, "DB Error");
                return false;
            }
        }

        // SINH MÃ PHIM TỰ ĐỘNG
        /// Truy vấn MaPhim lớn nhất trong DB rồi tăng lên 1.
        /// Định dạng: "P001", "P002", ...
        public static string SinhMaPhimMoi()
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    // Lấy số lớn nhất từ phần sau chữ "P"
                    string sql = @"
                        SELECT ISNULL(MAX(CAST(SUBSTRING(MaPhim,2,LEN(MaPhim)) AS INT)), 0)
                        FROM PHIM
                        WHERE MaPhim LIKE 'P%'
                          AND ISNUMERIC(SUBSTRING(MaPhim,2,LEN(MaPhim))) = 1";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        int max = Convert.ToInt32(cmd.ExecuteScalar());
                        return "P" + (max + 1).ToString("D3");
                    }
                }
            }
            catch
            {
                // Nếu DB lỗi, fallback về timestamp
                return "P" + DateTime.Now.Ticks.ToString().Substring(10, 5);
            }
        }
    }
}
