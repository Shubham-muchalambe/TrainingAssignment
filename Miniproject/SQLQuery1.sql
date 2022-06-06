create database StudentManagement
use StudentManagement

create table tblCourses
(CourseId int primary key,CourseName varchar(20),Courseduration int, Coursefees float)

insert into tblCourses values(10,'Jitesh',30,5000),(20,'Priti',30,4000),(30,'Rohan',25,1000);

select * from tblCourses

create table tblStudents
(StudentId int primary key,StudentName varchar(20),studentDOB date)

insert into tblstudents values(110,'Kishor','01/25/1993'),
(120,'javeed','02/22/1998'),(130,'Krishna','04/04/1993')

select * from tblStudents

create table tblEnrollDetails
(Courseid int foreign key references tblCourses(CourseId),
 StudentId int foreign key references tblStudents(StudentId),
 EnrollDate date)

 insert into tblEnrollDetails values(10,110,'2022/4/10'),
 (20,120,'2022/6/21'),(30,130,'2022/5/12')


 select * from tblEnrollDetails