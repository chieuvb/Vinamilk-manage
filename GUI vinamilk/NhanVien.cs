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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.DonHangs = new HashSet<DonHang>();
        }
    
        public string maNhanVien { get; set; }
        public string maChucVu { get; set; }
        public string tenNhanVien { get; set; }
        public string hinhAnh { get; set; }
        public bool gioiTinh { get; set; }
        public System.DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string soDienThoai { get; set; }
        public string email { get; set; }
        public string kinhNghiem { get; set; }
    
        public virtual ChucVu ChucVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
