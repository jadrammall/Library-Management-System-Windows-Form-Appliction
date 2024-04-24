USE [LMS]
GO

/****** Object:  Table [dbo].[AddUser]    Script Date: 5/16/2023 6:16:46 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AddUser](
	[UserName] [varchar](150) NOT NULL,
	[UserID] [varchar](150) NOT NULL,
	[UserContact] [varchar](150) NOT NULL,
	[UserEmail] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


