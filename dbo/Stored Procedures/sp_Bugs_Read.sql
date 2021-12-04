CREATE PROCEDURE [dbo].[sp_Bugs_View]
	@id bigint
AS
BEGIN
	SELECT 
		*
	FROM dbo.Bugs as bugs
	WHERE ((@id is null) or (@id = bugs.id));	
END
