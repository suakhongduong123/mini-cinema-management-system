using SmartCinema_Manager.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SmartCinema_Manager.Repositories
{
    public class SuatChieuRepository
    {
        // =========================
        // GET ALL
        // =========================
        public static List<SuatChieuIterm> GetAll()
        {
            var list = new List<SuatChieuIterm>();
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT 
                            sc.MaSuat, sc.MaPhim, sc.MaPhong,
                            sc.ThoiGianBatDau, sc.ThoiGianKetThuc,
                            sc.GiaVeStandard,
                            p.TenPhim, pc.TenPhong
                        FROM SUAT_CHIEU sc
                        LEFT JOIN PHIM        p  ON sc.MaPhim  = p.MaPhim
                        LEFT JOIN PHONG_CHIEU pc ON sc.MaPhong = pc.MaPhong
                        ORDER BY sc.ThoiGianBatDau";

                    using (var cmd = new SqlCommand(sql, conn))       // ← using
                    using (var rd = cmd.ExecuteReader())              // ← using
                    {
                        while (rd.Read())
                            list.Add(DocSuatChieu(rd));
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi load suất chiếu: " + ex.Message, "DB Error");
            }
            return list;
        }

        // =========================
        // INSERT
        // =========================
        public static bool Insert(SuatChieuIterm sc)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO SUAT_CHIEU
                            (MaSuat, MaPhim, MaPhong,
                             ThoiGianBatDau, ThoiGianKetThuc, GiaVeStandard)
                        VALUES
                            (@MaSuat, @MaPhim, @MaPhong,
                             @ThoiGianBatDau, @ThoiGianKetThuc, @GiaVeStandard)";

                    using (var cmd = new SqlCommand(sql, conn))       // ← using
                    {
                        cmd.Parameters.AddWithValue("@MaSuat", sc.MaSuat);
                        cmd.Parameters.AddWithValue("@MaPhim", sc.MaPhim);
                        cmd.Parameters.AddWithValue("@MaPhong", sc.MaPhong);
                        cmd.Parameters.AddWithValue("@ThoiGianBatDau", sc.GioBatDau);
                        cmd.Parameters.AddWithValue("@ThoiGianKetThuc", sc.GioKetThuc);
                        cmd.Parameters.AddWithValue("@GiaVeStandard", sc.GiaVe);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi thêm suất chiếu: " + ex.Message, "DB Error");
                return false;
            }
        }

        // =========================
        // UPDATE
        // =========================
        public static bool Update(SuatChieuIterm sc)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE SUAT_CHIEU SET
                            MaPhim          = @MaPhim,
                            MaPhong         = @MaPhong,
                            ThoiGianBatDau  = @ThoiGianBatDau,
                            ThoiGianKetThuc = @ThoiGianKetThuc,
                            GiaVeStandard   = @GiaVeStandard
                        WHERE MaSuat = @MaSuat";

                    using (var cmd = new SqlCommand(sql, conn))       // ← using
                    {
                        cmd.Parameters.AddWithValue("@MaSuat", sc.MaSuat);
                        cmd.Parameters.AddWithValue("@MaPhim", sc.MaPhim);
                        cmd.Parameters.AddWithValue("@MaPhong", sc.MaPhong);
                        cmd.Parameters.AddWithValue("@ThoiGianBatDau", sc.GioBatDau);
                        cmd.Parameters.AddWithValue("@ThoiGianKetThuc", sc.GioKetThuc);
                        cmd.Parameters.AddWithValue("@GiaVeStandard", sc.GiaVe);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi cập nhật suất chiếu: " + ex.Message, "DB Error");
                return false;
            }
        }

        // =========================
        // DELETE
        // =========================
        public static bool Delete(string maSuat)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM SUAT_CHIEU WHERE MaSuat = @MaSuat";

                    using (var cmd = new SqlCommand(sql, conn))       // ← using
                    {
                        cmd.Parameters.AddWithValue("@MaSuat", maSuat);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi xóa suất chiếu: " + ex.Message, "DB Error");
                return false;
            }
        }

        // =========================
        // SINH MÃ
        // =========================
        public static string SinhMaSuatMoi()
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT ISNULL(
                            MAX(CAST(SUBSTRING(MaSuat,3,LEN(MaSuat)) AS INT))
                        ,0) FROM SUAT_CHIEU
                        WHERE MaSuat LIKE 'SC%'
                          AND ISNUMERIC(SUBSTRING(MaSuat,3,LEN(MaSuat))) = 1";

                    using (var cmd = new SqlCommand(sql, conn))       // ← using
                    {
                        int max = Convert.ToInt32(cmd.ExecuteScalar());
                        return $"SC{(max + 1):000}";
                    }
                }
            }
            catch
            {
                return "SC" + DateTime.Now.Ticks.ToString().Substring(10, 5);
            }
        }

        // =========================
        // HELPER
        // =========================
        private static SuatChieuIterm DocSuatChieu(SqlDataReader r)
        {
            return new SuatChieuIterm
            {
                MaSuat = r["MaSuat"].ToString(),
                MaPhim = r["MaPhim"].ToString(),
                MaPhong = r["MaPhong"].ToString(),
                GioBatDau = Convert.ToDateTime(r["ThoiGianBatDau"]),
                GioKetThuc = Convert.ToDateTime(r["ThoiGianKetThuc"]),
                GiaVe = Convert.ToDecimal(r["GiaVeStandard"]),
                TenPhim = r["TenPhim"] == DBNull.Value ? "" : r["TenPhim"].ToString(),
                TenPhong = r["TenPhong"] == DBNull.Value ? "" : r["TenPhong"].ToString()
            };
        }
    }
}