create database practice
use practice

create table employe(empId int, empName varchar(30), empSalary decimal(6,2))

insert into employe values(202,'prashant kumar',1000.00)
insert into employe values(201,'sam',1000.00)
insert into employe values(200,'shivam',5251)
insert into employe values(199,'lucky',9999.99)
insert into employe values(198,'wipro',0000.11)
delete from employe where empId=202
select * from employe
alter table employe add age int
update employe set age = 24 where empId = 202 

EXEC sp_rename 'employe.age', 'Employee_Age', 'COLUMN';
update employe set Employee_Age = 25 where empId = 198 
update employe set Employee_Age = 30 where empId = 200
update employe set Employee_Age = 20 where empId = 201








create table Karmchari(
id int not null,
lastname varchar(250),
firstname varchar(250),
age int,
city varchar(255)default 'Mumbai', --giving defualt value if we did not insert any value then this default value gonna save in table
dateofbirth date default getdate(),

salary decimal(18,2)default  4000.00


)

insert into Karmchari(id,lastname,firstname,age,city,dateofbirth,salary) values(250,'prashant','maurya',21,'DELHI','2003/05/16',1252412.20)
select * from Karmchari