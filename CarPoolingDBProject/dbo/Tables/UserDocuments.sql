CREATE TABLE [dbo].[UserDocuments] (
    [UserDocumentId] BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserId]         BIGINT         NULL,
    [DocumentType]   NVARCHAR (MAX) NULL,
    [DocumentNumber] NVARCHAR (MAX) NULL,
    [DocumentPath]   NVARCHAR (MAX) NULL,
    [IsVerified]     BIT            DEFAULT ((0)) NULL,
    [UploadedAt]     DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([UserDocumentId] ASC),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

