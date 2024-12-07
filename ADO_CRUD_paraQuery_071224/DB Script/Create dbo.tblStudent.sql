USE [myDB123]
GO

/****** Object: Table [dbo].[tblStudent] Script Date: 7.12.24 15:38:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblStudent] (
    [Roll]        INT          NOT NULL,
    [Name]        VARCHAR (50) NULL,
    [total_marks] INT          NULL
);


