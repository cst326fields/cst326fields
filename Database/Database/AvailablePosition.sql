CREATE TABLE [dbo].[AvailablePosition]
(
	[availablePosId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [storeId] INT NOT NULL, 
    [positionId] INT NOT NULL, 
    [workingDays] VARCHAR(255) NOT NULL,
    CONSTRAINT [FK_Store_AvailablePosition] FOREIGN KEY (storeId) REFERENCES [dbo].[Store] ([storeId]),
    CONSTRAINT [FK_Position_AvailablePosition] FOREIGN KEY (positionId) REFERENCES [dbo].[Position] ([positionId])


)
