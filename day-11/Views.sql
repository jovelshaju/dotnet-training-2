use Day11DB
create schema et

create table et.Emps
(EId int primary key identity,
EName nvarchar(20) not null,
EMail nvarchar(20) not null,
ECity nvarchar(20) default 'Kochi')

insert into et.Emps values
('Leo','ll@gg.com','Mumbai'),
('Sam','ss@gg.com','Bangalore'),
('Sean','se@gg.com','Bangkok'),
('Yakuza','yz@gg.com','Tokyo')

create view et.vw_Emps
with schemabinding
as
select EName, EMail from et.Emps

drop view et.vw_Emps
select * from et.vw_Emps
select * from et.Emps

update et.vw_Emps set EMail='lm@gmail.com' where EName='Leo'

insert into et.vw_Emps values('Mariya','mm@gmail.com')

alter table et.Emps drop column EName
