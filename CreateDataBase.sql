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


--���������� �������� ������
USE ProductsByCategoriesByAntonGavrilochev
GO
INSERT INTO dbo.Categories
           (name_Categories)
     VALUES
           (N'������'),
		   (N'������'),
		   (N'�������'),
		   (N'���������')
GO

USE ProductsByCategoriesByAntonGavrilochev
GO
INSERT INTO dbo.Products
           (name_Product
           ,id_Categories)
     VALUES
           (N'� ������',1),
           (N'������',4),
           (N'� �����',2),
           (N'� ���������',3),
           (N'� ������� � �����',2),
		   (N'� ��������',1),
           (N'� ���������',1),
           (N'� �����',1),
           (N'���������',4)
GO

USE ProductsByCategoriesByAntonGavrilochev
GO
INSERT INTO [dbo].[Products]
           ([name_Product])
	VALUES
		   (N'��������')
GO