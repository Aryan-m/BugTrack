CREATE PROCEDURE [dbo].[sp_ImageFiles_Delete]
	  @BugID bigint	
	, @ID bigint
AS BEGIN
	Delete from dbo.ImageFiles
	where (
		   (BugID = @BugID)
		or (ID    = @ID)
	)
END