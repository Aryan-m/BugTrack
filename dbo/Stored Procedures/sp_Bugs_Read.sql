CREATE PROCEDURE [dbo].[sp_Bugs_View]
	@ID bigint
AS
BEGIN
	SELECT 
		*
	FROM dbo.Bugs as bugs
	WHERE ((@ID is null) or (bugs.ID = @ID));	
END
