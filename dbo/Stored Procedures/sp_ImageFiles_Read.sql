CREATE PROCEDURE [dbo].[sp_ImageFiles_Read]
	  @ID    bigint
	, @BugID bigint
AS BEGIN
	select * from dbo.ImageFiles
	where (
		(ID    = @ID)
	 or (BugID = @BugID)
	)
END
