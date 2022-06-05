using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseStudy1
{
    class Program
    {



        public static void scenario1_Student()
        {
            Info i1 = new Info();



            Student s1 = new Student(101, "lokesh", "22/ 2 / 1999");
            i1.display(s1);
            Student s2 = new Student(102, "Vijay", "01 / 02 / 1998");
            i1.display(s2);
            Student s3 = new Student(103, "mani", "12 / 04 / 1996");
            i1.display(s3);
            Student s4 = new Student(104, "Rakesh", " 17 / 04 / 1999");
            i1.display(s4);
            Student s5 = new Student(105, "Kiran", " 16 / 06 / 1999");
            i1.display(s5);
        }



        public static void scenario2_Student()
        {
            Info i2 = new Info();



            Student[] student = new Student[5];
            student[0] = new Student(106, "satish", "04/05/2000");
            student[1] = new Student(107, "Swaraj", "06/05/1999");
            student[2] = new Student(108, "Ranga", "08/04/2004");
            student[3] = new Student(109, "Krish", "03/02/2005");
            student[4] = new Student(110, "Trinadh", "01/09/2006");



            for (int i = 0; i < student.Length; i++)
            {
                i2.display(student[i]);
                Console.WriteLine();
            }
        }



        public static void scenario3_Student()
        {
            Student[] stud = new Student[2];
            for (int i = 0; i < stud.Length; i++)
            {
                int id;
                string name, Dob;
                Console.WriteLine("Enter Student ID : ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Student Date of Birth : ");
                Dob = Console.ReadLine();
                Console.WriteLine();
                stud[i] = new Student(id, name, Dob);
            }



            Console.WriteLine();
            Console.WriteLine(" Entered Students details :");
            Info i3 = new Info();



            for (int i = 0; i < stud.Length; i++)
            {
                i3.display(stud[i]);
                Console.WriteLine();
            }
        }




        public static void scenario1_Course()
        {
            Info i2 = new Info();
            Course c1 = new Course(1, "Java", 33, 40000);
            i2.display(c1);
            Course c2 = new Course(2, "Python", 39, 10000);
            i2.display(c2);
            Course c3 = new Course(203, "C", 45, 35000);
            i2.display(c3);
            Course c4 = new Course(204, "Salesfoorce", 70, 25000);
            i2.display(c4);
        }



        public static void scenario2_Course()
        {
            Info i2 = new Info();
            Course[] course = new Course[5];
            course[0] = new Course(205, "BBA", 70, 12000);
            course[1] = new Course(206, "BE", 70, 12000);
            course[2] = new Course(207, "BSC", 70, 12000);
            course[3] = new Course(208, "CME", 70, 12000);
            course[4] = new Course(209, "IE", 70, 12000);



            for (int i = 0; i < course.Length; i++)
            {
                i2.display(course[i]);
                Console.WriteLine();
            }
        }



        public static void scenario3_Course()
        {
            Course[] course = new Course[2];
            for (int i = 0; i < course.Length; i++)
            {
                int id;
                string name;
                float duration, fees;



                Console.WriteLine("Enter Course ID : ");
                id = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("Enter Course Name : ");
                name = Console.ReadLine();



                Console.WriteLine("Enter Course Duration in days : ");
                duration = float.Parse(Console.ReadLine());



                Console.WriteLine("Enter Course Fees : ");
                fees = float.Parse(Console.ReadLine());
                Console.WriteLine();
                course[i] = new Course(id, name, duration, fees);



            }
            Console.WriteLine();
            Console.WriteLine("Entered Course Details :");



            Info i3 = new Info();
            for (int i = 0; i < course.Length; i++)
            {
                i3.display(course[i]);
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            //Console.WriteLine("**************STUDENTS DETAILS*************");
            //Console.WriteLine();
            //Console.WriteLine("-----------------Scenario 1----------------");
            //Console.WriteLine();
            //scenario1_Student();
            //Console.WriteLine("-----------------Scenario 2----------------");
            //Console.WriteLine();
            //scenario2_Student();
            //Console.WriteLine("-----------------Scenario 3----------------");
            //Console.WriteLine();
            //scenario3_Student();
            //Console.WriteLine("***************COURSE DETAILS*************");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("-----------------Scenario 1----------------");
            //Console.WriteLine();
            //scenario1_Course();
            //Console.WriteLine("-----------------Scenario 2----------------");
            //Console.WriteLine();
            //scenario2_Course();
            //Console.WriteLine("-----------------Scenario 3----------------");
            //Console.WriteLine();
            //scenario3_Course();





            AppEngine ae = new AppEngine();



            //Enroll e = new Enroll();
            //ae.introduce();
            //ae.register();



            Institute_Details ID = new Institute_Details();
            ID.showFirstScreen();




            //ae.enroll();
            Console.Read();
        }



    }
}
