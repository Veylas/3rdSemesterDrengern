CREATE TABLE [dbo].[Product] (
    [productID]   UNIQUEIDENTIFIER NOT NULL,
    [title]       VARCHAR (255)    NOT NULL,
    [description] VARCHAR (255)    NOT NULL,
    [category]    VARCHAR (255)    NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([productID] ASC)
);

