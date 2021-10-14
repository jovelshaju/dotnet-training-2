create database CustomerDB on primary
(name='CustomerDB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-7\Databases\CustomerDB.mdf')
log on
(name='CustomerDB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-7\Databases\CustomerDB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurSecondDB

create table Customers(
CId int primary key,
CName nvarchar(20) not null,
CCity nvarchar(20))

insert into Customers values (1, 'Ravi', 'Banglore')
insert into Customers (CId,CCity) values (2,'delhi')

select * from Customers

create table StudentFees
(SId int not null,
SFee int not null,
SMonth int not null,
SYear int not null,
constraint Pk_Student primary key (SId, SMonth, SYear))
insert into StudentFees values(1,3000,5,2021)
insert into StudentFees values(1,5000,6,2021)

select * from StudentFees

drop table Emp

create table Emps
(EId int primary key,
EName nvarchar(50),
ECity nvarchar(50),
EMail nvarchar(50),
constraint C_Emp unique(EName, EMail)
)

insert into Emps values(1, 'John', 'New York', 'aa@bb.com')
insert into Emps values(2, 'Levi', 'Los Santos', 'aa@bb.com')

select * from Emps

create table Users
(UserId uniqueIdentifier primary key,
UserName nvarchar(50) not null)

insert into Users values(NEWID(), 'Michael')
insert into Users values(NEWID(), 'Peter')

select * from Users

drop table Users

create table Users
(UserId uniqueIdentifier primary key default NEWID(),
UserName nvarchar(50) not null)

insert into Users (UserName) values('Michael')
insert into Users (UserName) values('Peter')
