create database Day15DB on primary
(name='Day15DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-15\Databases\Day15DB.mdf')
log on
(name='Day15DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-15\Databases\Day15DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use Day15DB

create table Customers
(CId int primary key,
CName nvarchar(20) not null,
CEmail nvarchar(20) not null,
CContact nvarchar(20) not null)

select * from Customers