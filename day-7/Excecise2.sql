create database OurExcercise2DB on primary
(name='OurExcercise2DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-7\Databases\OurExcercise2DB.mdf', size = 8MB)
log on
(name='OurExcercise2DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-7\Databases\OurExcercise2DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise2DB

create table Category
(CId int primary key,
CategoryName nvarchar(20) unique not null)

create table Products
(PId int identity primary key,
PName nvarchar(20) not null,
PPrice int not null,
PCid int foreign key references Category(CId))

insert into Category values (101, 'Electronics')
insert into Category values (111, 'Kitchenware')
insert into Category values (121, 'Home Appliances')

insert into Products (PName,PPrice,PCid) values ('Headphone', 700, 101)
insert into Products (PName,PPrice,PCid) values ('Laptop', 70000, 101)
insert into Products (PName,PPrice,PCid) values ('Lunch Box', 100, 111)
insert into Products (PName,PPrice,PCid) values ('Fridge', 20000, 121)
insert into Products (PName,PPrice,PCid) values ('Washing Machine', 15000, 121)

select p.PId,p.PName, p.PPrice, c.CId, c.CategoryName from Products p, Category c where p.PCid = c.CId

