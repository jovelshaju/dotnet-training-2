
create table Employees
(EId int primary key,
EFName nvarchar(20) not null,
ELName nvarchar(20) not null,
EMailId nvarchar(20),
EContact nvarchar(20),
SSTime time not null,
SETime time not null,
MngrID int)

insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime) values (101,'John','doe','jd@gmail.com','461688','09:00:00','16:00:00')
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime,MngrID) values (222,'Jasmine','Bond','jb@gmail.com','65234752','10:00:00','18:00:00',101)
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime) values (363,'Angelinea','jolie','aj@gmail.com','898754','10:00:00','16:00:00')	
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime) values (424,'Brad','Pitt','bp@gmail.com','123422','09:00:00','16:00:00')
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime,MngrID) values (111,'Liam','Nesson','ln@gmail.com','42345676','10:00:00','18:00:00',363)
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime,MngrID) values (555,'George','Clooney','gc@gmail.com','657637','21:00:00','04:00:00',424)
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime,MngrID) values (633,'Brie','Larson','bl@gmail.com','123653','10:00:00','18:00:00',101)
insert into Employees (EId,EFName,ELName,EMailId,EContact,SSTime,SETime,MngrID) values (782,'Tom','Holland','th@gmail.com','687234','09:30:00','17:30:00',424)

select * from Employees
select * from Employees order by SSTime
select a.EFName+' '+ a.ELName as 'Employee', b.EFName+' '+ b.ELName as 'Manager' from Employees a, Employees b where a.MngrID = b.EId 