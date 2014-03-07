CREATE TABLE [dbo].[JobHistory]
(
	[applicantId] INT NOT NULL PRIMARY KEY
	CONSTRAINT [FK_PersonalInfo_JobHistory] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [employer] VARCHAR(255) NULL, 
    [from] DATE NULL, 
    [to] DATE NULL, 
    [address] VARCHAR(255) NULL, 
    [phone] VARCHAR(255) NULL, 
    [supervisor] VARCHAR(255) NULL, 
    [position] VARCHAR(255) NULL, 
    [startSalary] VARCHAR(255) NULL, 
    [endSalary] VARCHAR(255) NULL, 
    [reasonLeave] VARCHAR(255) NULL, 
    [duties] VARCHAR(255) NULL

)
