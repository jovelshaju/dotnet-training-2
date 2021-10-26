create database Day9DB on primary
(name='Day9DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-9\Databases\Day9DB.mdf')
log on
(name='Day9DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-9\Databases\Day9DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use Day9DB

create table Inventory
(PId int identity primary key,
PName nvarchar(20),
PPrice float,
PQty int)

insert into Inventory (PName,PPrice,PQty) values
('Jam', 125, 5),
('Sauce', 70, 10),
('Cake', 400, 20),
('Biscuit', 30, 30)

select max(PPrice) from Inventory

create table Category
(CId int identity primary key,
CName nvarchar(20) not null unique)

insert into Category values
('Stationary'),
('Beverage'),
('Consumables'),
('Misc')

drop table Category

create table Expenditure
(EId int identity primary key,
EAmount float,
EDate date,
ECategory nvarchar(20) references Category(CName))

insert into Expenditure values
(1200, '12/12/2020', 'Stationary'),
(800, '02/28/2017', 'Consumables'),
(1000, '08/15/2020', 'Beverage'),
(1500, '07/29/2019', 'Consumables'),
(1200, '12/12/2020', 'Stationary'),
(3000, '10/01/2021', 'Consumables'),
(1700, '01/01/2018', 'Beverage'),
(500, '04/17/2015', 'Misc')

select sum(EAmount) from Expenditure where DATEPART(year, EDate) = '2020'

select ECategory,sum(EAmount) as 'Total' from Expenditure group by ECategory order by  'Total' desc