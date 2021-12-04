CREATE PROCEDURE [dbo].[sp_Bugs_Insert]
	  @title nvarchar(100)
	, @description nvarchar(max)
AS
BEGIN
	INSERT INTO dbo.Bugs (Title, Description)
	VALUES (@title, @description)
END
