create database CricDB on primary
(name='CricDB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-16\Databases\CricDB.mdf')
log on
(name='CricDB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-16\Databases\CricDB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use CricDB
drop table Teams
create table Teams
(TeamID varchar(3) primary key check (TeamID Like 'T[0-9][0-9]'),
TeamName nvarchar(50) not null unique,
TeamLogo nvarchar(200))

drop table Player
create table Player
(PId int primary key,
PName nvarchar(20) not null unique,
PTId varchar(3) foreign key references Teams(TeamID),
PDoB datetime,
PPic nvarchar(200))

select * from Teams