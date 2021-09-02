CREATE TABLE [dbo].[Test_Request]
(
	[TestRequestID] INT NOT NULL PRIMARY KEY, 
    [PatientID] INT NOT NULL, 
    [RequestDate] DATETIME NOT NULL, 
    [RequestStatus] NVARCHAR(50) NOT NULL, 
    [TestAddress1] NVARCHAR(128) NOT NULL, 
    [TestAddress2] NVARCHAR(128) NULL, 
    [SuburbID] INT NOT NULL, 
    [NurseID] INT NOT NULL, 
    [DateAssigned] DATETIME NOT NULL, 
    [TimeSlotAssigned] DATETIME NOT NULL, 
    CONSTRAINT [FK_Test_Request_Patient] FOREIGN KEY ([PatientID]) REFERENCES [Patient]([PatientID]), 
    CONSTRAINT [FK_Test_Request_SuburbID] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Test_Request_NurseID] FOREIGN KEY ([NurseID]) REFERENCES [Nurse]([NurseID])
)
