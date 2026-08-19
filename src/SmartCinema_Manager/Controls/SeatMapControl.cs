using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SmartCinema_Manager.Controls
{
    // Trạng thái của từng ghế
    public enum SeatState { 
        Available, 
        Sold, 
        Selected, 
        VIP, 
        VIPSelected, 
        Gray, 
        GraySelected,
        Soldgray,
        SoldVIP}

    // Model lưu thông tin 1 ghế
    public class SeatItem
    {
        public string Row;
        public int Number;
        public SeatState State;
        public Rectangle Bounds;
        public string Key { get { return Row + Number; } }
    }

    public class SeatMapControl : Panel
    {
        // Màu sắc
        private static readonly Color C_Available = Color.FromArgb(255, 205, 210); // hồng nhạt
        private static readonly Color C_AvailBorder = Color.FromArgb(229, 115, 115);
        private static readonly Color C_Sold = Color.FromArgb(200, 200, 200); // xám (đã bán, không click được)
        private static readonly Color C_SoldBorder = Color.FromArgb(160, 160, 160);
        private static readonly Color C_Selected = Color.FromArgb(183, 28, 28); // đỏ đậm
        private static readonly Color C_SelectedBorder = Color.FromArgb(120, 10, 10);
        private static readonly Color C_VIP = Color.FromArgb(248, 187, 208); // hồng VIP
        private static readonly Color C_VIPBorder = Color.FromArgb(216, 83, 126);
        private static readonly Color C_VIPSel = Color.FromArgb(173, 20, 87); // VIP đang chọn
        private static readonly Color C_VIPSelBorder = Color.FromArgb(120, 10, 60);
        private static readonly Color C_Gray = Color.FromArgb(210, 210, 210); // xám nhạt (hàng A-D)
        private static readonly Color C_GrayBorder = Color.FromArgb(160, 160, 160);
        private static readonly Color C_GraySel = Color.FromArgb(90, 90, 90); // xám đậm khi chọn
        private static readonly Color C_GraySelBorder = Color.FromArgb(50, 50, 50);

        // Kích thước layout
        private const int ML = 20;
        private const int MT = 10;
        private const int SW = 30;
        private const int SH = 28;
        private const int SGAP = 3;
        private const int AGAP = 16;
        private const int RGAP = 4;
        private const int LW = 18;
        private const int CR = 6;
        private const int VIPW = 64;
        private const int VIPH = 36;

        private readonly string[] ROWS = { "A", "B", "C", "D", "E", "F", "G", "H", "I" };
        private const int COLS = 12;

        private List<SeatItem> _seats = new List<SeatItem>();

        public event EventHandler SelectionChanged;

        public SeatMapControl()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
            MouseClick += HandleClick;
        }

        // Nạp dữ liệu ghế
        // soldSeats: danh sách ghế đã bán, không click được, vd: new List<string>{"E1","F3"}
        public void LoadSeats(List<string> soldSeats)
        {
            _seats.Clear();

            HashSet<string> sold = new HashSet<string>(
                soldSeats ?? new List<string>(),
                StringComparer.OrdinalIgnoreCase);

            for (int r = 0; r < ROWS.Length; r++)
            {
                for (int s = 1; s <= COLS; s++)
                {
                    string key = ROWS[r] + s;

                    SeatState state;
                    if (sold.Contains(key))
                        state = SeatState.Sold;       // đã bán → xám, không click
                    else if (r < 4)
                        state = SeatState.Gray;       // hàng A-D → xám nhạt, vẫn click được
                    else
                        state = SeatState.Available;  // còn trống → hồng

                    _seats.Add(new SeatItem { Row = ROWS[r], Number = s, State = state });
                }
            }

            // Hàng J - VIP
            for (int s = 1; s <= 6; s++)
            {
                string key = "J" + s;
                _seats.Add(new SeatItem
                {
                    Row = "J",
                    Number = s,
                    State = sold.Contains(key) ? SeatState.Sold : SeatState.VIP
                });
            }

            RecalcBounds();
            Invalidate();

            if (SelectionChanged != null)
                SelectionChanged(this, EventArgs.Empty);
        }

        public void LoadSeats()
        {
            LoadSeats(null);
        }

        // Lấy danh sách ghế đang chọn (tất cả loại)
        public List<string> GetSelectedSeats()
        {
            List<string> list = new List<string>();
            foreach (SeatItem s in _seats)
                if (s.State == SeatState.Selected ||
                    s.State == SeatState.VIPSelected ||
                    s.State == SeatState.GraySelected)
                    list.Add(s.Key);
            return list;
        }

        public int SelectedCount
        {
            get
            {
                int n = 0;
                foreach (SeatItem s in _seats)
                    if (s.State == SeatState.Selected ||
                        s.State == SeatState.VIPSelected ||
                        s.State == SeatState.GraySelected)
                        n++;
                return n;
            }
        }

        // Tính tọa độ từng ghế
        private void RecalcBounds()
        {
            int stepX = SW + SGAP;
            int stepY = SH + RGAP;

            foreach (SeatItem seat in _seats)
            {
                if (seat.Row == "J") continue;

                int r = Array.IndexOf(ROWS, seat.Row);
                int s = seat.Number - 1;
                int blk = s / 6;
                int col = s % 6;

                int x = ML + LW + blk * (6 * stepX + AGAP) + col * stepX;
                int y = MT + r * stepY;
                seat.Bounds = new Rectangle(x, y, SW, SH);
            }

            int vipStepX = VIPW + SGAP;
            int vipY = MT + ROWS.Length * stepY + 6;
            int leftStart = ML + LW;
            int rightStart = ML + LW + 6 * stepX + AGAP + (6 * stepX - 3 * vipStepX);

            foreach (SeatItem seat in _seats)
            {
                if (seat.Row != "J") continue;
                int s = seat.Number - 1;
                int blk = s / 3;
                int col = s % 3;
                int x = (blk == 0 ? leftStart : rightStart) + col * vipStepX;
                seat.Bounds = new Rectangle(x, vipY, VIPW, VIPH);
            }
        }

        // Vẽ toàn bộ sơ đồ
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            DrawRowLabels(g);

            foreach (SeatItem seat in _seats)
                DrawSeat(g, seat);
        }

        // Vẽ nhãn hàng A, B, ... J bên trái
        private void DrawRowLabels(Graphics g)
        {
            int stepY = SH + RGAP;

            Font f = new Font("Segoe UI", 8f, FontStyle.Bold);
            SolidBrush b = new SolidBrush(Color.FromArgb(120, 120, 120));
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            for (int r = 0; r < ROWS.Length; r++)
                g.DrawString(ROWS[r], f, b,
                    new RectangleF(2, MT + r * stepY, LW, SH), sf);

            int vipY = MT + ROWS.Length * stepY + 6;
            g.DrawString("J", f, b, new RectangleF(2, vipY, LW, VIPH), sf);

            f.Dispose();
            b.Dispose();
        }

        // Vẽ 1 ghế với màu theo trạng thái
        private void DrawSeat(Graphics g, SeatItem seat)
        {
            Color fill, border, fg;

            switch (seat.State)
            {
                case SeatState.Sold:
                    fill = C_Sold; border = C_SoldBorder; fg = Color.FromArgb(130, 130, 130); break;
                case SeatState.Selected:
                    fill = C_Selected; border = C_SelectedBorder; fg = Color.White; break;
                case SeatState.VIP:
                    fill = C_VIP; border = C_VIPBorder; fg = Color.FromArgb(173, 20, 87); break;
                case SeatState.VIPSelected:
                    fill = C_VIPSel; border = C_VIPSelBorder; fg = Color.White; break;
                case SeatState.Gray:
                    fill = C_Gray; border = C_GrayBorder; fg = Color.FromArgb(80, 80, 80); break;
                case SeatState.GraySelected:
                    fill = C_GraySel; border = C_GraySelBorder; fg = Color.White; break;
                default: // Available
                    fill = C_Available; border = C_AvailBorder; fg = Color.FromArgb(183, 28, 28); break;
            }

            Rectangle r = seat.Bounds;
            GraphicsPath path = RoundRect(r, CR);
            SolidBrush fb = new SolidBrush(fill);
            Pen pen = new Pen(border, 1.2f);

            g.FillPath(fb, path);
            g.DrawPath(pen, path);

            path.Dispose();
            fb.Dispose();
            pen.Dispose();

            bool isBold = (seat.State == SeatState.Selected ||
                           seat.State == SeatState.VIPSelected ||
                           seat.State == SeatState.GraySelected);
            float fs = seat.Row == "J" ? 8f : 7.5f;

            Font font = new Font("Segoe UI", fs, isBold ? FontStyle.Bold : FontStyle.Regular);
            SolidBrush tb = new SolidBrush(fg);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            g.DrawString(seat.Number.ToString(), font, tb,
                new RectangleF(r.X, r.Y, r.Width, r.Height), sf);

            font.Dispose();
            tb.Dispose();
        }

        // Xử lý click chuột
        private void HandleClick(object sender, MouseEventArgs e)
        {
            foreach (SeatItem seat in _seats)
            {
                if (!seat.Bounds.Contains(e.Location)) continue;
                if (seat.State == SeatState.Sold) return; // đã bán, bỏ qua

                if (seat.State == SeatState.Available)
                    seat.State = SeatState.Selected;
                else if (seat.State == SeatState.Selected)
                    seat.State = SeatState.Available;
                else if (seat.State == SeatState.VIP)
                    seat.State = SeatState.VIPSelected;
                else if (seat.State == SeatState.VIPSelected)
                    seat.State = SeatState.VIP;
                else if (seat.State == SeatState.Gray)
                    seat.State = SeatState.GraySelected;
                else if (seat.State == SeatState.GraySelected)
                    seat.State = SeatState.Gray;

                Invalidate();
                if (SelectionChanged != null)
                    SelectionChanged(this, EventArgs.Empty);
                return;
            }
        }

        // Vẽ hình chữ nhật bo góc
        private static GraphicsPath RoundRect(Rectangle r, int rad)
        {
            int d = rad * 2;
            GraphicsPath p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RecalcBounds();
        }
    }
}