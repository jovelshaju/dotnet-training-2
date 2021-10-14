use OurExcercise3DB


create table CompanyInfo
(CId int identity primary key,
CName nvarchar(20) unique)

drop table CompanyInfo

select * from CompanyInfo;

insert into CompanyInfo (CName) values ('SamSung')
insert into CompanyInfo (CName) values ('HP')
insert into CompanyInfo (CName) values ('Apple')
insert into CompanyInfo (CName) values ('Dell')
insert into CompanyInfo (CName) values ('Toshiba')
insert into CompanyInfo (CName) values ('Redmi')

create table ProductInfo
(PId int identity(101,1) primary key,
PName nvarchar(20) not null,
PPrice float not null,
PMDate date not null,
CId int not null)

insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Laptop', 32000, GETDATE(), 1)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Laptop', 52000, GETDATE(), 2)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Mobile', 18000, GETDATE(), 2)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Laptop', 44000, GETDATE(), 3)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Mobile', 10000, GETDATE(), 3)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Laptop', 70000, GETDATE(), 5)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Mobile', 30000, GETDATE(), 5)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Earpod', 5000, GETDATE(), 3)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Laptop', 90000, GETDATE(), 6)
insert into ProductInfo (PName,PPrice,PMDate,CId) values ('Modile', 24000, GETDATE(), 1)

select c.CName,p.PId,p.PName,p.PPrice,p.PMDate from CompanyInfo c left join ProductInfo p on c.CId = p.CId

select p.PId,p.PName,c.CName from CompanyInfo c right join ProductInfo p on c.CId = p.CId

select * from CompanyInfo cross join ProductInfo


select * from 