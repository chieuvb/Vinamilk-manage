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
            this.pan_menu = new System.Windows.Forms.Panel();
            this.pan_thongtin = new System.Windows.Forms.Panel();
            this.pan_chitiet = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pan_menu
            // 
            this.pan_menu.BackColor = System.Drawing.Color.Honeydew;
            this.pan_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_menu.Location = new System.Drawing.Point(0, 0);
            this.pan_menu.Name = "pan_menu";
            this.pan_menu.Size = new System.Drawing.Size(256, 939);
            this.pan_menu.TabIndex = 0;
            // 
            // pan_thongtin
            // 
            this.pan_thongtin.BackColor = System.Drawing.Color.Honeydew;
            this.pan_thongtin.Dock = System.Windows.Forms.DockStyle.Right;
            this.pan_thongtin.Location = new System.Drawing.Point(1408, 0);
            this.pan_thongtin.Name = "pan_thongtin";
            this.pan_thongtin.Size = new System.Drawing.Size(512, 939);
            this.pan_thongtin.TabIndex = 1;
            // 
            // pan_chitiet
            // 
            this.pan_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_chitiet.Location = new System.Drawing.Point(256, 0);
            this.pan_chitiet.Name = "pan_chitiet";
            this.pan_chitiet.Size = new System.Drawing.Size(1152, 939);
            this.pan_chitiet.TabIndex = 2;
            // 
            // ThanhToanUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_chitiet);
            this.Controls.Add(this.pan_thongtin);
            this.Controls.Add(this.pan_menu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThanhToanUC";
            this.Size = new System.Drawing.Size(1920, 939);
            this.Load += new System.EventHandler(this.ThanhToanUC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_menu;
        private System.Windows.Forms.Panel pan_thongtin;
        private System.Windows.Forms.Panel pan_chitiet;
    }
}
