CREATE PROCEDURE [dbo].[sp_ImageFiles_Insert]
	  @BugID     bigint
	, @ImgName   varchar(250)
	, @ImgDataBytes    varbinary(max)	
	, @ImgDataBase64   varchar(max)	
AS
BEGIN
	Insert into dbo.ImageFiles (BugID, ImgName, ImgDataBytes, ImgDataBase64) values (@BugID, @ImgName, @ImgDataBytes, @ImgDataBase64)

	select SCOPE_IDENTITY()

END