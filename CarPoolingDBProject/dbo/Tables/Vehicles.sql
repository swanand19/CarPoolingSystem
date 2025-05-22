CREATE TABLE [dbo].[Vehicles] (
    [VehicleId]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [VehicleNumber]  NVARCHAR (50) NOT NULL,
    [Color]          NVARCHAR (70) NULL,
    [SeatsAvailable] INT           NULL,
    [CreatedAt]      DATETIME      DEFAULT (getdate()) NULL,
    [UserId]         BIGINT        NULL,
    [Model]          NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([VehicleId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId]),
    UNIQUE NONCLUSTERED ([VehicleNumber] ASC)
);

