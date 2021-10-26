use Day18DB

create table Student
(SId int primary key,
SName nvarchar(20) not null,
SEmail nvarchar(20),
SContact nvarchar(20))

create table Fee
(SId int foreign key references Student(SId),
SFee float,
SMonth int,
SYear int,
primary key (SId,SMonth, Syear))

insert into Student values
(1,'John','jj@gmail.com','657571237'),
(2,'Mariya','mm@gmail.com','4314666'),
(3,'Peter','pp@gmail.com','1423667'),
(4,'Angel','aa@gmail.com','12635756'),
(5,'Sean','ss@gmail.com','53175767')

insert into Fee values
(1,1000,1,2020),
(3,1200,5,2021),
(3,1500,7,2021),
(2,700,9,2020)