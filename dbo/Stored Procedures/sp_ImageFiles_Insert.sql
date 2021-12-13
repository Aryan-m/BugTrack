CREATE PROCEDURE [dbo].[sp_ImageFiles_Insert]
	  @BugID     bigint
	, @ImgData varbinary(max)	
AS
BEGIN
	Insert into dbo.ImageFiles (BugID, ImgData) values (@BugID, @ImgData)
END