using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUI_vinamilk.Controls
{
    public partial class ThanhToanUC : UserControl
    {
        public ThanhToanUC()
        {
            InitializeComponent();
        }

        private readonly Dictionary<string, string> dicPrice = new Dictionary<string, string>();

        private void ThanhToanUC_Load(object sender, EventArgs e)
        {
            tex_sanpham.Focus();
            tex_tongtien.Text = "0";

            string text = "Linux2610";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            using (SHA512 sha3 = new SHA512CryptoServiceProvider())
            {
                byte[] hashBytes = sha3.ComputeHash(bytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }

            using (VinamilkEntities vin = new VinamilkEntities())
            {
                List<SanPham> sanPhams = vin.SanPhams.AsNoTracking().ToList();
                dat_sanpham.DataSource = sanPhams;
                dat_sanpham.Height = sanPhams.Count * 32 + 70;

                if (dat_sanpham.Height > 685)
                    dat_sanpham.Height = 685;
            }
        }

        private void Dat_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    string tenSanPham = dat_sanpham["col_tenSP", e.RowIndex].Value.ToString().Trim();

                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        SanPham sanPham = vin.SanPhams.AsNoTracking().FirstOrDefault(s => s.tenSanPham == tenSanPham);
                        ChiTietSanPham chiTietSanPham = vin.ChiTietSanPhams.AsNoTracking().FirstOrDefault(c => c.maSanPham == sanPham.maSanPham);

                        if (!dicPrice.ContainsKey(sanPham.maSanPham))
                        {
                            string foNum = ReformatPrice(chiTietSanPham.giaBan) + " VND";
                            string[] sPs = new string[] { (dat_hoadon.Rows.Count + 1).ToString(), sanPham.tenSanPham, "-", "1", "+", foNum, "xoa", sanPham.maSanPham };
                            dicPrice.Add(sanPham.maSanPham, foNum.Replace(" VND", ""));
                            dat_hoadon.Rows.Add(sPs);
                        }
                        else
                        {
                            DataGridViewRow fRow = null;

                            foreach (DataGridViewRow row in dat_hoadon.Rows)
                            {
                                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == sanPham.maSanPham)
                                {
                                    fRow = row;
                                    break;
                                }
                            }

                            int soLuong = int.Parse(fRow.Cells["col_soluong"].Value.ToString()) + 1;
                            int giaBan = (int)(chiTietSanPham.giaBan * soLuong);

                            foreach (DataGridViewRow row in dat_hoadon.Rows)
                            {
                                if (row.Cells["maSanPham"].Value != null && row.Cells["maSanPham"].Value.ToString() == sanPham.maSanPham)
                                {
                                    row.Cells["col_soluong"].Value = soLuong;
                                    row.Cells["col_gia"].Value = ReformatPrice(giaBan) + " VND";
                                }
                            }
                        }

                        TinhTongTien(e.RowIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dat_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    if (dat_hoadon.Columns[e.ColumnIndex].Name == "col_xoa")
                    {
                        string key = dat_hoadon["maSanPham", e.RowIndex].Value.ToString();
                        dicPrice.Remove(key);
                        dat_hoadon.Rows.Remove(dat_hoadon.Rows[e.RowIndex]);
                        tex_tongtien.Text = "0";
                    }
                    else if (dat_hoadon.Columns[e.ColumnIndex].Name == "col_soluong")
                    {
                        dat_hoadon.BeginEdit(true);
                        if (dat_hoadon.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell)
                            dat_hoadon.EditingControl.Select();
                    }
                    else if (dat_hoadon.Columns[e.ColumnIndex].Name == "col_cong")
                    {
                        int sl = int.Parse(dat_hoadon["col_soluong", e.RowIndex].Value.ToString());
                        sl++;
                        dat_hoadon["col_soluong", e.RowIndex].Value = sl;

                        TinhTongTien(e.RowIndex);
                    }
                    else if (dat_hoadon.Columns[e.ColumnIndex].Name == "col_tru")
                    {
                        int sl = int.Parse(dat_hoadon["col_soluong", e.RowIndex].Value.ToString());
                        if (sl > 1)
                            sl--;
                        dat_hoadon["col_soluong", e.RowIndex].Value = sl;

                        TinhTongTien(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show(dat_hoadon["col_tensanpham", e.RowIndex].Value.ToString() ?? "null");
                    }

                    TinhTongTien(e.RowIndex);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hoa_don cellClick error: " + ex.Message);
            }
        }

        private string ReformatPrice(double price)
        {
            try
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return price.ToString("N0", cul);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi chuyen dinh dang so: " + ex.Message);
                return price.ToString("N0");
            }
        }

        private void TinhTongTien(int rowIndex)
        {
            try
            {
                string msp = dat_hoadon["maSanPham", rowIndex].Value.ToString();
                int pri = int.Parse(dicPrice[msp].Replace(".", ""));
                string sl = dat_hoadon["col_soluong", rowIndex].Value.ToString();
                int price = pri;

                if (int.TryParse(sl, out int intSL))
                {
                    if (intSL <= 0)
                    {
                        intSL = 1;
                        dat_hoadon["col_soluong", rowIndex].Value = intSL;
                    }

                    price = pri * intSL;
                }
                else
                {
                    dat_hoadon["col_soluong", rowIndex].Value = 1;
                }

                dat_hoadon["col_gia", rowIndex].Value = ReformatPrice(price) + " VND";

                double tongTien = 0;

                foreach (DataGridViewRow row in dat_hoadon.Rows)
                {
                    tongTien += double.Parse(row.Cells["col_gia"].Value.ToString().Replace(".", "").Replace(" VND", ""));
                }

                tex_tongtien.Text = ReformatPrice(tongTien);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi tinh tong tien: " + ex.Message);
            }
        }

        private void Tex_sanpham_TextChanged(object sender, EventArgs e)
        {
            RegexTiengViet reg = new RegexTiengViet();

            using (VinamilkEntities vin = new VinamilkEntities())
            {
                string keyword = reg.RemoveVietnameseMarks(tex_sanpham.Text.ToLower());
                List<SanPham> sanPhams = vin.SanPhams.AsNoTracking().ToList();
                List<SanPham> filteredSanPhams = sanPhams.Where(s => reg.RemoveVietnameseMarks(s.tenSanPham.ToLower()).Contains(keyword) || s.maSanPham.Contains(keyword)).ToList();
                dat_sanpham.DataSource = filteredSanPhams;
                dat_sanpham.Height = filteredSanPhams.Count * 32 + 70;

                if (dat_sanpham.Height > 685)
                    dat_sanpham.Height = 685;
            }
        }

        private void Dat_hoadon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dat_hoadon.Columns["col_xoa"].Index && e.Value != null)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                Color buttonColor = Color.OrangeRed;

                using (Brush brush = new SolidBrush(buttonColor))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);
                    SizeF textSize = e.Graphics.MeasureString("Xóa", e.CellStyle.Font);
                    float x = e.CellBounds.X + (e.CellBounds.Width - textSize.Width) / 2;
                    float y = e.CellBounds.Y + (e.CellBounds.Height - textSize.Height) / 2;
                    e.Graphics.DrawString("Xóa", e.CellStyle.Font, Brushes.White, x, y);
                }

                e.Handled = true;
            }
        }

        private void Dat_hoadon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TinhTongTien(e.RowIndex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi thay đoi so luong: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
