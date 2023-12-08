using GUI_vinamilk.Controls.Extra;
using GUI_vinamilk.Properties;
using System;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        SanPham sanPham = new SanPham();

        private async void SanPhamUC_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                gro_boloc.Visible = false;
                //pan_chitiet.Visible = false;

                await LoadData();

                using (VinamilkEntities vin = new VinamilkEntities())
                {
                    string[] nhaSanXuats = await vin.NhaSanXuats.Select(nsx => nsx.tenNhaSanXuat).ToArrayAsync();
                    com_nhasanxuat.Items.AddRange(nhaSanXuats);

                    string[] doiTuongs = await vin.DoiTuongs.Select(dt => dt.tenDoiTuong).ToArrayAsync();
                    com_doituong.Items.AddRange(doiTuongs);

                    string[] donVis = await vin.DonVis.Select(dv => dv.tenDonVi).ToArrayAsync();
                    com_donvi.Items.AddRange(donVis);
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

        async Task LoadData()
        {
            using (VinamilkEntities vin = new VinamilkEntities())
            {
                dat_sanpham.DataSource = await vin.SanPhams.AsNoTracking().ToListAsync();
            }
        }

        private async void Dat_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                    pan_chitiet.Visible = true;

                    string maSanPham = dat_sanpham["maSanPhamC", e.RowIndex].Value?.ToString() ?? string.Empty;

                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        sanPham = await vin.SanPhams.FirstOrDefaultAsync(s => s.maSanPham == maSanPham);
                        ChiTietSanPham chiTiet = await vin.ChiTietSanPhams.FirstOrDefaultAsync(c => c.maSanPham == maSanPham);
                        NhaSanXuat nha = await vin.NhaSanXuats.FirstOrDefaultAsync(n => n.maNhaSanXuat == sanPham.maNhaSanXuat);
                        DoiTuong doi = await vin.DoiTuongs.FirstOrDefaultAsync(d => d.maDoiTuong == sanPham.maDoiTuong);
                        DonVi don = await vin.DonVis.FirstOrDefaultAsync(d => d.maDonVi == chiTiet.maDonVi);

                        if (sanPham != null && chiTiet != null)
                        {
                            tex_masanpham.Text = sanPham.maSanPham;
                            tex_tensanpham.Text = sanPham.tenSanPham;
                            tex_mota.Text = sanPham.moTa;
                            com_nhasanxuat.SelectedItem = nha?.tenNhaSanXuat;
                            com_doituong.SelectedItem = doi?.tenDoiTuong;
                            che_trangthai.Checked = sanPham.trangThai;

                            dat_nsx.Value = chiTiet.ngaySanXuat;
                            dat_hsd.Value = chiTiet.ngayHetHan;
                            tex_soluong.Text = chiTiet.soLuong.ToString();
                            com_donvi.SelectedItem = don?.tenDonVi;
                            tex_gianhap.Text = chiTiet.giaNhap.ToString();

                            string fullPath = Path.Combine(folImage, chiTiet.hinhAnh);

                            if (File.Exists(fullPath))
                            {
                                Image image = Image.FromFile(fullPath);
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    image.Save(ms, image.RawFormat);
                                    byte[] imageBytes = ms.ToArray();
                                    using (MemoryStream mem = new MemoryStream(imageBytes))
                                    {
                                        pic_sanpham.Image = Image.FromStream(mem);
                                    }
                                }
                            }
                            else
                            {
                                pic_sanpham.SizeMode = PictureBoxSizeMode.CenterImage;
                                pic_sanpham.Image = Resources.icons8_no_image_96;
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
            sanPham.maSanPham = GenerateMaSanPham();

            pan_chitiet.Visible = true;
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
            pic_sanpham.Image = Resources.icons8_add_image_96;
            tex_tensanpham.Focus();
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
                        UpdateSanPham(vin, existingSanPham);
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

        private string GenerateMaSanPham()
        {
            string tenSanPham = tex_tensanpham.Text.Replace(" ", "") ?? string.Empty;
            string maSanPham = "sp" + (tenSanPham.Length >= 5 ? tenSanPham.Trim().Substring(0, 5) : tenSanPham);

            int remainingLength = 10 - maSanPham.Length;
            if (remainingLength > 0)
            {
                maSanPham += Path.GetRandomFileName().Replace(".", "").Substring(0, remainingLength);
            }

            return maSanPham.ToLower();
        }


        private SanPham CreateSanPhamObject(string msp)
        {
            using (VinamilkEntities vin = new VinamilkEntities())
            {
                string tenSanPham = tex_tensanpham.Text ?? string.Empty;
                string moTa = tex_mota.Text ?? string.Empty;
                bool trangThai = che_trangthai.Checked;

                string selectedDoiTuong = com_doituong.SelectedItem?.ToString() ?? string.Empty;
                string maDT = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == selectedDoiTuong)?.maDoiTuong ?? "";

                string selectedNhaSanXuat = com_nhasanxuat.SelectedItem?.ToString() ?? string.Empty;
                string maNX = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == selectedNhaSanXuat)?.maNhaSanXuat ?? "";

                SanPham sanPham = new SanPham
                {
                    maSanPham = msp,
                    tenSanPham = tenSanPham,
                    moTa = moTa,
                    maDoiTuong = maDT,
                    maNhaSanXuat = maNX,
                    trangThai = trangThai
                };
                return sanPham;
            }
        }

        private ChiTietSanPham CreateChiTietSanPhamObject(string msp)
        {
            string hinhAnh = "no-image";
            int giaNhap = int.Parse(tex_gianhap.Text ?? "0");
            int giaBan = int.Parse(tex_giaban.Text ?? "0");

            using (MemoryStream ms = new MemoryStream())
            {
                Image img = pic_sanpham.Image;
                img.Save(ms, img.RawFormat);
                byte[] imb = ms.ToArray();

                using (MemoryStream bti = new MemoryStream(imb))
                {
                    pic_sanpham.Image = Image.FromStream(bti);

                    if (imb != null)
                    {
                        hinhAnh = msp + ".png";

                        Image imag = Image.FromStream(bti);
                        imag.Save(folImage + hinhAnh, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }

            using (VinamilkEntities vin = new VinamilkEntities())
            {
                string maDonVi = vin.DonVis.FirstOrDefault(d => d.tenDonVi == com_donvi.SelectedItem.ToString())?.maDonVi;

                ChiTietSanPham chiTietSanPham = new ChiTietSanPham
                {
                    maChiTietSanPham = "ctsp" + DateTime.Now.ToString("ssffff"),
                    maSanPham = msp,
                    maDonVi = maDonVi,
                    hinhAnh = hinhAnh,
                    ngaySanXuat = dat_nsx.Value,
                    ngayHetHan = dat_hsd.Value,
                    giaNhap = giaNhap,
                    giaBan = giaBan,
                    soLuong = int.Parse(tex_soluong.Text ?? "0")
                };
                return chiTietSanPham;
            }
        }

        private async void AddNewSanPham(VinamilkEntities vin)
        {
            string maSP = GenerateMaSanPham();

            SanPham sanPh = CreateSanPhamObject(maSP);
            ChiTietSanPham chiTietSanPham = CreateChiTietSanPhamObject(maSP);

            vin.SanPhams.Add(sanPh);
            vin.SaveChanges();

            chiTietSanPham.maSanPham = maSP;
            vin.ChiTietSanPhams.Add(chiTietSanPham);
            vin.SaveChanges();

            await LoadData();
            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void UpdateSanPham(VinamilkEntities vin, SanPham sanPham)
        {
            NhaSanXuat nhaSanXuat = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == com_nhasanxuat.SelectedItem.ToString());
            DoiTuong doiTuong = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == com_doituong.SelectedItem.ToString());
            ChiTietSanPham chiTietSanPham = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == sanPham.maSanPham);
            DonVi donVi = vin.DonVis.FirstOrDefault(d => d.tenDonVi == com_donvi.SelectedItem.ToString());

            string oldAnh = chiTietSanPham.hinhAnh.Trim();
            string newAnh = "no-image";

            /*if (pic_sanpham.Image != null && pic_sanpham.Image != Resources.icons8_no_image_96)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    Image image = pic_sanpham.Image;
                    image.Save(ms, image.RawFormat);
                    byte[] ibs = ms.ToArray();

                    using (MemoryStream mem = new MemoryStream(ibs))
                    {
                        newAnh = sanPham.maSanPham + ".png";

                        Image anh = Image.FromStream(mem);
                        anh.Save(folImage + newAnh, System.Drawing.Imaging.ImageFormat.Png);
                    }
                }
            }*/

            if (File.Exists(folImage + oldAnh))
            {
                pic_sanpham.Image.Dispose();
                File.Delete(folImage + oldAnh);
            }

            if (pic_sanpham.Image != null && pic_sanpham.Image != Resources.icons8_no_image_96)
            {
                newAnh = sanPham.maSanPham + ".png";
                pic_sanpham.Image.Save(folImage + newAnh, System.Drawing.Imaging.ImageFormat.Png);
            }

            sanPham.maNhaSanXuat = nhaSanXuat.maNhaSanXuat;
            sanPham.maDoiTuong = doiTuong.maDoiTuong;
            sanPham.tenSanPham = tex_tensanpham.Text;
            sanPham.moTa = tex_mota.Text;
            sanPham.trangThai = che_trangthai.Checked;

            chiTietSanPham.maDonVi = donVi.maDonVi;
            chiTietSanPham.hinhAnh = newAnh;
            chiTietSanPham.ngaySanXuat = dat_nsx.Value;
            chiTietSanPham.ngayHetHan = dat_hsd.Value;
            chiTietSanPham.giaNhap = double.Parse(tex_giaban.Text);
            chiTietSanPham.giaBan = double.Parse(tex_gianhap.Text);
            chiTietSanPham.soLuong = int.Parse(tex_soluong.Text);

            vin.SaveChanges();

            await LoadData();
            MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void But_xoa_Click(object sender, EventArgs e)
        {
            /*try
            {
                DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa sản phẩm: \"" + tex_tensanpham.Text + "\"?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        SanPham sanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == tex_masanpham.Text);
                        ChiTietSanPham chiTiet = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == tex_masanpham.Text);
                        if (sanPham != null && chiTiet != null)
                        {
                            File.Delete(folImage + chiTiet.hinhAnh);
                            vin.ChiTietSanPhams.Remove(chiTiet);
                            vin.SanPhams.Remove(sanPham);
                            vin.SaveChanges();

                            await LoadData();
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            try
            {
                DialogResult dr = MessageBox.Show("Bạn có thực sự muốn xóa sản phẩm: \"" + tex_tensanpham.Text + "\"?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        SanPham sanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == tex_masanpham.Text);
                        ChiTietSanPham chiTiet = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == tex_masanpham.Text);
                        if (sanPham != null && chiTiet != null)
                        {
                            try
                            {
                                pic_sanpham.Image.Dispose();
                                File.Delete(folImage + chiTiet.hinhAnh);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            try
                            {
                                vin.ChiTietSanPhams.Remove(chiTiet);
                                vin.SanPhams.Remove(sanPham);
                                vin.SaveChanges();

                                await LoadData();
                                MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
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
            //pan_chitiet.Width = 0;

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
                /*OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;

                    string imagePath = openFileDialog.FileName;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        Image img = Image.FromFile(imagePath);
                        img.Save(ms, img.RawFormat);
                        byte[] imageBytes = ms.ToArray();

                        using (MemoryStream bti = new MemoryStream(imageBytes))
                        {
                            pic_sanpham.Image = Image.FromStream(bti);
                        }
                    }
                }*/

                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png; *.webp"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;

                    string imagePath = openFileDialog.FileName;

                    // Sử dụng Load() để hiển thị hình ảnh trực tiếp từ đường dẫn tệp
                    pic_sanpham.Image = Image.FromFile(imagePath);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            pic_sanpham.Dispose();
        }
    }
}
