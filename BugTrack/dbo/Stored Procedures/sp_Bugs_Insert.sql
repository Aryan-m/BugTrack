CREATE PROCEDURE [dbo].[sp_Bugs_Insert]
	  @title nvarchar(100)
	, @description nvarchar(max)
AS
BEGIN
	INSERT INTO dbo.Bugs (Title, Description, CreatedByUserID)
	VALUES (@title, @description, 999)

	select SCOPE_IDENTITY()
END
