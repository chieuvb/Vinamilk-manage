//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI_vinamilk
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDonHang
    {
        public string maChiTietDonHang { get; set; }
        public string maDonHang { get; set; }
        public string maSanPham { get; set; }
        public short soLuong { get; set; }
        public double thanhTien { get; set; }
        public double donGia { get; set; }
    
        public virtual DonHang DonHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
