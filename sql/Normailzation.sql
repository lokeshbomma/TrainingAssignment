create database company;
use company;

create table Empdetails(
ClientNo varchar(25),
Cname varchar(25),
Propertyno varchar(25),
Paddress varchar(55),
Rentstart varchar(25),
Rentfinish varchar(25),
rent int not null,
Ownerno varchar(25),
Oname varchar(25));

insert into Empdetails values('CR76','johnkay','PG4','6 lawrence St','1-july-00','31-Aug-01',350,'CO40','Tina Murphy')
insert into Empdetails values('CR76','johnkay','PG4','Glasgow','1-july-00','31-Aug-01',350,'CO40','Tina Murphy')
insert into Empdetails values('CR76','johnkay','PG16','5 Novar Dr','1-sep-02','1-sep-02',450,'CO93','Tony Shaw')
insert into Empdetails values('CR76','johnkay','PG16','Glasgow','1-sep-02','1-sep-02',450,'CO93','Tony Shaw')

insert into Empdetails values('CR56','Alinestewart','PG4','6 lawrence St','1-sep-99','10-jun-00',350,'CO40','Tina Murphy')
insert into Empdetails values('CR56','Alinestewart','PG4','Glasgow','1-sep-99','10-jun-00',350,'CO40','Tina Murphy')
insert into Empdetails values('CR56','Alinestewart','PG36','2 ManorRd','10-oct-00','1-dec-01',370,'CO93','Tony Shaw')
insert into Empdetails values('CR56','Alinestewart','PG36','Glasgow','10-oct-00','1-dec-01',370,'CO93','Tony Shaw')
insert into Empdetails values('CR56','Alinestewart','PG16','5 Novar Dr','1-nov-02','1-aug-03',450,'CO93','Tony Shaw')
insert into Empdetails values('CR56','Alinestewart','PG16','Glasgow','1-nov-02','1-aug-03',450,'CO93','Tony Shaw')

select * from Empdetails

----normalisation----

create database Normalization 
use normalization 
create table table1( cID int primary key,pAddress varchar(100),propertyNo varchar(20), rent float ) 
insert into table1 values(1,'6 Lawrence st,Glasgow','PG4',350), (2,'5 Novar Dr,Glassgow','PG36',450), (3,'2 Manor Rd,Glasgow','PG16',370) 
select * from table1 

create table table2( clientID int primary key,clintNo varchar(20), cName varchar(100),ownerNo varchar(20), oName varchar(100) ) 
insert into table2 values(1,'CR76','Jhon Kay','C040','Tina Murphy'), (2,'CR56','Aline Stewan','C093','Tony Shaw') 
select* from table2 

create table NormalForm( cID int foreign key references table1(cID),clientID int foreign key references table2(clientID),rentStart varchar(10), rentFinish varchar(10)) 
insert into NormalForm values(1,1,'1-july-00','31-aug-01'), (2,1,'1-sep-02','1-sep-02'), (1,2,'1-sep-99','10-june-00'), (3,2,'10-oct-00','1-dec-01'), (2,2,'1-nov-02','1-aug-03') 
select * from NormalForm
