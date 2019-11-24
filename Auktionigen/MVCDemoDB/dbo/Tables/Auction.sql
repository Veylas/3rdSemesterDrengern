CREATE TABLE [dbo].[Auction] (
    [auctionID]     UNIQUEIDENTIFIER NOT NULL,
    [endDate]       DATETIME         NULL,
    [time]          TIME (7)         NOT NULL,
    [state]         BIT              NULL,
    [currentPrice]  FLOAT (53)       NOT NULL,
    [maxPrice]      FLOAT (53)       NOT NULL,
    [bid]           FLOAT (53)       NULL,
    [currentWinner] VARCHAR (255)    NULL,
    [personID_FK]   UNIQUEIDENTIFIER NULL,
    [productID_FK]  UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_Auction] PRIMARY KEY CLUSTERED ([auctionID] ASC),
    CONSTRAINT [FK_Auction_Admin] FOREIGN KEY ([personID_FK]) REFERENCES [dbo].[Admin] ([personID]),
    CONSTRAINT [FK_Auction_Product] FOREIGN KEY ([productID_FK]) REFERENCES [dbo].[Product] ([productID]),
    CONSTRAINT [FK_Auction_User] FOREIGN KEY ([personID_FK]) REFERENCES [dbo].[User] ([personID])
);

