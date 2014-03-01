CREATE TABLE [dbo].[References]
(
	[applicantId] INT NOT NULL PRIMARY KEY
    CONSTRAINT [FK_PersonalInfo_References] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [name] VARCHAR(255) NULL, 
    [phone] VARCHAR(50) NULL, 
    [company] VARCHAR(255) NULL, 
    [title] VARCHAR(255) NULL

)
