using GUI_vinamilk.Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_vinamilk
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            But_thanhtoan_Click(sender, e);
            but_thanhtoan.BackColor = Color.DeepSkyBlue;
        }

        private void But_thanhtoan_Click(object sender, EventArgs e)
        {
            UserControl tha = new ThanhToanUC("chieuvb");
            AddControl(tha, sender);
        }

        void AddControl(UserControl uc, object se)
        {
            if (pan_container.Controls.Count > 0)
            {
                var currentControl = pan_container.Controls[0] as UserControl;
                if (uc.Tag == currentControl?.Tag)
                    return;

                pan_container.Controls.Remove(currentControl);
                currentControl.Dispose();
            }

            pan_container.Controls.Add(uc);
            uc.BackColor = Color.MintCream;
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();

            if (se is Button btn)
            {
                foreach (Button preBut in pan_navigator.Controls)
                    preBut.BackColor = Color.MintCream;
                btn.BackColor = Color.DeepSkyBlue;
            }
        }

        private void But_sanpham_Click(object sender, EventArgs e)
        {
            UserControl san = new SanPhamUC();
            AddControl(san, sender);
        }

        private void But_nhanvien_Click(object sender, EventArgs e)
        {
            UserControl nha = new NhanVienUC();
            AddControl(nha, sender);
        }

        private void But_khachhang_Click(object sender, EventArgs e)
        {
            UserControl kha = new KhachHangUC();
            AddControl(kha, sender);
        }

        private void But_thongke_Click(object sender, EventArgs e)
        {
            UserControl tho = new ThongKeUC();
            AddControl(tho, sender);
        }

        private void But_tuychon_Click(object sender, EventArgs e)
        {
            UserControl tuy = new TuyChonUC();
            AddControl(tuy, sender);
        }
    }
}
