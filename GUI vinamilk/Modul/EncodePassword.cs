using System;
using System.Security.Cryptography;
using System.Text;

namespace GUI_vinamilk.Modul
{
    public class EncodePassword
    {
        public string Encode(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);

            using (SHA512 sha3 = new SHA512CryptoServiceProvider())
            {
                byte[] hashBytes = sha3.ComputeHash(bytes);
                string hashPass = BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
                return hashPass;
            }
        }
    }
}
