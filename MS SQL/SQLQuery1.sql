create database EmployeeDB;
use EmployeeDB;
create table Employee(Emp_id int not null,Emp_name varchar(50) not null,SSN bigint not null,Salary float 
not null,Dep_Id int not null);
select * from Employee;
insert into Employee values(1,'Aakash',12345,22000,1);
insert into Employee values(2,'Aaron',11345,21500,2);
insert into Employee values(3,'John',12245,21000,3);
insert into Employee values(4,'Mohan',12335,23000,4);

create table Department(Dep_id int not null,Dep_name varchar(20) not null);
insert into Department values(1,'Tech');
insert into Department values(2,'Marketing');
insert into Department values(3,'Stores');
insert into Department values(4,'Admin');
 

alter table Department add primary key(Dep_id);
delete Department where Dep_id=3;

alter table Employee Add Constraint Fk_Dep_id Foreign key (Dep_id) references Department(Dep_id);