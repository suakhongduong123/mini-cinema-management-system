using SmartCinema_Manager.Model;
using SmartCinema_Manager.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartCinema_Manager.Controls
{
    public partial class FoodControl : UserControl
    {
        public event EventHandler<Model.SanPham> OnAddToCart;
        private Model.SanPham sanPhamIterm;
        public FoodControl()
        {
            InitializeComponent();
        }
        // Gọi hàm này để load dữ liệu vào control
        public void LoadData(Model.SanPham sp)
        {
            sanPhamIterm = sp;
            lblNameFood.Text = sp.TenSanPham;
            lblPriceFood.Text = sp.GiaTien.ToString("#,##0") + " đ";

            // HinhAnh giờ là string đường dẫn
            if (!string.IsNullOrEmpty(sp.HinhAnh) && System.IO.File.Exists(sp.HinhAnh))
            {
                Pic_Food.Image = Image.FromFile(sp.HinhAnh);
                Pic_Food.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                Pic_Food.Image = null;
            }
        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {
            if (sanPhamIterm == null) return;
            OnAddToCart?.Invoke(this, sanPhamIterm);
        }
    }
}
