create database OurExcercise3DB on primary
(name='OurExcercise3DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\OurExcercise3DB.mdf')
log on
(name='OurExcercise3DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\OurExcercise3DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise3DB

create table Products
(PId int identity(1000,1) primary key,
PName nvarchar(20) not null,
PPrice float not null,
PTax as PPrice * 0.18 persisted, 
PCompany nvarchar(20) check(PCompany in ('SamSung','Apple','Redmi','HTC')),
PQty int default 1 check (PQty>=1))

insert into Products (PName,PPrice,PCompany,PQty) values ('Smartwatch',12000,'SamSung',12)
insert into Products (PName,PPrice,PCompany,PQty) values ('Smart TV',25000,'Redmi',15)
insert into Products (PName,PPrice,PCompany,PQty) values ('Phone',112000,'Apple',25)
insert into Products (PName,PPrice,PCompany,PQty) values ('Speaker',5000,'HTC',10)
insert into Products (PName,PPrice,PCompany,PQty) values ('Laptop',50000,'SamSung',18)

select PId, PName, PPrice+PTax as 'Price(Inc. Tax)', PCompany, PQty*(PPrice+PTax) as 'Total Price' from Products