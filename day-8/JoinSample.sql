create database JoinExamplesDB on primary
(name='JoinExamplesDB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\JoinExamplesDB.mdf')
log on
(name='JoinExamplesDB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\JoinExamplesDB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use JoinExamplesDB

create table Depts
(DId int primary key,
DName nvarchar(50) not null unique)



insert into Depts values(1,'HR')
insert into Depts values(2,'IT')
insert into Depts values(3,'App Dev')
insert into Depts values(4,'Web Dev')
insert into Depts values(5,'Testing')
insert into Depts values(6,'DevOps')



select * from Depts order by DId



create table Emps
(EiId int primary key,
EFName nvarchar(50) not null,
ELname nvarchar(50) not null,
Eemail nvarchar(100) not null,
DepId int)



insert into Emps values(101,'John','doe','jd@gmail.com',4)
insert into Emps values(222,'Jasmine','Bond','jb@gmail.com',1)
insert into Emps values(363,'Angelinea','jolie','aj@gmail.com',2)
insert into Emps values(424,'Brad','Pitt','bp@gmail.com',3)
insert into Emps (EiId,EFName,ELname,Eemail) values(111,'Liam','Nesson','ln@gmail.com')
insert into Emps (EiId,EFName,ELname,Eemail) values(555,'George','Clooney','gc@gmail.com')



select * from Emps

-- Join --
select * from Emps join Depts on Emps.DepId = Depts.DId;

select * from Emps left outer join Depts on Emps.DepId = Depts.DId;

select * from Emps right outer join Depts on Emps.DepId = Depts.DId;

select * from Emps full outer join Depts on Emps.DepId = Depts.DId;