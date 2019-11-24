CREATE TABLE [dbo].[AuctionConfirmation] (
    [auctionNumber] UNIQUEIDENTIFIER NOT NULL,
    [buyer]         VARCHAR (255)    NOT NULL,
    [seller]        VARCHAR (255)    NOT NULL,
    [date_Time]     DATETIME         NOT NULL,
    [totalAmount]   FLOAT (53)       NOT NULL,
    [auctionID_FK]  UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_AuctionConfirmation] PRIMARY KEY CLUSTERED ([auctionNumber] ASC),
    CONSTRAINT [FK_AuctionConfirmation_Auction] FOREIGN KEY ([auctionID_FK]) REFERENCES [dbo].[Auction] ([auctionID])
);

