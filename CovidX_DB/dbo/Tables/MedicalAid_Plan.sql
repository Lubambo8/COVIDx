CREATE TABLE [dbo].[MedicalAid_Plan]
(
	[MedicalAidPlanID] INT NOT NULL PRIMARY KEY, 
    [Description] NVARCHAR(128) NOT NULL, 
    [MedicalAidScheme] INT NOT NULL
)
