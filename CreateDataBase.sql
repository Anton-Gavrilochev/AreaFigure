create database ProductsByCategoriesByAntonGavrilochev
go

use ProductsByCategoriesByAntonGavrilochev
go
create Table Categories
(
	id_Categories int not null identity(1,1) primary key,	
	name_Categories NVarChar (100) not null,
)

go
create Table Products
(
	id_Products int not null identity(1,1) primary key,
	name_Product NVarChar (100) not null,
	id_Categories int references Categories(id_Categories),
)


--Добавление тестовых данных
USE ProductsByCategoriesByAntonGavrilochev
GO
INSERT INTO dbo.Categories
           (name_Categories)
     VALUES
           (N'Пироги'),
		   (N'Слойка'),
		   (N'Печенье'),
		   (N'Гамбургер')
GO

USE ProductsByCategoriesByAntonGavrilochev
GO
INSERT INTO dbo.Products
           (name_Product
           ,id_Categories)
     VALUES
           (N'с вишней',1),
           (N'бигмак',4),
           (N'с сыром',2),
           (N'с шоколадом',3),
           (N'с веченой и сыром',2),
		   (N'с капустой',1),
           (N'с картошкой',1),
           (N'с мясом',1),
           (N'чизбургер',4)
GO

USE ProductsByCategoriesByAntonGavrilochev
GO
INSERT INTO [dbo].[Products]
           ([name_Product])
	VALUES
		   (N'Ватрушка')
GO