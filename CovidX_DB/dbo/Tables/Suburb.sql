CREATE TABLE [dbo].[Suburb]
(
	[SuburbID] INT NOT NULL PRIMARY KEY, 
    [SuburbName] NVARCHAR(128) NOT NULL, 
    [PostalCode] NCHAR(128) NOT NULL, 
    [CityID] INT NOT NULL, 
    CONSTRAINT [FK_Suburb_City] FOREIGN KEY ([CityID]) REFERENCES [City]([CityID]), 
    

)
