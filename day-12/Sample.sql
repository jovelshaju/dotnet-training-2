create database Day12DB on primary
(name='Day12DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-12\Databases\Day12DB.mdf')
log on
(name='Day12DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-12\Databases\Day12DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use day12DB
drop table Products

create table Products
(PId int primary key,
PName nvarchar(20) not null,
PPrice float not null,
MfgDate date not null,
ExpDate date not null)

select * from Products