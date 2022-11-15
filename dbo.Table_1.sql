CREATE TABLE [dbo].[Dvd]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Titolo] NVARCHAR(255) NULL, 
    [Anno] INT NULL, 
    [Stato] NVARCHAR(50) NULL, 
    [Settore] NVARCHAR(50) NULL, 
    [Scaffale] NCHAR(10) NULL, 
    [Autore] NVARCHAR(50) NULL, 
    [Codice] NVARCHAR(255) NULL, 
    [Durata] INT NULL
)
