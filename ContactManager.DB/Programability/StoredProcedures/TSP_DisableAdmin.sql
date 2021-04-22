CREATE PROCEDURE [dbo].[TSP_DisableAdmin]
	@Id int
AS
BEGIN
	UPDATE Utilisateurs SET [IsAdmin] = 0 WHERE @Id = Id AND [IsAdmin] = 1
RETURN 0
END
