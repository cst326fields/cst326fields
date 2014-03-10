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

CREATE TABLE [dbo].[Store]
(
	[storeId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [name] VARCHAR(255) NOT NULL, 
    [address] VARCHAR(255) NOT NULL, 
    [city] VARCHAR(255) NOT NULL, 
    [stateAbbreviation] CHAR(2) NOT NULL
)

CREATE TABLE [dbo].[Position]
(
	[positionId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [title] VARCHAR(255) NOT NULL, 
    [description] VARCHAR(255) NOT NULL, 
    [pay] VARCHAR(255) NOT NULL,
)

CREATE TABLE [dbo].[AvailablePosition]
(
	[availablePosId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [storeId] INT NOT NULL, 
    [positionId] INT NOT NULL, 
    [workingDays] VARCHAR(255) NOT NULL,
    CONSTRAINT [FK_Store_AvailablePosition] FOREIGN KEY (storeId) REFERENCES [dbo].[Store] ([storeId]),
    CONSTRAINT [FK_Position_AvailablePosition] FOREIGN KEY (positionId) REFERENCES [dbo].[Position] ([positionId])
)

CREATE TABLE [dbo].[Application]
(
	[applicantId] INT NOT NULL,
    CONSTRAINT [FK_PersonalInfo_Application] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]),
    CONSTRAINT [FK_AvailablePosition_Application] FOREIGN KEY (availablePosId) REFERENCES [dbo].[AvailablePosition] ([availablePosId]),
    CONSTRAINT [FK_Store_Application] FOREIGN KEY (storeId) REFERENCES [dbo].[Store] ([storeId]), 
    [availablePosId] INT NOT NULL,
	[storeId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([applicantId] ASC, [availablePosId] ASC)
)

CREATE TABLE [dbo].[Education]
(
	[applicantId] INT NOT NULL,
	[educationId] INT NOT NULL IDENTITY(1,1),
    CONSTRAINT [FK_PersonalInfo_Education] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [nameAddress] VARCHAR(255) NULL, 
    [yearsAttended] VARCHAR(255) NULL, 
    [graduated] CHAR(1) NULL, 
    [degreeMajor] VARCHAR(255) NULL,
	PRIMARY KEY CLUSTERED ([applicantId] ASC, [educationId] ASC)
)

CREATE TABLE [dbo].[ElectronicSig]
(
	[applicantId] INT NOT NULL PRIMARY KEY,
    CONSTRAINT [FK_PersonalInfo_ElectronicSig] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [signature] VARCHAR(255) NULL, 
    [date] DATETIME NULL

)

CREATE TABLE [dbo].[JobHistory]
(
	[applicantId] INT NOT NULL,
	[jobHistoryId] INT NOT NULL IDENTITY(1,1),
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
    [duties] VARCHAR(255) NULL,
	PRIMARY KEY CLUSTERED ([applicantId] ASC, [jobHistoryId] ASC)
)

CREATE TABLE [dbo].[Question]
(
	[questionId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [theQuestion] VARCHAR(255) NOT NULL, 
    [theAnswer] NCHAR(10) NOT NULL
)

CREATE TABLE [dbo].[Questionaire]
(
	[questionaireId] INT NOT NULL IDENTITY(1,1),
	[questionId] INT NOT NULL, 
    [positionId] INT NOT NULL PRIMARY KEY,
    CONSTRAINT [FK_Question_Questionaire] FOREIGN KEY (questionId) REFERENCES [dbo].[Question] ([questionId]),
    CONSTRAINT [FK_Position_Questionaire] FOREIGN KEY (positionId) REFERENCES [dbo].[Position] ([positionId])
)

CREATE TABLE [dbo].[References]
(
	[applicantId] INT NOT NULL,
	[referenceId] INT NOT NULL IDENTITY(1,1),
    CONSTRAINT [FK_PersonalInfo_References] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [name] VARCHAR(255) NULL, 
    [phone] VARCHAR(50) NULL, 
    [company] VARCHAR(255) NULL, 
    [title] VARCHAR(255) NULL,
	PRIMARY KEY CLUSTERED ([applicantId] ASC, [referenceId] ASC)
)


