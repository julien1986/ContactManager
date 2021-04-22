CREATE TABLE [dbo].[Contacts]
(
	[Id] INT IDENTITY NOT NULL,
	[UserId] INT NOT NULL,
	[LastName] NVARCHAR(50) NOT NULL,
	[Firstname] NVARCHAR(50) NOT NULL,
	[Phone] NVARCHAR(25) NOT NULL,
	[Email] NVARCHAR(384) NOT NULL,
	[Description] NVARCHAR(500)

    CONSTRAINT [PK_Contacts] PRIMARY KEY ([Id]),
	CONSTRAINT [FK_Contact_Utilisateurs] FOREIGN KEY ([UserId]) REFERENCES [Utilisateurs] ([Id])
)

GO

CREATE INDEX [IX_Contacts_UserId] ON [dbo].[Contacts] ([UserId])
