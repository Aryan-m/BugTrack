CREATE TABLE [dbo].[Bugs]
(
	  [ID] bigint NOT NULL PRIMARY KEY IDENTITY
    , [Title] nvarchar(100) not null
	, [Description] nvarchar(max) 
    , [Active] bit not null default 1
	, [CreatedOn] datetime not null default getdate()
	, [CreatedByUserID] NVARCHAR(450) not null
	, [LastModifiedOn] datetime
	, [LastModifiedBy] NVARCHAR(450) 
)
