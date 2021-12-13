CREATE PROCEDURE [dbo].[sp_Bugs_Update]
	  @ID          bigint
	, @title       nvarchar(100)
	, @description nvarchar(max)
AS
BEGIN
	UPDATE dbo.Bugs
	SET [Title] = @title
	  , [Description] = @description
	WHERE ID = @ID
END
