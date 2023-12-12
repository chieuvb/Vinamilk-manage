using GUI_vinamilk.Controls.Extra;
using GUI_vinamilk.Properties;
using System;
using System.Collections.Generic;
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

        readonly string sourceFolder = @"C:\Vinamilk manage\image\products\";
        readonly Dictionary<string, Image> cacheImage = new Dictionary<string, Image>();
        SanPham sanPham = new SanPham();

        private void LoadAndCacheImage(string key)
        {
            try
            {
                string imagePath = sourceFolder + key + ".png";

                if (cacheImage.ContainsKey(key))
                    return;

                if (File.Exists(imagePath))
                {
                    using (Image image = Image.FromFile(imagePath))
                    {
                        using (MemoryStream mem = new MemoryStream())
                        {
                            image.Save(mem, image.RawFormat);

                            if (cacheImage.TryGetValue(key, out Image existingImage))
                            {
                                existingImage.Dispose();
                                cacheImage[key] = Image.FromStream(mem);
                            }
                            else
                                cacheImage.Add(key, Image.FromStream(mem));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu ảnh vào bộ đệm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SaveAndCacheImage(string key)
        {
            try
            {
                Image imageToSave = pic_sanpham.Image;

                string destinationFile = sourceFolder + key + ".png";

                if (imageToSave != null && imageToSave.Width >= 128 && !File.Exists(destinationFile))
                {
                    using (imageToSave)
                    {
                        imageToSave.Save(destinationFile, System.Drawing.Imaging.ImageFormat.Png);

                        LoadAndCacheImage(key);
                    }

                    return key;
                }
                else if (File.Exists(destinationFile))
                {
                    UpdateImage(key);
                    return key;
                }
                else
                    return "no-image";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "no-image";
            }
        }

        private void UpdateImage(string key)
        {
            try
            {
                string sourceFile = sourceFolder + key + ".png";

                if (File.Exists(sourceFile))
                    File.Delete(sourceFile);

                if (cacheImage.ContainsKey(key))
                    cacheImage.Remove(key);

                SaveAndCacheImage(key);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteImage(string key)
        {
            try
            {
                string sourceFile = sourceFolder + key + ".png";

                if (File.Exists(sourceFile))
                    File.Delete(sourceFile);

                if (cacheImage.ContainsKey(key))
                    cacheImage.Remove(key);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SanPhamUC_LoadAsync(object sender, EventArgs e)
        {
            try
            {
                gro_boloc.Visible = false;
                pan_chitiet.Visible = false;

                await RefreshData();

                if (!Directory.Exists(sourceFolder))
                    Directory.CreateDirectory(sourceFolder);

                if (!cacheImage.ContainsKey("no-image"))
                    cacheImage.Add("no-image", Resources.icons8_no_image_96);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi động: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task RefreshData()
        {
            try
            {
                using (VinamilkEntities vin = new VinamilkEntities())
                {
                    dat_sanpham.DataSource = await vin.SanPhams.AsNoTracking().ToListAsync();

                    com_nhasanxuat.Items.Clear();
                    com_nhasanxuat.Items.Add("-- Nhà sản xuất --");
                    string[] nhaSX = await vin.NhaSanXuats.Select(nsx => nsx.tenNhaSanXuat).ToArrayAsync();
                    foreach (string s in nhaSX)
                    {
                        if (!com_nhasanxuat.Items.Contains(s))
                            com_nhasanxuat.Items.Add(s);
                    }
                    com_nhasanxuat.SelectedIndex = 0;

                    com_doituong.Items.Clear();
                    com_doituong.Items.Add("-- Đối tượng sử dụng --");
                    string[] doiT = await vin.DoiTuongs.Select(dt => dt.tenDoiTuong).ToArrayAsync();
                    foreach (string d in doiT)
                    {
                        if (!com_doituong.Items.Contains(d))
                            com_doituong.Items.Add(d);
                    }
                    com_doituong.SelectedIndex = 0;

                    com_donvi.Items.Clear();
                    com_donvi.Items.Add("-- Đơn vị tính --");
                    string[] donV = await vin.DonVis.Select(dv => dv.tenDonVi).ToArrayAsync();
                    foreach (string d in donV)
                    {
                        if (!com_donvi.Items.Contains(d))
                            com_donvi.Items.Add(d);
                    }
                    com_donvi.SelectedIndex = 0;
                }

                pan_chitiet.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Dat_sanpham_CellContentDoubleClickAsync(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    pan_chitiet.Visible = true;

                    string maSanPham = dat_sanpham["maSanPhamC", e.RowIndex].Value?.ToString() ?? string.Empty;
                    string imageKey = null;

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

                            imageKey = chiTiet.hinhAnh.Trim();
                        }
                    }

                    if (imageKey != null)
                        LoadAndCacheImage(imageKey);

                    if (cacheImage.ContainsKey(imageKey))
                        pic_sanpham.Image = cacheImage[imageKey];
                    else
                        pic_sanpham.Image = cacheImage["no-image"];

                    if (pic_sanpham.Image != null)
                    {
                        if (pic_sanpham.Image.Width <= 128 && pic_sanpham.Image.Height <= 128)
                            pic_sanpham.SizeMode = PictureBoxSizeMode.CenterImage;
                        else
                            pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                        pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chuyển dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_them_Click(object sender, EventArgs e)
        {
            sanPham.maSanPham = GenerateMaSanPham();
            pan_chitiet.Visible = !pan_chitiet.Visible;

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
                string result = ValidateInputs();
                if (result == "success")
                {
                    using (VinamilkEntities vin = new VinamilkEntities())
                    {
                        SanPham existingSanPham = vin.SanPhams.FirstOrDefault(s => s.maSanPham == sanPham.maSanPham);
                        if (existingSanPham == null)
                            AddNewSanPham(vin);
                        else
                            UpdateSanPham(vin, existingSanPham);
                    }
                }
                else
                    throw new Exception(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateInputs()
        {
            try
            {
                if (string.IsNullOrEmpty(tex_tensanpham.Text))
                    return "Bạn chưa nhập tên sản phẩm!";
                else if (string.IsNullOrEmpty(tex_mota.Text))
                    return "Bạn cần mô tả cho sản phẩm!";
                else if (com_nhasanxuat.SelectedIndex == 0)
                    return "Bạn cần chọn nhà sản xuất!";
                else if (com_doituong.SelectedIndex == 0)
                    return "Bạn cần chọn đối tượng sử dụng!";
                else if (dat_nsx.Value >= DateTime.Now)
                    return "Ngày sản xuất không hợp lệ!";
                else if (dat_hsd.Value <= dat_nsx.Value)
                    return "Hạn sử dụng không hợp lệ!";
                else if (string.IsNullOrEmpty(tex_soluong.Text))
                    return "Số lượng không hợp lệ!";
                else if (com_donvi.SelectedIndex == 0)
                    return "Đơn vị tính không hợp lệ!";
                else if (string.IsNullOrEmpty(tex_gianhap.Text))
                    return "Giá nhập không hợp lệ!";
                else
                    return "success";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "fail";
            }
        }

        private string GenerateMaSanPham()
        {
            try
            {
                string tenSanPham = tex_tensanpham.Text.Replace(" ", "") ?? string.Empty;
                string maSanPham = "sp" + (tenSanPham.Length >= 5 ? tenSanPham.Trim().Substring(0, 5) : tenSanPham);

                int remainingLength = 10 - maSanPham.Length;
                if (remainingLength > 0)
                    maSanPham += Path.GetRandomFileName().Replace(".", "").Substring(0, remainingLength);

                RegexTiengViet reg = new RegexTiengViet();
                string result = reg.RemoveVietnameseMarks(maSanPham.ToLower());

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        private SanPham CreateSanPhamObject(string msp)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private ChiTietSanPham CreateChiTietSanPhamObject(string msp)
        {
            try
            {
                int giaNhap = int.Parse(tex_gianhap.Text ?? "0");
                int giaBan = int.Parse(tex_giaban.Text ?? "0");

                string hinhAnh = SaveAndCacheImage(msp);

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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo chi tiết sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private async void AddNewSanPham(VinamilkEntities vin)
        {
            try
            {
                string maSP = GenerateMaSanPham();
                SanPham sanPh = CreateSanPhamObject(maSP);
                ChiTietSanPham chiTietSanPham = CreateChiTietSanPhamObject(maSP);

                vin.SanPhams.Add(sanPh);
                vin.SaveChanges();
                chiTietSanPham.maSanPham = maSP;
                vin.ChiTietSanPhams.Add(chiTietSanPham);

                vin.SaveChanges();
                await RefreshData();

                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sản phẩm mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void UpdateSanPham(VinamilkEntities vin, SanPham sanPham)
        {
            try
            {
                NhaSanXuat nhaSanXuat = vin.NhaSanXuats.FirstOrDefault(n => n.tenNhaSanXuat == com_nhasanxuat.SelectedItem.ToString());
                DoiTuong doiTuong = vin.DoiTuongs.FirstOrDefault(d => d.tenDoiTuong == com_doituong.SelectedItem.ToString());
                ChiTietSanPham chiTietSanPham = vin.ChiTietSanPhams.FirstOrDefault(c => c.maSanPham == sanPham.maSanPham);
                DonVi donVi = vin.DonVis.FirstOrDefault(d => d.tenDonVi == com_donvi.SelectedItem.ToString());

                string newAnh = sanPham.maSanPham;

                UpdateImage(newAnh);

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

                await RefreshData();
                MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void But_xoa_Click(object sender, EventArgs e)
        {
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
                            DeleteImage(chiTiet.maSanPham);

                            vin.ChiTietSanPhams.Remove(chiTiet);
                            vin.SanPhams.Remove(sanPham);
                            vin.SaveChanges();

                            await RefreshData();
                            MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void But_timkiem_Click(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }

        private void Tex_timkiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemSanPham();
        }

        private void TimKiemSanPham()
        {
            try
            {
                RegexTiengViet reg = new RegexTiengViet();

                using (VinamilkEntities vin = new VinamilkEntities())
                {
                    string keyword = reg.RemoveVietnameseMarks(tex_timkiem.Text.ToLower());

                    List<SanPham> sanPhams = vin.SanPhams.ToList();

                    List<SanPham> filteredSanPhams = sanPhams.Where(s => reg.RemoveVietnameseMarks(s.tenSanPham.ToLower()).Contains(keyword) || s.maSanPham.Contains(keyword)).ToList();

                    dat_sanpham.DataSource = filteredSanPhams;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm kiếm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string imagePath = openFileDialog.FileName;
                    pic_sanpham.SizeMode = PictureBoxSizeMode.Zoom;
                    Image image = Image.FromFile(imagePath);
                    pic_sanpham.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            pan_grid.Controls.Add(dat_sanpham);
            pan_grid.Controls.Add(pan_timkiem);
            pan_menu.Visible = true;
            pan_timkiem.Visible = true;
            pan_chitiet.Visible = true;
        }

        private void OpenUserControl(UserControl uc)
        {
            pan_menu.Visible = false;
            pan_timkiem.Visible = false;
            pan_chitiet.Visible = false;

            pan_grid.Controls.Clear();
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

        private async void Pan_grid_ControlAddedAsync(object sender, ControlEventArgs e)
        {
            await RefreshData();
        }

        private void But_closepan_Click(object sender, EventArgs e)
        {
            pan_chitiet.Visible = false;
        }
    }
}
