CREATE TABLE [dbo].[User] (
    [personID] INT           NOT NULL,
    [phone]    INT           NULL,
    [fName]    VARCHAR (255) NULL,
    [lName]    VARCHAR (255) NULL,
    [email]    VARCHAR (255) NULL,
    [password] VARCHAR (255) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([personID] ASC)
);

