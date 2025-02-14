create database My
use My

 

-- one character or max to 128 characters  ,, a table can contain max 1024  

create table student 

( 

studid int, 

sname varchar(30), 

salary decimal(6 , 2) 

 

) 

 

Alter table student alter column salary decimal(5,2) 

 

alter table student add marks decimal(5,2) 

 

alter table student drop column marks ; 

 

sp_rename 'student' ,'studentdata'  

 

sp_rename 'studentdata.salary' , 'sal' 

 

insert into studentdata values(10,'Niti' , 100.00) 

 

select * from studentdata 

 

truncate table studentdata   --structure of a table exist but data will be deleted 

 

drop table studentdata 

 

 

 

 

 