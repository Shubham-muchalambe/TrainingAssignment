create database EmpDB

use EmpDB

--creating department table

create table DEPT(DeptNo int primary key, DeptName varchar(15),Loc varchar(15))
insert into DEPT
values(10,'ACCOUNTING','NEW YORK')
insert into DEPT
values(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

select * from DEPT

-- creating Employee table--

create table EMP
(empno int primary key,ename varchar(20),job varchar(15),
mgrId int, hiredate varchar(20), sal int, comm int,
deptno int foreign key references DEPT(DeptNo)) 



insert into EMP
values(7369,'SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

select * from EMP

--1. List all employees whose name begins with 'A'.----
 
select * from EMP where ename like'A%'

--2. Select all those employees who don't have a manager.----

select * from EMP where mgrId is null

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400.---

select * from EMP where sal between 1200 and 1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.---- 
select SAL+SAL*10/100 as "10% PAYRISE"
from EMP
Where DEPTNO in (select DEPTNO
from DEPT
where DeptName='RESEARCH')

--5. Find the number of CLERKS employed. Give it a descriptive heading. -----

Select job,Count(job) as NO_OF_CLERKS
FROM EMP
WHERE job='CLERK'
GROUP BY job

--6. Find the average salary for each job type and the number of people employed in each job.---

select JOB,AVG(sal) as AVGSAL,count(job) as NO_OF_PEOPLE
FROM EMP
GROUP BY job

--7. List the employees with the lowest and highest salary.----
select Max(sal) as "MAX SAL" ,min(sal) as "MIN SAL"
FROM EMP

--8. List full details of departments that don't have any employees.
select * from DEPT
where DEPTNO
not in (select DEPTNO from EMP)

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name.-------

select ENAME,SAL
from EMP
where job ='ANALYST' AND DeptNo=20
order by ename asc

--10. For each department, list its name and number together with the total salary paid to employees in that department.

select job ,DEPTNO, sum(sal) as "TOTAL SAL"
from EMP
group by job,deptno

--11. Find out salary of both MILLER and SMITH.----

select ename,sal
from EMP
where ename IN('MILLER','SMITH')

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.---

select ename
from EMP
where ename LIKE 'A%' OR ename LIKE 'M%'

--13. Compute yearly salary of SMITH---

select ename,sal*12 as "YEAR SAL"
from EMP
where ename='SMITH'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.---

select ename ,sal
from EMP
where sal not between 1500 and 2850
