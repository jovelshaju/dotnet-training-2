use PlayerDBContext

create table IPLPlayers
(PId int primary key,
PName nvarchar(50),
PType nvarchar(50),
PStrikeRate float,
PTeam nvarchar(50))

insert into IPLPlayers values
(1,'Virat','Batsman',4.5,'RCB'),
(2,'Rohit','All rounder',4.7,'MI'),
(3,'Dhoni','Keeper',3.3,'CSK'),
(4,'Rishabh','Bowler',3.7,'KKR'),
(5,'Sanju','Batsman',4.1,'SRH')
