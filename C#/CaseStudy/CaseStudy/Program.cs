using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Program
    {
        public class Student
        {
            public int id;
            public string name;
            public string dob;

            public Student(int id, string name, string dob)
            {
                this.id = id;
                this.name = name;
                this.dob = dob;
            }
            public Student()
            {

            }

            public void setId(int id)
            {
                this.id = id;
            }
            public int getId()
            {
                return id;
            }
            public void setName(string name)
            {
                this.name = name;
            }
            public string getName()
            {
                return name;
            }
            public void setDob(string dob)
            {
                this.dob = dob;
            }
            public string getDob()
            {
                return dob;
            }


        }
        public class Info
        {
            public void display(Student student, Student student2, Student student3, Student student4)
            {
                //Code here to display the details of given student
                Console.WriteLine("\nthe details of the given students are: ");
                Console.WriteLine($"the student name is {student.getName()} with id {student.getId()} and dob {student.getDob()}");
                Console.WriteLine($"the student name is {student2.getName()} with id {student2.getId()} and dob {student2.getDob()}");
                Console.WriteLine($"the student name is {student3.getName()} with id {student3.getId()} and dob {student3.getDob()}");
                Console.WriteLine($"the student name is {student4.getName()} with id {student4.getId()} and dob {student4.getDob()}");

            }

        }
        
        public class App
        {
            public void scenerio1()
            {
                Student student = new Student(1, "lokesh", "22/2/1999");
                Student student2 = new Student(2, "rakesh", "21/6/1997");
                Student student3 = new Student(3, "vijay", "19/3/1996");
                Student student4 = new Student(4, "krishna", "12/5/1998");

                Info info = new Info();
                info.display(student, student2, student3, student4);
            }
            public class Course
            {
                int id;
                string name;
                string duration="6months";
                int fees=1000;
                public string course;
                public void display()
                {
                    Console.WriteLine("\n========successfully enrolled course===========");
                }
            }

            public void scenerio2()
            {
                Console.WriteLine("\nenter the number of students data you want to store ");
                int n = int.Parse(Console.ReadLine());
                string[] student = new string[n];

                string []name=new string[n];
                int []id=new int[n];
                string []course=new string[n];
                

                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine("\nenter the student name " + (i + 1));
                    name[i] = Console.ReadLine();
                    

                    Console.WriteLine("\nenter the student id " + (i + 1));
                    id[i]= int.Parse(Console.ReadLine());

                    Console.WriteLine("\nenter the course " + (i + 1));
                    course[i] = Console.ReadLine();

                    
                }
                Console.WriteLine("\nthe details: ");

                for (int j = 0; j <n; j++)
                {
                    Console.WriteLine("student name is " + name[j] +  " with id " + id[j] + " has enrolled this " + course[j] + " course ");
                }
            }
            public static void Main(string[] args)
            {
                App app = new App();
                app.scenerio1();
                app.scenerio2();
                Course course = new Course();
                course.display();
                Console.ReadLine();
            }
        }
       
    }
}
