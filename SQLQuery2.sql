CREATE TABLE [dbo].[utente]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [nome] NVARCHAR(255) NULL, 
    [cognome] NVARCHAR(255) NULL, 
    [email] NVARCHAR(255) NULL, 
    [telefono] NVARCHAR(255) NOT NULL
)
