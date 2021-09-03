CREATE TABLE [dbo].[MedicalAid_Plan]
(
	[MedicalAidPlanID] INT NOT NULL PRIMARY KEY, 
    [Description] NVARCHAR(128) NOT NULL, 
    [MedicalAidSchemeID] INT NOT NULL, 
    CONSTRAINT [FK_MedicalAid_Plan_MedicalAidScheme] FOREIGN KEY (MedicalAidSchemeID) REFERENCES MedicalAid_Scheme([MedicalAidSchemeID])
)
