using SmartCinema_Manager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCinema_Manager.Models
{
    internal class SessionManager
    {
        public static TaiKhoan CurrentUser { get; set; }

        public static bool IsLoggedIn
            => CurrentUser != null;

        public static void Logout()
            => CurrentUser = null;

    }
}
