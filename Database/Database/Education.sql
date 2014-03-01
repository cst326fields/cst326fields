CREATE TABLE [dbo].[Education]
(
	[applicantId] INT NOT NULL PRIMARY KEY
    CONSTRAINT [FK_PersonalInfo_Education] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [nameAddress] VARCHAR(255) NULL, 
    [yearsAttended] VARCHAR(255) NULL, 
    [graduated] CHAR(1) NULL, 
    [degreeMajor] VARCHAR(255) NULL

)
