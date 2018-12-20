CREATE TABLE [dbo].[Client]
(
	[Id] INT NOT NULL PRIMARY KEY , 
    [FirstName] NCHAR(10) NOT NULL, 
    [ LastName] NCHAR(10) NOT NULL, 
    [SenderId] NCHAR(10) NOT NULL, 
    [Date] DATETIME NOT NULL
)
