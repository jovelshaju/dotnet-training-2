create database OurExcercise8DB on primary
(name='OurExcercise8DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-13\Databases\OurExcercise8DB.mdf')
log on
(name='OurExcercise8DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-13\Databases\OurExcercise8DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise8DB

create table Emp
(EId int primary key,
EName nvarchar(20) not null,
EDesig nvarchar(20) not null,
ESalary float not null)

insert into Emp values
(101, 'John', 'HR', 25000),
(102, 'Lea', 'Manager', 45000),
(103, 'Anna', 'Sales', 50000),
(104, 'Joe', 'Developer', 25000),
(105, 'Zeke', 'Tester', 35000),
(106, 'Ben', 'HR', 55000),
(107, 'Henry', 'Developer', 43000),
(108, 'Kelly', 'Sales', 20000),
(109, 'Mia', 'Tester', 25000),
(110, 'Gon', 'HR', 60000)

create table Student
(SId int primary key,
SName nvarchar(20) not null,
SFee float not null,
SDoB date)

delete from Student
insert into Student values
(1,'Michael',1500,'02/02/2003'),
(2,'Gabriel',1500,'03/03/2002'),
(3,'Kayne',1200,'05/22/2003'),
(4,'Azrael',1000,'12/21/2001'),
(5,'Abel',1400,'09/17/2002')