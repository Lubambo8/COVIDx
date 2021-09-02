CREATE TABLE [dbo].[Request_History]
(
	[TestRequestID] INT NOT NULL PRIMARY KEY, 
    [Date] DATETIME NOT NULL, 
    [OldRequestStatus] NVARCHAR(50) NOT NULL
)
