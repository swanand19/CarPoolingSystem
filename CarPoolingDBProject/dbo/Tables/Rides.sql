CREATE TABLE [dbo].[Rides] (
    [RideId]              BIGINT          IDENTITY (1, 1) NOT NULL,
    [DriverId]            BIGINT          NULL,
    [VehicleId]           BIGINT          NULL,
    [StartLocation]       NVARCHAR (MAX)  NULL,
    [EndLocation]         NVARCHAR (MAX)  NULL,
    [DepartureTime]       DATETIME        NULL,
    [TotalSeats]          INT             NULL,
    [FarePerSeat]         DECIMAL (10, 2) NULL,
    [CreatedAt]           DATETIME        DEFAULT (getdate()) NULL,
    [NumberOfSeatsBooked] INT             NULL,
    PRIMARY KEY CLUSTERED ([RideId] ASC),
    FOREIGN KEY ([DriverId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    FOREIGN KEY ([VehicleId]) REFERENCES [dbo].[Vehicles] ([VehicleId])
);

