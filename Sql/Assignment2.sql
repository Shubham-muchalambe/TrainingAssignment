select * from EMP

select *from DEPT

--1. Retrieve a list of MANAGERS. -----

select * from Emp where job = 'MANAGER'

--2. Find out salary of both MILLER and SMITH. -----

select ename, sal from emp where ename in('MILLER','SMITH')

--3. Find out the names and salaries of all employees earning more than 1000 per month.----

select ename, sal from emp where sal>1000 

--4. Display the names and salaries of all employees except JAMES. ------

select ename, sal from emp where ename != 'JAMES'

--5. Find out the details of employees whose names begin with ‘S’. -----

select * from emp where ename like's%'

--6. Find out the names of all employees that have ‘A’ anywhere in their name. ----

select * from emp where ename like'%A%'

--7. Find out the names of all employees that have ‘L’ as their third character in their name.-----

select * from emp where ename like'__L%'

--8. Find out the names of the employees whose name begin with ‘A’ or ‘M’. ------

select * from emp where ename like 'A%' or ename like 'M%'
 
 --9. Compute yearly salary of SMITH.----

 select (sal*12) as 'Anual salary' from emp where ename ='SMITH'

 --10. Compute daily salary of JONES.-----

 select (sal/24) as 'Daily salary' from emp where ename ='JONES'

 --11. Calculate the total monthly salary of all employees.----
  
 select sum(sal) as 'Total sum' from EMP

 --12. Print the average annual salary. ------

 select (sal*12) from emp 
 select avg(sal*12) as 'Average anual sal' from emp 

 --13. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. ----

 select ename, job, sal, deptno from emp where (job !='SALESMAN' and deptno =30)

 --14. List unique departments of the EMP table. ---

 select distinct(deptno) from EMP
 

 --15. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.------


 select ename as'employee name', sal as'Mounthly salary' from emp 
 where sal>1500 and deptno in(10,30) 