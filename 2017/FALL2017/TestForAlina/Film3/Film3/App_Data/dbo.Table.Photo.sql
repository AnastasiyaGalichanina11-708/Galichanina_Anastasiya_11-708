CREATE TABLE [dbo].[Photo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Path] NCHAR(10) NOT NULL, 
    [DateCreate] DATETIME NOT NULL, 
    [UserId] INT NOT NULL
)
