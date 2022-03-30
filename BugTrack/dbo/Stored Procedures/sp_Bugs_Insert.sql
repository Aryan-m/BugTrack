CREATE PROCEDURE [dbo].[sp_Bugs_Insert]
	  @userID      nvarchar(450)
	, @title       nvarchar(100)
	, @description nvarchar(max)
AS
BEGIN
	INSERT INTO dbo.Bugs (Title, Description, CreatedByUserID)
	VALUES (@title, @description, @userID)

	select SCOPE_IDENTITY()
END
