namespace GUI_vinamilk.Controls
{
    partial class SanPhamUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamUC));
            this.dat_sanpham = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPhamC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pan_menu = new System.Windows.Forms.Panel();
            this.but_them = new System.Windows.Forms.Button();
            this.men_nsx = new System.Windows.Forms.MenuStrip();
            this.tsmi_them = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_nsx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_doituong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_donvi = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_chitiet = new System.Windows.Forms.Panel();
            this.pic_sanpham = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.com_donvi = new System.Windows.Forms.ComboBox();
            this.che_trangthai = new System.Windows.Forms.CheckBox();
            this.but_xoa = new System.Windows.Forms.Button();
            this.but_luu = new System.Windows.Forms.Button();
            this.tex_soluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tex_gianhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tex_giaban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dat_hsd = new System.Windows.Forms.DateTimePicker();
            this.dat_nsx = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_mota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.com_doituong = new System.Windows.Forms.ComboBox();
            this.lab_doituong = new System.Windows.Forms.Label();
            this.com_nhasanxuat = new System.Windows.Forms.ComboBox();
            this.lab_nhasanxuat = new System.Windows.Forms.Label();
            this.tex_tensanpham = new System.Windows.Forms.TextBox();
            this.lab_tensanpham = new System.Windows.Forms.Label();
            this.tex_masanpham = new System.Windows.Forms.TextBox();
            this.pan_grid = new System.Windows.Forms.Panel();
            this.pan_timkiem = new System.Windows.Forms.Panel();
            this.but_loc = new System.Windows.Forms.Button();
            this.gro_boloc = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.but_timkiem = new System.Windows.Forms.Button();
            this.tex_timkiem = new System.Windows.Forms.TextBox();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.pan_menu.SuspendLayout();
            this.men_nsx.SuspendLayout();
            this.pan_chitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sanpham)).BeginInit();
            this.pan_grid.SuspendLayout();
            this.pan_timkiem.SuspendLayout();
            this.gro_boloc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dat_sanpham
            // 
            this.dat_sanpham.AllowUserToAddRows = false;
            this.dat_sanpham.AllowUserToDeleteRows = false;
            this.dat_sanpham.AllowUserToResizeColumns = false;
            this.dat_sanpham.AllowUserToResizeRows = false;
            this.dat_sanpham.AutoGenerateColumns = false;
            this.dat_sanpham.BackgroundColor = System.Drawing.Color.Snow;
            this.dat_sanpham.ColumnHeadersHeight = 32;
            this.dat_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maSanPhamC,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.tenSanPhamC,
            this.moTaC,
            this.trangThaiC,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dat_sanpham.DataSource = this.sanPhamBindingSource;
            this.dat_sanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_sanpham.Location = new System.Drawing.Point(0, 52);
            this.dat_sanpham.MultiSelect = false;
            this.dat_sanpham.Name = "dat_sanpham";
            this.dat_sanpham.ReadOnly = true;
            this.dat_sanpham.RowTemplate.Height = 32;
            this.dat_sanpham.Size = new System.Drawing.Size(1206, 877);
            this.dat_sanpham.TabIndex = 0;
            this.dat_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_sanpham_CellClick);
            this.dat_sanpham.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.Dat_sanpham_RowPrePaint);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 64;
            // 
            // maSanPhamC
            // 
            this.maSanPhamC.DataPropertyName = "maSanPham";
            this.maSanPhamC.HeaderText = "maSanPham";
            this.maSanPhamC.Name = "maSanPhamC";
            this.maSanPhamC.ReadOnly = true;
            this.maSanPhamC.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "maNhaSanXuat";
            this.dataGridViewTextBoxColumn2.HeaderText = "maNhaSanXuat";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "maDoiTuong";
            this.dataGridViewTextBoxColumn4.HeaderText = "maDoiTuong";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // tenSanPhamC
            // 
            this.tenSanPhamC.DataPropertyName = "tenSanPham";
            this.tenSanPhamC.HeaderText = "Tên sản phẩm";
            this.tenSanPhamC.Name = "tenSanPhamC";
            this.tenSanPhamC.ReadOnly = true;
            this.tenSanPhamC.Width = 500;
            // 
            // moTaC
            // 
            this.moTaC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTaC.DataPropertyName = "moTa";
            this.moTaC.HeaderText = "Mô tả";
            this.moTaC.Name = "moTaC";
            this.moTaC.ReadOnly = true;
            // 
            // trangThaiC
            // 
            this.trangThaiC.DataPropertyName = "trangThai";
            this.trangThaiC.HeaderText = "Trạng thái";
            this.trangThaiC.Name = "trangThaiC";
            this.trangThaiC.ReadOnly = true;
            this.trangThaiC.Visible = false;
            this.trangThaiC.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ChiTietDonHangs";
            this.dataGridViewTextBoxColumn12.HeaderText = "ChiTietDonHangs";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ChiTietSanPhams";
            this.dataGridViewTextBoxColumn13.HeaderText = "ChiTietSanPhams";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DoiTuong";
            this.dataGridViewTextBoxColumn14.HeaderText = "DoiTuong";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "NhaSanXuat";
            this.dataGridViewTextBoxColumn15.HeaderText = "NhaSanXuat";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(GUI_vinamilk.SanPham);
            // 
            // pan_menu
            // 
            this.pan_menu.BackColor = System.Drawing.Color.Honeydew;
            this.pan_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_menu.Controls.Add(this.but_them);
            this.pan_menu.Controls.Add(this.men_nsx);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_menu.Location = new System.Drawing.Point(0, 8);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Padding = new System.Windows.Forms.Padding(8);
            this.pan_menu.Size = new System.Drawing.Size(200, 931);
            this.pan_menu.TabIndex = 1;
            // 
            // but_them
            // 
            this.but_them.BackColor = System.Drawing.Color.LightSteelBlue;
            this.but_them.FlatAppearance.BorderSize = 0;
            this.but_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_them.Image = ((System.Drawing.Image)(resources.GetObject("but_them.Image")));
            this.but_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_them.Location = new System.Drawing.Point(8, 8);
            this.but_them.Name = "but_them";
            this.but_them.Size = new System.Drawing.Size(184, 32);
            this.but_them.TabIndex = 0;
            this.but_them.Text = "Thêm sản phẩm";
            this.but_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_them.UseVisualStyleBackColor = false;
            this.but_them.Click += new System.EventHandler(this.But_them_Click);
            // 
            // men_nsx
            // 
            this.men_nsx.AutoSize = false;
            this.men_nsx.BackColor = System.Drawing.Color.LightSteelBlue;
            this.men_nsx.Dock = System.Windows.Forms.DockStyle.None;
            this.men_nsx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_nsx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_them});
            this.men_nsx.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.men_nsx.Location = new System.Drawing.Point(8, 265);
            this.men_nsx.Name = "men_nsx";
            this.men_nsx.Size = new System.Drawing.Size(184, 36);
            this.men_nsx.TabIndex = 1;
            // 
            // tsmi_them
            // 
            this.tsmi_them.AutoSize = false;
            this.tsmi_them.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_nsx,
            this.tsm_doituong,
            this.tsm_donvi});
            this.tsmi_them.Name = "tsmi_them";
            this.tsmi_them.Size = new System.Drawing.Size(180, 32);
            this.tsmi_them.Text = "Tùy chọn";
            this.tsmi_them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmi_them.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // tsm_nsx
            // 
            this.tsm_nsx.Name = "tsm_nsx";
            this.tsm_nsx.Size = new System.Drawing.Size(165, 22);
            this.tsm_nsx.Text = "Nhà sản xuất";
            this.tsm_nsx.Click += new System.EventHandler(this.Tsm_nsx_Click);
            // 
            // tsm_doituong
            // 
            this.tsm_doituong.Name = "tsm_doituong";
            this.tsm_doituong.Size = new System.Drawing.Size(165, 22);
            this.tsm_doituong.Text = "Đối tượng";
            this.tsm_doituong.Click += new System.EventHandler(this.Tsm_phanloai_Click);
            // 
            // tsm_donvi
            // 
            this.tsm_donvi.Name = "tsm_donvi";
            this.tsm_donvi.Size = new System.Drawing.Size(165, 22);
            this.tsm_donvi.Text = "Đơn vị tính";
            this.tsm_donvi.Click += new System.EventHandler(this.Tsm_donvi_Click);
            // 
            // pan_chitiet
            // 
            this.pan_chitiet.BackColor = System.Drawing.Color.Honeydew;
            this.pan_chitiet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_chitiet.Controls.Add(this.pic_sanpham);
            this.pan_chitiet.Controls.Add(this.label8);
            this.pan_chitiet.Controls.Add(this.label6);
            this.pan_chitiet.Controls.Add(this.com_donvi);
            this.pan_chitiet.Controls.Add(this.che_trangthai);
            this.pan_chitiet.Controls.Add(this.but_xoa);
            this.pan_chitiet.Controls.Add(this.but_luu);
            this.pan_chitiet.Controls.Add(this.tex_soluong);
            this.pan_chitiet.Controls.Add(this.label7);
            this.pan_chitiet.Controls.Add(this.tex_gianhap);
            this.pan_chitiet.Controls.Add(this.label5);
            this.pan_chitiet.Controls.Add(this.tex_giaban);
            this.pan_chitiet.Controls.Add(this.label4);
            this.pan_chitiet.Controls.Add(this.dat_hsd);
            this.pan_chitiet.Controls.Add(this.dat_nsx);
            this.pan_chitiet.Controls.Add(this.label3);
            this.pan_chitiet.Controls.Add(this.label2);
            this.pan_chitiet.Controls.Add(this.tex_mota);
            this.pan_chitiet.Controls.Add(this.label1);
            this.pan_chitiet.Controls.Add(this.com_doituong);
            this.pan_chitiet.Controls.Add(this.lab_doituong);
            this.pan_chitiet.Controls.Add(this.com_nhasanxuat);
            this.pan_chitiet.Controls.Add(this.lab_nhasanxuat);
            this.pan_chitiet.Controls.Add(this.tex_tensanpham);
            this.pan_chitiet.Controls.Add(this.lab_tensanpham);
            this.pan_chitiet.Controls.Add(this.tex_masanpham);
            this.pan_chitiet.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_chitiet.Location = new System.Drawing.Point(1408, 8);
            this.pan_chitiet.Name = "pan_chitiet";
            this.pan_chitiet.Size = new System.Drawing.Size(512, 931);
            this.pan_chitiet.TabIndex = 2;
            // 
            // pic_sanpham
            // 
            this.pic_sanpham.BackColor = System.Drawing.Color.Snow;
            this.pic_sanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_sanpham.Location = new System.Drawing.Point(5, 5);
            this.pic_sanpham.Name = "pic_sanpham";
            this.pic_sanpham.Size = new System.Drawing.Size(500, 254);
            this.pic_sanpham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_sanpham.TabIndex = 34;
            this.pic_sanpham.TabStop = false;
            this.pic_sanpham.DoubleClick += new System.EventHandler(this.Pic_sanpham_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 737);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 18);
            this.label8.TabIndex = 32;
            this.label8.Text = "vnd";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 705);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "vnd";
            // 
            // com_donvi
            // 
            this.com_donvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_donvi.FormattingEnabled = true;
            this.com_donvi.Items.AddRange(new object[] {
            "-- Đơn vị tính --"});
            this.com_donvi.Location = new System.Drawing.Point(344, 650);
            this.com_donvi.Name = "com_donvi";
            this.com_donvi.Size = new System.Drawing.Size(134, 26);
            this.com_donvi.Sorted = true;
            this.com_donvi.TabIndex = 30;
            // 
            // che_trangthai
            // 
            this.che_trangthai.AutoSize = true;
            this.che_trangthai.Location = new System.Drawing.Point(122, 555);
            this.che_trangthai.Name = "che_trangthai";
            this.che_trangthai.Size = new System.Drawing.Size(144, 22);
            this.che_trangthai.TabIndex = 29;
            this.che_trangthai.Text = "Đang kinh doanh";
            this.che_trangthai.UseVisualStyleBackColor = true;
            // 
            // but_xoa
            // 
            this.but_xoa.BackColor = System.Drawing.Color.LightSalmon;
            this.but_xoa.Location = new System.Drawing.Point(350, 865);
            this.but_xoa.Name = "but_xoa";
            this.but_xoa.Size = new System.Drawing.Size(128, 32);
            this.but_xoa.TabIndex = 28;
            this.but_xoa.Text = "Xóa";
            this.but_xoa.UseVisualStyleBackColor = false;
            this.but_xoa.Click += new System.EventHandler(this.But_xoa_Click);
            // 
            // but_luu
            // 
            this.but_luu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.but_luu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but_luu.Location = new System.Drawing.Point(122, 865);
            this.but_luu.Name = "but_luu";
            this.but_luu.Size = new System.Drawing.Size(128, 32);
            this.but_luu.TabIndex = 26;
            this.but_luu.Text = "Lưu";
            this.but_luu.UseVisualStyleBackColor = false;
            this.but_luu.Click += new System.EventHandler(this.But_luu_Click);
            // 
            // tex_soluong
            // 
            this.tex_soluong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_soluong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_soluong.Location = new System.Drawing.Point(122, 650);
            this.tex_soluong.MaxLength = 16;
            this.tex_soluong.Name = "tex_soluong";
            this.tex_soluong.Size = new System.Drawing.Size(216, 26);
            this.tex_soluong.TabIndex = 25;
            this.tex_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 652);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Số lượng:";
            // 
            // tex_gianhap
            // 
            this.tex_gianhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_gianhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_gianhap.Location = new System.Drawing.Point(122, 703);
            this.tex_gianhap.MaxLength = 16;
            this.tex_gianhap.Name = "tex_gianhap";
            this.tex_gianhap.Size = new System.Drawing.Size(216, 26);
            this.tex_gianhap.TabIndex = 21;
            this.tex_gianhap.TextChanged += new System.EventHandler(this.Tex_gianhap_TextChanged);
            this.tex_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumber);
            this.tex_gianhap.Leave += new System.EventHandler(this.Tex_gianhap_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Giá nhập:";
            // 
            // tex_giaban
            // 
            this.tex_giaban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_giaban.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_giaban.Location = new System.Drawing.Point(122, 735);
            this.tex_giaban.Name = "tex_giaban";
            this.tex_giaban.ReadOnly = true;
            this.tex_giaban.Size = new System.Drawing.Size(216, 26);
            this.tex_giaban.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá bán:";
            // 
            // dat_hsd
            // 
            this.dat_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_hsd.Location = new System.Drawing.Point(347, 598);
            this.dat_hsd.MaxDate = new System.DateTime(2976, 12, 31, 0, 0, 0, 0);
            this.dat_hsd.MinDate = new System.DateTime(1976, 1, 1, 0, 0, 0, 0);
            this.dat_hsd.Name = "dat_hsd";
            this.dat_hsd.Size = new System.Drawing.Size(131, 26);
            this.dat_hsd.TabIndex = 17;
            // 
            // dat_nsx
            // 
            this.dat_nsx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dat_nsx.Location = new System.Drawing.Point(122, 598);
            this.dat_nsx.MaxDate = new System.DateTime(2976, 12, 31, 0, 0, 0, 0);
            this.dat_nsx.MinDate = new System.DateTime(1976, 1, 1, 0, 0, 0, 0);
            this.dat_nsx.Name = "dat_nsx";
            this.dat_nsx.Size = new System.Drawing.Size(131, 26);
            this.dat_nsx.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "HSD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "NSX:";
            // 
            // tex_mota
            // 
            this.tex_mota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_mota.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_mota.Location = new System.Drawing.Point(122, 331);
            this.tex_mota.Multiline = true;
            this.tex_mota.Name = "tex_mota";
            this.tex_mota.Size = new System.Drawing.Size(356, 113);
            this.tex_mota.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mô tả:";
            // 
            // com_doituong
            // 
            this.com_doituong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_doituong.FormattingEnabled = true;
            this.com_doituong.Items.AddRange(new object[] {
            "-- Loại sản phẩm --"});
            this.com_doituong.Location = new System.Drawing.Point(122, 505);
            this.com_doituong.Name = "com_doituong";
            this.com_doituong.Size = new System.Drawing.Size(356, 26);
            this.com_doituong.Sorted = true;
            this.com_doituong.TabIndex = 11;
            // 
            // lab_doituong
            // 
            this.lab_doituong.AutoSize = true;
            this.lab_doituong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_doituong.Location = new System.Drawing.Point(36, 508);
            this.lab_doituong.Name = "lab_doituong";
            this.lab_doituong.Size = new System.Drawing.Size(80, 36);
            this.lab_doituong.TabIndex = 10;
            this.lab_doituong.Text = "Đối tượng\r\nsử dụng:";
            // 
            // com_nhasanxuat
            // 
            this.com_nhasanxuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_nhasanxuat.FormattingEnabled = true;
            this.com_nhasanxuat.Items.AddRange(new object[] {
            "-- Nhà sản xuất --"});
            this.com_nhasanxuat.Location = new System.Drawing.Point(122, 473);
            this.com_nhasanxuat.Name = "com_nhasanxuat";
            this.com_nhasanxuat.Size = new System.Drawing.Size(356, 26);
            this.com_nhasanxuat.Sorted = true;
            this.com_nhasanxuat.TabIndex = 7;
            // 
            // lab_nhasanxuat
            // 
            this.lab_nhasanxuat.AutoSize = true;
            this.lab_nhasanxuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_nhasanxuat.Location = new System.Drawing.Point(15, 476);
            this.lab_nhasanxuat.Name = "lab_nhasanxuat";
            this.lab_nhasanxuat.Size = new System.Drawing.Size(101, 18);
            this.lab_nhasanxuat.TabIndex = 5;
            this.lab_nhasanxuat.Text = "Nhà sản xuất:";
            // 
            // tex_tensanpham
            // 
            this.tex_tensanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_tensanpham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_tensanpham.Location = new System.Drawing.Point(122, 265);
            this.tex_tensanpham.Multiline = true;
            this.tex_tensanpham.Name = "tex_tensanpham";
            this.tex_tensanpham.Size = new System.Drawing.Size(356, 60);
            this.tex_tensanpham.TabIndex = 2;
            // 
            // lab_tensanpham
            // 
            this.lab_tensanpham.AutoSize = true;
            this.lab_tensanpham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_tensanpham.Location = new System.Drawing.Point(6, 267);
            this.lab_tensanpham.Name = "lab_tensanpham";
            this.lab_tensanpham.Size = new System.Drawing.Size(110, 18);
            this.lab_tensanpham.TabIndex = 1;
            this.lab_tensanpham.Text = "Tên sản phẩm:";
            // 
            // tex_masanpham
            // 
            this.tex_masanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_masanpham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_masanpham.Location = new System.Drawing.Point(122, 233);
            this.tex_masanpham.MaxLength = 16;
            this.tex_masanpham.Name = "tex_masanpham";
            this.tex_masanpham.Size = new System.Drawing.Size(216, 26);
            this.tex_masanpham.TabIndex = 33;
            this.tex_masanpham.Visible = false;
            // 
            // pan_grid
            // 
            this.pan_grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_grid.Controls.Add(this.dat_sanpham);
            this.pan_grid.Controls.Add(this.pan_timkiem);
            this.pan_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_grid.Location = new System.Drawing.Point(200, 8);
            this.pan_grid.Name = "pan_grid";
            this.pan_grid.Size = new System.Drawing.Size(1208, 931);
            this.pan_grid.TabIndex = 3;
            // 
            // pan_timkiem
            // 
            this.pan_timkiem.BackColor = System.Drawing.Color.PeachPuff;
            this.pan_timkiem.Controls.Add(this.but_loc);
            this.pan_timkiem.Controls.Add(this.gro_boloc);
            this.pan_timkiem.Controls.Add(this.but_timkiem);
            this.pan_timkiem.Controls.Add(this.tex_timkiem);
            this.pan_timkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_timkiem.Location = new System.Drawing.Point(0, 0);
            this.pan_timkiem.Name = "pan_timkiem";
            this.pan_timkiem.Size = new System.Drawing.Size(1206, 52);
            this.pan_timkiem.TabIndex = 1;
            // 
            // but_loc
            // 
            this.but_loc.BackColor = System.Drawing.Color.MistyRose;
            this.but_loc.FlatAppearance.BorderSize = 0;
            this.but_loc.Image = global::GUI_vinamilk.Properties.Resources.icons8_filter_24;
            this.but_loc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_loc.Location = new System.Drawing.Point(869, 8);
            this.but_loc.Name = "but_loc";
            this.but_loc.Size = new System.Drawing.Size(128, 32);
            this.but_loc.TabIndex = 3;
            this.but_loc.Text = "Lọc";
            this.but_loc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_loc.UseVisualStyleBackColor = false;
            this.but_loc.Click += new System.EventHandler(this.But_loc_Click);
            // 
            // gro_boloc
            // 
            this.gro_boloc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gro_boloc.Controls.Add(this.checkedListBox1);
            this.gro_boloc.Location = new System.Drawing.Point(1003, 3);
            this.gro_boloc.Name = "gro_boloc";
            this.gro_boloc.Size = new System.Drawing.Size(200, 46);
            this.gro_boloc.TabIndex = 2;
            this.gro_boloc.TabStop = false;
            this.gro_boloc.Text = "Bộ lọc";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 32);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(163, 25);
            this.checkedListBox1.TabIndex = 0;
            // 
            // but_timkiem
            // 
            this.but_timkiem.BackColor = System.Drawing.Color.MistyRose;
            this.but_timkiem.FlatAppearance.BorderSize = 0;
            this.but_timkiem.Image = global::GUI_vinamilk.Properties.Resources.icons8_search_24;
            this.but_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_timkiem.Location = new System.Drawing.Point(732, 8);
            this.but_timkiem.Name = "but_timkiem";
            this.but_timkiem.Size = new System.Drawing.Size(128, 32);
            this.but_timkiem.TabIndex = 1;
            this.but_timkiem.Text = "Tìm kiếm";
            this.but_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_timkiem.UseVisualStyleBackColor = false;
            // 
            // tex_timkiem
            // 
            this.tex_timkiem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_timkiem.ForeColor = System.Drawing.Color.Gray;
            this.tex_timkiem.Location = new System.Drawing.Point(6, 12);
            this.tex_timkiem.Name = "tex_timkiem";
            this.tex_timkiem.Size = new System.Drawing.Size(720, 26);
            this.tex_timkiem.TabIndex = 0;
            this.tex_timkiem.Text = "Nhập mã sản phẩm hoặc tên sản phẩm ở đây";
            this.tex_timkiem.Enter += new System.EventHandler(this.Tex_timkiem_Enter);
            this.tex_timkiem.Leave += new System.EventHandler(this.Tex_timkiem_Leave);
            // 
            // maSanPham
            // 
            this.maSanPham.Name = "maSanPham";
            // 
            // SanPhamUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.pan_grid);
            this.Controls.Add(this.pan_chitiet);
            this.Controls.Add(this.pan_menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanPhamUC";
            this.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Size = new System.Drawing.Size(1920, 939);
            this.Tag = "sanpham";
            this.Load += new System.EventHandler(this.SanPhamUC_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.dat_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.pan_menu.ResumeLayout(false);
            this.men_nsx.ResumeLayout(false);
            this.men_nsx.PerformLayout();
            this.pan_chitiet.ResumeLayout(false);
            this.pan_chitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sanpham)).EndInit();
            this.pan_grid.ResumeLayout(false);
            this.pan_timkiem.ResumeLayout(false);
            this.pan_timkiem.PerformLayout();
            this.gro_boloc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTietDonHangsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiTietSanPhamsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doiTuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhaSanXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Panel pan_chitiet;
        private System.Windows.Forms.Panel pan_grid;
        private System.Windows.Forms.Button but_them;
        private System.Windows.Forms.Panel pan_timkiem;
        private System.Windows.Forms.Button but_timkiem;
        private System.Windows.Forms.TextBox tex_timkiem;
        private System.Windows.Forms.Label lab_tensanpham;
        private System.Windows.Forms.TextBox tex_tensanpham;
        private System.Windows.Forms.Label lab_nhasanxuat;
        private System.Windows.Forms.ComboBox com_nhasanxuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox com_doituong;
        private System.Windows.Forms.Label lab_doituong;
        private System.Windows.Forms.DateTimePicker dat_nsx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tex_mota;
        private System.Windows.Forms.TextBox tex_giaban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dat_hsd;
        private System.Windows.Forms.TextBox tex_gianhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tex_soluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button but_luu;
        private System.Windows.Forms.Button but_loc;
        private System.Windows.Forms.GroupBox gro_boloc;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip men_nsx;
        private System.Windows.Forms.ToolStripMenuItem tsmi_them;
        private System.Windows.Forms.ToolStripMenuItem tsm_nsx;
        private System.Windows.Forms.ToolStripMenuItem tsm_doituong;
        private System.Windows.Forms.ToolStripMenuItem tsm_donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button but_xoa;
        private System.Windows.Forms.CheckBox che_trangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ComboBox com_donvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tex_masanpham;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPhamC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamC;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangThaiC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.PictureBox pic_sanpham;
    }
}
