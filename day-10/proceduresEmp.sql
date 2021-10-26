create database Day10DB on primary
(name='Day10DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-10\Databases\Day10DB.mdf')
log on
(name='Day10DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-10\Databases\Day10DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

create table Emps
(EId int primary key,
EName nvarchar(20) not null,
EDesignation nvarchar(20) not null,
ESalary float,
EDOJ date)

alter proc usp_iEmps
@id int,
@name nvarchar(20),
@desg nvarchar(20),
@sal float,
@doj date
with encryption
as
begin
set nocount on
insert into Emps (EId,EName,EDesignation,ESalary,EDOJ)
values (@id,@name,@desg,@sal,@doj);
print 'Insertion successful: No. of rows affected - '+convert(nvarchar(20), @@rowcount)
end

alter proc usp_uEmps
@id int,
@name nvarchar(20),
@desg nvarchar(20),
@sal float,
@doj date
as
begin
begin try
update Emps set EName = @name, EDesignation = @desg, ESalary = @sal, EDOJ = @doj
where EId = @id
end try
begin catch
print 'Error Occured'
print ERROR_MESSAGE()
end catch
end

alter proc usp_dEmps
@id int
as
begin
begin try
delete from Emps
where EId = @id
if @@ROWCOUNT>=1
begin
print 'Row(s) deleted'
end
else
begin
print 'No rows deleted'
end
end try
begin catch
print 'Error Occured'
print ERROR_MESSAGE()
end catch
end

alter proc usp_saEmps
as
begin
select EId as 'Employee ID', EName 'Employee Name', EDesignation 'Employee Role', ESalary 'Employee Salary', EDOJ 'Date of Joining'  from Emps
end

alter proc usp_SalaryByDesg
@desig nvarchar(20),
@salary float out
as
begin
set nocount on
select @salary=sum(ESalary) from Emps where EDesignation = @desig
end


exec usp_iEmps 101,'John','Manager',25000,'10/10/2021'
exec usp_iEmps 201,'Peter','Sales',10000,'07/01/2021'

exec usp_uEmps 201,'Peter','Sales',15000,'07/01/2021'

exec usp_dEmps 201

exec usp_saEmps

declare @sal decimal(10,2)
exec usp_SalaryByDesg 'Sales',@sal output
print 'salary = '+convert(nvarchar(20),@sal)

select * from Emps

