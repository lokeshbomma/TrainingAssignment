using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public Student(int Id, string Name, string DateOfBirth)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }
    }
    class Info
    {
        public void display(Student student)
        {
            Console.WriteLine($"The  student id {student.Id}, student name {student.Name}, student dob {student.DateOfBirth}");
        }

        public void display(Course course)
        {
            Console.WriteLine($"the course id {course.SID}, course name {course.SName}, course duration is {course.Duration}, course fee is {course.Fees}");
        }
        public void displayEnrolldetails(Enroll enroll)
        {
            display(enroll._student);
            display(enroll._course);
            Console.WriteLine(enroll._dateTime);
        }
    }
    class AppEngine
    {
        public void introduce(Course course)
        {
            Console.WriteLine(course.SID + " " + course.SName + " " + course.Duration + " " + course.Fees);
        }

        public void register(Student student)
        {

            Console.WriteLine(student.Id + " " + student.Name + " " + student.DateOfBirth);
        }


    }
    class Course
    {
        public int SID { get; set; }
        public string SName { get; set; }
        public string Duration { get; set; }
        public int Fees { get; set; }

        public Course(int SID, string SName, string Duration, int Fees)
        {
            this.SID = SID;
            this.SName = SName;
            this.Duration = Duration;
            this.Fees = Fees;
        }
    }
    class Enroll {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Student _student
        {
            get { return student; }
            set { student = value; }
        }
        public Course _course
        {
            get { return course; }
            set { course = value; }
        }
        public DateTime _dateTime
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;

        }

    }

    class App
    {
        Info info = new Info();

        public void Scenario1()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Scenario  1----------------");
            Student student = new Student(101, "akhil", "1-2-1998");
            Student student1 = new Student(102, "nikhil", "1-2-1992");
            Student student2 = new Student(103, "vinod", "1-23-1994");
            info.display(student);
            info.display(student1);
            info.display(student2);
        }

        public void Scenario2()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Scenario  2----------------");
            Student[] std = new Student[3];
            std[0] = new Student(104, "vijay", "1-2-1993");
            std[1] = new Student(105, "lokesh", "1-2-1996");
            std[2] = new Student(106, "sai", "1-23-1995");
            for (int i = 0; i < std.Length; i++)
            {
                info.display(std[i]);
            }
        }
        public void Scenario3()
        {
            Console.WriteLine();
            Console.WriteLine("----------------Scenario  3----------------");
            Console.WriteLine("Enter the number of details to be inserted");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[n];
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Enter the Student ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter the Student DateOfBirth:");
                string DateOfBirth = Console.ReadLine();
                std[i] = new Student(Id, Name, DateOfBirth);
                
            }
            for (int i = 0; i < std.Length; i++)
            {
                info.display(std[i]);
            }
        }

        public void CourseScenario1()
        {
            Console.WriteLine();
            Console.WriteLine("-------------Course-Scenario1-------------");
            Course course = new Course(1, "JS", "1 Month", 5000);
            Course course1 = new Course(2, "HTML", "1 Month", 5000);
            Course course2 = new Course(3, "C Sharp", "1 Month", 7000);
            info.display(course);
            info.display(course1);
            info.display(course2);
        }
        public void CourseScenario2()
        {
            Console.WriteLine();
            Console.WriteLine("---------------Course-Scenario2----------------");
            Info info = new Info();
            Course[] crs = new Course[3];
            crs[0] = new Course(4, "C Language", "2 Months", 8000);
            crs[1] = new Course(5, "R Language", "1 Month", 4000);
            crs[2] = new Course(6, "Python", "2 Months", 5000);
            for (int i = 0; i < crs.Length; i++)
            {
                info.display(crs[i]);
            }
        }

        public void CourseScenario3()
        {
            Console.WriteLine();
            Console.WriteLine("--------------Course-Scenario3----------------");
            Console.WriteLine("Enter the number of details to be inserted");
            int n = Convert.ToInt32(Console.ReadLine());
            Course[] crs = new Course[n];
            for (int i = 0; i < crs.Length; i++)
            {
                Console.WriteLine("Enter Course ID:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name:");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Course Duration:");
                string Duration = Console.ReadLine();
                Console.WriteLine("Enter Course Fee:");
                int fee = int.Parse(Console.ReadLine());
                crs[i] = new Course(Id, Name, Duration, fee);
            }
            for (int i = 0; i < crs.Length; i++)
            {
                info.display(crs[i]);
            }
        }


        static void Main(string[] args)
        {

            App a = new App();
            a.Scenario1();
            a.Scenario2();
            a.Scenario3();

            a.CourseScenario1();
            a.CourseScenario2();
            a.CourseScenario3();

            Console.Read();
        }
    }
}