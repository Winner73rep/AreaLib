create table Products --��������
(ID bigint primary key identity,
Name varchar(255))

create table Categories --���������
(ID bigint primary key identity,
Name varchar(255))

create table ProductCutegory --����� ������ �� ������
(ID bigint primary key identity,
ProductsID bigint foreign key references Products,
CategoriesID bigint foreign key references Categories)

select p.Name as [�������], c.Name as [���������] --������
from Products p
left join ProductCutegory pc on pc.ProductsID = p.ID
left join Categories c on pc.CategoriesID = c.ID
