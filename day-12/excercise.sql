create database OurExcercise7DB on primary
(name='OurExcercise7DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-12\Databases\OurExcercise7DB.mdf')
log on
(name='OurExcercise7DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-12\Databases\OurExcercise7DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise7DB

drop table Products
create table Products
(id int identity,
PId as 'P' + RIGHT('00000'+ CONVERT(VARCHAR,id),5) persisted primary key,
PName nvarchar(20) not null,
PPrice float not null,
MfgDate date not null,
ExpDate date not null)

insert into Products values ('Torchd',1000,'09/24/2021','10/10/2030')
insert into Products values ('Jello',150,'11/30/2021','01/17/2022')
insert into Products values ('M&M',200,'04/17/2020','10/17/2020')
insert into Products values ('Sunlight',300,'05/05/2021','05/05/2021')
insert into Products values ('Tobelorone',100,'08/10/2021','11/10/2021')
insert into Products values ('Lays',50,'03/09/2021','04/14/2021')
insert into Products values ('Pepsi',100,'07/19/2021','11/23/2021')
insert into Products values ('Viva La',120,'12/25/2021','12/25/2022')
insert into Products values ('Aviation',1500,'06/30/2021','06/30/2026')
insert into Products values ('Bris',750,'03/07/2021','04/09/2021')

select * from Products

-- 2nd Excercise(ShowBiz) --

create table Movies
(MovieId int primary key,
MovieName nvarchar(20) not null unique,
StarCast nvarchar(20),
Procucer nvarchar(20))

delete from Movies
select * from movies