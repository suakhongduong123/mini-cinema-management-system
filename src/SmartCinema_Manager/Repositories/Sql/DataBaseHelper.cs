using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SmartCinema_Manager.Repositories
{
    public class DataBaseHelper
    {
        private static readonly string connectionStr = 
            @"Server=MINHCHAU;Database=QuanLyRapPhim;Integrated Security=true;";
        public static SqlConnection GetConnection()
            => new SqlConnection(connectionStr);
    }
}
