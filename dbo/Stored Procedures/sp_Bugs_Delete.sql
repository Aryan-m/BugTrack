CREATE PROCEDURE [dbo].[sp_Bugs_Delete]
	@ID int
AS
BEGIN
	UPDATE dbo.Bugs
	SET Active = 0
	  , LastModifiedOn = GETDATE()
	WHERE ID = @ID
END