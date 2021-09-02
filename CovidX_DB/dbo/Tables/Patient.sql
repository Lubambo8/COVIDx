CREATE TABLE [dbo].[Patient]
(
	[PatientID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(128) NOT NULL, 
    [LastName] NVARCHAR(128) NOT NULL, 
    [IDNumber] NVARCHAR(13) NOT NULL, 
    [EmailAddress] NVARCHAR(128) NOT NULL, 
    [MobileNumber] NCHAR(10) NOT NULL, 
    [AddressLine1] NVARCHAR(128) NOT NULL, 
    [AddressLine2] NVARCHAR(128) NULL, 
    [SuburbID] INT NOT NULL, 
    [MedicalAidStatus] BIT NOT NULL, 
    [MedicalAidPlanID] INT NOT NULL, 
    [MedicalAidNo] INT NOT NULL, 
    [DependencyCode] INT NOT NULL, 
    [DateOfBirth] DATETIME NOT NULL, 
    CONSTRAINT [FK_Patient_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Patient_MedicalAidPlan] FOREIGN KEY ([MedicalAidPlanID]) REFERENCES [MedicalAid_Plan]([MedicalAidPlanID]), 
    CONSTRAINT [FK_Patient_User] FOREIGN KEY ([PatientID]) REFERENCES [User]([UserID]), 

)
