CREATE PROCEDURE [dbo].[sp_Bugs_Delete]
	@id int
AS
BEGIN
	UPDATE dbo.Bugs
	SET Active = 0
	  , LastModifiedOn = GETDATE()
	WHERE ID = @id
END