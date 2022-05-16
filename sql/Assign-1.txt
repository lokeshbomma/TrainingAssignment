create database employee;
use employee;
create table Emp1(
empno int not null, 
ename varchar(55),
job varchar(55), 
age int not null, 
mgr int , 
hiredate date, 
sal int, 
comm int, 
deptno int);
insert into Emp1 values(7369,'SMITH','CLERK',22,7902,'17-DEC-80',800,null,20);
insert into Emp1 values(7499,'ALLEN','SALESMAN',23,7698,'20-FEB-81',1600,300,30);
insert into Emp1 values(7521,'WARD','SALESMAN', 24,7698,'22-FEB-81',1250,500,30);
insert into Emp1 values(7566,'JONES','MANAGER',25,7839,'02-APR-81',2975,null,20);
insert into Emp1 values(7654,'MARTIN','SALESMAN',26,7698,'28-SEP-81',1250,1400,30);
insert into Emp1 values(7698,'BLAKE','MANAGER',27,7839,'01-MAY-81',2850,null,30);
insert into Emp1 values(7782,'CLARK','MANAGER',28,7839,'09-JUN-81',2450,null,10);
insert into Emp1 values(7788,'SCOTT','ANALYST',29,7566,'19-APR-87',3000 ,null,20);
insert into Emp1 values(7839,'KING','PRESIDENT',22,null,'17-NOV-81',5000,null,10);
insert into Emp1 values(7844,'TURNER','SALESMAN',23,7698,'08-SEP-81',1500,0,30);
insert into Emp1 values(7876,'ADAMS','CLERK',24,7788,'23-MAY-87',1100,null,20);
insert into Emp1 values(7900,'JAMES','CLERK',25,7698,'03-DEC-81',950,null,30);
insert into Emp1 values(7902,'FORD','ANALYST',26,7566,'03-DEC-81',3000,null,20);
insert into Emp1 values(7934,'MILLER','CLERK',27,7782,'23-JAN-82',1300,null,10);

select * from Emp1;

select * from Emp1 where ename like'A%';

select * from Emp1 where job!='MANAGER';

Select ename,empno,sal from Emp1
where sal BETWEEN 1201 AND 1399;

select sal+sal*10/100 AS "10% PAYRISE" from Emp1
Where Job ='PRESIDENT';

Select COUNT(*) AS " NUMBER OF CLERKS" from Emp1
Where Job='CLERK';

Select AVG(sal) AS "AVG sal",COUNT(*) AS "Number Of People Employed In Each Job" from Emp1
Group by job;


SELECT MAX(sal) AS "MAX Sal" ,MIN(sal) AS "MIN sal" from Emp1;

select ename,sal from Emp1
Where Job ='ANALYST' And deptno=20
Order by ename asc;

SELECT job ,deptno, SUM(sal) As "Total Sal" from Emp1
Group by Job,deptno;


Select sal from Emp1
Where ename In('MILLER','SMITH');



Select ename from Emp1
Where ename Like 'A%' Or Ename Like 'M%';


Select sal*12 AS "Year sal" from Emp1
Where ename='SMITH';



Select ename,sal from Emp1
where sal between 1500 and 2850;






create table Dept(
deptno int not null,
 dname varchar(55),
 loc varchar(55));

 insert into Dept values(10,'ACCOUNTING','NEW YORK' );
 insert into Dept values(20,'RESEARCH','DALLAS' );
 insert into Dept values(30,'SALES','CHICAGO' );
 insert into Dept values(40,'OPERATIONS','BOSTON');

 select * from Dept;
 Select * From Dept
Where deptno not in (select deptno from Emp1);