CREATE TABLE [dbo].[RideBookings] (
    [RideBookingId] BIGINT        IDENTITY (1, 1) NOT NULL,
    [RideId]        BIGINT        NULL,
    [PassengerId]   BIGINT        NULL,
    [SeatsBooked]   INT           NULL,
    [BookingStatus] NVARCHAR (50) NULL,
    [CreatedAt]     DATETIME      DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([RideBookingId] ASC),
    FOREIGN KEY ([PassengerId]) REFERENCES [dbo].[AspNetUsers] ([Id]),
    FOREIGN KEY ([RideId]) REFERENCES [dbo].[Rides] ([RideId])
);

