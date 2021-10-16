use ProductsByCategoriesByAntonGavrilochev
go
select  [Categories].[Name] as 'Категория', [Products].[Name] as 'Продукт'
from    [Products] Left join
            [Categories] on [Categories].[ID] = [Products].[idCategories]