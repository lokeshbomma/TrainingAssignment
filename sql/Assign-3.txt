use employee;
select * from Emp1;

select * from Dept;

--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select ename,sal from Emp1 where sal>1500 and sal<2850;


--2. Display the name and job of all employees who do not have a MANAGER.
select ename,job from  Emp1 where job != 'Manager';



--3. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename,job ,sal from  Emp1
where job in ('Manager','Analyst') And sal not in (1000,3000,5000);





--4. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%.
select ename,sal+sal*10/100 as "salary increased 10%", comm from Emp1
where comm>sal;





--5. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from  Emp1
where ename like '%LL%' and deptno=30 or mgr=7782;



--6. Display the names of employees with experience of over 10 years and under 20 yrs.
-- Count the total number of employees.
select count(*) as No_of_employees,ename from  Emp1
where CONVERT(varchar(3),DATEDIFF(Year,HireDate,getdate()))>10
And CONVERT(varchar(3),DATEDIFF(Year,HireDate,getdate()))>20
Group By ename;





--7. Retrieve the names of departments in ascending order and their employees in descending order.
Select dname,ename
From  Emp1 join Dept on  Emp1.deptno=Dept.deptno
order by Dname Asc,Ename desc;



--8. Find out experience of MILLER.
select DATEDIFF(YY,'1982/01/23','2022/05/30') AS DOB_NOOF_DAYS;





--9. How many different departments are there in the employee table.
select count(*) as "different dept" , deptno from  Emp1
group by deptno;


--10. Find out which employee either work in SALES or RESEARCH department.
select * from Emp1
where deptno in(select deptno from Dept
where dname in ('SALES','RESEARCH'));




--11. Print the name and average salary of each department.
select ename,avg(sal) as 'salary' from Emp1
group by deptno,ename;



--12. Select the minimum and maximum salary from employee table.
select max(sal) as "maxsal", min(sal) as "minsal" from Emp1;



--13. Select the minimum and maximum salaries from each department in employee table.
select max(sal) as "maxsal", min(sal) as "minsal" from Emp1
group by deptno;



--14. Select the details of employees whose salary is below 1000 and job is CLERK.
select * from Emp1
where sal<1000 and job = 'CLERK';

