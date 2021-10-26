create database OurExcercise4DB on primary
(name='OurExcercise4DB', filename ='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-9\Databases\OurExcercise4DB.mdf')
log on
(name='OurExcercise4DB_log', filename='C:\Users\jshaju\Documents\Training Projects\soti\soti-back-end-aug2021\dotnet-training-2\day-9\Databases\OurExcercise4DB_log.ldf')
collate SQL_Latin1_General_CP1_CI_AS

use OurExcercise4DB

create table IPLPlayers
(PId int identity primary key,
PName nvarchar(20) not null,
PTeam nvarchar(20) not null,
PRole nvarchar(20) not null,
PBPrice	int not null,
PCountry nvarchar(20) not null)

insert into IPLPlayers values
('John Doe', 'CSK','Batsman', 500000,'England'),
('Virat Kohli', 'RCB','Batsman', 110000,'India'),
('Rohit Sharma', 'MI','Batsman', 90000,'India'),
('M S Dhoni', 'CSK','Wicket Keeper', 100000,'India'),
('AB Devillers', 'RCB','All Rounder', 750000,'Australia'),
('Bradd Pitt', 'MI','Bowler', 450000,'South Africa'),
('Chris Hemsworth', 'CSK','Bowler', 650000,'Australia'),
('Tom Holland', 'MI','Bowler', 550000,'England'),
('Johnny Depp', 'RCB','All Rounder', 800000,'South Africa'),
('Cillian Murphy', 'CSK','Bowler', 700000,'England')

select distinct(PCountry) from IPLPLayers
select PName,PCountry from IPLPlayers order by PCountry
select PName,PCountry,PTeam from IPLPlayers order by PTeam,PCountry


