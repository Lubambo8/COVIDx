CREATE TABLE [dbo].[Nurse_Schedule]
(
	[TestRequestID] INT NOT NULL PRIMARY KEY, 
    [NurseID] INT NOT NULL, 
    CONSTRAINT [FK_Nurse_Schedule_Nurse] FOREIGN KEY ([NurseID]) REFERENCES [Nurse]([NurseID])
)
