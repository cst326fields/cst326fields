CREATE TABLE [dbo].[Store]
(
	[storeId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [name] VARCHAR(255) NOT NULL, 
    [address] VARCHAR(255) NOT NULL, 
    [city] VARCHAR(255) NOT NULL, 
    [stateAbbreviation] CHAR(2) NOT NULL
)
