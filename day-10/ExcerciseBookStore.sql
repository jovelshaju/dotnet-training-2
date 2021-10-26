create database OurExcercise5DB on primary
(name='OurExcercise5DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-10\Databases\OurExcercise5DB.mdf')
log on
(name='OurExcercise5DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-10\Databases\OurExcercise5DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise5DB

create table BookStoreOne
(BId int primary key identity,
BName nvarchar(20) not null,
AName nvarchar(20) not null,
BPrice float not null)

create table BookStoreTwo
(BId int primary key identity,
BName nvarchar(20) not null,
AName nvarchar(20) not null,
BPrice float not null)

-- Procedures for inserting --
create proc usp_iBkStrOne
@bname nvarchar(20),
@aname nvarchar(20),
@price float
as
begin
begin try
insert into BookStoreOne (BName,AName,BPrice)
values (@bname, @aname, @price)
end try
begin catch
print 'Error occured'
print error_message()
end catch
end

alter proc usp_iBkStrTwo
@bname nvarchar(20),
@aname nvarchar(20),
@price float
as
begin
begin try
insert into BookStoreTwo (BName,AName,BPrice)
values (@bname, @aname, @price)
end try
begin catch
print 'Error occured'
print error_message()
end catch
end

-- Procedure for common books --
create proc usp_cmnBooks
as
begin
select a.BName 'Book',a.AName 'Author' from BookStoreOne a, BookStoreTwo b where a.BName=b.BName
end

alter proc usp_mergeBooks
as
begin
select BId 'ID', BName 'Book',AName 'Author', BPrice 'Price' from BookStoreOne union all select  BId 'ID', BName 'Book',AName 'Author', BPrice 'Price' from BookStoreTwo
end



-- Prcoedure calls --

exec usp_iBkStrOne 'Alchemist', 'Paulo', 400
exec usp_iBkStrOne 'Clocks', 'Agatha', 500
exec usp_iBkStrOne 'The World', 'John', 300
exec usp_iBkStrOne 'G.o.T', 'Geroge', 800
exec usp_iBkStrOne 'Smile', 'Leela', 350
delete from BookStoreOne
select * from BookStoreOne

exec usp_iBkStrTwo 'Alchemist', 'Paulo', 400
exec usp_iBkStrTwo 'Clocks', 'Agatha', 500
exec usp_iBkStrTwo 'The World', 'John', 300
exec usp_iBkStrTwo 'For Her Eyes Onle', 'Bond', 600
exec usp_iBkStrTwo 'Dune', 'Ray', 700

select * from BookStoreTwo

exec usp_cmnBooks

exec usp_mergeBooks