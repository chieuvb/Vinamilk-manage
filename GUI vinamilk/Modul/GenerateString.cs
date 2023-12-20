using System.IO;

namespace GUI_vinamilk.Modul
{
    internal class GenerateString
    {
        public string StringID(string key, string name)
        {
            string tenSanPham = name.Replace(" ", "") ?? string.Empty;
            string maSanPham = key + (tenSanPham.Length >= 5 ? tenSanPham.Trim().Substring(0, 5) : tenSanPham);

            int remainingLength = 10 - maSanPham.Length;
            if (remainingLength > 0)
                maSanPham += Path.GetRandomFileName().Replace(".", "").Substring(0, remainingLength);

            RegexInput reg = new RegexInput();
            string result = reg.RemoveVietnameseMarks(maSanPham.ToLower());

            return result;
        }
    }
}
