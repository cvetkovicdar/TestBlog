﻿CREATE TABLE [dbo].[Posts]
(
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Title] NVARCHAR (50) NULL,
	[Date] DATETIME NULL,
	[Authors] NVARCHAR (50) NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)