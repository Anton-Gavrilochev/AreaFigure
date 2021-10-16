--Добавление тестовых данных
use ProductsByCategoriesByAntonGavrilochev
go
insert into [dbo].[Categories] ([Name]) values (N'Пироги')
insert into [dbo].[Categories] ([Name]) values (N'Слойка')
insert into [dbo].[Categories] ([Name]) values (N'Печенье')
insert into [dbo].[Categories] ([Name]) values (N'Гамбургер')
go
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с вишней',1)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'Бигмак',4)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с сыром',2)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с шоколадом',3)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с веченой и сыром',2)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с капустой',1)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с картошкой',1)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'с мясом',1)
insert into [dbo].[Products] ([Name],[idCategories]) values (N'Чизбургер',4)
insert into [dbo].[Products] ([Name]) values (N'Ватрушка')
go