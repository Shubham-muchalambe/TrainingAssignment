using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniproject
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }

        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            DOB = dob;
        }

    }

    public class Course
    {
        public int Id;
        public string Name;
        public int duration;
        public float fees;


        public Course(int id, string name, int dura, float fee)
        {
            this.Id = id;
            this.Name = name;
            this.duration = dura;
            this.fees = fee;
        }

    }
    class App
    {
        info info = new info();
        public void Scenerio1()
        {
            Student student = new Student(111, "shubham", "19/10/1998");
            Student student1 = new Student(112, "devidas", "21/05/1999");
            Student student2 = new Student(113, "muchalambe", "21/05/1997");

            info.display(student);
            info.display(student1);
        }

        public void Scenerio2()
        {
            Student[] students = new Student[2];
            students[0] = new Student(1001, "virat", "10/01/1998");
            students[1] = new Student(1002, "kohli", "12/05/1999");
            students[2] = new Student(1003, "rahul", "12/12/1990");
            for (int i = 0; i < students.Length; i++)
            {
                info.display(students[i]);

            }
        }

        public void Scenerio3()
        {
            Console.WriteLine("Enter the no.of students you want");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[n];
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter Student Id,Name and Date of Birth");
                student[i] = new Student(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
            }
            for (int i = 0; i < student.Length; i++)
            {
                info.display(student[i]);
            }



        }
        static void Main(string[] args)
        {
            App app = new App();
           
            AppEngine engine = new AppEngine();
            
            new UserInterFace().showFirstScreen();

            Console.Read();
        }
    }
}