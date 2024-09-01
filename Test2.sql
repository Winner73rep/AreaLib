create table Products --Продукты
(ID bigint primary key identity,
Name varchar(255))

create table Categories --Категории
(ID bigint primary key identity,
Name varchar(255))

create table ProductCutegory --Связь многие ко многим
(ID bigint primary key identity,
ProductsID bigint foreign key references Products,
CategoriesID bigint foreign key references Categories)

select p.Name as [Продукт], c.Name as [Категория] --Запрос
from Products p
left join ProductCutegory pc on pc.ProductsID = p.ID
left join Categories c on pc.CategoriesID = c.ID
