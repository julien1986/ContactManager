CREATE PROCEDURE [dbo].[TSP_MakeActive]
	@Id INT
AS
BEGIN
	UPDATE Utilisateurs SET [IsValid] = 1 WHERE Id = @Id
RETURN 0
END