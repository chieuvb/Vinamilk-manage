using System;
using System.Collections.Generic;
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
            string text = "Linux2610";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            using (SHA512 sha3 = new SHA512CryptoServiceProvider())
            {
                byte[] hashBytes = sha3.ComputeHash(bytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }

            string[] row = new string[] { "1", "Sua tuoi", "2", "654.300 vnd" };

            dat_hoadon.Rows.Add(row);

            /*using (VinamilkEntities vin = new VinamilkEntities())
            {
                dat_sanpham.DataSource = vin.SanPhams.ToList();
            }*/
        }

        private void Dat_sanpham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tex_sanpham_TextChanged(object sender, EventArgs e)
        {
            using (VinamilkEntities vin = new VinamilkEntities())
            {
                List<SanPham> sanphams = vin.SanPhams.Where(s => s.tenSanPham.Contains(tex_sanpham.Text)).ToList();

                if (!string.IsNullOrEmpty(tex_sanpham.Text))
                    dat_sanpham.DataSource = sanphams;
            }
        }
    }
}
