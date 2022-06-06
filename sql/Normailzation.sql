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