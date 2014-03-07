CREATE TABLE [dbo].[Question]
(
	[questionId] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [theQuestion] VARCHAR(255) NOT NULL, 
    [theAnswer] NCHAR(10) NOT NULL
)
