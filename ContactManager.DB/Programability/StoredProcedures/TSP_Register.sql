CREATE PROCEDURE [dbo].[TSP_Register]
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50),
	@Email NVARCHAR(384),
	@Passwd NVARCHAR(20),
	@Genre CHAR(1)
AS
BEGIN
	DECLARE @IsAdmin BIT = 0;
	IF(NOT EXISTS(SELECT TOP 1 * FROM Utilisateurs))
		BEGIN
		SET @IsAdmin = 1
		END
	INSERT INTO [Utilisateurs] ([Lastname], [FirstName], [Email], [Passwd],[IsAdmin], [Genre]) VALUES (@LastName, @FirstName, @Email, HASHBYTES('SHA2_512', [dbo].[TSF_GetPreSalt]() + @Passwd + [dbo].[TSF_GetPostSalt]()), @IsAdmin, @Genre)
END
RETURN 0
