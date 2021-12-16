CREATE PROCEDURE [dbo].[sp_Bugs_Delete]
	@ID bigint
AS
BEGIN
	UPDATE dbo.Bugs
	SET Active = 0
	  , LastModifiedOn = GETDATE()
	WHERE ID = @ID

	exec [dbo].[sp_ImageFiles_Delete] @ID, null

	select @ID
END