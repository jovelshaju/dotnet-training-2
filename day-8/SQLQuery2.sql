
drop database OurExcerciseDB

-- Step 1 --
create database OurExcerciseDB on primary
(name='OurExcerciseDB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\OurExcerciseDB.mdf')
log on
(name='OurExcerciseDB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\OurExcerciseDB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

create table Person
(PId int,
PName nvarchar(50),
PEmail nvarchar(50))

-- Step 2 --
alter table Person alter column PId int not null
alter table Person add constraint Pk_Person primary key (PId)

-- Step 3 --
alter table Person alter column PEmail nvarchar(100)
alter table Person add constraint Uk_Person unique (PEMail)

-- Step 4 --
alter table Person drop constraint Uk_Person
alter table Person drop column PEmail

-- Step 5 --
exec sp_rename 'Person.PId', 'CId', 'COLUMN'
exec sp_rename 'Person.PName', 'CName', 'COLUMN'

select * from Person

-- Step 6 --
exec sp_rename 'Person', 'Customers'

select * from Customers




