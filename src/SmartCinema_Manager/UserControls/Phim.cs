using SmartCinema_Manager.Model;
using SmartCinema_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SmartCinema_Manager.UserControls
{
    public partial class Phim : UserControl
    {
        // INNER MODEL
        private class DanhSachPhimItem
        {
            public String MaPhim { get; set; }

            public string Name { get; set; }

            public string Type { get; set; }

            public decimal Duration { get; set; }

            public DateTime StartDate { get; set; }

            public string Status { get; set; }

            public string Description { get; set; }

            public string ImagePath { get; set; }
        }

        // STATE
        private readonly List<DanhSachPhimItem> data =new List<DanhSachPhimItem>();
        private string selectedMaPhim = null;
        private bool loaded = false;

        // CONSTRUCTOR
        public Phim()
        {
            InitializeComponent();
            // Load dữ liệu khi tab được mở
            this.Load += (s, e) => LoadFromDb();
            this.VisibleChanged += (s, e) => { if (this.Visible && loaded) LoadFromDb(); };

            ConfigureGrid();
        }

        // LOAD TỪ DB -> data + grid
        private void LoadFromDb()
        {
            data.Clear();

            // Reload cache từ DB
            CinemaRepository.DanhSachPhim = PhimRepository.GetAll();

            // Map sang DanhSachPhimItem để bind grid
            foreach (var p in CinemaRepository.DanhSachPhim)
            {
                data.Add(new DanhSachPhimItem
                {
                    MaPhim = p.MaPhim,
                    Name = p.TenPhim,
                    Type = p.TheLoai,
                    Duration = p.ThoiLuong,
                    StartDate = p.NgayKhoiChieu,
                    Status = p.TrangThai,
                    Description = p.Mota,
                    ImagePath = p.HinhAnh
                });
            }

            LoadGrid();
        }
  

        // CONFIG GRID
        private void ConfigureGrid()
        {
            dgrView_movie.AutoGenerateColumns = false;
            dgrView_movie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgrView_movie.MultiSelect = false;
            dgrView_movie.ReadOnly = true;
            dgrView_movie.AllowUserToAddRows = false;
            dgrView_movie.DataError += (s, e) => e.Cancel = true;
        }

        // LOAD GRID
        private void LoadGrid()
        {
            dgrView_movie.Rows.Clear();
            foreach (var item in data)
            {
                int i = dgrView_movie.Rows.Add(
                    item.Name,
                    item.Type,
                    item.Duration + " phút",
                    item.StartDate.ToString("dd/MM/yyyy"),
                    item.Status
                );
                dgrView_movie.Rows[i].Tag = item.MaPhim;
            }
        }

        // VALIDATION
        private bool ValidateForm(out string err)
        {
            err = string.Empty;
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                err = "Vui lòng nhập tên phim!";
                txtName.Focus();
                return false;
            }
            if (cbType.SelectedIndex < 0)
            {
                err = "Vui lòng chọn thể loại!";
                cbType.Focus();
                return false;
            }
            if (MovieTime.Value <= 0)
            {
                err = "Thời lượng phim phải lớn hơn 0!";
                MovieTime.Focus();
                return false;
            }
            if (cbStatus.SelectedIndex < 0)
            {
                err = "Vui lòng chọn trạng thái!";
                cbStatus.Focus();
                return false;
            }
            return true;
        }

        // BUILD ITEM
        private DanhSachPhimItem BuildItem(String maPhim)
        {
            return new DanhSachPhimItem
            {
                MaPhim = maPhim,

                Name = txtName.Text.Trim(),

                Type = cbType.Text,

                Duration = MovieTime.Value,

                StartDate = dtMovieStar.Value,

                Status = cbStatus.Text,

                Description = txtDescription.Text.Trim(),

                ImagePath = selectedImagePath
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(out string err)) { ShowWarn(err); return; }

            bool isExist = data.Any(x => x.Name.Equals(txtName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (isExist) { ShowWarn("Phim này đã tồn tại!"); return; }

            // Sinh MaPhim dạng "P001", "P002", ...
            string maPhim = PhimRepository.SinhMaPhimMoi();
            var dbItem = new PhimIterm
            {
                MaPhim = maPhim,
                TenPhim = txtName.Text.Trim(),
                TheLoai = cbType.Text,
                ThoiLuong = (int)MovieTime.Value,
                NgayKhoiChieu = dtMovieStar.Value,
                TrangThai = cbStatus.Text,
                Mota = txtDescription.Text.Trim(),
                HinhAnh = selectedImagePath
            };
            // ghi db trước
            if (!PhimRepository.Insert(dbItem)) return; // nếu lỗi db thì dừng

            // Ghi thành công sẽ update memory
            var item = BuildItem(maPhim);
            data.Add(item);
            CinemaRepository.DanhSachPhim.Add(dbItem);

            LoadGrid();
            ClearForm();
            ShowInfo("Thêm phim thành công!");
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            if (selectedMaPhim == null) { ShowWarn("Vui lòng chọn dòng cần cập nhật!"); return; }
            if (!ValidateForm(out string err)) { ShowWarn(err); return; }

            bool duplicate = data.Any(x =>x.MaPhim != selectedMaPhim && x.Name.Equals(txtName.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (duplicate) { ShowWarn("Tên phim đã tồn tại!"); return; }

            int idx = data.FindIndex(x => x.MaPhim == selectedMaPhim);
            if (idx < 0) { ShowWarn("Không tìm thấy dữ liệu!"); return; }

            var dbItem = new PhimIterm
            {
                MaPhim = selectedMaPhim,
                TenPhim = txtName.Text.Trim(),
                TheLoai = cbType.Text,
                ThoiLuong = (int)MovieTime.Value,
                NgayKhoiChieu = dtMovieStar.Value,
                TrangThai = cbStatus.Text,
                Mota = txtDescription.Text.Trim(),
                HinhAnh = selectedImagePath
            };

            // Ghi DB trước
            if (!PhimRepository.Update(dbItem)) return;

            // Thành công thì update memory
            data[idx] = BuildItem(selectedMaPhim);

            int repoIdx = CinemaRepository.DanhSachPhim.FindIndex(x => x.MaPhim == selectedMaPhim);
            if (repoIdx >= 0)
                CinemaRepository.DanhSachPhim[repoIdx] = dbItem;

            LoadGrid();
            ClearForm();
            ShowInfo("Cập nhật thành công!");
        }

        private void dgrView_movie_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgrView_movie.Rows[e.RowIndex];
            if (row.Tag is string ma)       
                selectedMaPhim = ma;

            var item = data.FirstOrDefault(x => x.MaPhim == selectedMaPhim);
            if (item == null) return;

            txtName.Text = item.Name;
            cbType.Text = item.Type;
            MovieTime.Value = Math.Max(MovieTime.Minimum, Math.Min(MovieTime.Maximum, item.Duration));
            dtMovieStar.Value = item.StartDate;
            cbStatus.Text = item.Status;
            txtDescription.Text = item.Description;
            selectedImagePath = item.ImagePath;
            if (!string.IsNullOrEmpty(item.ImagePath) && File.Exists(item.ImagePath))
            {
                pic_UpLoad.Image = Image.FromFile(item.ImagePath);
                pic_UpLoad.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pic_UpLoad.Image = null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (selectedMaPhim == null) { ShowWarn("Vui lòng chọn dòng cần xóa!"); return; }

            string tenPhim = data.FirstOrDefault(x => x.MaPhim == selectedMaPhim)?.Name ?? "";
            if (MessageBox.Show($"Xác nhận xóa \"{tenPhim}\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            // Ghi DB trước
            if (!PhimRepository.Delete(selectedMaPhim)) return;

            // Thành công thì xóa khỏi memory
            data.RemoveAll(x => x.MaPhim == selectedMaPhim);
            CinemaRepository.DanhSachPhim.RemoveAll(x => x.MaPhim == selectedMaPhim);

            LoadGrid();
            ClearForm();
            ShowInfo("Xóa thành công!");
        }

        // FILTER
        private void FilterGrid()
        {
            string keyword =txtFind.Text.Trim().ToLower();

            string filterType =cbFindTypes.SelectedIndex >= 0? cbFindTypes.Text: null;

            string filterStatus =cbFindStatus.SelectedIndex >= 0 ? cbFindStatus.Text: null;

            var results = data.Where(x => (string.IsNullOrEmpty(keyword)|| x.Name.ToLower().Contains(keyword))&&(filterType == null || x.Type == filterType) 
            && (filterStatus == null || x.Status == filterStatus) ).ToList();

            dgrView_movie.Rows.Clear();

            foreach (var item in results)
            {
                int i = dgrView_movie.Rows.Add(
                    item.Name,
                    item.Type,
                    item.Duration + " phút",
                    item.StartDate.ToString("dd/MM/yyyy"),
                    item.Status
                );

                dgrView_movie.Rows[i].Tag = item.MaPhim;
            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void cbFindTypes_SelectedIndexChanged( object sender, EventArgs e)
        {
            FilterGrid();
        }

        private void cbFindStatus_SelectedIndexChanged( object sender, EventArgs e)
        {
            FilterGrid();
        }
        private void btnRefresh_Click(object sender,EventArgs e)
        {
            ClearForm();
            txtFind.Clear();
            cbFindTypes.SelectedIndex = -1;
            cbFindStatus.SelectedIndex = -1;

            LoadFromDb(); 
        }

        private string selectedImagePath = null;
        private void pic_UpLoad_Click(object sender,EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn hình ảnh";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        selectedImagePath = dlg.FileName; 
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

        private void ClearForm()
        {
            selectedMaPhim =null;
            selectedImagePath = null;
            txtName.Text = string.Empty;
            cbType.SelectedIndex = -1;
            MovieTime.Value = MovieTime.Minimum;
            dtMovieStar.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
            txtDescription.Text = string.Empty;
            pic_UpLoad.Image = null;
            dgrView_movie.ClearSelection();
        }
        private void ShowInfo(string msg)
        {
            MessageBox.Show(
                msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarn(string msg)
        {
            MessageBox.Show(
                msg, "Cảnh báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}