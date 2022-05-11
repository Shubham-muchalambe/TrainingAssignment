using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    interface Student
    {
        void ShowDetails(int id, string name);
    }
    class DaySholar : Student
    {
        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("Student Id is:{0}\nName of the student is:{1}", id, name);
        }
    }
    class Resident : Student
    {
        public void ShowDetails(int id, string name)
        {
            Console.WriteLine("Student id is:{0}\n Name of the Student is{1}", id, name);
        }
    }
    class InterfaeEg
    {
        static void Main()
        {
            Console.WriteLine("Dayscholar Details");
            Student d = new DaySholar();
            d.ShowDetails(1, "Anaya");

            Console.WriteLine("Resident Scholar Details");
            Student r = new Resident();
            r.ShowDetails(2, "Anay");
            Console.ReadLine();
        }
    }
}
