CREATE TABLE [dbo].[Suburbs_Preferred]
(
	[SuburbID] INT NOT NULL PRIMARY KEY, 
    [NurseID] INT NOT NULL, 
    CONSTRAINT [FK_Suburbs_Preferred_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Suburbs_Preferred_NurseID] FOREIGN KEY ([NurseID]) REFERENCES [Nurse]([NurseID]), 
    
)
