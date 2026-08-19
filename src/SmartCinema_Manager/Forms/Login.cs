using SmartCinema_Manager.Model;
using SmartCinema_Manager.Models;
using SmartCinema_Manager.Repositories;
using SmartCinema_Manager.Repositories.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCinema_Manager.Forms
{
    public partial class login : Form
    {
        private readonly TaiKhoanRepository TK = new TaiKhoanRepository();
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            String email = txtEmail.Text;
            String password = txtPassWord.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            // --- Xử lý đăng nhập ---
            try
            {
               TaiKhoan user = TK.Login(email, password);

                if (user == null)
                {

                    MessageBox.Show("Email hoặc mật khẩu không đúng!",
                        "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassWord.Clear();
                    txtPassWord.Focus();
                    return;
                }
                // Lưu user vào session
                SessionManager.CurrentUser = user;
                CinemaRepository.LoadFromDatabase();

                // Mở Main và truyền quyền
                var mainForm = new frMain();
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
           "Message: " + ex.Message + "\n\n" +
           "Source: " + ex.Source + "\n\n" +
           "Detail: " + ex.ToString(),
           "Lỗi chi tiết",
           MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
