create database MVCDatabase

use MVCDatabase

create table Trainees(
tid int primary key identity(1,1),
tname varchar(25),
tcity varchar(25),
deptid int,
domain varchar(20)
)

insert into Trainees values('Arun Joseph','Gudalur',100,'DOTNET'),('Harita','Coimbatore',100,'DOTNET'),('Harishmitha','Coimbatore',101,'PHP')

select * from Trainees