using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartCinema_Manager.Repositories.Sql
{
    public class VePhimRepository
    {
        // Lấy ghế đã bán theo suất chiếu
        public static List<string> GetSoldSeats(string maSuat)
        {
            var list = new List<string>();
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT SoGhe FROM VE_PHIM WHERE MaSuat = @MaSuat";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSuat", maSuat);
                        using (var rd = cmd.ExecuteReader())
                            while (rd.Read())
                                list.Add(rd["SoGhe"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy ghế đã bán: " + ex.Message);
            }
            return list;
        }

        // Sinh mã vé tự động: MV001, MV002, ...
        public static string SinhMaVeMoi()
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT ISNULL(MAX(CAST(SUBSTRING(MaVe,3,LEN(MaVe)) AS INT)),0)
                        FROM VE_PHIM
                        WHERE MaVe LIKE 'MV%'
                          AND ISNUMERIC(SUBSTRING(MaVe,3,LEN(MaVe))) = 1";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        int max = Convert.ToInt32(cmd.ExecuteScalar());
                        return "MV" + (max + 1).ToString("D3");
                    }
                }
            }
            catch
            {
                return "MV" + DateTime.Now.Ticks.ToString().Substring(10, 5);
            }
        }

        // Lưu 1 ghế vào VE_PHIM (mỗi ghế = 1 row)
        // MaHD: mã hóa đơn (có thể null nếu chưa có bảng HĐ)
        public static bool InsertVe(string maVe, string maSuat, string maHD, string soGhe, string loaiVe)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO VE_PHIM (MaVe, MaSuat, MaHD, LoaiVe, SoGhe)
                        VALUES (@MaVe, @MaSuat, @MaHD, @LoaiVe, @SoGhe)";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaVe", maVe);
                        cmd.Parameters.AddWithValue("@MaSuat", maSuat);
                        cmd.Parameters.AddWithValue("@MaHD", (object)maHD ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoaiVe", (object)loaiVe ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@SoGhe", soGhe);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu vé: " + ex.Message);
                return false;
            }
        }

        // Lưu nhiều ghế cùng 1 lúc (dùng transaction)
        public static bool InsertNhieuVe(string maSuat, string maHD, List<string> dsGhe, string loaiVe)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();

                    // Lấy số thứ tự lớn nhất 1 lần duy nhất
                    string sqlMax = @"
                SELECT ISNULL(MAX(CAST(SUBSTRING(MaVe,3,LEN(MaVe)) AS INT)),0)
                FROM VE_PHIM
                WHERE MaVe LIKE 'MV%'
                  AND ISNUMERIC(SUBSTRING(MaVe,3,LEN(MaVe))) = 1";

                    int max;
                    using (var cmdMax = new SqlCommand(sqlMax, conn))
                        max = Convert.ToInt32(cmdMax.ExecuteScalar());

                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            string sql = @"
                        INSERT INTO VE_PHIM (MaVe, MaSuat, MaHD, LoaiVe, SoGhe)
                        VALUES (@MaVe, @MaSuat, @MaHD, @LoaiVe, @SoGhe)";

                            for (int i = 0; i < dsGhe.Count; i++)
                            {
                                string maVe = "MV" + (max + 1 + i).ToString("D3");

                                using (var cmd = new SqlCommand(sql, conn, tran))
                                {
                                    cmd.Parameters.AddWithValue("@MaVe", maVe);
                                    cmd.Parameters.AddWithValue("@MaSuat", maSuat);
                                    cmd.Parameters.AddWithValue("@MaHD", (object)maHD ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@LoaiVe", (object)loaiVe ?? DBNull.Value);
                                    cmd.Parameters.AddWithValue("@SoGhe", dsGhe[i]);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            tran.Commit();
                            return true;
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu nhiều vé: " + ex.Message);
                return false;
            }
        }
    }
}