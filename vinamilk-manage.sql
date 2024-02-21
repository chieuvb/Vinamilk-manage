USE [master]
GO
DROP DATABASE [vinamilk-manage]
GO
CREATE DATABASE [vinamilk-manage]
GO
USE [vinamilk-manage]
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[maChiTietDonHang] [nchar](10) NOT NULL,
	[maDonHang] [nchar](10) NOT NULL,
	[maSanPham] [nchar](10) NOT NULL,
	[soLuong] [smallint] NOT NULL,
	[thanhTien] [float] NOT NULL,
	[trangThai] [bit] NOT NULL,
 )
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[maChiTietSanPham] [nchar](10) NOT NULL,
	[maSanPham] [nchar](10) NOT NULL,
	[maDonVi] [nchar](10) NOT NULL,
	[maKhoHang] [nchar](10) NOT NULL,
	[hinhAnh] [nchar](128) NULL,
	[ngaySanXuat] [date] NOT NULL,
	[ngayHetHan] [date] NOT NULL,
	[giaNhap] [float] NOT NULL,
	[giaBan] [float] NOT NULL,
 )
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [nchar](10) NOT NULL,
	[tenChucVu] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[DoiTuong](
	[maDoiTuong] [nchar](10) NOT NULL,
	[tenDoiTuong] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[DonHang](
	[maDonHang] [nchar](10) NOT NULL,
	[maKhachHang] [nchar](10) NOT NULL,
	[maNhanVien] [nchar](10) NOT NULL,
	[hinhThucThanhToan] [nvarchar](128) NOT NULL,
	[ngayTao] [date] NOT NULL,
	[giaGiam] [float] NOT NULL,
	[tongTien] [float] NOT NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[DonVi](
	[maDonVi] [nchar](10) NOT NULL,
	[tenDonVi] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [nchar](10) NOT NULL,
	[maLoaiKhachHang] [nchar](10) NOT NULL,
	[tenKhachHang] [nvarchar](128) NOT NULL,
	[diaChi] [nvarchar](128) NOT NULL,
	[soDienThoai] [nchar](10) NOT NULL,
	[email] [nchar](128) NULL,
	[diemTichLuy] [smallint] NOT NULL,
	[ngayDangKy] [date] NOT NULL,
)
GO
CREATE TABLE [dbo].[KhoHang](
	[maKhoHang] [nchar](10) NOT NULL,
	[maSanPhamChiTiet] [nchar](10) NOT NULL,
	[tenKhoHang] [nvarchar](128) NOT NULL,
	[soLuong] [smallint] NOT NULL,
	[diaChi] [nvarchar](128) NOT NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[LoaiHang](
	[maLoaiHang] [nchar](10) NOT NULL,
	[tenLoaiHang] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[maLoaiKhachHang] [nchar](10) NOT NULL,
	[tenLoaiKhachHang] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [nchar](10) NOT NULL,
	[maChucVu] [nchar](10) NOT NULL,
	[tenNhanVien] [nvarchar](128) NOT NULL,
	[hinhAnh] [nchar](128) NULL,
	[gioiTinh] [bit] NOT NULL,
	[ngaySinh] [date] NOT NULL,
	[diaChi] [nvarchar](128) NOT NULL,
	[soDienThoai] [nchar](10) NOT NULL,
	[email] [nchar](128) NULL,
	[kinhNghiem] [nvarchar](128) NOT NULL,
)
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[maNhaSanXuat] [nchar](10) NOT NULL,
	[tenNhaSanXuat] [nvarchar](128) NOT NULL,
	[dienThoai] [nchar](10) NOT NULL,
	[diaChi] [nvarchar](128) NOT NULL,
)
GO
CREATE TABLE [dbo].[SanPham](
	[maSanPham] [nchar](10) NOT NULL,
	[maNhaSanXuat] [nchar](10) NOT NULL,
	[maLoaiHang] [nchar](10) NOT NULL,
	[maDoiTuong] [nchar](10) NOT NULL,
	[tenSanPham] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NOT NULL,
	[trangThai] [bit] NOT NULL,
)
GO
CREATE TABLE [dbo].[TaiKhoan](
	[maNhanVien] [nchar](10) NOT NULL,
	[matKhau] [nchar](128) NOT NULL,
	[quyenHan] [nchar](10) NOT NULL,
	[trangThai] [bit] NOT NULL
)
