-- Create Database
CREATE DATABASE [QLCongTy]
GO

-- Use Database
USE [QLCongTy]
GO

-- Create Table ThongTinPhongBan
CREATE TABLE [dbo].[ThongTinPhongBan](
	  [MaPB] [nvarchar](50) NOT NULL,
	  [TenPB] [nvarchar](50)NOT NULL,
	  [DiaChi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ThongTinPhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (
	PAD_INDEX = OFF, 
	STATISTICS_NORECOMPUTE = OFF, 
	IGNORE_DUP_KEY = OFF, 
	ALLOW_ROW_LOCKS = ON, 
	ALLOW_PAGE_LOCKS = ON, 
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Create Table ThongTinNhanVien
CREATE TABLE [dbo].[ThongTinNhanVien](
	 [MaNV] [nvarchar](50) NOT NULL,
	 [TenNV] [nvarchar](50)NOT NULL,
	 [NgaySinh] [date] NOT NULL,
	 [GioiTinh] [nvarchar](10) NOT NULL,
	 [ChucVu] [nvarchar](50) NOT NULL,
	 [TienLuong] [int] NOT NULL,
	 [MaPB] [nvarchar](50)NOT NULL,
 CONSTRAINT [PK_ThongTinNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (
	PAD_INDEX = OFF, 
	STATISTICS_NORECOMPUTE = OFF, 
	IGNORE_DUP_KEY = OFF, 
	ALLOW_ROW_LOCKS = ON, 
	ALLOW_PAGE_LOCKS = ON, 
	OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF
) ON [PRIMARY]
) ON [PRIMARY]
GO

-- Add Foreign Key Constraint with ON DELETE CASCADE
ALTER TABLE [dbo].[ThongTinNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_ThongTinNhanVien_ThongTinPhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[ThongTinPhongBan] ([MaPB])
ON DELETE CASCADE
GO

-- Enable the Constraint
ALTER TABLE [dbo].[ThongTinNhanVien] CHECK CONSTRAINT [FK_ThongTinNhanVien_ThongTinPhongBan]
GO
