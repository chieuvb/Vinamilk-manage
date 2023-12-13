namespace GUI_vinamilk.Controls
{
    partial class ThanhToanUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.GroupBox gro_sanpham;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan_menu = new System.Windows.Forms.Panel();
            this.tex_sanpham = new System.Windows.Forms.TextBox();
            this.dat_sanpham = new System.Windows.Forms.DataGridView();
            this.pan_chitiet = new System.Windows.Forms.Panel();
            this.pan_container = new System.Windows.Forms.Panel();
            this.dat_hoadon = new System.Windows.Forms.DataGridView();
            this.pan_tongtien = new System.Windows.Forms.Panel();
            this.tex_tongtien = new System.Windows.Forms.TextBox();
            this.pan_right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tex_khachhang = new System.Windows.Forms.TextBox();
            this.gro_khachhang = new System.Windows.Forms.GroupBox();
            this.col_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tru = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.col_tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            gro_sanpham = new System.Windows.Forms.GroupBox();
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sanpham)).BeginInit();
            this.pan_chitiet.SuspendLayout();
            this.pan_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_hoadon)).BeginInit();
            this.pan_tongtien.SuspendLayout();
            this.pan_right.SuspendLayout();
            this.gro_khachhang.SuspendLayout();
            gro_sanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.BackColor = System.Drawing.Color.Honeydew;
            this.pan_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_menu.Controls.Add(gro_sanpham);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_menu.Location = new System.Drawing.Point(0, 8);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(480, 931);
            this.pan_menu.TabIndex = 0;
            // 
            // tex_sanpham
            // 
            this.tex_sanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_sanpham.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_sanpham.Location = new System.Drawing.Point(6, 28);
            this.tex_sanpham.Name = "tex_sanpham";
            this.tex_sanpham.Size = new System.Drawing.Size(458, 44);
            this.tex_sanpham.TabIndex = 1;
            this.tex_sanpham.TextChanged += new System.EventHandler(this.Tex_sanpham_TextChanged);
            // 
            // dat_sanpham
            // 
            this.dat_sanpham.AllowUserToAddRows = false;
            this.dat_sanpham.AllowUserToDeleteRows = false;
            this.dat_sanpham.AllowUserToResizeColumns = false;
            this.dat_sanpham.AllowUserToResizeRows = false;
            this.dat_sanpham.AutoGenerateColumns = false;
            this.dat_sanpham.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_sanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_sanpham.ColumnHeadersHeight = 38;
            this.dat_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_tenSP});
            this.dat_sanpham.DataSource = this.sanPhamBindingSource;
            this.dat_sanpham.Location = new System.Drawing.Point(6, 106);
            this.dat_sanpham.Name = "dat_sanpham";
            this.dat_sanpham.ReadOnly = true;
            this.dat_sanpham.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat_sanpham.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dat_sanpham.RowTemplate.Height = 32;
            this.dat_sanpham.Size = new System.Drawing.Size(458, 70);
            this.dat_sanpham.TabIndex = 0;
            this.dat_sanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_sanpham_CellClick);
            // 
            // pan_chitiet
            // 
            this.pan_chitiet.Controls.Add(this.pan_container);
            this.pan_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_chitiet.Location = new System.Drawing.Point(480, 8);
            this.pan_chitiet.Name = "pan_chitiet";
            this.pan_chitiet.Size = new System.Drawing.Size(1440, 931);
            this.pan_chitiet.TabIndex = 2;
            // 
            // pan_container
            // 
            this.pan_container.Controls.Add(this.dat_hoadon);
            this.pan_container.Controls.Add(this.pan_tongtien);
            this.pan_container.Controls.Add(this.pan_right);
            this.pan_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_container.Location = new System.Drawing.Point(0, 0);
            this.pan_container.Name = "pan_container";
            this.pan_container.Size = new System.Drawing.Size(1440, 931);
            this.pan_container.TabIndex = 1;
            // 
            // dat_hoadon
            // 
            this.dat_hoadon.AllowUserToAddRows = false;
            this.dat_hoadon.AllowUserToDeleteRows = false;
            this.dat_hoadon.AllowUserToResizeColumns = false;
            this.dat_hoadon.AllowUserToResizeRows = false;
            this.dat_hoadon.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_hoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dat_hoadon.ColumnHeadersHeight = 38;
            this.dat_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stt,
            this.col_tensanpham,
            this.col_tru,
            this.col_soluong,
            this.col_cong,
            this.col_gia,
            this.col_xoa,
            this.maSanPham});
            this.dat_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_hoadon.Location = new System.Drawing.Point(0, 0);
            this.dat_hoadon.Name = "dat_hoadon";
            this.dat_hoadon.RowHeadersVisible = false;
            this.dat_hoadon.RowTemplate.Height = 32;
            this.dat_hoadon.Size = new System.Drawing.Size(960, 803);
            this.dat_hoadon.TabIndex = 3;
            this.dat_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_hoadon_CellClick);
            this.dat_hoadon.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_hoadon_CellEndEdit);
            this.dat_hoadon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Dat_hoadon_CellPainting);
            // 
            // pan_tongtien
            // 
            this.pan_tongtien.BackColor = System.Drawing.Color.Honeydew;
            this.pan_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_tongtien.Controls.Add(this.label1);
            this.pan_tongtien.Controls.Add(this.label2);
            this.pan_tongtien.Controls.Add(this.tex_tongtien);
            this.pan_tongtien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_tongtien.Location = new System.Drawing.Point(0, 803);
            this.pan_tongtien.Name = "pan_tongtien";
            this.pan_tongtien.Size = new System.Drawing.Size(960, 128);
            this.pan_tongtien.TabIndex = 1;
            // 
            // tex_tongtien
            // 
            this.tex_tongtien.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_tongtien.Location = new System.Drawing.Point(485, 57);
            this.tex_tongtien.Name = "tex_tongtien";
            this.tex_tongtien.ReadOnly = true;
            this.tex_tongtien.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tex_tongtien.Size = new System.Drawing.Size(379, 44);
            this.tex_tongtien.TabIndex = 0;
            // 
            // pan_right
            // 
            this.pan_right.BackColor = System.Drawing.Color.Honeydew;
            this.pan_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_right.Controls.Add(this.gro_khachhang);
            this.pan_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_right.Location = new System.Drawing.Point(960, 0);
            this.pan_right.Name = "pan_right";
            this.pan_right.Size = new System.Drawing.Size(480, 931);
            this.pan_right.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(870, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "VND";
            // 
            // tex_khachhang
            // 
            this.tex_khachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_khachhang.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_khachhang.Location = new System.Drawing.Point(6, 49);
            this.tex_khachhang.Name = "tex_khachhang";
            this.tex_khachhang.Size = new System.Drawing.Size(458, 32);
            this.tex_khachhang.TabIndex = 3;
            // 
            // gro_khachhang
            // 
            this.gro_khachhang.Controls.Add(this.tex_khachhang);
            this.gro_khachhang.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gro_khachhang.Location = new System.Drawing.Point(5, 5);
            this.gro_khachhang.Name = "gro_khachhang";
            this.gro_khachhang.Size = new System.Drawing.Size(470, 109);
            this.gro_khachhang.TabIndex = 5;
            this.gro_khachhang.TabStop = false;
            this.gro_khachhang.Text = "Khách hàng";
            // 
            // gro_sanpham
            // 
            gro_sanpham.BackColor = System.Drawing.Color.DarkSeaGreen;
            gro_sanpham.Controls.Add(this.tex_sanpham);
            gro_sanpham.Controls.Add(this.dat_sanpham);
            gro_sanpham.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gro_sanpham.Location = new System.Drawing.Point(5, 5);
            gro_sanpham.Name = "gro_sanpham";
            gro_sanpham.Size = new System.Drawing.Size(468, 797);
            gro_sanpham.TabIndex = 6;
            gro_sanpham.TabStop = false;
            gro_sanpham.Text = "Sản phẩm";
            // 
            // col_stt
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_stt.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_stt.HeaderText = "STT";
            this.col_stt.Name = "col_stt";
            this.col_stt.ReadOnly = true;
            this.col_stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_stt.Width = 48;
            // 
            // col_tensanpham
            // 
            this.col_tensanpham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.col_tensanpham.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_tensanpham.HeaderText = "Tên sản phẩm";
            this.col_tensanpham.Name = "col_tensanpham";
            this.col_tensanpham.ReadOnly = true;
            this.col_tensanpham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // col_tru
            // 
            this.col_tru.HeaderText = "";
            this.col_tru.Name = "col_tru";
            this.col_tru.ReadOnly = true;
            this.col_tru.Text = "-";
            this.col_tru.UseColumnTextForButtonValue = true;
            this.col_tru.Width = 32;
            // 
            // col_soluong
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Linen;
            this.col_soluong.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_soluong.HeaderText = "Số lượng";
            this.col_soluong.Name = "col_soluong";
            this.col_soluong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_soluong.Width = 128;
            // 
            // col_cong
            // 
            this.col_cong.HeaderText = "";
            this.col_cong.Name = "col_cong";
            this.col_cong.ReadOnly = true;
            this.col_cong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_cong.Text = "+";
            this.col_cong.UseColumnTextForButtonValue = true;
            this.col_cong.Width = 32;
            // 
            // col_gia
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_gia.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_gia.HeaderText = "Thành tiền";
            this.col_gia.Name = "col_gia";
            this.col_gia.ReadOnly = true;
            this.col_gia.Width = 200;
            // 
            // col_xoa
            // 
            this.col_xoa.HeaderText = "";
            this.col_xoa.Name = "col_xoa";
            this.col_xoa.ReadOnly = true;
            this.col_xoa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_xoa.Text = "Xóa";
            this.col_xoa.UseColumnTextForButtonValue = true;
            this.col_xoa.Width = 80;
            // 
            // maSanPham
            // 
            this.maSanPham.HeaderText = "maSanPham";
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.ReadOnly = true;
            this.maSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maSanPham.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng:";
            // 
            // col_tenSP
            // 
            this.col_tenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tenSP.DataPropertyName = "tenSanPham";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_tenSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_tenSP.HeaderText = "Tên sản phẩm";
            this.col_tenSP.Name = "col_tenSP";
            this.col_tenSP.ReadOnly = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(GUI_vinamilk.SanPham);
            // 
            // ThanhToanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_chitiet);
            this.Controls.Add(this.pan_menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThanhToanUC";
            this.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.Size = new System.Drawing.Size(1920, 939);
            this.Load += new System.EventHandler(this.ThanhToanUC_Load);
            this.pan_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_sanpham)).EndInit();
            this.pan_chitiet.ResumeLayout(false);
            this.pan_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_hoadon)).EndInit();
            this.pan_tongtien.ResumeLayout(false);
            this.pan_tongtien.PerformLayout();
            this.pan_right.ResumeLayout(false);
            this.gro_khachhang.ResumeLayout(false);
            this.gro_khachhang.PerformLayout();
            gro_sanpham.ResumeLayout(false);
            gro_sanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Panel pan_chitiet;
        private System.Windows.Forms.Panel pan_container;
        private System.Windows.Forms.Panel pan_tongtien;
        private System.Windows.Forms.Panel pan_right;
        private System.Windows.Forms.TextBox tex_tongtien;
        private System.Windows.Forms.DataGridView dat_sanpham;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.TextBox tex_sanpham;
        private System.Windows.Forms.DataGridView dat_hoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gro_khachhang;
        private System.Windows.Forms.TextBox tex_khachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tensanpham;
        private System.Windows.Forms.DataGridViewButtonColumn col_tru;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soluong;
        private System.Windows.Forms.DataGridViewButtonColumn col_cong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gia;
        private System.Windows.Forms.DataGridViewButtonColumn col_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.Label label1;
    }
}
