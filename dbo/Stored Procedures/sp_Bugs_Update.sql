CREATE PROCEDURE [dbo].[sp_Bugs_Update]
	  @id bigint
	, @title nvarchar(100)
	, @description nvarchar(max)
AS
BEGIN
	UPDATE dbo.Bugs
	SET [Title] = @title
	  , [Description] = @description
	WHERE ID = @id
END
