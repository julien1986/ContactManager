CREATE PROCEDURE [dbo].[TSP_MakeAdmin]
	@Id int
AS
BEGIN
	UPDATE Utilisateurs SET [IsAdmin] = 1 WHERE @Id = Id AND [IsAdmin] = 0
RETURN 0
END
