USE [LMS]
GO

/****** Object:  Table [dbo].[AddNewBook]    Script Date: 5/16/2023 6:16:16 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AddNewBook](
	[BookName] [varchar](150) NOT NULL,
	[ISBN] [varchar](150) NOT NULL,
	[PublishDate] [varchar](150) NOT NULL,
	[Category] [varchar](150) NOT NULL,
	[Quantity] [int] NOT NULL,
	[AuthorName] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


