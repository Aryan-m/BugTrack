CREATE PROCEDURE [dbo].[sp_Bugs_Update]
	  @userID      nvarchar(450)
	, @ID          bigint
	, @title       nvarchar(100)
	, @description nvarchar(max)
AS
BEGIN
	UPDATE dbo.Bugs
	SET [Title] = @title
	  , [Description] = @description
	  , LastModifiedOn = getdate()
	  , LastModifiedBy = @userID
	WHERE ID = @ID

	return @ID
END
