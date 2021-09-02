CREATE TABLE [dbo].[Dependent]
(
	[DependentID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(128) NOT NULL, 
    [LastName] NVARCHAR(128) NOT NULL, 
    [IDNumber] NVARCHAR(13) NOT NULL, 
    [EmailAddress] NVARCHAR(128) NOT NULL, 
    [AddressLine1] NVARCHAR(128) NOT NULL, 
    [AddressLine2] NVARCHAR(128) NULL, 
    [SuburbID] INT NOT NULL, 
    [DateOFBirth] DATETIME NOT NULL, 
    [MedicalAidPlanID] INT NOT NULL, 
    [MedicalAidStatus] BIT NOT NULL, 
    [MobileNumber] NCHAR(10) NOT NULL, 
    [RelationshipTypeID] INT NOT NULL, 
    [DependencyCode] NCHAR(10) NOT NULL, 
    [MainMemberID] INT NOT NULL, 
    CONSTRAINT [FK_Dependent_Suburb] FOREIGN KEY ([SuburbID]) REFERENCES [Suburb]([SuburbID]), 
    CONSTRAINT [FK_Dependent_MedicalAidPlan] FOREIGN KEY ([MedicalAidPlanID]) REFERENCES [MedicalAid_Plan]([MedicalAidPlanID]), 
    CONSTRAINT [FK_Dependent_RelationshipType] FOREIGN KEY ([RelationshipTypeID]) REFERENCES [Relationship]([RelationshipTypeID]), 
    CONSTRAINT [FK_Dependent_Patient] FOREIGN KEY ([MainMemberID]) REFERENCES [Patient]([PatientID])
)
