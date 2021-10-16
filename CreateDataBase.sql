create database ProductsByCategoriesByAntonGavrilochev
go

use ProductsByCategoriesByAntonGavrilochev
go
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categories]') AND type in (N'U'))
DROP TABLE [dbo].[Categories]
create Table [Categories](
	[ID] int not null identity(1,1),	
	[Name] NVarChar (100) not null,
	CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED (ID ASC),
);
go
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Products]') AND type in (N'U'))
DROP TABLE [dbo].[Products]
create Table [Products](
	[ID] int not null identity(1,1),
	[Name] NVarChar (100) not null,
	[idCategories] int references [Categories]([ID]),
	CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED (ID ASC),
);