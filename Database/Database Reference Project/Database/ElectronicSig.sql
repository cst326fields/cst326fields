CREATE TABLE [dbo].[ElectronicSig]
(
	[applicantId] INT NOT NULL PRIMARY KEY
    CONSTRAINT [FK_PersonalInfo_ElectronicSig] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [signature] VARCHAR(255) NULL, 
    [date] DATETIME NULL

)
