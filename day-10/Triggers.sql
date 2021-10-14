use Day10DB

alter table Customers
(Cid int primary key,
CName nvarchar(20),
CCity nvarchar(20) default 'Delhi',
CODLimit float)

alter table Customers_LogIn_Info
(LogID int identity primary key,
CId int,
CName nvarchar(20),
CCity nvarchar(20),
CODLimit float,
LogAction nvarchar(50),
LogTime datetime)

--insert trigger --
alter trigger tri_iCustomer
on Customers
with encryption
after insert
as
begin
declare @id int
declare @name nvarchar(20)
declare @city nvarchar(20)
declare @odLimit float
select @id = Cid from inserted
select @name = CName from inserted
select @city = CCity from inserted
select @odLimit = CODLimit from inserted
insert into Customers_LogIn_Info (CId,CName,CCity,CODLimit,LogAction,LogTime)
values (@id,@name,@city,@odLimit,'Record Insertion',GETDATE())
if(@@ROWCOUNT>=1)
begin
print 'Inserted into Log Info Table as well'
end
else
begin
print 'Not inserted into Log Info Table'
end
end

--update trigger--
alter trigger tri_uCustomer
on Customers
with encryption
after update
as
begin
declare @id int
declare @name nvarchar(20)
declare @city nvarchar(20)
declare @odLimit float
select @id = Cid from inserted
select @name = CName from inserted
select @city = CCity from inserted
select @odLimit = CODLimit from inserted
insert into Customers_LogIn_Info (CId,CName,CCity,CODLimit,LogAction,LogTime)
values (@id,@name,@city,@odLimit,'Record Updation',GETDATE())
if(@@ROWCOUNT>=1)
begin
print 'Update recorded in Log Info Table'
end
else
begin
print 'Update not recorded Log Info Table'
end
end

-- delete trigger--
create trigger tri_dCustomer
on Customers
after delete
as
begin
declare @id int
declare @name nvarchar(20)
declare @city nvarchar(20)
declare @odLimit float
select @id = Cid from deleted
select @name = CName from deleted
select @city = CCity from deleted
select @odLimit = CODLimit from deleted
insert into Customers_LogIn_Info (CId,CName,CCity,CODLimit,LogAction,LogTime)
values (@id,@name,@city,@odLimit,'Record deletion',GETDATE())
if(@@ROWCOUNT>=1)
begin
print 'Delete recorded in Log Info Table'
end
else
begin
print 'Delete not recorded Log Info Table'
end
end

-- pre-delete trigger --
create trigger tri_bfrDltCustomer
on Customers
instead of delete
as
declare @id int
declare @name nvarchar(20)
declare @city nvarchar(20)
declare @odLimit float
select @id = Cid from deleted
select @name = CName from deleted
select @city = CCity from deleted
select @odLimit = CODLimit from deleted
begin
if(@odLimit>=40000)
begin
raiserror('Deletion requires Manager Aprroval for ODLimit>=40000',16,1)
rollback
end
else
begin
delete from Customers where Cid = @id
insert into Customers_LogIn_Info (CId,CName,CCity,CODLimit,LogAction,LogTime)
values (@id,@name,@city,@odLimit,'Record deletion',GETDATE())
end
end


insert into Customers values (101,'John','Mumbai',20000)
insert into Customers values (201,'Mariya','Delhi',30000)
insert into Customers values (301,'Peter','Banglore',45000)
insert into Customers values (401,'Lavia','Hyderabad',25000)
insert into Customers values (501,'Sean','Goa',40000)
insert into Customers values (601,'Ram','Noida',35000)

delete from Customers where Cid=201
select * from Customers_LogIn_Info

-- pre-delete triggered
delete from Customers where Cid=301

select * from Customers

