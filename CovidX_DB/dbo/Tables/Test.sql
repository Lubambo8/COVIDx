﻿CREATE TABLE [dbo].[Test]
(
	[TestID] INT NOT NULL PRIMARY KEY, 
    [TestRequestID] INT NOT NULL, 
    [BarCode] NVARCHAR(128) NOT NULL, 
    [Temperature] FLOAT NOT NULL, 
    [BloodPressure] FLOAT NOT NULL, 
    [OxygenLevel] FLOAT NOT NULL, 
    [TestDate] DATETIME NOT NULL, 
    [TestTime] TIME NOT NULL, 
    [TestResult] NVARCHAR(128) NOT NULL, 
    [ResultDate] DATETIME NOT NULL, 
    [LabUserID] INT NOT NULL, 
    CONSTRAINT [FK_Test_TestRequest] FOREIGN KEY ([TestRequestID]) REFERENCES [Test_Request]([TestRequestID]), 
    CONSTRAINT [FK_Test_LabUser] FOREIGN KEY ([LabUserID]) REFERENCES [LabUser]([LabUserID])
)