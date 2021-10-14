create table Customers
(CId int primary key,
CName nvarchar(20) not null,
CCity nvarchar(20) not null,
CODLimit float,
CEmail nvarchar(20) not null)

insert into Customers values
(101, 'John', 'Delhi', 25000,'jj@gmail.com'),
(102, 'Lea', 'Mumbai', 45000,'ll@gmail.com'),
(103, 'Anna', 'Banglore', 50000,'aa@gmail.com'),
(104, 'Joe', 'Delhi', 25000,'je@gmail.com'),
(105, 'Zeke', 'Chennai', 35000,'zz@gmail.com')

select * from Customers