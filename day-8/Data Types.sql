create database Day8DB on primary
(name='Day8DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\Day8DB.mdf')
log on
(name='Day8DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-8\Databases\Day8DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use Day8DB

-- Date and Time --
create table MyDateTime
(DateCol date,
TimeCol time,
DateTimeCol datetime,
SmallDTCol smalldatetime,
DT2Col datetime2,
DTOffsetCol datetimeoffset)

delete from MyDateTime;

insert into MyDateTime (DateCol) values (GETDATE());
insert into MyDateTime (TimeCol) values (CURRENT_TIMESTAMP);
insert into MyDateTime (DateTimeCol) values (SYSDATETIME());
insert into MyDateTime (SmallDTCol) values (SYSDATETIME());
insert into MyDateTime (DT2Col) values (SYSUTCDATETIME());
insert into MyDateTime (DTOffsetCol) values (SYSDATETIMEOFFSET());

select * from MyDateTime;

-- Creating custom type --

create type MyType from int not null;

