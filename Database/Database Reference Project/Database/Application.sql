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
