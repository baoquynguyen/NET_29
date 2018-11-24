CREATE DATABASE "QLNhansu"

USE [QLNhansu]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/24/2018 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [char](4) NOT NULL,
	[Hoten] [nvarchar](40) NULL,
	[NamSinh] [int] NULL,
	[MaPB] [int] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Phongban]    Script Date: 11/24/2018******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
