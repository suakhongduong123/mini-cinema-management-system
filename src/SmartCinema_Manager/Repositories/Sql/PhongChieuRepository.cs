using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SmartCinema_Manager.Model;

namespace SmartCinema_Manager.Repositories
{
    public class PhongChieuRepository
    {
        public static List<PhongChieu> GetAll()
        {
            var list = new List<PhongChieu>();
            using (var conn = DataBaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(
                    "SELECT MaPhong, TenPhong, SoLuongGhe FROM PHONG_CHIEU", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new PhongChieu
                    {
                        MaPhong = reader["MaPhong"].ToString(),
                        TenPhong = reader["TenPhong"].ToString(),
                        SoLuongGhe = reader["SoLuongGhe"] == DBNull.Value
                                     ? 0
                                     : Convert.ToInt32(reader["SoLuongGhe"])
                    });
                }
            }
            return list;
        }
        public static bool Insert(PhongChieu p)
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"
                        INSERT INTO PHONG_CHIEU (MaPhong, TenPhong, SoLuongGhe)
                        VALUES (@MaPhong, @TenPhong, @SoLuongGhe)", conn);

                    cmd.Parameters.AddWithValue("@MaPhong", p.MaPhong);
                    cmd.Parameters.AddWithValue("@TenPhong", p.TenPhong);
                    cmd.Parameters.AddWithValue("@SoLuongGhe",
                        p.SoLuongGhe == 0 ? (object)DBNull.Value : p.SoLuongGhe);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Lỗi thêm phòng chiếu: " + ex.Message, "DB Error");
                return false;
            }
        }
        public static string SinhMaPhongMoi()
        {
            try
            {
                using (var conn = DataBaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"
                        SELECT ISNULL(
                            MAX(CAST(SUBSTRING(MaPhong,3,LEN(MaPhong)) AS INT))
                        ,0) FROM PHONG_CHIEU
                        WHERE MaPhong LIKE 'PC%'
                          AND ISNUMERIC(SUBSTRING(MaPhong,3,LEN(MaPhong))) = 1", conn);

                    int max = Convert.ToInt32(cmd.ExecuteScalar());
                    return $"PC{(max + 1):000}"; // PC001, PC002...
                }
            }
            catch
            {
                return "PC" + DateTime.Now.Ticks.ToString().Substring(10, 5);
            }
        }
    }
}
