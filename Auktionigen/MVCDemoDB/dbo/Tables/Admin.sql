CREATE TABLE [dbo].[Admin] (
    [personID] UNIQUEIDENTIFIER NOT NULL,
    [phone]    INT              NOT NULL,
    [fName]    VARCHAR (255)    NOT NULL,
    [lName]    VARCHAR (255)    NOT NULL,
    [email]    VARCHAR (255)    NOT NULL,
    [password] VARCHAR (255)    NOT NULL,
    CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED ([personID] ASC)
);

