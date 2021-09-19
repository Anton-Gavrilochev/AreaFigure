use ProductsByCategoriesByAntonGavrilochev
go
SELECT        Products.name_Product as 'Продукт', Categories.name_Categories as 'Категория'
FROM          Products Left JOIN
               Categories ON Categories.id_Categories = Products.id_Categories