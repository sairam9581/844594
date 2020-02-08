create procedure GetCustomersByCountry(@country varchar(30))
As select customerID,contactName,companyName,Address,Country from Customers where Country = @country;

Execute GetCustomersByCountry 'UK';

create procedure GetProductsByCategoryID(@categoryID int) as
select p.ProductID,p.ProductName, p.unitprice,p.quantityperUnit,c.categoryId,c.categoryName from products p inner join Categories c on  p.CategoryID=c.CategoryID and c.CategoryID=@categoryID;

execute GetProductsByCategoryID '2';


--Declaring Local Variable

Declare @country as varchar(30);
select @country = 'usa';
select * from Customers where country = @country;

create procedure gettotalordersbyDate(@date1 date,@date2 date,@countOrder int output) as
select count(orderId) from orders where OrderDate Between @date1 and @date2;

alter procedure gettotalordersbyDate(@date1 date,@date2 date,@countOrder int output) as
select @countorder = count(orderId) from orders where OrderDate Between @date1 and @date2;


declare @count as varchar(100);
Execute gettotalordersbyDate '10/10/1990','12/31/1998',@count output;

print 'Total number of orders placed : ' + @count;


--creating functions

--by default this function is stored inside the default schema known as 'dbo' which stands for database owner

Create function Multiple(@n1 int, @n2 int) 
returns bigint begin 
declare @prod as bigint;
set @prod = @n1*@n2;
return @prod;
end

select dbo.Multiple(50,80) as product;

--table valued function

create function GetCustomers(@country varchar(30)) returns table 
as
return select * from Customers where country=@country;
go

select * from dbo.GetCustomers('Germany');


--Subqueries

--1. A subquery is used as part of a main query, and the value returned from the subqyery will be used by the main query for its execution

--2. Sometimes a subquery is used in-place of join operation to combine to tables, but joins are performed over subqueries because of their effiency


select ProductID,ProductName,unitprice,quantityperUnit,categoryId from Products where UnitPrice > (select avg(unitprice) from products) order by UnitPrice;


select orderId,customerId,employeeId from orders where OrderID = (select OrderID from orders where EmployeeId=5 and customerId = 'Vinet');


--correlated subquery

--A correleted subquery does't return any data to the main query. But it always retuen a boolean value of either 'true' or 'false' and accordingly the main query gets executed if it receives a boolean value of true. othereise the main menu query will not be executed.

--The correlated subqueries make use of exists or not exists operators as a part of main quary




select customerId, companyName, Address, Country from Customers where Exists (select ContactName from Customers where Country in ('uk' ,'USA'));


select customerId, companyName, Address, Country from Customers where  not  Exists (select ContactName from Customers where Country = 'russia');
