CREATE TABLE [dbo].[Admin] (
    [personID] INT           IDENTITY (1, 1) NOT NULL,
    [phone]    INT           NULL,
    [fName]    VARCHAR (255) NULL,
    [lName]    VARCHAR (255) NULL,
    [email]    VARCHAR (255) NULL,
    [password] VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([personID] ASC)
);

