USE [propertyX]
GO

/****** Object:  Table [dbo].[tabl_propertyRecords]    Script Date: 3/10/2022 2:50:39 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tabl_propertyRecords](
	[Date] [date] NULL,
	[IPAIFileNo] [varchar](50) NULL,
	[Requesting_Unit] [varchar](50) NULL,
	[Account_Name] [varchar](50) NULL,
	[Type_Of_Property] [varchar](50) NULL,
	[Loc_City] [varchar](50) NULL,
	[Loc_Brgy] [varchar](50) NULL,
	[Loc_Street] [varchar](50) NULL,
	[Loc_Full] [varchar](50) NULL,
	[Value_Square_Meter] [float] NULL
) ON [PRIMARY]
GO


