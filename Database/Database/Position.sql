CREATE TABLE [dbo].[Position]
(
	[positionId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [title] VARCHAR(255) NOT NULL, 
    [description] VARCHAR(255) NOT NULL, 
    [pay] VARCHAR(255) NOT NULL,

)
