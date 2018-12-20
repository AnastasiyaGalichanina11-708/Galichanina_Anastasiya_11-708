CREATE TABLE [dbo].[Emotion]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Contempt] INT NOT NULL, 
    [Disgust] INT NOT NULL, 
    [Anger] INT NOT NULL, 
    [Fear] INT NOT NULL, 
    [Happiness] INT NOT NULL, 
    [Neutral] INT NOT NULL, 
    [Sadness] INT NOT NULL, 
    [Surprise] INT NOT NULL, 
    [PhotoId] INT NOT NULL, 
    [DateTimeCreate] DATETIME NOT NULL, 
    [PhotoId_1] INT NOT NULL, 


)
