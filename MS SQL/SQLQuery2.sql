 
select MAX(Salary) [MAx salary], MIN(Salary) 'Min salary', AVG(Salary) 'Averege salary' From Employee;

Select Dep_Id,SUM(Salary) [Total salary] from Employee Group By Dep_Id order by Dep_Id; 
Select Dep_Id,SUM(Salary) [Total salary] from Employee Group By Dep_Id Having SUM(Salary)>=22000 order by Dep_Id;

insert into Employee values (5,'Praveen',12233,30000,3);
insert into Employee values (6,'velu',12243,31000,null);
insert into Department values(5,'Hr');

Select * From Employee;
Select * From Department;

Select Top(4) * from Employee;
Select Top(3) Salary,Emp_name from Employee order by Salary;

select e.Emp_id,e.Emp_name,e.Salary,e.Dep_Id,d.Dep_name from Employee as e inner join Department as d on e.Dep_Id=d.Dep_id;

select e.Emp_id,e.Emp_name,e.Salary,e.Dep_Id,d.Dep_name from Employee as e left outer join Department as d on e.Dep_Id=d.Dep_id;

select e.Emp_id,e.Emp_name,e.Salary,e.Dep_Id,d.Dep_name from Employee as e right outer join Department as d on e.Dep_Id=d.Dep_id;

select e.Emp_id,e.Emp_name,e.Salary,e.Dep_Id,d.Dep_name from Employee as e Full join Department as d on e.Dep_Id=d.Dep_id;