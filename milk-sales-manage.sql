USE [master]
GO
/****** Object:  Database [vinamilk-manage]    Script Date: 10/31/2024 7:19:03 PM ******/
CREATE DATABASE [vinamilk-manage]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'vinamilk-manage', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSI\MSSQL\DATA\vinamilk-manage.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'vinamilk-manage_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSI\MSSQL\DATA\vinamilk-manage_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [vinamilk-manage] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [vinamilk-manage].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [vinamilk-manage] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [vinamilk-manage] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [vinamilk-manage] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [vinamilk-manage] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [vinamilk-manage] SET ARITHABORT OFF 
GO
ALTER DATABASE [vinamilk-manage] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [vinamilk-manage] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [vinamilk-manage] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [vinamilk-manage] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [vinamilk-manage] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [vinamilk-manage] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [vinamilk-manage] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [vinamilk-manage] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [vinamilk-manage] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [vinamilk-manage] SET  ENABLE_BROKER 
GO
ALTER DATABASE [vinamilk-manage] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [vinamilk-manage] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [vinamilk-manage] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [vinamilk-manage] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [vinamilk-manage] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [vinamilk-manage] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [vinamilk-manage] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [vinamilk-manage] SET RECOVERY FULL 
GO
ALTER DATABASE [vinamilk-manage] SET  MULTI_USER 
GO
ALTER DATABASE [vinamilk-manage] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [vinamilk-manage] SET DB_CHAINING OFF 
GO
ALTER DATABASE [vinamilk-manage] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [vinamilk-manage] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [vinamilk-manage] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [vinamilk-manage] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'vinamilk-manage', N'ON'
GO
ALTER DATABASE [vinamilk-manage] SET QUERY_STORE = ON
GO
ALTER DATABASE [vinamilk-manage] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [vinamilk-manage]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[maChiTietDonHang] [nchar](10) NOT NULL,
	[maDonHang] [nchar](20) NOT NULL,
	[maSanPham] [nchar](10) NOT NULL,
	[soLuong] [smallint] NOT NULL,
	[thanhTien] [float] NOT NULL,
	[donGia] [float] NOT NULL,
 CONSTRAINT [PK_ChiTietDonHang] PRIMARY KEY CLUSTERED 
(
	[maChiTietDonHang] ASC,
	[maDonHang] ASC,
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[maChiTietSanPham] [nchar](10) NOT NULL,
	[maSanPham] [nchar](10) NOT NULL,
	[maDonVi] [nchar](10) NOT NULL,
	[hinhAnh] [varchar](64) NULL,
	[ngaySanXuat] [datetime] NOT NULL,
	[ngayHetHan] [datetime] NOT NULL,
	[giaNhap] [float] NOT NULL,
	[giaBan] [float] NOT NULL,
	[soLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietSanPham] PRIMARY KEY CLUSTERED 
(
	[maChiTietSanPham] ASC,
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[maChucVu] [nchar](10) NOT NULL,
	[tenChucVu] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiTuong]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiTuong](
	[maDoiTuong] [nchar](10) NOT NULL,
	[tenDoiTuong] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_DoiTuong] PRIMARY KEY CLUSTERED 
(
	[maDoiTuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[maDonHang] [nchar](20) NOT NULL,
	[maKhachHang] [nchar](10) NOT NULL,
	[maNhanVien] [nchar](10) NOT NULL,
	[hinhThucThanhToan] [nvarchar](128) NOT NULL,
	[ngayTao] [datetime] NOT NULL,
	[giaGiam] [float] NOT NULL,
	[tongTien] [float] NOT NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[maDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonVi]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonVi](
	[maDonVi] [nchar](10) NOT NULL,
	[tenDonVi] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_DonVi] PRIMARY KEY CLUSTERED 
(
	[maDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [nchar](10) NOT NULL,
	[maLoaiKhachHang] [nchar](10) NOT NULL,
	[tenKhachHang] [nvarchar](128) NOT NULL,
	[diaChi] [nvarchar](max) NOT NULL,
	[soDienThoai] [varchar](16) NOT NULL,
	[email] [varchar](128) NULL,
	[diemTichLuy] [int] NOT NULL,
	[ngayDangKy] [datetime] NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[maLoaiKhachHang] [nchar](10) NOT NULL,
	[tenLoaiKhachHang] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](128) NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY CLUSTERED 
(
	[maLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNhanVien] [nchar](10) NOT NULL,
	[maChucVu] [nchar](10) NOT NULL,
	[tenNhanVien] [nvarchar](128) NOT NULL,
	[hinhAnh] [varchar](16) NULL,
	[gioiTinh] [bit] NOT NULL,
	[ngaySinh] [datetime] NOT NULL,
	[diaChi] [nvarchar](128) NOT NULL,
	[soDienThoai] [varchar](16) NOT NULL,
	[email] [varchar](128) NULL,
	[kinhNghiem] [nvarchar](max) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[maNhaSanXuat] [nchar](10) NOT NULL,
	[tenNhaSanXuat] [nvarchar](128) NOT NULL,
	[dienThoai] [varchar](16) NULL,
	[diaChi] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[maNhaSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[maSanPham] [nchar](10) NOT NULL,
	[maNhaSanXuat] [nchar](10) NOT NULL,
	[maDoiTuong] [nchar](10) NOT NULL,
	[tenSanPham] [nvarchar](128) NOT NULL,
	[moTa] [nvarchar](max) NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 10/31/2024 7:19:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[maNhanVien] [nchar](10) NOT NULL,
	[matKhau] [varchar](128) NOT NULL,
	[quyenHan] [nchar](10) NOT NULL,
	[trangThai] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietDonHang_DonHang]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietDonHang_DonHang] ON [dbo].[ChiTietDonHang]
(
	[maDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietDonHang_SanPham]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietDonHang_SanPham] ON [dbo].[ChiTietDonHang]
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietSanPham_DonVi]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietSanPham_DonVi] ON [dbo].[ChiTietSanPham]
(
	[maDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietSanPham_SanPham]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietSanPham_SanPham] ON [dbo].[ChiTietSanPham]
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_DonHang_KhachHang]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_DonHang_KhachHang] ON [dbo].[DonHang]
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_DonHang_NhanVien]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_DonHang_NhanVien] ON [dbo].[DonHang]
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_KhachHang_LoaiKhachHang]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_KhachHang_LoaiKhachHang] ON [dbo].[KhachHang]
(
	[maLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_NhanVien_ChucVu]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_NhanVien_ChucVu] ON [dbo].[NhanVien]
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_SanPham_DoiTuong]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_SanPham_DoiTuong] ON [dbo].[SanPham]
(
	[maDoiTuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_SanPham_NhaSanXuat]    Script Date: 10/31/2024 7:19:04 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_SanPham_NhaSanXuat] ON [dbo].[SanPham]
(
	[maNhaSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_DonHang] FOREIGN KEY([maDonHang])
REFERENCES [dbo].[DonHang] ([maDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_DonHang]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonHang_SanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([maSanPham])
GO
ALTER TABLE [dbo].[ChiTietDonHang] CHECK CONSTRAINT [FK_ChiTietDonHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSanPham_DonVi] FOREIGN KEY([maDonVi])
REFERENCES [dbo].[DonVi] ([maDonVi])
GO
ALTER TABLE [dbo].[ChiTietSanPham] CHECK CONSTRAINT [FK_ChiTietSanPham_DonVi]
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietSanPham_SanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([maSanPham])
GO
ALTER TABLE [dbo].[ChiTietSanPham] CHECK CONSTRAINT [FK_ChiTietSanPham_SanPham]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_NhanVien]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhachHang] FOREIGN KEY([maLoaiKhachHang])
REFERENCES [dbo].[LoaiKhachHang] ([maLoaiKhachHang])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhachHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([maChucVu])
REFERENCES [dbo].[ChucVu] ([maChucVu])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_DoiTuong] FOREIGN KEY([maDoiTuong])
REFERENCES [dbo].[DoiTuong] ([maDoiTuong])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_DoiTuong]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhaSanXuat] FOREIGN KEY([maNhaSanXuat])
REFERENCES [dbo].[NhaSanXuat] ([maNhaSanXuat])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhaSanXuat]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NhanVien] FOREIGN KEY([maNhanVien])
REFERENCES [dbo].[NhanVien] ([maNhanVien])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [vinamilk-manage] SET  READ_WRITE 
GO
