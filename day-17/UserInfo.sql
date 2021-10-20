create database SecureDB on primary
(name='SecureDB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-17\Databases\SecureDB.mdf')
log on
(name='SecureDB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-17\Databases\SecureDB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use SecureDB

create table UsersInfo
(usrName nvarchar(50) primary key,
usrPswd nvarchar(50) not null,
usrRole nvarchar(20))

drop table UsersInfo

insert into UsersInfo values
('johnhonai','pettitharu','admin'),
('madhavan','kakkum','emp'),
('chandhu','chathikkum','user')