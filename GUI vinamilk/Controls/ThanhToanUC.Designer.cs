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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pan_menu = new System.Windows.Forms.Panel();
            this.dat_sanpham = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pan_chitiet = new System.Windows.Forms.Panel();
            this.pan_container = new System.Windows.Forms.Panel();
            this.dat_hoadon = new System.Windows.Forms.DataGridView();
            this.col_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tensanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pan_tongtien = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pan_right = new System.Windows.Forms.Panel();
            this.pan_header = new System.Windows.Forms.Panel();
            this.chiTietDonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tex_sanpham = new System.Windows.Forms.TextBox();
            this.pan_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).BeginInit();
            this.pan_chitiet.SuspendLayout();
            this.pan_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_hoadon)).BeginInit();
            this.pan_tongtien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.BackColor = System.Drawing.Color.Honeydew;
            this.pan_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_menu.Controls.Add(this.tex_sanpham);
            this.pan_menu.Controls.Add(this.dat_sanpham);
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_menu.Location = new System.Drawing.Point(0, 0);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(512, 939);
            this.pan_menu.TabIndex = 0;
            // 
            // dat_sanpham
            // 
            this.dat_sanpham.AllowUserToAddRows = false;
            this.dat_sanpham.AllowUserToDeleteRows = false;
            this.dat_sanpham.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_sanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dat_sanpham.ColumnHeadersHeight = 32;
            this.dat_sanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.tenSanPhamDataGridViewTextBoxColumn});
            this.dat_sanpham.DataSource = this.sanPhamBindingSource;
            this.dat_sanpham.Location = new System.Drawing.Point(3, 204);
            this.dat_sanpham.Name = "dat_sanpham";
            this.dat_sanpham.ReadOnly = true;
            this.dat_sanpham.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dat_sanpham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dat_sanpham.RowTemplate.Height = 24;
            this.dat_sanpham.Size = new System.Drawing.Size(502, 221);
            this.dat_sanpham.TabIndex = 0;
            this.dat_sanpham.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dat_sanpham_CellContentDoubleClick);
            // 
            // stt
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stt.DefaultCellStyle = dataGridViewCellStyle2;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 48;
            // 
            // tenSanPhamDataGridViewTextBoxColumn
            // 
            this.tenSanPhamDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSanPhamDataGridViewTextBoxColumn.DataPropertyName = "tenSanPham";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tenSanPhamDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.tenSanPhamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSanPhamDataGridViewTextBoxColumn.Name = "tenSanPhamDataGridViewTextBoxColumn";
            this.tenSanPhamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sanPhamBindingSource
            // 
            this.sanPhamBindingSource.DataSource = typeof(GUI_vinamilk.SanPham);
            // 
            // pan_chitiet
            // 
            this.pan_chitiet.Controls.Add(this.pan_container);
            this.pan_chitiet.Controls.Add(this.pan_header);
            this.pan_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_chitiet.Location = new System.Drawing.Point(512, 0);
            this.pan_chitiet.Name = "pan_chitiet";
            this.pan_chitiet.Size = new System.Drawing.Size(1408, 939);
            this.pan_chitiet.TabIndex = 2;
            // 
            // pan_container
            // 
            this.pan_container.Controls.Add(this.dat_hoadon);
            this.pan_container.Controls.Add(this.pan_tongtien);
            this.pan_container.Controls.Add(this.pan_right);
            this.pan_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_container.Location = new System.Drawing.Point(0, 64);
            this.pan_container.Name = "pan_container";
            this.pan_container.Size = new System.Drawing.Size(1408, 875);
            this.pan_container.TabIndex = 1;
            // 
            // dat_hoadon
            // 
            this.dat_hoadon.AllowUserToAddRows = false;
            this.dat_hoadon.AllowUserToDeleteRows = false;
            this.dat_hoadon.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dat_hoadon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dat_hoadon.ColumnHeadersHeight = 38;
            this.dat_hoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stt,
            this.col_tensanpham,
            this.col_soluong,
            this.col_thanhtien});
            this.dat_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dat_hoadon.GridColor = System.Drawing.Color.Snow;
            this.dat_hoadon.Location = new System.Drawing.Point(0, 0);
            this.dat_hoadon.Name = "dat_hoadon";
            this.dat_hoadon.ReadOnly = true;
            this.dat_hoadon.RowTemplate.Height = 32;
            this.dat_hoadon.Size = new System.Drawing.Size(1152, 747);
            this.dat_hoadon.TabIndex = 2;
            // 
            // col_stt
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_stt.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_stt.HeaderText = "STT";
            this.col_stt.Name = "col_stt";
            this.col_stt.ReadOnly = true;
            this.col_stt.Width = 64;
            // 
            // col_tensanpham
            // 
            this.col_tensanpham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_tensanpham.HeaderText = "Tên sản phẩm";
            this.col_tensanpham.Name = "col_tensanpham";
            this.col_tensanpham.ReadOnly = true;
            // 
            // col_soluong
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_soluong.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_soluong.HeaderText = "Số lượng";
            this.col_soluong.Name = "col_soluong";
            this.col_soluong.ReadOnly = true;
            this.col_soluong.Width = 200;
            // 
            // col_thanhtien
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.col_thanhtien.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_thanhtien.HeaderText = "Thành tiền";
            this.col_thanhtien.Name = "col_thanhtien";
            this.col_thanhtien.ReadOnly = true;
            this.col_thanhtien.Width = 200;
            // 
            // pan_tongtien
            // 
            this.pan_tongtien.BackColor = System.Drawing.Color.Honeydew;
            this.pan_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_tongtien.Controls.Add(this.textBox1);
            this.pan_tongtien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_tongtien.Location = new System.Drawing.Point(0, 747);
            this.pan_tongtien.Name = "pan_tongtien";
            this.pan_tongtien.Size = new System.Drawing.Size(1152, 128);
            this.pan_tongtien.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(628, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 57);
            this.textBox1.TabIndex = 0;
            // 
            // pan_right
            // 
            this.pan_right.BackColor = System.Drawing.Color.Honeydew;
            this.pan_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_right.Location = new System.Drawing.Point(1152, 0);
            this.pan_right.Name = "pan_right";
            this.pan_right.Size = new System.Drawing.Size(256, 875);
            this.pan_right.TabIndex = 0;
            // 
            // pan_header
            // 
            this.pan_header.BackColor = System.Drawing.Color.Honeydew;
            this.pan_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_header.Location = new System.Drawing.Point(0, 0);
            this.pan_header.Name = "pan_header";
            this.pan_header.Size = new System.Drawing.Size(1408, 64);
            this.pan_header.TabIndex = 0;
            // 
            // chiTietDonHangBindingSource
            // 
            this.chiTietDonHangBindingSource.DataSource = typeof(GUI_vinamilk.ChiTietDonHang);
            // 
            // tex_sanpham
            // 
            this.tex_sanpham.Location = new System.Drawing.Point(83, 76);
            this.tex_sanpham.Name = "tex_sanpham";
            this.tex_sanpham.Size = new System.Drawing.Size(306, 26);
            this.tex_sanpham.TabIndex = 1;
            this.tex_sanpham.TextChanged += new System.EventHandler(this.Tex_sanpham_TextChanged);
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
            this.Size = new System.Drawing.Size(1920, 939);
            this.Load += new System.EventHandler(this.ThanhToanUC_Load);
            this.pan_menu.ResumeLayout(false);
            this.pan_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource)).EndInit();
            this.pan_chitiet.ResumeLayout(false);
            this.pan_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dat_hoadon)).EndInit();
            this.pan_tongtien.ResumeLayout(false);
            this.pan_tongtien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Panel pan_chitiet;
        private System.Windows.Forms.Panel pan_header;
        private System.Windows.Forms.Panel pan_container;
        private System.Windows.Forms.Panel pan_tongtien;
        private System.Windows.Forms.Panel pan_right;
        private System.Windows.Forms.DataGridView dat_hoadon;
        private System.Windows.Forms.BindingSource chiTietDonHangBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tensanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhtien;
        private System.Windows.Forms.DataGridView dat_sanpham;
        private System.Windows.Forms.BindingSource sanPhamBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tex_sanpham;
    }
}
