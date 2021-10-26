create database Day18DB on primary
(name='Day18DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-18\Databases\Day18DB.mdf')
log on
(name='Day18DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-18\Databases\Day18DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use Day18DB

create table UsersInfo
(usrName nvarchar(50) primary key,
usrPswd nvarchar(50) not null,
usrRole nvarchar(20) not null)

insert into UsersInfo values
('john','john@123','admin'),
('levi','levi#2001','customer'),
('riya','riya@321','customer'),
('agnes','agnes$444','admin')