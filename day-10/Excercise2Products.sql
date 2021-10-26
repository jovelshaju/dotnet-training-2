create table Products
(PId int identity(1000,1) primary key,
PName nvarchar(20) not null,
PPrice float not null,
PTax as PPrice * 0.10 persisted, 
PCompany nvarchar(20) check(PCompany in ('SamSung','Apple','Redmi','HTC','Realme')),
PQty int default 1 check (PQty>=1))

create proc usp_displayProducts
with encryption
as
begin
select PId 'Id', PName 'Product', PPrice+PTax as 'Price(Inc. Tax)', PCompany 'Company', PQty*(PPrice+PTax) as 'Total Price' from Products
end

create proc usp_companyTax
@cname nvarchar(20),
@taxamnt float out
with encryption
as
begin
select @taxamnt=sum(PTax) from Products where PCompany=@cname
end

insert into Products (PName,PPrice,PCompany,PQty) values ('Smartwatch',12000,'SamSung',12)
insert into Products (PName,PPrice,PCompany,PQty) values ('Smart TV',25000,'Redmi',15)
insert into Products (PName,PPrice,PCompany,PQty) values ('Phone',112000,'Apple',25)
insert into Products (PName,PPrice,PCompany,PQty) values ('Speaker',5000,'HTC',10)
insert into Products (PName,PPrice,PCompany,PQty) values ('Laptop',50000,'Realme',18)

exec usp_displayProducts

declare @totaltax float
exec usp_companyTax 'Redmi', @totaltax output
print 'Total tax = '+convert(nvarchar(20),@totaltax)