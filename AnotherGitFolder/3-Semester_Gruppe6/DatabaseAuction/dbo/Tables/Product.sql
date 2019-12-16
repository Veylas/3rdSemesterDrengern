CREATE TABLE [dbo].[Product] (
    [productID]   INT           NOT NULL,
    [title]       VARCHAR (255) NULL,
    [description] VARCHAR (255) NULL,
    [catagory]    VARCHAR (255) NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([productID] ASC)
);

