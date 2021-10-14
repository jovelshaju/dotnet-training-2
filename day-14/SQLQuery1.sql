create database Day14DB on primary
(name='Day14DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-14\Databases\Day14DB.mdf')
log on
(name='Day14DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-14\Databases\Day14DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use Day14DB

create table Depts
(DId int primary key,
DName nvarchar(20) not null)

create table Emp
(EId int primary key,
EFName nvarchar(20) not null,
ELName nvarchar(20) not null,
EDesig nvarchar(20) not null,
DeptID int foreign key references Depts(DId))

insert into Depts values
(101,'Sales'),
(102,'DevOPs')

insert into Emp values
(1,'John','Doe','Manager',101),
(2,'Martha','Lewis','Developer',102)