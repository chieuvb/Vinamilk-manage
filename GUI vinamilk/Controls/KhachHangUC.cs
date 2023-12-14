﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI_vinamilk.Controls
{
    public partial class KhachHangUC : UserControl
    {
        public KhachHangUC()
        {
            InitializeComponent();
        }

        KhachHang khachHang = new KhachHang();

        private void KhachHangUC_Load(object sender, EventArgs e)
        {
            panelChiTiet.Visible = false;
            buttonLuu.Visible = false;

            RefreshData();
        }

        private async void RefreshData()
        {
            using (VinamilkEntities vinamilkEntities = new VinamilkEntities())
            {
                dataGridViewKhachHang.DataSource = await vinamilkEntities.KhachHangs.AsNoTracking().ToListAsync();
                List<LoaiKhachHang> loaiKhachHangs = await vinamilkEntities.LoaiKhachHangs.AsNoTracking().ToListAsync();

                comboBoxLoaiKhachHang.Items.Clear();
                comboBoxLoaiKhachHang.Items.Add("-- Loại khách hàng --");

                foreach (LoaiKhachHang loai in loaiKhachHangs)
                {
                    if (!comboBoxLoaiKhachHang.Items.Contains(loai.tenLoaiKhachHang))
                        comboBoxLoaiKhachHang.Items.Add(loai.tenLoaiKhachHang);
                }

                comboBoxLoaiKhachHang.SelectedIndex = 0;
            }
        }

        private void DataGridViewKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewKhachHang.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
        }

        private void DataGridViewKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    panelChiTiet.Visible = true;

                    DataGridViewRow row = dataGridViewKhachHang.Rows[e.RowIndex];

                    khachHang = new KhachHang
                    {
                        maKhachHang = row.Cells["maKhachHangDataGridViewTextBoxColumn"].Value.ToString(),
                        maLoaiKhachHang = row.Cells["maLoaiKhachHangDataGridViewTextBoxColumn"].Value.ToString(),
                        tenKhachHang = row.Cells["tenKhachHangDataGridViewTextBoxColumn"].Value.ToString(),
                        diaChi = row.Cells["diaChiDataGridViewTextBoxColumn"].Value.ToString(),
                        soDienThoai = row.Cells["soDienThoaiDataGridViewTextBoxColumn"].Value.ToString(),
                        email = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString(),
                        diemTichLuy = short.Parse(row.Cells["diemTichLuyDataGridViewTextBoxColumn"].Value.ToString()),
                        ngayDangKy = (DateTime)row.Cells["ngayDangKyDataGridViewTextBoxColumn"].Value
                    };

                    textBoxTenKhachHang.Text = khachHang.tenKhachHang;
                    textBoxDiaChi.Text = khachHang.diaChi;
                    textBoxSoDienThoai.Text = khachHang.soDienThoai;
                    textBoxEmail.Text = khachHang.email;
                    dateTimePickerNgayDangKy.Value = khachHang.ngayDangKy;
                    labelDiemTichLuy.Text = "Điểm tích lũy: " + khachHang.diemTichLuy.ToString();

                    using (VinamilkEntities vinamilkEntities = new VinamilkEntities())
                    {
                        LoaiKhachHang loaiKhach = vinamilkEntities.LoaiKhachHangs.AsNoTracking().FirstOrDefault(l => l.maLoaiKhachHang == khachHang.maLoaiKhachHang);

                        if (loaiKhach != null)
                        {
                            string item = loaiKhach.tenLoaiKhachHang;

                            if (comboBoxLoaiKhachHang.Items.Contains(item))
                                comboBoxLoaiKhachHang.SelectedItem = item;
                            else
                                comboBoxLoaiKhachHang.SelectedIndex = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi cell click: " + ex.Message);
            }
        }

        private void ButtonKhachHangMoi_Click(object sender, EventArgs e)
        {
            khachHang.maKhachHang = GenerateMaKhachHang(textBoxTenKhachHang.Text);

            panelChiTiet.Visible = !panelChiTiet.Visible;

            textBoxTenKhachHang.Clear();
            comboBoxLoaiKhachHang.SelectedIndex = 0;
            textBoxDiaChi.Clear();
            textBoxSoDienThoai.Clear();
            textBoxEmail.Clear();
            dateTimePickerNgayDangKy.Value = DateTime.Now;
            labelDiemTichLuy.Text = "Điểm tích lũy: 0";
        }

        private void GroupBoxThongTinKhachHang_Enter(object sender, EventArgs e)
        {
            buttonLuu.Visible = true;
        }

        private void LuttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (khachHang.maKhachHang == "kh-khdonle")
                {
                    MessageBox.Show("Đây là bản ghi đặc biệt, không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string result = ValidateInputs();

                if (result == "success")
                {
                    using (VinamilkEntities vinamilkEntities = new VinamilkEntities())
                    {
                        KhachHang existingKhachHang = vinamilkEntities.KhachHangs.FirstOrDefault(k => k.maKhachHang == khachHang.maKhachHang);

                        if (existingKhachHang == null)
                            AddNewKhachHang(vinamilkEntities, khachHang.maKhachHang);
                        else
                            UpdateKhachHang(vinamilkEntities, existingKhachHang);
                    }
                }
                else
                {
                    throw new Exception(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidateInputs()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxTenKhachHang.Text))
                    return "Chưa nhập tên khách hàng!";
                if (comboBoxLoaiKhachHang.SelectedIndex <= 0)
                    return "Loại khách hàng không hợp lệ!";
                if (string.IsNullOrEmpty(textBoxDiaChi.Text))
                    return "Địa chỉ khách hàng không được bỏ trống!";
                if (string.IsNullOrEmpty(textBoxSoDienThoai.Text) || !ValidatePhoneNumber(textBoxSoDienThoai.Text))
                    return "Vui lòng nhập số điện thoại hợp lệ!";
                if (string.IsNullOrEmpty(textBoxEmail.Text) || !ValidateEmail(textBoxEmail.Text))
                    return "Vui lòng nhập email hợp lệ!";
                else
                    return "success";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "fail";
            }
        }

        static bool ValidatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^(0[1-9][0-9]{8,9})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phoneNumber);
        }

        static bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private string GenerateMaKhachHang(string tenKhachHang)
        {
            try
            {
                string tenSanPham = tenKhachHang.Replace(" ", "") ?? string.Empty;
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
                Console.WriteLine("Lỗi tạo mã khách hàng: " + ex.Message);
                return string.Empty;
            }
        }

        private void AddNewKhachHang(VinamilkEntities vinamilkEntities, string maKhach)
        {
            try
            {
                LoaiKhachHang loaiKhachHang = vinamilkEntities.LoaiKhachHangs.AsNoTracking().FirstOrDefault(l => l.tenLoaiKhachHang == comboBoxLoaiKhachHang.SelectedItem.ToString());

                KhachHang khachHang = new KhachHang
                {
                    maKhachHang = maKhach,
                    maLoaiKhachHang = loaiKhachHang.maLoaiKhachHang,
                    tenKhachHang = textBoxTenKhachHang.Text.Trim(),
                    diaChi = textBoxDiaChi.Text.Trim(),
                    soDienThoai = textBoxSoDienThoai.Text.Trim(),
                    email = textBoxEmail.Text.Trim(),
                    diemTichLuy = short.Parse(labelDiemTichLuy.Text.Trim().Replace("Điểm tích lũy: ", "")),
                    ngayDangKy = dateTimePickerNgayDangKy.Value
                };

                vinamilkEntities.KhachHangs.Add(khachHang);
                vinamilkEntities.SaveChanges();

                RefreshData();

                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khách hàng mới: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateKhachHang(VinamilkEntities vinamilkEntities, KhachHang khach)
        {
            try
            {
                LoaiKhachHang loaiKhach = vinamilkEntities.LoaiKhachHangs.FirstOrDefault(l => l.tenLoaiKhachHang == comboBoxLoaiKhachHang.SelectedItem.ToString());

                khach.tenKhachHang = textBoxTenKhachHang.Text;
                khach.LoaiKhachHang = loaiKhach;
                khach.diaChi = textBoxDiaChi.Text;
                khach.soDienThoai = textBoxSoDienThoai.Text;
                khach.email = textBoxEmail.Text;
                khach.diemTichLuy = short.Parse(labelDiemTichLuy.Text.Replace("Điểm tích lũy: ", ""));
                khach.ngayDangKy = dateTimePickerNgayDangKy.Value;

                vinamilkEntities.SaveChanges();

                RefreshData();

                MessageBox.Show("Sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if (khachHang.maKhachHang == "kh-khdonle")
            {
                MessageBox.Show("Đây là bản ghi đặc biệt, không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Mọi thông tin về khách hàng \"" + khachHang.tenKhachHang + "\" sẽ bị xóa vĩnh viễn!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                XoaKhachHang();
            }
        }

        private void XoaKhachHang()
        {
            try
            {
                using (VinamilkEntities vinamilkEntities = new VinamilkEntities())
                {
                    KhachHang khach = vinamilkEntities.KhachHangs.FirstOrDefault(k => k.maKhachHang == khachHang.maKhachHang);

                    if (khach != null)
                        vinamilkEntities.KhachHangs.Remove(khach);

                    vinamilkEntities.SaveChanges();

                    RefreshData();

                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
