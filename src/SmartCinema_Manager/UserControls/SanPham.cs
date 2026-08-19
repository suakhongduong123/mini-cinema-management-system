using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using SmartCinema_Manager.Model;
using SmartCinema_Manager.Repositories;

namespace SmartCinema_Manager.UserControls
{
    public partial class SanPham : UserControl
    {
        // EVENT
        public static event Action<List<Model.SanPham>> onDanhSachThayDoi;

        // INNER MODEL
        public class DichVuItem
        {
            public string MaThucPham { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Type { get; set; }
            public string ImagePath { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }
            public int SoLuong { get; set; }
        }

        // STATE
        private readonly List<DichVuItem> data = new List<DichVuItem>();
        private string selectedMaThucPham = null;
        private string selectedImagePath = null;

        // CONSTRUCTOR
        public SanPham()
        {
            InitializeComponent();
            this.Load += (s, e) => LoadFromDb();
            this.VisibleChanged += (s, e) => { if (this.Visible) LoadFromDb(); };
            ConfigureGrid();
        }
        private void LoadFromDb()
        {
            try
            {
                data.Clear();
                CinemaRepository.DanhSachSanPham = ThucPhamRepository.GetAll();
                foreach (var p in CinemaRepository.DanhSachSanPham)
                {
                    data.Add(new DichVuItem
                    {
                        MaThucPham = p.MaThucPham,
                        Name = p.TenSanPham,
                        Price = p.GiaTien,
                        Type = LoaiToString(p.Loai),
                        ImagePath = p.HinhAnh,
                        Status = p.TrangThai,
                        SoLuong = p.SoLuong
                    });
                }
                LoadGrid();
            }
            catch (Exception ex)
            {
                ShowWarn("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private string LoaiToString(int loai)
        {
            switch (loai)
            {
                case LoaiSanPham.Bap: return "Bắp";
                case LoaiSanPham.ComboNuoc: return "Combo bắp nước";
                default: return "Nước";
            }
        }

        // CONVERT thành = SANPHAM
        private Model.SanPham ConvertToSanPham(
            DichVuItem item)
        {
            int loai = LoaiSanPham.Nuoc;

            switch (item.Type)
            { 
                case "Nước":
                    loai = LoaiSanPham.Nuoc;
                    break;

                case "Bắp":
                    loai = LoaiSanPham.Bap;
                    break;

                case "Combo bắp nước":
                    loai = LoaiSanPham.ComboNuoc;
                    break;
            }

            return new Model.SanPham
            {
                MaThucPham = item.MaThucPham,

                TenSanPham = item.Name,

                GiaTien = item.Price,

                Loai = loai,

                TrangThai = item.Status,
                HinhAnh = item.ImagePath
            };
        }

        // PHÁT EVENT
        private void phatSuKien()
        {
            var dsSanPham = data .Select(x => ConvertToSanPham(x)) .ToList();

            CinemaRepository.DanhSachSanPham = dsSanPham;

            onDanhSachThayDoi?.Invoke(dsSanPham);
        }

        // GRID
        private void ConfigureGrid()
        {
            dgrView_Service.AutoGenerateColumns = false;
            dgrView_Service.SelectionMode =DataGridViewSelectionMode.FullRowSelect;
            dgrView_Service.MultiSelect = false;
            dgrView_Service.ReadOnly = true;
            dgrView_Service.AllowUserToAddRows = false;
            dgrView_Service.RowTemplate.Height = 80;
            dgrView_Service.RowTemplate.MinimumHeight = 80;

            if (dgrView_Service.Columns.Count > 0)
            {
                dgrView_Service.Columns[0].Width = 100;
            }

            foreach (DataGridViewColumn col
                in dgrView_Service.Columns)
            {
                if (col is DataGridViewImageColumn imgCol)
                {
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private Image LoadThumbnail(string path)
        {
            if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
            {
                try { return Image.FromFile(path); }
                catch { }
            }
            return null;
        }

        // LOAD GRID
        private void LoadGrid()
        {
            dgrView_Service.Rows.Clear();

            foreach (var item in data)
            {
                int i = dgrView_Service.Rows.Add(
                    LoadThumbnail(item.ImagePath), // ← Image từ đường dẫn
                    item.Name,
                    item.Price.ToString("N0") + " đ",
                    item.Type,
                    item.Status
                );
                dgrView_Service.Rows[i].Tag = item.MaThucPham;
            }
        }

        // PARSE PRICE
        private decimal parsePrice()
        {
            string raw =txtPrice.Text.Replace(".", "").Replace(",", "").Trim();
            decimal.TryParse(raw, out decimal price);
            return price;
        }
        private int ParseLoaiFromString(string type)
        {
            switch (type)
            {
                case "Bắp": return LoaiSanPham.Bap;
                case "Combo bắp nước": return LoaiSanPham.ComboNuoc;
                default: return LoaiSanPham.Nuoc;
            }
        }
        // VALIDATION
        private bool ValidateForm(out string err)
        {
            err = string.Empty;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                err = "Vui lòng nhập tên dịch vụ!";
                txtName.Focus();
                return false;
            }

            if (cbType.SelectedIndex < 0)
            {
                err = "Vui lòng chọn loại!";
                cbType.Focus();
                return false;
            }

            if (parsePrice() <= 0)
            {
                err = "Giá phải lớn hơn 0!";
                txtPrice.Focus();
                return false;
            }

            if (!chbSale.Checked
                && !chbStopSale.Checked)
            {
                err = "Vui lòng chọn trạng thái!";
                return false;
            }

            return true;
        }

        // BUILD ITEM
        private DichVuItem BuildItem(string maTP)
        {
            return new DichVuItem
            {
                MaThucPham = maTP,
                Name = txtName.Text.Trim(),
                Price = parsePrice(),
                Type = cbType.Text,
                ImagePath = selectedImagePath,
                Status = chbSale.Checked ? "Đang bán" : "Ngừng bán",
                Description = txtDescription.Text.Trim(),
                SoLuong = (int)SoLuongTP.Value
            };
        }

        // ADD
        private void btnAdd_Click( object sender, EventArgs e)
        {
            if (!ValidateForm(out string err)) { ShowWarn(err); return; }

            bool isExist = data.Any(x =>x.Name.Equals(txtName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (isExist) { ShowWarn("Dịch vụ đã tồn tại!"); return; }

            string maTP = ThucPhamRepository.SinhMaMoi();
            var item = BuildItem(maTP);

            var dbItem = new Model.SanPham
            {
                MaThucPham = maTP,
                TenSanPham = item.Name,
                GiaTien = item.Price,
                Loai = ParseLoaiFromString(item.Type),
                TrangThai = item.Status,
                HinhAnh = item.ImagePath,
                SoLuong = item.SoLuong
            };

            if (!ThucPhamRepository.Insert(dbItem)) return;

            data.Add(item);
            CinemaRepository.DanhSachSanPham.Add(dbItem);
            phatSuKien();
            LoadGrid();
            ClearForm();
            ShowInfo("Thêm thành công!");
        }

        // UPDATE
        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (selectedMaThucPham == null) { ShowWarn("Vui lòng chọn dòng cần sửa!"); return; }
            if (!ValidateForm(out string err)) { ShowWarn(err); return; }

            int idx = data.FindIndex(x => x.MaThucPham == selectedMaThucPham);
            if (idx < 0) { ShowWarn("Không tìm thấy dữ liệu!"); return; }

            var item = BuildItem(selectedMaThucPham);
            var dbItem = new Model.SanPham
            {
                MaThucPham = selectedMaThucPham,
                TenSanPham = item.Name,
                GiaTien = item.Price,
                Loai = ParseLoaiFromString(item.Type),
                TrangThai = item.Status,
                HinhAnh = item.ImagePath,
                SoLuong = item.SoLuong
            };

            if (!ThucPhamRepository.Update(dbItem)) return;
            data[idx] = item;

            phatSuKien();

            int ri = CinemaRepository.DanhSachSanPham.FindIndex(x => x.MaThucPham == selectedMaThucPham);
            if (ri >= 0) CinemaRepository.DanhSachSanPham[ri] = dbItem;

            LoadGrid();
            ClearForm();
            ShowInfo("Cập nhật thành công!");
        }

        private void btnClear_Click( object sender,EventArgs e)
        {
            if (selectedMaThucPham == null) { ShowWarn("Vui lòng chọn dòng cần xóa!"); return; }

            string ten = data.FirstOrDefault(x => x.MaThucPham == selectedMaThucPham)?.Name ?? "";
            if (MessageBox.Show($"Xác nhận xóa \"{ten}\"?", "Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            if (!ThucPhamRepository.Delete(selectedMaThucPham)) return;

            data.RemoveAll(x => x.MaThucPham == selectedMaThucPham);
            phatSuKien();

            CinemaRepository.DanhSachSanPham.RemoveAll(x => x.MaThucPham == selectedMaThucPham);

            LoadGrid();
            ClearForm();
            ShowInfo("Xóa thành công!");
        }
        private void dgrView_Service_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgrView_Service.Rows[e.RowIndex];
            if (row.Tag is string ma) selectedMaThucPham = ma;

            var item = data.FirstOrDefault(x => x.MaThucPham == selectedMaThucPham);
            if (item == null) return;

            txtName.Text = item.Name;
            cbType.Text = item.Type;
            txtPrice.Text = item.Price.ToString("N0").Replace(",", ".");
            chbSale.Checked = item.Status == "Đang bán";
            chbStopSale.Checked = item.Status == "Ngừng bán";
            txtDescription.Text = item.Description ?? "";
            selectedImagePath = item.ImagePath;
            SoLuongTP.Value = Math.Max(SoLuongTP.Minimum,
                  Math.Min(SoLuongTP.Maximum, item.SoLuong));
            // Hiển thị ảnh từ đường dẫn
            if (!string.IsNullOrEmpty(item.ImagePath)
                && System.IO.File.Exists(item.ImagePath))
            {
                pic_UpLoad.Image = Image.FromFile(item.ImagePath);
                pic_UpLoad.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pic_UpLoad.Image = null;
            }
        }
        private void btnRefresh_Click(
            object sender,
            EventArgs e)
        {
            ClearForm();
            LoadFromDb();
        }

        private void FilterGrid()
        {
            string keyword = txtFindWord.Text.Trim().ToLower();
            string filterType = cbTypes.SelectedIndex >= 0 ? cbTypes.Text : null;
            string filterStatus = cbFindStatus.SelectedIndex >= 0 ? cbFindStatus.Text : null;

            var results = data.Where(x =>(string.IsNullOrEmpty(keyword) || x.Name.ToLower().Contains(keyword)) &&(filterType == null || x.Type == filterType) 
            &&(filterStatus == null || x.Status == filterStatus)).ToList();

            dgrView_Service.Rows.Clear();

            foreach (var item in results)
            {
                int i = dgrView_Service.Rows.Add(
                    LoadThumbnail(item.ImagePath), 
                    item.Name,
                    item.Price.ToString("N0") + " đ",
                    item.Type,
                    item.Status
                );
                dgrView_Service.Rows[i].Tag = item.MaThucPham;
            }
        }

        private void txtFindWord_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void cbFindStatus_SelectedIndexChanged(object sender,EventArgs e)
        {
            FilterGrid();
        }

        private void cbTypes_SelectedIndexChanged( object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void pic_UpLoad_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImagePath = dlg.FileName;  // ← lưu đường dẫn
                        pic_UpLoad.Image = Image.FromFile(dlg.FileName);
                        pic_UpLoad.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        ShowWarn("Không thể tải ảnh!");
                    }
                }
            }
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            string raw =txtPrice.Text.Replace(".", "") .Replace(",", "").Trim();

            if (decimal.TryParse(raw, out decimal price) && price > 0)
            {
                txtPrice.Text = price.ToString("N0")  .Replace(",", ".");
            }
        }

        private void ClearForm()
        {
            selectedMaThucPham = null;
            selectedImagePath = null;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            cbType.SelectedIndex = -1;
            pic_UpLoad.Image = null;
            chbSale.Checked = false;
            chbStopSale.Checked = false;
            txtDescription.Text = string.Empty;
            dgrView_Service.ClearSelection();
            SoLuongTP.Value = SoLuongTP.Minimum;
        }
        private void ShowInfo(string msg)
        {
            MessageBox.Show( msg, "Thông báo",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarn(string msg)
        {
            MessageBox.Show( msg,"Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}