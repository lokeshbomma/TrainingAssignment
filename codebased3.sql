create database  EmployeeManagement;
use EmployeeManagement;
create table  Code_Employee 
( 
empno int primary key, 
empname varchar(50) not null, 
empsal numeric(10,2) check(empsal >= 25000) , 
emptype varchar(1) check(emptype in('C','P')) 
) 
insert into Code_Employee values(1,'lokesh',26000,'P');
insert into Code_Employee values(2,'rakesh',27000,'C');
insert into Code_Employee values(3,'vijay',25000,'P');
select * from Code_Employee;

select * from Code_Employee



create or alter procedure AddNewEmployee(@ename varchar(50), @esal numeric(10,2), @etype varchar(1))
as
begin
declare @eid int = (select max(empno) from Code_Employee)
begin
declare @empid int = @eid + 1;
insert into Code_Employee values(@empid, @ename, @esal, @etype)
end
end




execute AddNewEmployee @ename='vijay',@esal=30000,@etype='C';