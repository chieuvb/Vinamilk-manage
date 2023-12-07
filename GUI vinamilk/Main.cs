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
            but_thanhtoan_Click(sender, e);
            but_thanhtoan.BackColor = Color.DeepSkyBlue;
        }

        private void but_thanhtoan_Click(object sender, EventArgs e)
        {
            UserControl tha = new ThanhToanUC();
            AddControl(tha, sender);
        }

        void AddControl(UserControl uc, object se)
        {
            if (pan_container.Controls.Count > 0)
            {
                if (uc.Tag == pan_container.Controls[0].Tag)
                {
                    return;
                }
            }

            pan_container.Controls?.Clear();
            pan_container.Controls.Add(uc);
            uc.BackColor = Color.MintCream;
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();

            if (se is Button btn)
            {
                foreach (Button preBut in pan_navigator.Controls)
                {
                    preBut.BackColor = Color.MintCream;
                }
                btn.BackColor = Color.DeepSkyBlue;
            }
        }

        private void but_sanpham_Click(object sender, EventArgs e)
        {
            UserControl san = new SanPhamUC();
            AddControl(san, sender);
        }

        private void but_nhanvien_Click(object sender, EventArgs e)
        {
            UserControl nha = new UserControl
            {
                Tag = "Nhan vien"
            };
            AddControl(nha, sender);
        }

        private void but_khachhang_Click(object sender, EventArgs e)
        {
            UserControl kha = new UserControl
            {
                Tag = "Khach hang"
            };
            AddControl(kha, sender);
        }

        private void but_thongke_Click(object sender, EventArgs e)
        {
            UserControl tho = new UserControl
            {
                Tag = "Thong ke"
            };
            AddControl(tho, sender);
        }

        private void but_tuychon_Click(object sender, EventArgs e)
        {
            UserControl tuy = new UserControl
            {
                Tag = "Tuy chon"
            };
            AddControl(tuy, sender);
        }
    }
}
