create function dbo.fnGetDiscountedPrice 
(@price float, @discount float)
returns float
as
begin
 return (@price - (@price*@discount))
end

select PId,dbo.fnGetDiscountedPrice(PPrice,PDiscount) as 'Discounted Price' from Products