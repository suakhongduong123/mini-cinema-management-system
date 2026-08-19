using SmartCinema_Manager.Model;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace SmartCinema_Manager.Repositories.Sql
{
    internal class TaiKhoanRepository
    {
        private string HashSHA256(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("X2")); // uppercase hex, giống SQL
                return sb.ToString();
            }
        }
        public TaiKhoan Login(string email, string matKhau)
        {
            using (var conn = DataBaseHelper.GetConnection()) 
            {
                conn.Open();
                var cmd = new SqlCommand(@"
            SELECT MaTK, Email, MatKhau, PhanLoai, NgayDK
            FROM TAI_KHOAN
            WHERE Email   = @Email
              AND MatKhau = @MatKhau", conn);

                cmd.Parameters.AddWithValue("@Email", email.Trim());
                cmd.Parameters.AddWithValue("@MatKhau", HashSHA256(matKhau.Trim()));

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new TaiKhoan
                    {
                        // Dùng Convert.ToInt32 thay vì cast trực tiếp (int)
                        MaTK = Convert.ToInt32(reader["MaTK"]),
                        Email = reader["Email"].ToString(),
                        MatKhau = reader["MatKhau"].ToString(),
                        PhanLoai = Convert.ToInt32(reader["PhanLoai"]),
                        NgayDK = Convert.ToDateTime(reader["NgayDK"])
                    };
                }
            }
            return null;
        }
    }
}
