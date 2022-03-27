create database hospital;

create table addPatient
(
	name varchar(50),
	age int,
	gender varchar(10),
	contact bigint,
	address varchar(50),
	blood varchar(10),
	symptoms varchar(50)
)

select * from addPatient;

create table addDoctor
(
	name varchar(50),
	age int,
	gender varchar(10),
	address varchar(50),
	blood varchar(10),
	type varchar(50)
)
select * from addDoctor;