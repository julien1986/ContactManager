CREATE PROCEDURE [dbo].[TSP_AddContact]
	@UserId INT ,
	@LastName NVARCHAR(50),
	@FirstName NVARCHAR(50),
	@Phone NVARCHAR(25),
	@Email NVARCHAR(384),
	@Description NVARCHAR(500)

AS
BEGIN
	INSERT INTO Contacts (UserId, LastName, Firstname, Phone, Email, Description) VALUES (@UserId, @LastName, @FirstName, @Phone, @Email, @Description)
RETURN 0
END
