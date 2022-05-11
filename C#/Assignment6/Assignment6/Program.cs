using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }

        public DateTime DOJ { get; set; }
        public string DOB { get; set; }
        string City { get; set; }

        public override string ToString()
        {
            return EmployeeID + " " + FirstName + " " + LastName + " " + Title + " " + DOJ + " " + DOB + " " + City;
        }
        static void Main(string[] args)
        {
            List<Employee> Emp1 = new List<Employee>()
            {



new Employee { EmployeeID = 1001, FirstName = "Sachin", LastName = "Tendulkar", Title = "Manager", DOB =" 23/07/1984",
    DOJ =DateTime.Parse("14/08/2018"), City = "Mumbai" },
new Employee { EmployeeID = 1002, FirstName = "Anil", LastName = "Kumbale", Title = "AsstManager", DOB = "2/08/1988",
    DOJ =DateTime.Parse("7/4/2016"), City = "Mumbai" },
new Employee { EmployeeID = 1003, FirstName = "Kedar", LastName = "Jadhav", Title = " Consultant ", DOB = " 04 / 01 / 1997",
    DOJ = DateTime.Parse("11/06 / 2014"), City = "Pune" },
new Employee { EmployeeID = 1004, FirstName = "Anjali ", LastName = "Patil", Title = "SE", DOB = "3 / 6 / 1980",
    DOJ = DateTime.Parse("04/03/ 2007"), City = " Pune" },
new Employee { EmployeeID = 1005, FirstName = "Rahul", LastName = "KL", Title = "SE", DOB = "09/ 12/ 1996",
    DOJ = DateTime.Parse("03/05/ 2017"), City = "Mumbai" },
new Employee { EmployeeID = 1006, FirstName = " MS ", LastName = "Dhoni", Title = "Consultant ", DOB = "09/ 11 / 1979",
    DOJ =DateTime.Parse( " 23/09/ 2017"), City = " Chennai" },
new Employee { EmployeeID = 1007, FirstName = "Dinesh", LastName = "Kartik", Title = "Consultant", DOB = " 12 / 2 / 1984",
    DOJ =DateTime.Parse( "19/ 06 / 2014"), City = "Mumbai" },
new Employee { EmployeeID = 1008, FirstName = "Ravindra", LastName = " Jadeja", Title = " Associate  ", DOB = "10 / 10 / 1988",
    DOJ = DateTime.Parse("26 / 1 / 2013"), City = "Chennai" },
new Employee { EmployeeID = 1009, FirstName = " Suresh", LastName = "Raina ", Title = " Associate", DOB = "30 /11 / 1992",
    DOJ = DateTime.Parse("23/ 6 / 2014"), City = "Chennai" },
new Employee { EmployeeID = 1010, FirstName = " Smriti", LastName = "Mandhana", Title = "Manager", DOB = "12 / 4 / 1998",
    DOJ = DateTime.Parse(" 20/4 / 2018"), City = " Pune" },

        };


            IEnumerable<Employee> Query1 = from Employee in Emp1
                                           select Employee;
            Console.WriteLine("All the Employee Details");

            foreach (Employee e in Query1)
            {
                Console.WriteLine(e.ToString());

            }


            IEnumerable<Employee> Query2 = from Employee in Emp1
                                           where Employee.City != "Mumbai"
                                           select Employee;
            Console.WriteLine("Whos location  is not mumbai");

            foreach (Employee e in Query2)
            {

                Console.WriteLine(e.ToString());
            }


            IEnumerable<Employee> Query = from Employee in Emp1
                                          where Employee.Title == "AsstManager"
                                          select Employee;
            Console.WriteLine("Who is working in  AsstManager");
            foreach (Employee e in Query)
            {

                Console.WriteLine(e.ToString());
            }


            IEnumerable<Employee> Query3 = from Employee in Emp1
                                           where Employee.LastName.StartsWith("S")
                                           select Employee;
            Console.WriteLine("Whos Name Start With S ");

            foreach (Employee e in Query3)
            {

                Console.WriteLine(e.ToString());
            }


            IEnumerable<Employee> Query4 = from Employee in Emp1
                                           where Employee.DOJ <= DateTime.Parse("01/01/2015")
                                           select Employee;


            Console.WriteLine("Who is Joined Before 2015 ");

            foreach (Employee e in Query4)
            {

                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();

        }
    }
}
