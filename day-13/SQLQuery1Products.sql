create database Day13DB on primary
(name='Day13DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-13\Databases\Day13DB.mdf')
log on
(name='Day13DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-13\Databases\Day13DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use Day13DB

create table Products
(PId int primary key,
PName nvarchar(20) not null unique,
PPrice float not null,
MfgDate date not null,
ExpDate date not null)

create proc usp_iProducts
@id int,
@name nvarchar(20),
@price float,
@mfgdate date,
@expdate date
as
insert into Products
values(@id,@name,@price,@mfgdate,@expdate)

create proc usp_uProducts
@id int,
@name nvarchar(20),
@price float,
@mfgdate date,
@expdate date
as
update Products set PName=@name,PPrice=@price,MfgDate=@mfgdate,ExpDate=@expdate where PId=@id

create proc usp_sByIdProducts
@id int
as
select * from Products where PId=@id

create proc usp_dProducts
@id int
as
delete from Products where PId=@id

select * from Products