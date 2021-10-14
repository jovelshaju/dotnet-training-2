use Excercise6DB

create table Category
(CId int primary key,
Category nvarchar(20) not null unique)

create table Author
(AId int primary key,
AName nvarchar(20) not null unique)

create table Book
(BId int primary key,
BName nvarchar(20),
BPrice float,
CId int,
AId int,
constraint fk_CId foreign key (CId) references Category(Cid),
constraint fk_AId foreign key (AId) references Author(Aid))

-- ## Creating View ## --
drop view vw_Books
create view vw_Books
as
select b.BName 'Title', a.AName 'Author', b.BPrice 'Price', c.Category 'Category'  from Author a, Book b, Category c where b.AId=a.AId and b.CId=c.CId 

-- Inserting data into category --
insert into Category values (1, 'Fiction')
insert into Category values (2, 'Non-fiction')
insert into Category values (3, 'Literature')
insert into Category values (4, 'Poems')

-- inserting data intto Authors --
insert into Author values (41, 'Paulo')
insert into Author values (42, 'Chetan')
insert into Author values (43, 'Arundhathi')
insert into Author values (44, 'Agatha')
insert into Author values (45, 'George')

-- inserting data into Book --
insert into Book values (61, 'The Alchemist', 400, 1, 41)
insert into Book values (62, 'The Clocks', 300, 3, 44)
insert into Book values (63, 'Soceity', 500, 2, 43)
insert into Book values (64, 'Euphoria', 250, 4, 42)
insert into Book values (65, 'Lavendar', 300, 1, 45)
insert into Book values (66, 'Maniac', 440, 2, 41)


select * from vw_Books where [Author]='George'
