CREATE TABLE [dbo].[RideRoutes] (
    [RideRouteId]   BIGINT         IDENTITY (1, 1) NOT NULL,
    [RideId]        BIGINT         NULL,
    [Location]      NVARCHAR (MAX) NULL,
    [SequenceOrder] INT            NULL,
    PRIMARY KEY CLUSTERED ([RideRouteId] ASC),
    FOREIGN KEY ([RideId]) REFERENCES [dbo].[Rides] ([RideId])
);

