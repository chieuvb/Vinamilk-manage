//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace milk_sales_manager
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietSanPham
    {
        public string maChiTietSanPham { get; set; }
        public string maSanPham { get; set; }
        public string maDonVi { get; set; }
        public string hinhAnh { get; set; }
        public System.DateTime ngaySanXuat { get; set; }
        public System.DateTime ngayHetHan { get; set; }
        public double giaNhap { get; set; }
        public double giaBan { get; set; }
        public Nullable<int> soLuong { get; set; }
    
        public virtual DonVi DonVi { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
