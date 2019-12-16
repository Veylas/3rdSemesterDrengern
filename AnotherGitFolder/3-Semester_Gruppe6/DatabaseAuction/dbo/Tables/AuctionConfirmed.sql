CREATE TABLE [dbo].[AuctionConfirmed] (
    [auctionNumber] INT          IDENTITY (1, 1) NOT NULL,
    [date_time]     DATETIME     NULL,
    [totalAmount]   DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([auctionNumber] ASC)
);

