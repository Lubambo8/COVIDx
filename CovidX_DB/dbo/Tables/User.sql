CREATE TABLE [dbo].[User]
(
	[UserID] INT NOT NULL PRIMARY KEY, 
    [UserName] NVARCHAR(128) NOT NULL,
	[PasswordHash] NVARCHAR(MAX) NOT NULL,
	[Avatar] NVARCHAR(MAX),
	[Active] BIT NOT NULL,
	[UserType] CHAR(10) NOT NULL, 
  
)
