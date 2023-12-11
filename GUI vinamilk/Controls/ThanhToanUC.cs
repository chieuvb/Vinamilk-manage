using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_vinamilk.Controls
{
    public partial class ThanhToanUC : UserControl
    {
        public ThanhToanUC()
        {
            InitializeComponent();
        }



        private void ThanhToanUC_Load(object sender, EventArgs e)
        {
            string text = "Your text here";
            byte[] bytes = Encoding.UTF8.GetBytes(text);

            using (SHA3 sha3 = new SHA3CryptoServiceProvider())
            {
                byte[] hashBytes = sha3.ComputeHash(bytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                Console.WriteLine(hash); // In ra giá trị băm SHA-3
            }
        }
    }
}
