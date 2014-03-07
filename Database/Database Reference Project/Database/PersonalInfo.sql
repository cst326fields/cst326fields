CREATE TABLE [dbo].[PersonalInfo]
(
	[applicantId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [firstName] VARCHAR(255) NOT NULL, 
    [middleName] VARCHAR(255) NULL, 
    [lastName] VARCHAR(255) NOT NULL, 
    [socialNum] VARCHAR(9) NOT NULL, 
    [address] VARCHAR(255) NOT NULL, 
    [Phone] VARCHAR(16) NULL, 
    [alias] VARCHAR(255) NULL
)
