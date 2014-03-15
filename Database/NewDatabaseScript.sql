IF OBJECT_ID('[dbo].[Education]', 'U') IS NOT NULL
DROP TABLE [dbo].[Education];
IF OBJECT_ID('[dbo].[References]', 'U') IS NOT NULL
DROP TABLE [dbo].[References];
IF OBJECT_ID('[dbo].[ElectronicSig]', 'U') IS NOT NULL
DROP TABLE [dbo].[ElectronicSig];
IF OBJECT_ID('[dbo].[JobHistory]', 'U') IS NOT NULL
DROP TABLE [dbo].[JobHistory];
IF OBJECT_ID('[dbo].[Questionaire]', 'U') IS NOT NULL
DROP TABLE [dbo].[Questionaire];
IF OBJECT_ID('[dbo].[Question]', 'U') IS NOT NULL
DROP TABLE [dbo].[Question];
IF OBJECT_ID('[dbo].[Application]', 'U') IS NOT NULL
DROP TABLE [dbo].[Application];
IF OBJECT_ID('[dbo].[AvailablePosition]', 'U') IS NOT NULL
DROP TABLE [dbo].[AvailablePosition];
IF OBJECT_ID('[dbo].[Position]', 'U') IS NOT NULL
DROP TABLE [dbo].[Position];
IF OBJECT_ID('[dbo].[Store]', 'U') IS NOT NULL
DROP TABLE [dbo].[Store];
IF OBJECT_ID('[dbo].[PersonalInfo]', 'U') IS NOT NULL
DROP TABLE [dbo].[PersonalInfo];

CREATE TABLE [dbo].[PersonalInfo]
(
	[applicantId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [firstName] VARCHAR(255) NOT NULL, 
    [middleName] VARCHAR(255) NULL, 
    [lastName] VARCHAR(255) NOT NULL, 
    [socialNum] VARCHAR(16) NOT NULL, 
    [address] VARCHAR(255) NOT NULL, 
    [Phone] VARCHAR(16) NULL, 
    [alias] VARCHAR(255) NULL
);

CREATE TABLE [dbo].[Store]
(
	[storeId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [name] VARCHAR(255) NOT NULL, 
    [address] VARCHAR(255) NOT NULL, 
    [city] VARCHAR(255) NOT NULL, 
    [stateAbbreviation] CHAR(2) NOT NULL
);

INSERT INTO [dbo].[Store] VALUES ('West Wilsonville Store', '1234 Road St', 'Wilsonville', 'OR');
INSERT INTO [dbo].[Store] VALUES ('East Wilsonville Store', '3678 High St', 'Wilsonville', 'OR');
INSERT INTO [dbo].[Store] VALUES ('West Portland Store', '786 Stree st', 'Portland', 'OR');

CREATE TABLE [dbo].[Position]
(
	[positionId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [title] VARCHAR(255) NOT NULL, 
    [description] VARCHAR(2000) NOT NULL, 
    [pay] VARCHAR(255) NOT NULL,
);

INSERT INTO [dbo].[Position] VALUES ('Cashier', 'Greet customers as they arrive at the store and provide them with information 
Respond to customers’ records and resolve their issues
Take payment in exchange of items sold
Bag, box or wrap purchased items
Enter transactions in the cash register and provide customers with the total
Identify prices of goods using memory or scanner
Issue receipts and change to customers
', '$10/hr');

INSERT INTO [dbo].[Position] VALUES ('Custodian', '
Clean building floors by sweeping, mopping, scrubbing, or vacuuming them.
Gather and empty trash.
Service, clean, and supply restrooms.
Clean and polish furniture and fixtures.
Clean windows, glass partitions, and mirrors, using soapy water or other cleaners, sponges, and squeegees.
Dust furniture, walls, machines, and equipment.
', '$9.80/hr');

INSERT INTO [dbo].[Position] VALUES ('Assistant Manager', '
Ensure the business operations run smoothly in the shop
Keeping on track to meet the monthly budgets and targets
Provide training for staff and new recruitments
Provide excellent customer service
Prepared to attend to urgent customers when required
Planning rosters and duties for staff
Monitoring the displays of products on shelves
Handling the deliveries, checking quality, expiry date, price and correct quantity
', '$15/hr');

CREATE TABLE [dbo].[AvailablePosition]
(
	[availablePosId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [storeId] INT NOT NULL, 
    [positionId] INT NOT NULL, 
    [workingDays] VARCHAR(255) NOT NULL,
    CONSTRAINT [FK_Store_AvailablePosition] FOREIGN KEY (storeId) REFERENCES [dbo].[Store] ([storeId]),
    CONSTRAINT [FK_Position_AvailablePosition] FOREIGN KEY (positionId) REFERENCES [dbo].[Position] ([positionId])
);

INSERT INTO [dbo].[AvailablePosition] VALUES ('1', '1','Monday-Friday');
INSERT INTO [dbo].[AvailablePosition] VALUES ('1', '2','Satuday-Sunday');
INSERT INTO [dbo].[AvailablePosition] VALUES ('1', '3','Satuday-Wednesday');
INSERT INTO [dbo].[AvailablePosition] VALUES ('2', '3','Monday-Friday');

CREATE TABLE [dbo].[Application]
(
	[applicantId] INT NOT NULL,
    CONSTRAINT [FK_PersonalInfo_Application] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]),
    CONSTRAINT [FK_AvailablePosition_Application] FOREIGN KEY (availablePosId) REFERENCES [dbo].[AvailablePosition] ([availablePosId]),
    CONSTRAINT [FK_Store_Application] FOREIGN KEY (storeId) REFERENCES [dbo].[Store] ([storeId]), 
    [availablePosId] INT NOT NULL,
	[storeId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([applicantId] ASC, [availablePosId] ASC)
);

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
);

CREATE TABLE [dbo].[ElectronicSig]
(
	[applicantId] INT NOT NULL PRIMARY KEY,
    CONSTRAINT [FK_PersonalInfo_ElectronicSig] FOREIGN KEY (applicantId) REFERENCES [dbo].[PersonalInfo] ([applicantId]), 
    [signature] VARCHAR(255) NULL, 
    [date] DATETIME NULL

);

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
);

CREATE TABLE [dbo].[Question]
(
	[questionId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [theQuestion] VARCHAR(255) NOT NULL, 
    [theAnswer] NCHAR(1) NOT NULL
);

INSERT INTO [dbo].[Question] VALUES ('Can you lift 50 lbs?', 'y');
INSERT INTO [dbo].[Question] VALUES ('Can you stand for over 8 hours', 'y');
INSERT INTO [dbo].[Question] VALUES ('Do you have transportation?', 'y');

CREATE TABLE [dbo].[Questionaire]
(
	[questionaireId] INT NOT NULL IDENTITY(1,1),
	[questionId] INT NOT NULL, 
    [positionId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([questionId] ASC, [positionId] ASC),
    CONSTRAINT [FK_Question_Questionaire] FOREIGN KEY (questionId) REFERENCES [dbo].[Question] ([questionId]),
    CONSTRAINT [FK_Position_Questionaire] FOREIGN KEY (positionId) REFERENCES [dbo].[Position] ([positionId])
);

INSERT INTO [dbo].[Questionaire] VALUES (1, 1);
INSERT INTO [dbo].[Questionaire] VALUES (2, 1);
INSERT INTO [dbo].[Questionaire] VALUES (3, 1);
INSERT INTO [dbo].[Questionaire] VALUES (1, 2);
INSERT INTO [dbo].[Questionaire] VALUES (2, 2);
INSERT INTO [dbo].[Questionaire] VALUES (3, 2);

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
);


