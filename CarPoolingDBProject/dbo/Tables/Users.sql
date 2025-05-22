CREATE TABLE [dbo].[Users] (
    [UserId]       BIGINT         IDENTITY (1, 1) NOT NULL,
    [FullName]     NVARCHAR (MAX) NULL,
    [Email]        NVARCHAR (MAX) NULL,
    [PhoneNumber]  NVARCHAR (25)  NULL,
    [PasswordHash] NVARCHAR (MAX) NULL,
    [CreatedAt]    DATETIME       DEFAULT (getdate()) NULL,
    [IsDriver]     BIT            DEFAULT ((0)) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

