using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void ThanhToanUC_Load(object sender, EventArgs e)
        {
            tex_sanpham.Focus();

            string text = "Linux2610";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            using (SHA512 sha3 = new SHA512CryptoServiceProvider())
            {
                byte[] hashBytes = sha3.ComputeHash(bytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }

            string[] row1 = new string[] { "1", "Sua tuoi", "2", "654.300 vnd" };
            string[] row2 = new string[] { "2", "Sua dac", "1", "23.540 vnd" };

            dat_hoadon.Rows.Add(row1);
            dat_hoadon.Rows.Add(row2);

            /*using (VinamilkEntities vin = new VinamilkEntities())
            {
                dat_sanpham.DataSource = vin.SanPhams.AsNoTracking().ToList();
            }*/
        }

        private void Dat_sanpham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                MessageBox.Show("double-click");
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

        private void Dat_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    /*if (e.ColumnIndex != 4)
                        MessageBox.Show(dat_hoadon["col_tensanpham", e.RowIndex].Value.ToString() ?? "null");
                    else
                        MessageBox.Show("deleted");*/

                    dat_hoadon.BeginEdit(true);
                    if (dat_hoadon.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewTextBoxCell)
                        dat_hoadon.EditingControl.Select();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
