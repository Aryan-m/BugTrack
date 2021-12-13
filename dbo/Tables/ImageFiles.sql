CREATE TABLE [dbo].[ImageFiles]
(
	  [ID] bigint NOT NULL PRIMARY KEY IDENTITY
	, [BugID] bigint FOREIGN KEY REFERENCES Bugs(ID) NOT NULL
	, [ImgData] varbinary(max)
)
