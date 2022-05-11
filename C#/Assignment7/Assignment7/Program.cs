using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Employee
    {
        public int EmployeeId;
        public string firstName;
        public string lastName;
        public string Title;
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City;

    }
    class Query
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();

            emplist.Add(new Employee { EmployeeId = 1001, firstName = "Virat", lastName = "Kohli", Title = "Manager", DOB = DateTime.Parse("11 / 16 / 1984"), DOJ = Convert.ToDateTime("8 / 6 / 2011"), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1002, firstName = "David", lastName = "Warner", Title = "AsstManager", DOB = DateTime.Parse("08/ 20 / 1984"), DOJ = Convert.ToDateTime("7 / 7 / 2012"), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1003, firstName = "Madhavi", lastName = "Patil", Title = "Consultant", DOB = DateTime.Parse("11 / 14 / 1987"), DOJ = Convert.ToDateTime("12 / 4 / 2015"), City = "Pune" });
            emplist.Add(new Employee { EmployeeId = 1004, firstName = "Anjali", lastName = "Patil", Title = "SE", DOB = DateTime.Parse("6 / 03 / 1990"), DOJ = Convert.ToDateTime("2 / 2 / 2016"), City = "Pune" });
            emplist.Add(new Employee { EmployeeId = 1005, firstName = "Sai", lastName = "Shirke", Title = "SE", DOB = DateTime.Parse("03/ 08 / 1991"), DOJ = Convert.ToDateTime("2 / 2 / 2016"), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1006, firstName = "Amit", lastName = "Singh", Title = "Consultant", DOB = DateTime.Parse("11 / 07 / 1989 "), DOJ = Convert.ToDateTime("8 / 8 / 2014"), City = "Chennai" });
            emplist.Add(new Employee { EmployeeId = 1007, firstName = "Vijay", lastName = "Murli", Title = "Consultant", DOB = DateTime.Parse("12 / 02 / 1989"), DOJ = Convert.ToDateTime("1 / 6 / 2015"), City = "Mumbai" });
            emplist.Add(new Employee { EmployeeId = 1008, firstName = "Rahul", lastName = "Chahar", Title = "Associate", DOB = DateTime.Parse("11 / 11 / 1993"), DOJ = Convert.ToDateTime("6 / 11 / 2014"), City = "Chennai" });
            emplist.Add(new Employee { EmployeeId = 1009, firstName = "Suresh", lastName = "Raina", Title = "Associate", DOB = DateTime.Parse("08 / 12 / 1992"), DOJ = Convert.ToDateTime("3 / 12 / 2014"), City = "Chennai" });
            emplist.Add(new Employee { EmployeeId = 1010, firstName = "Sanju", lastName = "Samsun", Title = "Manager", DOB = DateTime.Parse("04 / 12 / 1991"), DOJ = Convert.ToDateTime("2 / 1 / 2016"), City = "Pune" });

            Employee emp = new Employee();
            // Query
            var Query1 = (from Employee in emplist
                          where Employee.DOB > DateTime.Parse("1/1/1990")
                          select Employee.firstName).Count();
            Console.WriteLine("Number of employees whose Date of Birth is after 1/1/1990 is: {0}", Query1);
            Console.WriteLine("------------------------------------------------------------------------------");

            var Query2 = (from Employee in emplist
                          where ((Employee.Title == "Consultant") || (Employee.Title == "Associate"))
                          select Employee.firstName).ToList();
            Console.WriteLine("List of Employees whose Designation is Consultant and Associate are: ");
            foreach (var Title in Query2) { Console.WriteLine(Title); }
            Console.WriteLine("---------------------------------------------");

            var Query3 = (from Employee in emplist
                          select Employee).Count();
            Console.WriteLine("Total number of Employees in the list are: {0}", Query3);
            Console.WriteLine("-----------------------------------------------------------");

            var Query4 = (from Employee in emplist
                          where Employee.City == "Chennai"
                          select Employee).Count();
            Console.WriteLine("Total number of employees in chennai are: {0}", Query4);
            Console.WriteLine("-------------------------------------------------------");

            var Query5 = emplist.Max(e => e.EmployeeId);
            Console.WriteLine("Highest EmployeeId in the list is: {0}", Query5);
            Console.WriteLine("----------------------------------------");

            var Query6 = (from Employee in emplist
                          where Employee.DOJ > DateTime.Parse("1/1/2015")
                          select Employee).Count();
            Console.WriteLine("Total number of employees joined after 1/1/2015 are: {0}", Query6);
            Console.WriteLine("------------------------------------------------------------------");

            var Query7 = (from Employee in emplist
                          where Employee.Title != "Associate"
                          select Employee).Count();
            Console.WriteLine("Total number of employees whose Designation is not associate are: {0}", Query7);
            Console.WriteLine("--------------------------------------------------------------------------");

            var Query8_1 = (from Employee in emplist
                            where Employee.City == "Mumbai"
                            select Employee).Count();
            Console.WriteLine("Total number of employees from Mumbai are: {0}", Query8_1);
            var Query8_2 = (from Employee in emplist
                            where Employee.City == "Pune"
                            select Employee).Count();
            Console.WriteLine("Total number of employees from Pune are: {0}", Query8_2);
            var Query8_3 = (from Employee in emplist
                            where Employee.City == "Chennai"
                            select Employee).Count();
            Console.WriteLine("Total number of employees from chennai are: {0}", Query8_3);
            Console.WriteLine("---------------------------------------------------------------");

            var Query9 = (from Employee in emplist
                          orderby Employee.City
                          orderby Employee.Title
                          select Employee).Count();
            Console.WriteLine("Total number of Emoloyees based on City and Title are: {0}", Query9);
            Console.WriteLine("---------------------------------------------------------------------");

            var Query10 = (emplist.Max(y => y.DOB));

            Console.WriteLine("Youngest Employee in the list is: {0}", Query10);

            Console.Read();
        }
    }
}
