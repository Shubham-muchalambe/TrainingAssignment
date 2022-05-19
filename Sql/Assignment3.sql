use EmpDB

select * from emp

select* from DEPT

--1. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.---------

select ename, sal from emp where sal not between 1500 and 2850

--2. Display the name and job of all employees who do not have a MANAGER.--------

select ename, job from emp where mgrid is null

--3. Display the name, job, and salary of all the employees whose job is MANAGER or------
 
--ANALYST and their salary is not equal to 1000, 3000, or 5000.-----------

select ename,job,sal from emp where job in('MANAGER','ANALYST') and sal not in(1000,3000,5000)

--4. Display the name, salary and commission for all employees whose commission 
--amount is greater than their salary increased by 10%.----------------
 
select ename,sal,comm from emp where comm > sal+sal*.10

--5. Display the name of all employees who have two Ls in their name and are in 
--department 30 or their manager is 7782. 
 select ename from emp where ename like '%LL%' and deptno in (30) or mgrid =7782

 --6. Display the names of employees with experience of over 10 years and under 20 yrs.
 --Count the total number of employees.--------
  
 update emp set hiredate='28-SEP-10' where empno in(7654,7900)

 SELECT COUNT(hiredate) AS NO_OF_EMPLOYEES,ename
 FROM EMP
 WHERE CONVERT(varchar(3),DATEDIFF(YEAR, HIREDATE, GETDATE()))>10
 AND CONVERT(varchar(3),DATEDIFF(YEAR, HIREDATE, GETDATE()))<20
 GROUP BY ename


 --7. Retrieve the names of departments in ascending order and their employees in descending order.-----

 select deptname,ename from DEPT join emp on dept.DeptNo = emp.deptno
 order by deptname asc , ename desc

 --8. Find out experience of MILLER. 

select convert(varchar(5),datediff(year,hiredate,getdate())) as'Experience'
from emp where ename='MILLER'

 --9. How many different departments are there in the employee table.--------
  
 select deptname,count(*) as 'noof departments' from emp join dept on
 dept.deptno= emp.deptno
 group by deptname

 --10. Find out which employee either work in SALES or RESEARCH department. ----

 select ename, deptname from emp join dept on emp.deptno=dept.DeptNo 
 where DeptName in('SALES','RESEARCH')

 --11. Print the name and average salary of each department.------
  
 select deptname, avg(sal) as AverageSalary from emp join dept on emp.deptno=dept.DeptNo
 group by DeptName

 --12. Select the minimum and maximum salary from employee table.------
  
 select min(sal) as minimumsalary, max(sal) as maximumsalary from emp

 --13. Select the minimum and maximum salaries from each department in employee table.-------

 select deptname,min(sal) as minimum_salary,max(sal) as maximum_salary from emp join dept
 on emp.deptno=dept.DeptNo 
 group by deptname 

 --14. Select the details of employees whose salary is below 1000 and job is CLERK. -----

 select * from emp where sal<1000 and job = 'CLERK'
