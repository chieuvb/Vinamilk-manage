using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI_vinamilk.Controls.Extra
{
    public partial class DoiTuongUC : UserControl
    {
        public event EventHandler BackButtonClicked;

        public DoiTuongUC()
        {
            InitializeComponent();
        }

        private void PhanLoaiHangUC_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();

                dat_doituong.Columns["luu"].Visible = false;
                dat_doituong.Columns["xoa"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void LoadData()
        {
            VinamilkEntities vinamilkEntities = new VinamilkEntities();
            DoiTuong doi = new DoiTuong();
            List<DoiTuong> dois = vinamilkEntities.DoiTuongs.ToList();
            dois.Add(doi);
            dat_doituong.DataSource = dois;
        }

        private void But_back_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void Dat_loaihang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dat_doituong.Rows[e.RowIndex].Cells["stt"].Value = e.RowIndex + 1;
            dat_doituong.Columns["stt"].Width = 64;
        }

        private void Dat_loaihang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && dat_doituong.Columns[e.ColumnIndex].Name == "luu" && e.RowIndex >= 0)
                {
                    DoiTuong doi = new DoiTuong
                    {
                        maDoiTuong = dat_doituong["maDoiTuongDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                        tenDoiTuong = dat_doituong["tenDoiTuongDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                        moTa = dat_doituong["moTaDataGridViewTextBoxColumn", e.RowIndex].Value?.ToString() ?? string.Empty,
                        trangThai = Convert.ToBoolean(dat_doituong["trangThaiDataGridViewCheckBoxColumn", e.RowIndex].Value ?? false)
                    };

                    using (VinamilkEntities vnm = new VinamilkEntities())
                    {
                        string maDoiTuong = "lh" + (doi.tenDoiTuong.Length >= 5 ? doi.tenDoiTuong.Trim().Substring(doi.tenDoiTuong.Replace(" ", "").Trim().Length - 5) : doi.tenDoiTuong) + DateTime.Now.ToString("fff");

                        RegexTiengViet reg = new RegexTiengViet();
                        string result = reg.RemoveVietnameseMarks(maDoiTuong.ToLower());

                        DoiTuong dt = new DoiTuong
                        {
                            maDoiTuong = result,
                            tenDoiTuong = doi.tenDoiTuong,
                            moTa = doi.moTa,
                            trangThai = doi.trangThai
                        };

                        if (dt.maDoiTuong.Length < 10)
                            throw new Exception("Tên của đối tượng không hợp lệ!");
                        else if (dt.moTa.Length < 10)
                            throw new Exception("Mô tả quá ngắn!");

                        DoiTuong doiTuong = vnm.DoiTuongs.FirstOrDefault(n => n.maDoiTuong == doi.maDoiTuong);

                        if (doiTuong == null)
                        {
                            vnm.DoiTuongs.Add(dt);
                            vnm.SaveChanges();
                            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            doiTuong.tenDoiTuong = doi.tenDoiTuong;
                            doiTuong.moTa = doi.moTa;
                            doiTuong.trangThai = doi.trangThai;
                            vnm.SaveChanges();
                            MessageBox.Show("Đã lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        LoadData();
                    }

                    dat_doituong.Columns["luu"].Visible = false;
                    dat_doituong.Columns["xoa"].Visible = false;
                }

                if (e.ColumnIndex >= 0 && dat_doituong.Columns[e.ColumnIndex].Name == "xoa" && e.RowIndex >= 0)
                {
                    if (dat_doituong.Rows[e.RowIndex].Cells["maDoiTuongDataGridViewTextBoxColumn"].Value == null)
                    {
                        return;
                    }

                    string nam = dat_doituong.Rows[e.RowIndex].Cells["tenDoiTuongDataGridViewTextBoxColumn"].Value.ToString();

                    if (MessageBox.Show("Đối tượng sử dụng \"" + nam + "\" sẽ bị xóa!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        using (var vnm = new VinamilkEntities())
                        {
                            string id = dat_doituong.Rows[e.RowIndex].Cells["maDoiTuongDataGridViewTextBoxColumn"].Value.ToString();

                            var doi = vnm.DoiTuongs.FirstOrDefault(n => n.maDoiTuong == id);

                            if (doi != null)
                            {
                                vnm.DoiTuongs.Remove(doi);
                                vnm.SaveChanges();
                                LoadData();

                                MessageBox.Show("Xóa \"" + nam + "\" thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Có lỗi khi xóa \"" + nam + "\"!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Dat_loaihang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            dat_doituong.Columns["luu"].Visible = true;
            dat_doituong.Columns["xoa"].Visible = true;
        }

        private void Dat_loaihang_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == 4)
            {
                dat_doituong.Columns["luu"].Visible = true;
                dat_doituong.Columns["xoa"].Visible = true;
            }
        }
    }
}
