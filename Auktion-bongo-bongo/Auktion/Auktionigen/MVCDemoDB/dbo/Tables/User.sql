CREATE TABLE [dbo].[User] (
    [personID] UNIQUEIDENTIFIER NOT NULL,
    [phone]    INT              NOT NULL,
    [fName]    VARCHAR (255)    NOT NULL,
    [lName]    VARCHAR (255)    NOT NULL,
    [email]    VARCHAR (255)    NOT NULL,
    [password] VARCHAR (255)    NOT NULL,
    [wallet]   FLOAT (53)       NOT NULL,
    [address]  VARCHAR (255)    NOT NULL,
    [postcode] VARCHAR (255)    NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([personID] ASC)
);

