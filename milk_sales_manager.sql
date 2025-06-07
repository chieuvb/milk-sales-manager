USE [master]
GO
/****** Object:  Database [vinamilk-manage]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[ChucVu]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[DoiTuong]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[DonHang]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[DonVi]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/7/2025 5:10:55 PM ******/
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
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/7/2025 5:10:55 PM ******/
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
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctbglgdh85', N'dh202506071534418571', N'sp00000002', 1, 21000, 21000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctbglgdh85', N'dh202506071534418571', N'sp00000003', 4, 1200000, 300000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctbglgdh85', N'dh202506071534418571', N'sp00000004', 1, 390000, 390000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctbglgdh85', N'dh202506071534418571', N'sp00000005', 1, 15000, 15000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctdvgydz38', N'dh202506071604337644', N'sp00000010', 1, 30000, 30000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctdvgydz38', N'dh202506071604337644', N'sp00000013', 2, 1160000, 580000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctdvgydz38', N'dh202506071604337644', N'sp00000014', 2, 1500000, 750000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctdvgydz38', N'dh202506071604337644', N'sp00000015', 1, 350000, 350000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctdvgydz38', N'dh202506071604337644', N'sp00000017', 1, 13000, 13000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctkucxtv00', N'dh202506071555193603', N'sp00000002', 3, 63000, 21000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctkucxtv00', N'dh202506071555193603', N'sp00000003', 3, 900000, 300000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctkucxtv00', N'dh202506071555193603', N'sp00000005', 2, 30000, 15000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctkucxtv00', N'dh202506071555193603', N'sp00000006', 1, 10000, 10000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctkzlqge89', N'dh202506071603332567', N'sp00000013', 2, 1160000, 580000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctkzlqge89', N'dh202506071603332567', N'sp00000014', 3, 2250000, 750000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctramyor08', N'dh202506071603545895', N'sp00000007', 1, 12000, 12000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctramyor08', N'dh202506071603545895', N'sp00000009', 1, 28000, 28000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctramyor08', N'dh202506071603545895', N'sp00000010', 1, 30000, 30000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctramyor08', N'dh202506071603545895', N'sp00000013', 2, 1160000, 580000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctramyor08', N'dh202506071603545895', N'sp00000014', 2, 1500000, 750000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctziblsc81', N'dh202506071532532404', N'sp00000001', 1, 21600, 21600)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctziblsc81', N'dh202506071532532404', N'sp00000002', 2, 42000, 21000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctziblsc81', N'dh202506071532532404', N'sp00000003', 1, 300000, 300000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctziblsc81', N'dh202506071532532404', N'sp00000006', 1, 10000, 10000)
INSERT [dbo].[ChiTietDonHang] ([maChiTietDonHang], [maDonHang], [maSanPham], [soLuong], [thanhTien], [donGia]) VALUES (N'ctziblsc81', N'dh202506071532532404', N'sp00000009', 1, 28000, 28000)
GO
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000001', N'sp00000001', N'dvhop00001', N'sp00000001', CAST(N'2025-05-01T00:00:00.000' AS DateTime), CAST(N'2025-11-01T00:00:00.000' AS DateTime), 18000, 21600, 499)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000002', N'sp00000001', N'dvthung01 ', N'vinamilk_thung.jpg', CAST(N'2025-05-01T00:00:00.000' AS DateTime), CAST(N'2025-11-01T00:00:00.000' AS DateTime), 400000, 550000, 100)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000003', N'sp00000002', N'dvhop00001', N'sp00000002', CAST(N'2025-04-15T00:00:00.000' AS DateTime), CAST(N'2025-10-15T00:00:00.000' AS DateTime), 17500, 21000, 444)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000004', N'sp00000003', N'dvgoi0001 ', N'sp00000003', CAST(N'2025-03-20T00:00:00.000' AS DateTime), CAST(N'2026-03-20T00:00:00.000' AS DateTime), 250000, 300000, 192)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000005', N'sp00000004', N'dvhop00001', N'abbott_grow.jpg', CAST(N'2025-02-10T00:00:00.000' AS DateTime), CAST(N'2026-02-10T00:00:00.000' AS DateTime), 300000, 390000, 149)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000006', N'sp00000005', N'dvml000001', N'dutch_lady_chai.jpg', CAST(N'2025-05-20T00:00:00.000' AS DateTime), CAST(N'2025-08-20T00:00:00.000' AS DateTime), 10000, 15000, 797)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000007', N'sp00000006', N'dvtui0001 ', N'fami_tui.jpg', CAST(N'2025-04-01T00:00:00.000' AS DateTime), CAST(N'2025-09-01T00:00:00.000' AS DateTime), 7000, 10000, 998)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000008', N'sp00000007', N'dvml000001', N'kun_suachua.jpg', CAST(N'2025-05-25T00:00:00.000' AS DateTime), CAST(N'2025-08-25T00:00:00.000' AS DateTime), 8000, 12000, 749)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000009', N'sp00000008', N'dvhop00001', N'sure_prevent.jpg', CAST(N'2025-03-01T00:00:00.000' AS DateTime), CAST(N'2026-03-01T00:00:00.000' AS DateTime), 280000, 360000, 180)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000010', N'sp00000009', N'dvchai001 ', N'vinamilk_organic.jpg', CAST(N'2025-04-10T00:00:00.000' AS DateTime), CAST(N'2025-10-10T00:00:00.000' AS DateTime), 20000, 28000, 398)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000011', N'sp00000010', N'dvhop00001', N'th_topkid.jpg', CAST(N'2025-05-05T00:00:00.000' AS DateTime), CAST(N'2025-11-05T00:00:00.000' AS DateTime), 22000, 30000, 298)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000012', N'sp00000011', N'dvhop00001', N'ongtho_hop.jpg', CAST(N'2025-04-20T00:00:00.000' AS DateTime), CAST(N'2026-04-20T00:00:00.000' AS DateTime), 15000, 22000, 600)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000013', N'sp00000012', N'dvchai001 ', N'th_hilo_chai.jpg', CAST(N'2025-05-18T00:00:00.000' AS DateTime), CAST(N'2025-11-18T00:00:00.000' AS DateTime), 19000, 27000, 480)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000014', N'sp00000013', N'dvhop00001', N'varna_complete.jpg', CAST(N'2025-03-10T00:00:00.000' AS DateTime), CAST(N'2026-03-10T00:00:00.000' AS DateTime), 450000, 580000, 114)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000015', N'sp00000014', N'dvgoi0001 ', N'ensure_gold_goi.jpg', CAST(N'2025-02-25T00:00:00.000' AS DateTime), CAST(N'2026-02-25T00:00:00.000' AS DateTime), 600000, 750000, 83)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000016', N'sp00000015', N'dvhop00001', N'dutchlady_123.jpg', CAST(N'2025-05-12T00:00:00.000' AS DateTime), CAST(N'2026-05-12T00:00:00.000' AS DateTime), 280000, 350000, 159)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000017', N'sp00000016', N'dvtui0001 ', N'fami_canxi_tui.jpg', CAST(N'2025-04-05T00:00:00.000' AS DateTime), CAST(N'2025-09-05T00:00:00.000' AS DateTime), 8500, 12500, 900)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000018', N'sp00000017', N'dvml000001', N'kun_socola.jpg', CAST(N'2025-05-28T00:00:00.000' AS DateTime), CAST(N'2025-08-28T00:00:00.000' AS DateTime), 9000, 13000, 699)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000019', N'sp00000018', N'dvchai001 ', N'yomilk_active.jpg', CAST(N'2025-05-08T00:00:00.000' AS DateTime), CAST(N'2025-08-08T00:00:00.000' AS DateTime), 11000, 16000, 550)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000020', N'sp00000019', N'dvml000001', N'th_pro.jpg', CAST(N'2025-04-22T00:00:00.000' AS DateTime), CAST(N'2025-09-22T00:00:00.000' AS DateTime), 13000, 19000, 420)
INSERT [dbo].[ChiTietSanPham] ([maChiTietSanPham], [maSanPham], [maDonVi], [hinhAnh], [ngaySanXuat], [ngayHetHan], [giaNhap], [giaBan], [soLuong]) VALUES (N'ctsp000021', N'sp00000020', N'dvl0000001', N'sp00000020', CAST(N'2025-03-15T00:00:00.000' AS DateTime), CAST(N'2025-09-15T00:00:00.000' AS DateTime), 25000, 30000, 350)
GO
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvadmin001', N'Quản trị viên', N'Tài khoản có toàn quyền trong hệ thống', 1)
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvbhang001', N'Nhân viên bán hàng', N'Tư vấn và bán sản phẩm', 1)
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvgiao001c', N'Nhân viên giao hàng', N'Giao hàng tận nơi cho khách', 1)
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvintern01', N'Thực tập sinh', N'Học việc, hỗ trợ công việc', 0)
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvkho0012a', N'Quản lý kho', N'Quản lý nhập xuất hàng hóa', 1)
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvkt00001b', N'Kế toán', N'Xử lý sổ sách và báo cáo tài chính', 1)
INSERT [dbo].[ChucVu] ([maChucVu], [tenChucVu], [moTa], [trangThai]) VALUES (N'cvthungan ', N'Nhân viên thu ngân', N'Thanh toán và xử lý hóa đơn', 1)
GO
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtbme00001', N'Phụ nữ mang thai', N'Sữa bầu bổ sung DHA, acid folic, sắt', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtbnh00001', N'Người bệnh', N'Sữa chuyên biệt cho người cần hồi phục sức khỏe', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtem000001', N'Trẻ em', N'Sản phẩm dành cho trẻ từ 0 đến 12 tuổi', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtgia00001', N'Người già', N'Sữa hỗ trợ xương khớp, trí nhớ và tiêu hóa', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtkdi00001', N'Người ăn kiêng', N'Sữa không đường, ít béo, giàu đạm', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtkha00001', N'Khác', N'Đối tượng chưa phân loại cụ thể', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtngl00001', N'Người lớn', N'Sữa bổ sung canxi, vitamin cho người trưởng thành', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtnhi00001', N'Thiếu niên', N'Sữa tăng chiều cao, phát triển toàn diện cho tuổi teen', 1)
INSERT [dbo].[DoiTuong] ([maDoiTuong], [tenDoiTuong], [moTa], [trangThai]) VALUES (N'dtvo000001', N'Vận động viên', N'Sữa giàu protein và khoáng chất, hỗ trợ thể lực', 1)
GO
INSERT [dbo].[DonHang] ([maDonHang], [maKhachHang], [maNhanVien], [hinhThucThanhToan], [ngayTao], [giaGiam], [tongTien], [trangThai]) VALUES (N'dh202506071532532404', N'kh-khdonle', N'nv00000001', N'Tiền mặt', CAST(N'2025-06-07T15:32:53.240' AS DateTime), 0, 401600, 1)
INSERT [dbo].[DonHang] ([maDonHang], [maKhachHang], [maNhanVien], [hinhThucThanhToan], [ngayTao], [giaGiam], [tongTien], [trangThai]) VALUES (N'dh202506071534418571', N'kh-khdonle', N'nv00000001', N'Tiền mặt', CAST(N'2025-06-07T15:34:41.857' AS DateTime), 0, 1626000, 1)
INSERT [dbo].[DonHang] ([maDonHang], [maKhachHang], [maNhanVien], [hinhThucThanhToan], [ngayTao], [giaGiam], [tongTien], [trangThai]) VALUES (N'dh202506071555193603', N'kh005     ', N'nv00000001', N'Tiền mặt', CAST(N'2025-06-07T15:55:19.360' AS DateTime), 0, 1003000, 1)
INSERT [dbo].[DonHang] ([maDonHang], [maKhachHang], [maNhanVien], [hinhThucThanhToan], [ngayTao], [giaGiam], [tongTien], [trangThai]) VALUES (N'dh202506071603332567', N'kh005     ', N'nv00000001', N'Tiền mặt', CAST(N'2025-06-07T16:03:33.257' AS DateTime), 341000, 3069000, 1)
INSERT [dbo].[DonHang] ([maDonHang], [maKhachHang], [maNhanVien], [hinhThucThanhToan], [ngayTao], [giaGiam], [tongTien], [trangThai]) VALUES (N'dh202506071603545895', N'kh005     ', N'nv00000001', N'Tiền mặt', CAST(N'2025-06-07T16:03:54.590' AS DateTime), 0, 2730000, 1)
INSERT [dbo].[DonHang] ([maDonHang], [maKhachHang], [maNhanVien], [hinhThucThanhToan], [ngayTao], [giaGiam], [tongTien], [trangThai]) VALUES (N'dh202506071604337644', N'kh005     ', N'nv00000001', N'Tiền mặt', CAST(N'2025-06-07T16:04:33.763' AS DateTime), 305300, 2747700, 1)
GO
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvchai001 ', N'Chai', N'Dạng chai nhựa hoặc thủy tinh', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvgoi0001 ', N'Gói', N'Sữa bột đóng gói nhỏ', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvhop00001', N'Hộp', N'Sản phẩm đóng hộp, có thể là sữa bột, sữa tươi,...', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvl0000001', N'Lít (L)', N'Sản phẩm sữa chai lớn, hộp lớn', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvml000001', N'Mililit (ml)', N'Đơn vị thể tích nhỏ, thường dùng cho chai nhỏ hoặc hộp sữa uống liền', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvthung01 ', N'Thùng', N'Đóng gói nhiều hộp trong 1 thùng, thường dùng để bán sỉ', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvtui0001 ', N'Túi', N'Sữa tươi dạng túi, phổ biến ở siêu thị', 1)
INSERT [dbo].[DonVi] ([maDonVi], [tenDonVi], [moTa], [trangThai]) VALUES (N'dvvien001 ', N'Viên', N'Dùng cho sữa dạng viên nén, sữa bổ sung', 1)
GO
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh001     ', N'lkhchan01 ', N'Nguyễn Văn A', N'123 Đường A, Quận 1, TP.HCM', N'0909123456', N'a.nguyen@example.com', 0, CAST(N'2025-06-07T08:42:46.040' AS DateTime))
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh002     ', N'lkhdacb01 ', N'Công ty B', N'456 Đường B, Quận 2, TP.HCM', N'0919123456', N'contact@congtyb.vn', 1500, CAST(N'2025-06-07T08:42:46.040' AS DateTime))
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh003     ', N'lkhdai001 ', N'Đại lý C', N'789 Đường C, Quận 3, TP.HCM', N'0929123456', N'dailyc@gmail.com', 3000, CAST(N'2025-06-07T08:42:46.040' AS DateTime))
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh004     ', N'lkhle00001', N'Khách Lẻ D', N'101 Đường D, Quận 4, TP.HCM', N'0939123456', N'le.d@example.com', 100, CAST(N'2025-06-07T08:42:46.040' AS DateTime))
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh005     ', N'lkhsi00001', N'Khách Sỉ E', N'202 Đường E, Quận 5, TP.HCM', N'0949123456', N'si.e@example.com', 5088, CAST(N'2025-06-07T08:42:46.040' AS DateTime))
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh006     ', N'lkhtiem01 ', N'Khách Tiềm Năng F', N'303 Đường F, Quận 6, TP.HCM', N'0959123456', N'tiemnangf@gmail.com', 0, CAST(N'2025-06-07T08:42:46.040' AS DateTime))
INSERT [dbo].[KhachHang] ([maKhachHang], [maLoaiKhachHang], [tenKhachHang], [diaChi], [soDienThoai], [email], [diemTichLuy], [ngayDangKy]) VALUES (N'kh-khdonle', N'lkhle00001', N'Khách hàng lẻ', N'*', N'*', N'*', 0, CAST(N'2025-06-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[LoaiKhachHang] ([maLoaiKhachHang], [tenLoaiKhachHang], [moTa], [trangThai]) VALUES (N'lkhchan01 ', N'Khách chặn', N'Danh sách hạn chế do vi phạm chính sách', 0)
INSERT [dbo].[LoaiKhachHang] ([maLoaiKhachHang], [tenLoaiKhachHang], [moTa], [trangThai]) VALUES (N'lkhdacb01 ', N'Khách hàng đặc biệt', N'Khách VIP hoặc đối tác chiến lược', 1)
INSERT [dbo].[LoaiKhachHang] ([maLoaiKhachHang], [tenLoaiKhachHang], [moTa], [trangThai]) VALUES (N'lkhdai001 ', N'Khách hàng đại lý', N'Đại lý phân phối sản phẩm chính thức', 1)
INSERT [dbo].[LoaiKhachHang] ([maLoaiKhachHang], [tenLoaiKhachHang], [moTa], [trangThai]) VALUES (N'lkhle00001', N'Khách lẻ', N'Mua hàng không thường xuyên, số lượng ít', 1)
INSERT [dbo].[LoaiKhachHang] ([maLoaiKhachHang], [tenLoaiKhachHang], [moTa], [trangThai]) VALUES (N'lkhsi00001', N'Khách sỉ', N'Mua hàng số lượng lớn với giá sỉ', 1)
INSERT [dbo].[LoaiKhachHang] ([maLoaiKhachHang], [tenLoaiKhachHang], [moTa], [trangThai]) VALUES (N'lkhtiem01 ', N'Tiềm năng', N'Khách có khả năng trở thành đối tác lâu dài', 1)
GO
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000001', N'cvadmin001', N'Nguyễn Văn A', N'nv00000001', 1, CAST(N'1985-04-12T00:00:00.000' AS DateTime), N'123 Trần Hưng Đạo, Q1, TP.HCM', N'0912345678', N'a.nguyen@vinamilk.vn', N'10 năm quản trị hệ thống')
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000002', N'cvbhang001', N'Trần Thị B', N'nv02.jpg', 0, CAST(N'1992-08-25T00:00:00.000' AS DateTime), N'45 Nguyễn Thái Học, Q3, TP.HCM', N'0987654321', N'b.tran@vinamilk.vn', N'5 năm bán hàng')
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000003', N'cvkt00001b', N'Lê Văn C', N'nv00000003', 1, CAST(N'1990-01-05T00:00:00.000' AS DateTime), N'89 Phạm Văn Đồng, TP.Thủ Đức', N'0933445566', N'c.le@vinamilk.vn', N'Chứng chỉ CPA, 7 năm kế toán')
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000004', N'cvthungan ', N'Phạm Thị D', N'nv04.jpg', 0, CAST(N'1995-11-15T00:00:00.000' AS DateTime), N'22 Võ Văn Tần, Q.10, TP.HCM', N'0977888999', N'd.pham@vinamilk.vn', N'3 năm làm thu ngân')
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000005', N'cvgiao001c', N'Hoàng Văn E', N'no-image', 1, CAST(N'1988-03-20T00:00:00.000' AS DateTime), N'12 Lý Thường Kiệt, Q.5, TP.HCM', N'0961122334', N'e.hoang@vinamilk.vn', N'Kinh nghiệm giao hàng nội thành')
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000006', N'cvkho0012a', N'Ngô Thị F', N'nv06.jpg', 0, CAST(N'1991-07-10T00:00:00.000' AS DateTime), N'8 Phan Xích Long, Q.Bình Thạnh', N'0909090909', N'f.ngo@vinamilk.vn', N'Quản lý kho hơn 6 năm')
INSERT [dbo].[NhanVien] ([maNhanVien], [maChucVu], [tenNhanVien], [hinhAnh], [gioiTinh], [ngaySinh], [diaChi], [soDienThoai], [email], [kinhNghiem]) VALUES (N'nv00000007', N'cvintern01', N'Vũ Minh G', N'no-image', 1, CAST(N'2002-09-01T00:00:00.000' AS DateTime), N'9 Nguyễn Tri Phương, Q.10', N'0922121212', N'g.vu@vinamilk.vn', N'Sinh viên thực tập ngành kế toán')
GO
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxabmalt ', N'Abbott', N'19001519', N'72 Lê Thánh Tôn, Quận 1, TP.HCM')
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxdutchy ', N'Dutch Lady', N'1800545454', N'12 Nguyễn Văn Bảo, Gò Vấp, TP.HCM')
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxfamiya ', N'Fami (Vinasoy)', N'1800555584', N'Long An, Việt Nam')
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxidmilk ', N'IDP - Kun', N'02837288888', N'Bình Dương, Việt Nam')
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxnutifo ', N'Nutifood', N'02835123456', N'456 Nguyễn Thị Minh Khai, Quận 3, TP.HCM')
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxthtrue ', N'TH True Milk', N'1900545416', N'Nghĩa Đàn, Nghệ An')
INSERT [dbo].[NhaSanXuat] ([maNhaSanXuat], [tenNhaSanXuat], [dienThoai], [diaChi]) VALUES (N'nsxvnmilk ', N'Vinamilk', N'02838482222', N'10 Tân Trào, Quận 7, TP.HCM')
GO
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000001', N'nsxvnmilk ', N'dtem000001', N'Sữa tươi tiệt trùng Vinamilk 100% có đường', N'Sữa tươi nguyên chất từ trang trại Vinamilk, bổ sung vitamin D3', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000002', N'nsxthtrue ', N'dtngl00001', N'Sữa tươi TH True Milk ít đường', N'Sữa tươi thanh trùng tự nhiên, tốt cho sức khỏe người lớn', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000003', N'nsxnutifo ', N'dtbme00001', N'Sữa bầu Nutifood GrowPLUS+', N'Sữa dành cho phụ nữ mang thai, hỗ trợ phát triển thai nhi', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000004', N'nsxabmalt ', N'dtem000001', N'Sữa bột Abbott Grow 3', N'Sữa công thức cho trẻ em từ 1-3 tuổi, hỗ trợ phát triển chiều cao', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000005', N'nsxdutchy ', N'dtnhi00001', N'Sữa Dutch Lady Active 20+', N'Sữa bổ sung năng lượng và dưỡng chất cho tuổi thiếu niên', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000006', N'nsxfamiya ', N'dtngl00001', N'Sữa đậu nành Fami nguyên chất', N'Sữa đậu nành tự nhiên, giàu protein thực vật', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000007', N'nsxidmilk ', N'dtem000001', N'Sữa chua uống KUN trái cây', N'Sữa chua uống liền với hương vị trái cây tự nhiên cho trẻ em', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000008', N'nsxnutifo ', N'dtgia00001', N'Sữa Nutifood Sure Prevent', N'Sữa chuyên biệt dành cho người già, hỗ trợ xương khớp và tiêu hóa', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000009', N'nsxvnmilk ', N'dtkdi00001', N'Sữa tươi Vinamilk Organic không đường', N'Sữa tươi hữu cơ không đường, phù hợp cho người ăn kiêng', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000010', N'nsxthtrue ', N'dtvo000001', N'Sữa TH True Milk TopKid Protein', N'Sữa giàu protein, dành cho vận động viên và người hoạt động thể chất', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000011', N'nsxvnmilk ', N'dtngl00001', N'Sữa đặc Ông Thọ Vinamilk', N'Sữa đặc có đường truyền thống, dùng trong pha chế và làm bánh', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000012', N'nsxthtrue ', N'dtem000001', N'Sữa tươi TH True Milk HILO', N'Sữa tươi ít béo, giàu canxi, tốt cho xương', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000013', N'nsxnutifo ', N'dtbnh00001', N'Sữa Nutifood Varna Complete', N'Dinh dưỡng y học cho người bệnh cần phục hồi sức khỏe', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000014', N'nsxabmalt ', N'dtgia00001', N'Ensure Gold Abbott', N'Sữa bột bổ sung dinh dưỡng toàn diện cho người lớn tuổi', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000015', N'nsxdutchy ', N'dtem000001', N'Sữa công thức Dutch Lady 123', N'Sữa bột cho trẻ từ 1-3 tuổi, hỗ trợ phát triển thể chất và trí não', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000016', N'nsxfamiya ', N'dtkdi00001', N'Sữa hạt Fami Canxi', N'Sữa hạt bổ sung canxi, không cholesterol, phù hợp cho người ăn kiêng', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000017', N'nsxidmilk ', N'dtnhi00001', N'Sữa chua KUN Sô-cô-la', N'Sữa chua ăn liền hương vị sô-cô-la, được trẻ em yêu thích', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000018', N'nsxvnmilk ', N'dtvo000001', N'Sữa Yomilk Active Pro', N'Sữa chua uống lợi khuẩn, hỗ trợ tiêu hóa và tăng cường sức đề kháng', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000019', N'nsxthtrue ', N'dtkdi00001', N'Sữa chua uống TH True Milk Pro', N'Sữa chua uống không đường, ít béo, giàu protein', 1)
INSERT [dbo].[SanPham] ([maSanPham], [maNhaSanXuat], [maDoiTuong], [tenSanPham], [moTa], [trangThai]) VALUES (N'sp00000020', N'nsxnutifo ', N'dtkha00001', N'Sữa đậu nành Nutifood VFresh', N'Sữa đậu nành tự nhiên, thơm ngon, phù hợp mọi đối tượng, độ tuổi', 1)
GO
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000001', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvadmin001', 1)
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000002', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvbhang001', 1)
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000003', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvkt00001b', 1)
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000004', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvthungan ', 1)
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000005', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvgiao001c', 1)
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000006', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvkhoadmin', 1)
INSERT [dbo].[TaiKhoan] ([maNhanVien], [matKhau], [quyenHan], [trangThai]) VALUES (N'nv00000007', N'4dff4ea340f0a823f15d3f4f01ab62eae0e5da579ccb851f8db9dfe84c58b2b37b89903a740e1ee172da793a6e79d560e5f7f9bd058a12a280433ed6fa46510a', N'cvintern01', 1)
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietDonHang_DonHang]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietDonHang_DonHang] ON [dbo].[ChiTietDonHang]
(
	[maDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietDonHang_SanPham]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietDonHang_SanPham] ON [dbo].[ChiTietDonHang]
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietSanPham_DonVi]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietSanPham_DonVi] ON [dbo].[ChiTietSanPham]
(
	[maDonVi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_ChiTietSanPham_SanPham]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_ChiTietSanPham_SanPham] ON [dbo].[ChiTietSanPham]
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_DonHang_KhachHang]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_DonHang_KhachHang] ON [dbo].[DonHang]
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_DonHang_NhanVien]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_DonHang_NhanVien] ON [dbo].[DonHang]
(
	[maNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_KhachHang_LoaiKhachHang]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_KhachHang_LoaiKhachHang] ON [dbo].[KhachHang]
(
	[maLoaiKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_NhanVien_ChucVu]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_NhanVien_ChucVu] ON [dbo].[NhanVien]
(
	[maChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_SanPham_DoiTuong]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_SanPham_DoiTuong] ON [dbo].[SanPham]
(
	[maDoiTuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_FK_SanPham_NhaSanXuat]    Script Date: 6/7/2025 5:10:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_FK_SanPham_NhaSanXuat] ON [dbo].[SanPham]
(
	[maNhaSanXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NhanVien] ADD  CONSTRAINT [DF_NhanVien_hinhAnh]  DEFAULT ('no-image') FOR [hinhAnh]
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
