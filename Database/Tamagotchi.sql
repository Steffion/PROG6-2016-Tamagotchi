CREATE TABLE [dbo].[Tamagotchi]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
	[LastAccess] DATETIME NULL,
	[Created] DATETIME NOT NULL,
    [Age] INT NULL DEFAULT 0, 
    [Hunger] INT NULL DEFAULT 0, 
    [Sleep] INT NULL DEFAULT 0, 
    [Bored] INT NULL DEFAULT 0, 
    [Health] INT NULL DEFAULT 100
)
