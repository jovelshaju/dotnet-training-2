create database OurExcerciseDB

use OurExcerciseDB

create table Products
(PId int identity(50,1) primary key,
PName nvarchar(20) not null,
PPrice int,
PCompany nvarchar(20),
PQty int default 1,
check(PPrice>=50 and PPrice<=100000),
check(PQty>=1),
check(PCompany in ('SamSung','Apple','Redmi','HTC')))

insert into Products (PName,PPrice,PCompany,PQty) values('Pad',20000,'Apple',2)
insert into Products (PName,PPrice,PCompany) values('Laptop',20000,'Redmi')
insert into Products (PName,PPrice,PCompany,PQty) values('Pad',20000,'Apple',2)
insert into Products (PName,PPrice,PCompany,PQty) values('Phone',62000,'HTC',2)

select * from Products

create table SReg
(SId int primary key,
SName nvarchar(20) not null,
SContact int,
SAge int)

create table SFee
(SId int foreign key references SReg,
FAmount float not null,
FMonth int,
Fyear int,
constraint Pk_SFee primary key(SId, FMonth, FYear))

insert into SReg
values(101,'Ram',736152,27)
insert into SReg
values(205,'Arathi',99472,24)

insert into SFee
values(101,12000.50,5,2019)

select r.SId,r.SName,f.FAmount,f.FMonth,f.Fyear from SFee f, SReg r where f.SId=r.SId