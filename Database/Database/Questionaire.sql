CREATE TABLE [dbo].[Questionaire]
(
	[questionId] INT NOT NULL, 
    [positionId] INT NOT NULL,
	PRIMARY KEY CLUSTERED ([questionId] ASC, [positionId] ASC),
    CONSTRAINT [FK_Question_Questionaire] FOREIGN KEY (questionId) REFERENCES [dbo].[Question] ([questionId]),
    CONSTRAINT [FK_Position_Questionaire] FOREIGN KEY (positionId) REFERENCES [dbo].[Position] ([positionId])



)
