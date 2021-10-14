create database OurExcercise9DB on primary
(name='OurExcercise9DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-14\Databases\OurExcercise9DB.mdf')
log on
(name='OurExcercise9DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-14\Databases\OurExcercise9DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise9DB

create table Category
(CId int primary key,
CName nvarchar(20) not null unique)

create table Book
(BId int primary key,
BName nvarchar(20),
BPrice float,
AName nvarchar(20),
CatID int foreign key references Category(CId))

insert into Category values
(201, 'Fiction'),
(202, 'Non-Fiction'),
(203, 'Literature'),
(204, 'Magazine'),
(205, 'Poem')

insert into Book values
(101, 'The Dune', 500, 'John', 201),
(102, 'The Clocks', 300, 'Agatha', 203),
(103, 'The Alchemist', 400, 'Paul', 202),
(104, 'Smiles', 250, 'Aaron', 204),
(105, 'Acknowledged', 350, 'Lilly', 205),
(106, 'Zenin', 150, 'Leo', 204)