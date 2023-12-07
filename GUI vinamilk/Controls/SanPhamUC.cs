using GUI_vinamilk.Controls.Extra;
using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI_vinamilk.Controls
{
    public partial class SanPhamUC : UserControl
    {
        public SanPhamUC()
        {
            InitializeComponent();
        }

        readonly string folImage = @"C:\Vinamilk manage\image\products\";
        string imagePath;
        SanPham sanPham;

        private async void SanPhamUC_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                gro_boloc.Visible = false;
                pan_chitiet.Visible = false;

                using (VinamilkEntities vin = new VinamilkEntities())
                {
                    dat_sanpham.DataSource = await vin.SanPhams.AsNoTracking().ToListAsync();

                    com_nhasanxuat.Items.AddRange(await vin.NhaSanXuats.Select(nsx => nsx.tenNhaSanXuat).ToArrayAsync());

                    com_doituong.Items.AddRange(await vin.DoiTuongs.Select(doi => doi.tenDoiTuong).ToArrayAsync());

                    com_donvi.Items.AddRange(await vin.DonVis.Select(don => don.tenDonVi).ToArrayAsync());
                }

                if (!Directory.Exists(folImage))
                {
                    Directory.CreateDirectory(folImage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dat_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                    pan_chitiet.Visible = true;

                    SanPham sanPham = new SanPham
                    {
                        maSanPham = dat_sanpham["maSanPham", e.RowIndex].Value?.ToString() ?? string.Empty,
                        maNhaSanXuat = dat_sanpham["maNhaSanXuat", e.RowIndex].Value?.ToString() ?? string.Empty,
                        maDoiTuong = dat_sanpham["maDoiTuong", e.RowIndex].Value?.ToString() ?? string.Empty,
                        tenSanPham = dat_sanpham["tenSanPham", e.RowIndex].Value?.ToString() ?? string.Empty,
                        moTa = dat_sanpham["moTa", e.RowIndex].Value?.ToString() ?? string.Empty,
                        trangThai = Convert.ToBoolean(dat_sanpham["trangThai", e.RowIndex].Value ?? false)
                    };

                    tex_tensanpham.Text = sanPham.tenSanPham;
                    tex_mota.Text = sanPham.moTa;

                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        NhaSanXuat nha = vin.NhaSanXuats.FirstOrDefault(n => n.maNhaSanXuat == sanPham.maNhaSanXuat);
                        if (nha != null)
                        {
                            var item = com_nhasanxuat.Items.Cast<object>().FirstOrDefault(i => i.ToString() == nha.tenNhaSanXuat);
                            if (item != null)
                            {
                                com_nhasanxuat.SelectedItem = item;
                            }
                            else
                            {
                                com_nhasanxuat.SelectedIndex = 0;
                            }
                        }

                        DoiTuong doi = vin.DoiTuongs.FirstOrDefault(n => n.maDoiTuong == sanPham.maDoiTuong);
                        if (doi != null)
                        {
                            var item = com_doituong.Items.Cast<object>().FirstOrDefault(i => i.ToString() == doi.tenDoiTuong);
                            if (item != null)
                            {
                                com_doituong.SelectedItem = item;
                            }
                            else
                            {
                                com_doituong.SelectedIndex = 0;
                            }
                        }
                        che_trangthai.Checked = sanPham.trangThai;

                        ChiTietSanPham chi = vin.ChiTietSanPhams.FirstOrDefault(s => s.maSanPham == sanPham.maSanPham);
                        dat_nsx.Value = chi.ngaySanXuat;
                        dat_hsd.Value = chi.ngayHetHan;

                        tex_soluong.Text = chi.soLuong.ToString();

                        DonVi don = vin.DonVis.FirstOrDefault(d => d.maDonVi == chi.maDonVi);
                        com_donvi.SelectedItem = don.tenDonVi;

                        tex_gianhap.Text = chi.giaNhap.ToString();
                        tex_giaban.Text = chi.giaBan.ToString();

                        string imagePath = folImage + chi.hinhAnh;
                        if (File.Exists(imagePath))
                        {
                            pic_sanpham.Image = Image.FromFile(imagePath);
                        }
                        else
                        {
                            pic_sanpham.SizeMode = PictureBoxSizeMode.CenterImage;
                            pic_sanpham.Image = Properties.Resources.icons8_no_image_96;
                        }
                    }
                }


                */

                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                    pan_chitiet.Visible = true;

                    string maSanPham = dat_sanpham["maSanPham", e.RowIndex].Value?.ToString() ?? string.Empty;

                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        sanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == maSanPham);
                        if (sanPham != null)
                        {
                            tex_tensanpham.Text = sanPham.tenSanPham;
                            tex_mota.Text = sanPham.moTa;

                            NhaSanXuat nha = vin.NhaSanXuats.FirstOrDefault(n => n.maNhaSanXuat == sanPham.maNhaSanXuat);
                            com_nhasanxuat.SelectedItem = nha?.tenNhaSanXuat;

                            DoiTuong doi = vin.DoiTuongs.FirstOrDefault(d => d.maDoiTuong == sanPham.maDoiTuong);
                            com_doituong.SelectedItem = doi?.tenDoiTuong;

                            che_trangthai.Checked = sanPham.trangThai;

                            ChiTietSanPham chiTiet = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == maSanPham);
                            if (chiTiet != null)
                            {
                                dat_nsx.Value = chiTiet.ngaySanXuat;
                                dat_hsd.Value = chiTiet.ngayHetHan;
                                tex_soluong.Text = chiTiet.soLuong.ToString();

                                DonVi don = vin.DonVis.FirstOrDefault(d => d.maDonVi == chiTiet.maDonVi);
                                com_donvi.SelectedItem = don?.tenDonVi;

                                tex_gianhap.Text = chiTiet.giaNhap.ToString();
                                tex_giaban.Text = chiTiet.giaBan.ToString();

                                string imagePath = folImage + chiTiet.hinhAnh;
                                if (File.Exists(imagePath))
                                {
                                    pic_sanpham.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    pic_sanpham.SizeMode = PictureBoxSizeMode.CenterImage;
                                    pic_sanpham.Image = Properties.Resources.icons8_no_image_96;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_them_Click(object sender, EventArgs e)
        {
            foreach (Control con in pan_chitiet.Controls)
            {
                switch (con)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;
                    case ComboBox comboBox:
                        comboBox.SelectedIndex = 0;
                        break;
                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Value = DateTime.Now;
                        break;
                }
            }

            pic_sanpham.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_sanpham.Image = Properties.Resources.icons8_add_image_96;
            tex_tensanpham.Focus();
            pan_chitiet.Visible = true;
        }

        private void But_luu_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateInputs();

                using (VinamilkEntities vin = new VinamilkEntities())
                {
                    SanPham existingSanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == sanPham.maSanPham);
                    if (existingSanPham == null)
                    {
                        AddNewSanPham(vin);
                    }
                    else
                    {
                        UpdateSanPham(existingSanPham, vin);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateInputs()
        {
            try
            {
                if (string.IsNullOrEmpty(tex_tensanpham.Text))
                {
                    throw new Exception("Bạn chưa nhập tên sản phẩm!");
                }
                else if (string.IsNullOrEmpty(tex_mota.Text))
                {
                    throw new Exception("Bạn cần mô tả cho sản phẩm!");
                }
                else if (com_nhasanxuat.SelectedIndex == 0)
                {
                    throw new Exception("Bạn cần chọn nhà sản xuất!");
                }
                else if (com_doituong.SelectedIndex == 0)
                {
                    throw new Exception("Bạn cần chọn đối tượng sử dụng!");
                }
                else if (dat_nsx.Value >= DateTime.Now)
                {
                    throw new Exception("Ngày sản xuất không hợp lệ!");
                }
                else if (dat_hsd.Value <= dat_nsx.Value)
                {
                    throw new Exception("Hạn sử dụng không hợp lệ!");
                }
                else if (string.IsNullOrEmpty(tex_soluong.Text))
                {
                    throw new Exception("Số lượng không hợp lệ!");
                }
                else if (com_donvi.SelectedIndex == 0)
                {
                    throw new Exception("Đơn vị tính không hợp lệ!");
                }
                else if (string.IsNullOrEmpty(tex_gianhap.Text))
                {
                    throw new Exception("Giá nhập không hợp lệ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateMaSanPham()
        {

        }

        private SanPham CreateSanPhamObject(string msp)
        {

        }

        private void AddNewSanPham(VinamilkEntities vin)
        {
            string maSP = GenerateMaSanPham();

            SanPham sanPh = CreateSanPhamObject(maSP);
            ChiTietSanPham chiTietSanPham = CreateChiTietSanPhamObject(maSP);

            vin.SanPhams.Add(sanPh);
            vin.SaveChanges();

            chiTietSanPham.maSanPham = maSP;
            vin.ChiTietSanPhams.Add(chiTietSanPham);
            vin.SaveChanges();

            SanPhamUC_LoadAsync(this, EventArgs.Empty);
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateSanPham(SanPham existingSanPham, VinamilkEntities vin)
        {
            // Update the existingSanPham object properties here
            // e.g., existingSanPham.tenSanPham = tex_tensanpham.Text;

            // Save changes to the existing SanPham object
            vin.SaveChanges();

            // Show success message or handle further updates if necessary
        }


        /*private void But_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tex_tensanpham.Text))
                {
                    throw new Exception("Bạn chưa nhập tên sản phẩm!");
                }
                else if (string.IsNullOrEmpty(tex_mota.Text))
                {
                    throw new Exception("Bạn cần mô tả cho sản phẩm!");
                }
                else if (com_nhasanxuat.SelectedIndex == 0)
                {
                    throw new Exception("Bạn cần chọn nhà sản xuất!");
                }
                else if (com_doituong.SelectedIndex == 0)
                {
                    throw new Exception("Bạn cần chọn đối tượng sử dụng!");
                }
                else if (dat_nsx.Value >= DateTime.Now)
                {
                    throw new Exception("Ngày sản xuất không hợp lệ!");
                }
                else if (dat_hsd.Value <= dat_nsx.Value)
                {
                    throw new Exception("Hạn sử dụng không hợp lệ!");
                }
                else if (string.IsNullOrEmpty(tex_soluong.Text))
                {
                    throw new Exception("Số lượng không hợp lệ!");
                }
                else if (com_donvi.SelectedIndex == 0)
                {
                    throw new Exception("Đơn vị tính không hợp lệ!");
                }
                else if (string.IsNullOrEmpty(tex_gianhap.Text))
                {
                    throw new Exception("Giá nhập không hợp lệ!");
                }

                using (VinamilkEntities vin = new VinamilkEntities())
                {
                    */
        /*SanPham sanP = vin.SanPhams.FirstOrDefault(s => s.maSanPham == sanPham.maSanPham);
                    if (sanP != null)
                    {
                        sanP.tenSanPham = tex_tensanpham.Text;
                        sanP.moTa = tex_mota.Text;
                        sanP.trangThai = che_trangthai.Checked;

                        DoiTuong doi = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == com_doituong.SelectedItem.ToString());
                        if (doi != null)
                        {
                            sanP.maDoiTuong = doi.maDoiTuong;
                        }

                        NhaSanXuat nha = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == com_nhasanxuat.SelectedItem.ToString());
                        if (nha != null)
                        {
                            sanP.maNhaSanXuat = nha.maNhaSanXuat;
                        }

                        vin.SaveChanges();

                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
        /*


                    if (vin.SanPhams.FirstOrDefault(s => s.maSanPham == sanPham.maSanPham) == null)
                    {
                        string tenSP = tex_tensanpham.Text.Replace(" ", "") ?? string.Empty;
                        string maSP = "sp" + (tenSP.Length >= 5 ? tenSP.Trim().Substring(0, 5) : tenSP) + DateTime.Now.ToString("fff");

                        DoiTuong doi = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == com_doituong.SelectedItem.ToString());
                        string maDT = "";
                        if (doi != null) { maDT = doi.maDoiTuong; }

                        NhaSanXuat nha = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == com_nhasanxuat.SelectedItem.ToString());
                        string maNX = "";
                        if (nha != null) { maNX = nha.maNhaSanXuat; }

                        SanPham sanPh = new SanPham
                        {
                            maSanPham = maSP.ToLower(),
                            tenSanPham = tex_tensanpham.Text,
                            moTa = tex_mota.Text,
                            maDoiTuong = maDT,
                            maNhaSanXuat = maNX,
                            trangThai = che_trangthai.Checked
                        };

                        SanPham sanP = vin.SanPhams.FirstOrDefault(s => s.maSanPham == sanPh.maSanPham);
                        if (sanPh == null)
                        {
                            string hinh = "";
                            if (File.Exists(imagePath))
                            {
                                string[] src = imagePath.Split('\\');
                                hinh = src[src.Length - 1];
                                if (!File.Exists(folImage + hinh))
                                {
                                    File.Copy(imagePath, folImage + hinh);
                                }
                            }
                            else
                            {
                                hinh = "no-image";
                            }

                            int gN = int.Parse(tex_gianhap.Text ?? "0");
                            int gB = gN + (gN / 100 * 20);

                            DonVi don = vin.DonVis.FirstOrDefault(d => d.tenDonVi == com_donvi.SelectedItem.ToString());
                            string donV = don.maDonVi;

                            ChiTietSanPham chiTietSanPham = new ChiTietSanPham
                            {
                                maChiTietSanPham = "ctsp" + DateTime.Now.ToString("ssffff"),
                                maSanPham = maSP,
                                maDonVi = donV,
                                hinhAnh = hinh,
                                ngaySanXuat = dat_nsx.Value,
                                ngayHetHan = dat_hsd.Value,
                                giaNhap = gN,
                                giaBan = gB,
                                soLuong = int.Parse(tex_soluong.Text ?? "0")
                            };

                            ChiTietSanPham chiT = vin.ChiTietSanPhams.FirstOrDefault(c => c.maChiTietSanPham == chiTietSanPham.maChiTietSanPham);
                            if (chiT == null)
                            {
                                vin.SanPhams.Add(sanPh);
                                vin.SaveChanges();
                                vin.ChiTietSanPhams.Add(chiTietSanPham);
                                vin.SaveChanges();
                                SanPhamUC_LoadAsync(sender, e);
                                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        //cap nhat san pham
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void But_xoa_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Tex_timkiem_Enter(object sender, EventArgs e)
        {
            if (tex_timkiem.Text == "Nhập mã sản phẩm hoặc tên sản phẩm ở đây")
            {
                tex_timkiem.Clear();
            }
            tex_timkiem.ForeColor = Color.Black;
            tex_timkiem.Font = new Font("Arial", 12);
        }

        private void Tex_timkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_timkiem.Text))
            {
                tex_timkiem.Text = "Nhập mã sản phẩm hoặc tên sản phẩm ở đây";
                tex_timkiem.ForeColor = Color.Gray;
                tex_timkiem.Font = new Font("Arial", 12, FontStyle.Italic);
            }
        }

        private void But_loc_Click(object sender, EventArgs e)
        {
            //gro_boloc.Visible = !gro_boloc.Visible;

            if (gro_boloc.Visible)
            {
                gro_boloc.Visible = false;
                pan_timkiem.Height = 52;
            }
            else
            {
                gro_boloc.Visible = true;
                pan_timkiem.Height = 256;
            }
        }

        private void Tsm_nsx_Click(object sender, EventArgs e)
        {
            NhaSanXuatUC nha = new NhaSanXuatUC();
            nha.BackButtonClicked += Uc_back;

            OpenUserControl(nha);
        }

        private void Uc_back(object sender, EventArgs e)
        {
            pan_grid.Controls.Remove(sender as Control);

            pan_menu.Width = 200;
            pan_timkiem.Height = 52;
            pan_chitiet.Width = 512;
        }

        void OpenUserControl(UserControl uc)
        {
            pan_menu.Width = 0;
            pan_timkiem.Height = 0;
            pan_chitiet.Width = 0;

            pan_grid.Controls.Add(uc);
            uc.BackColor = Color.MintCream;
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
        }

        private void Tsm_phanloai_Click(object sender, EventArgs e)
        {
            DoiTuongUC pha = new DoiTuongUC();
            pha.BackButtonClicked += Uc_back;

            OpenUserControl(pha);
        }

        private void Tsm_donvi_Click(object sender, EventArgs e)
        {
            DonViTinhUC don = new DonViTinhUC();
            don.BackButtonClicked += Uc_back;

            OpenUserControl(don);
        }

        private void Pic_sanpham_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;

                    pic_sanpham.Image = Image.FromFile(imagePath);

                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dat_sanpham_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dat_sanpham.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void Tex_gianhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tex_soluong.Text))
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OnlyNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tex_gianhap_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tex_gianhap.Text))
            {
                long gN = long.Parse(tex_gianhap.Text);
                long gB = gN + (gN / 100 * 20);
                tex_giaban.Text = gB.ToString();
            }
        }
    }
}
