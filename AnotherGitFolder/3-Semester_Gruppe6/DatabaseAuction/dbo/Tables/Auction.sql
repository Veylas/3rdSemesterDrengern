CREATE TABLE [dbo].[Auction] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [endDate]       DATETIME      NULL,
    [time]          DATETIME      NULL,
    [status]        BIT           NULL,
    [currentPrice]  DECIMAL (18)  NULL,
    [maxPrice]      DECIMAL (18)  NULL,
    [bid]           DECIMAL (18)  NULL,
    [title]         VARCHAR (255) NULL,
    [description]   VARCHAR (255) NULL,
    [category]      VARCHAR (255) NULL,
    [currentWinner] INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

