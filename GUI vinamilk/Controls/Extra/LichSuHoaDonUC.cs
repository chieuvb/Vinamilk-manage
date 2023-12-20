﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI_vinamilk.Controls.Extra
{
    public partial class LichSuHoaDonUC : UserControl
    {
        public LichSuHoaDonUC()
        {
            InitializeComponent();
        }

        public event EventHandler BackButtonClicked;

        private void LichSuHoaDonUC_Load(object sender, EventArgs e)
        {
            using (VinamilkEntities vinamilkEntities = new VinamilkEntities())
            {
                dataGridViewDonHang.DataSource = vinamilkEntities.DonHangs.AsNoTracking().ToList();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void DataGridViewDonHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDonHang.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void DataGridViewDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                listViewSanPham.Items.Clear();

                string maDonHang = dataGridViewDonHang["maDonHangDataGridViewTextBoxColumn", e.RowIndex].Value.ToString();
                string nguoiBan = string.Empty;
                string nguoiMua = string.Empty;

                DonHang donHang = new DonHang();
                List<ChiTietDonHang> chiTiets = new List<ChiTietDonHang>();
                List<SanPham> sanPhams = new List<SanPham>();

                using (VinamilkEntities vinamilkEntities = new VinamilkEntities())
                {
                    donHang = vinamilkEntities.DonHangs.AsNoTracking().FirstOrDefault(d => d.maDonHang == maDonHang);
                    nguoiBan = vinamilkEntities.NhanViens.AsNoTracking().FirstOrDefault(n => n.maNhanVien == donHang.maNhanVien).tenNhanVien;
                    nguoiMua = vinamilkEntities.KhachHangs.AsNoTracking().FirstOrDefault(n => n.maKhachHang == donHang.maKhachHang).tenKhachHang;
                    chiTiets = vinamilkEntities.ChiTietDonHangs.AsNoTracking().Where(c => c.maDonHang == donHang.maDonHang).ToList();

                    foreach (ChiTietDonHang chi in chiTiets)
                    {
                        sanPhams.Add(vinamilkEntities.SanPhams.AsNoTracking().FirstOrDefault(s => s.maSanPham == chi.maSanPham));
                    }
                }

                labelMaDonHang.Text = "#" + maDonHang;
                labelNguoiMua.Text = nguoiMua;
                labelNguoiBan.Text = nguoiBan;

                int x = 1;
                foreach (ChiTietDonHang chi in chiTiets)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Text = x.ToString()
                    };

                    item.SubItems.Add(sanPhams.FirstOrDefault(p => p.maSanPham == chi.maSanPham).tenSanPham);
                    item.SubItems.Add(chi.soLuong.ToString());
                    item.SubItems.Add(chi.donGia.ToString());

                    listViewSanPham.Items.Add(item);
                    x++;
                }

                labelPTTT.Text = donHang.hinhThucThanhToan;
                labelNgayMua.Text = donHang.ngayTao.ToString("D");
                labelGiaGiam.Text = donHang.giaGiam.ToString();
                labelTongTien.Text = donHang.tongTien.ToString();
            }
        }
    }
}
