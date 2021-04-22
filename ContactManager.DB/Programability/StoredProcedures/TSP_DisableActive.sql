CREATE PROCEDURE [dbo].[TSP_DisableActive]
	@Id INT
AS
BEGIN
	UPDATE Utilisateurs SET [IsValid] = 0 WHERE Id = @Id
RETURN 0
END