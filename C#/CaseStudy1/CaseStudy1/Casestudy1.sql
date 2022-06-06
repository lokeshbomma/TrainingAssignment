<<<<<<< HEAD
create database StudentManagementSystem
use StudentManagementSystem

create table courses
(Cid int primary key,CName varchar(20),dur int, Cfee float)

insert into Courses values(01,'Csharp',25,30000),(02,'MsSQL',15,20000),(03,'Asp.Net',35,40000);

select * from Courses

create table Student
(StdId int primary key,StdName varchar(30),sDOB date)

insert into student values(10,'Vinod','05/09/1998'),
(15,'Kumar','06/12/2000'),(20,'Bantu','05/08/1999')

select * from Student

create table Enroll
(Cid int foreign key references Courses(CId),
 StdId int foreign key references Student(StdId),
 EnrollDate date)

 insert into Enroll values(01,10,'2022/4/18'),
 (02,15,'2022/5/3'),(03,20,'2022/5/20')


 select * from Enroll
 select * from Student
=======
create database StudentManagementSystem
use StudentManagementSystem

create table courses
(Cid int primary key,CName varchar(20),dur int, Cfee float)

insert into Courses values(01,'Csharp',25,30000),(02,'MsSQL',15,20000),(03,'Asp.Net',35,40000);

select * from Courses

create table Student
(StdId int primary key,StdName varchar(30),sDOB date)

insert into student values(10,'Vinod','05/09/1998'),
(15,'Kumar','06/12/2000'),(20,'Bantu','05/08/1999')

select * from Student

create table Enroll
(Cid int foreign key references Courses(CId),
 StdId int foreign key references Student(StdId),
 EnrollDate date)

 insert into Enroll values(01,10,'2022/4/18'),
 (02,15,'2022/5/3'),(03,20,'2022/5/20')


 select * from Enroll
 select * from Student
>>>>>>> d38434b1711b7d5e0eb86cc15fd79ca5f78063fa
 select * from Courses