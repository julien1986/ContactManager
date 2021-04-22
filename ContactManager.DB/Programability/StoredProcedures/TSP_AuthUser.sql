CREATE PROCEDURE [dbo].[TSP_AuthUser]
	@Email NVARCHAR(384),
	@Passwd NVARCHAR(20)
AS
	SELECT [Id], [LastName], [Firstname], [Email], [Genre] FROM [Utilisateurs] WHERE @Email = Email AND Passwd = HASHBYTES('SHA2_512', [dbo].[TSF_GetPreSalt]() + @Passwd + [dbo].[TSF_GetPostSalt]()) AND IsValid = 1
RETURN 0
