using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCinema_Manager.Model;

namespace SmartCinema_Manager.Repositories
{
    public class ThucPhamRepository
    {
        // =========================
        // GET ALL
        // =========================
        public static List<SanPham> GetAll()
        {
            var list = new List<SanPham>();
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT MaThucPham, TenThucPham,
                               GiaTien, LoaiTP, TrangThai, HinhAnhTP, SoLuongTon
                        FROM THUC_PHAM";

                    using (var cmd = new SqlCommand(sql, conn))
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            list.Add(new SanPham
                            {
                                MaThucPham = rd["MaThucPham"].ToString(),
                                TenSanPham = rd["TenThucPham"].ToString(),
                                GiaTien = rd["GiaTien"] == DBNull.Value
                                                ? 0 : Convert.ToDecimal(rd["GiaTien"]),
                                Loai = ParseLoai(rd["LoaiTP"]),
                                TrangThai = rd["TrangThai"] == DBNull.Value
                                                ? "Đang bán" : rd["TrangThai"].ToString(),
                                HinhAnh = rd["HinhAnhTP"] == DBNull.Value
                                                ? null : rd["HinhAnhTP"].ToString(),
                                SoLuong = rd["SoLuongTon"] == DBNull.Value
                                                ? 0 : Convert.ToInt32(rd["SoLuongTon"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi tải sản phẩm: " + ex.Message, "DB Error");
            }
            return list;
        }

        // =========================
        // INSERT
        // =========================
        public static bool Insert(SanPham p)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO THUC_PHAM
                            (MaThucPham, TenThucPham, GiaTien,
                             LoaiTP, TrangThai, HinhAnhTP, SoLuongTon)
                        VALUES
                            (@Ma, @Ten, @Gia,
                             @Loai, @TrangThai, @HinhAnh, @SoLuongTon)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ma", p.MaThucPham);
                        cmd.Parameters.AddWithValue("@Ten", p.TenSanPham);
                        cmd.Parameters.AddWithValue("@Gia", p.GiaTien);
                        cmd.Parameters.AddWithValue("@Loai", LoaiToString(p.Loai));
                        cmd.Parameters.AddWithValue("@TrangThai", (object)p.TrangThai ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HinhAnh", (object)p.HinhAnh ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoLuongTon", p.SoLuong);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi thêm sản phẩm: " + ex.Message, "DB Error");
                return false;
            }
        }

        // =========================
        // UPDATE
        // =========================
        public static bool Update(SanPham p)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE THUC_PHAM SET
                            TenThucPham = @Ten,
                            GiaTien     = @Gia,
                            LoaiTP        = @Loai,
                            TrangThai   = @TrangThai,
                            HinhAnhTP     = @HinhAnh,
                            SoLuongTon  = @SoLuongTon
                        WHERE MaThucPham = @Ma";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ma", p.MaThucPham);
                        cmd.Parameters.AddWithValue("@Ten", p.TenSanPham);
                        cmd.Parameters.AddWithValue("@Gia", p.GiaTien);
                        cmd.Parameters.AddWithValue("@Loai", LoaiToString(p.Loai));
                        cmd.Parameters.AddWithValue("@TrangThai", (object)p.TrangThai ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HinhAnh", (object)p.HinhAnh ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoLuongTon", p.SoLuong);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi cập nhật sản phẩm: " + ex.Message, "DB Error");
                return false;
            }
        }

        // =========================
        // DELETE
        // =========================
        public static bool Delete(string ma)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM THUC_PHAM WHERE MaThucPham = @Ma";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ma", ma);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi xóa sản phẩm: " + ex.Message, "DB Error");
                return false;
            }
        }

        // =========================
        // SINH MÃ
        // =========================
        public static string SinhMaMoi()
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT ISNULL(MAX(CAST(SUBSTRING(MaThucPham,3,LEN(MaThucPham)) AS INT)),0)
                        FROM THUC_PHAM
                        WHERE MaThucPham LIKE 'TP%'
                          AND ISNUMERIC(SUBSTRING(MaThucPham,3,LEN(MaThucPham))) = 1";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        int max = Convert.ToInt32(cmd.ExecuteScalar());
                        return "TP" + (max + 1).ToString("D3");
                    }
                }
            }
            catch
            {
                return "TP" + DateTime.Now.Ticks.ToString().Substring(10, 5);
            }
        }

        // =========================
        // HELPERS LOẠI
        // =========================
        private static int ParseLoai(object val)
        {
            if (val == DBNull.Value || val == null) return LoaiSanPham.Nuoc;
            string s = val.ToString();
            switch (s)
            {
                case "Bắp": return LoaiSanPham.Bap;
                case "Combo bắp nước": return LoaiSanPham.ComboNuoc;
                default: return LoaiSanPham.Nuoc;
            }
        }

        private static string LoaiToString(int loai)
        {
            switch (loai)
            {
                case LoaiSanPham.Bap: return "Bắp";
                case LoaiSanPham.ComboNuoc: return "Combo bắp nước";
                default: return "Nước";
            }
        }
    }
}