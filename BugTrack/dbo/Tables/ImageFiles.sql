CREATE TABLE [dbo].[ImageFiles]
(
	  [ID] bigint NOT NULL PRIMARY KEY IDENTITY
	, [BugID] bigint FOREIGN KEY REFERENCES Bugs(ID) NOT NULL
	, [ImgName] varchar(250)
	, [ImgDataBytes] varbinary(max)
	, [ImgDataBase64] varchar(max)
)
