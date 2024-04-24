USE [LMS]
GO

/****** Object:  Table [dbo].[IssueBook]    Script Date: 5/16/2023 6:17:12 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[IssueBook](
	[UserID] [varchar](150) NOT NULL,
	[ISBN] [varchar](150) NOT NULL,
	[IssueDate] [varchar](150) NOT NULL,
	[ReturnDate] [varchar](150) NOT NULL,
	[IsReturned] [bit] NOT NULL,
	[Fine] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[IssueBook]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[AddNewBook] ([ISBN])
GO

ALTER TABLE [dbo].[IssueBook]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[AddNewBook] ([ISBN])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[IssueBook]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[AddUser] ([UserID])
GO

ALTER TABLE [dbo].[IssueBook]  WITH CHECK ADD FOREIGN KEY([UserID])
REFERENCES [dbo].[AddUser] ([UserID])
ON DELETE CASCADE
GO


