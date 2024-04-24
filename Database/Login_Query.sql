USE [LMS]
GO

/****** Object:  Table [dbo].[Login]    Script Date: 5/16/2023 6:17:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Login](
	[Username] [varchar](150) NOT NULL,
	[Password] [varchar](20) NOT NULL
) ON [PRIMARY]
GO


