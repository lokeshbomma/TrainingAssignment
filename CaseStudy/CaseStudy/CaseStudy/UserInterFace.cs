using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class UserInterFace : IUseraction
    {
        AppEngine engine = new AppEngine();

        string res;
        public void showFirstScreen()
        {
            do
            {


                Console.WriteLine("Welcome to SMS(Student Mgmt. System) v1.0");
                Console.WriteLine("Tell us who you are : \n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice ( 1 or 2 ) : ");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        showStudentScreen();
                        break;
                    case 2:
                        showAdminScreen();
                        break;
                    default:
                        Console.WriteLine("Choose Valid Option");
                        break;
                }
                Console.WriteLine("Do you want to continue Main Screen:Y or N");
                res = Console.ReadLine();
            }
            while ((res == "Y") || (res == "y"));
        }

        public void showStudentScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Check your Details(Existing User)\n2.Registration(New User)\n3.Search Available Courses\n4.Enroll to Course in List");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        // Checks  Particular student details
                        engine.ParticularStudent();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2://New registration
                        this.showStudentRegistrationScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 3:
                        //Showcase all available courses
                        Console.WriteLine("--------------------List of Courses------------------------");
                        engine.AllCoursesLists();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 4:
                        //Student enrolling to particular course
                        engine.EnrollDetailslists();
                        Console.WriteLine("You have successfully enrolled you may Exit the Screen now");
                        break;
                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Student Screen:Y or N");
                string res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));
        }
        public void showAdminScreen()
        {
            do
            {
                Console.WriteLine("Select: \n1.Introduce New Course\n2.Courses Available\n3.Update Course Details\n4.Retrieve Particular Course in List\n5.Deleting Existing Student\n6.Delete Course\n7.Update Student Details\n8.All Registered Students");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        //If any new course want to add for Organization
                        this.introduceNewCourseScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 2:
                        //list of existing courses
                        Console.WriteLine("-------------All Available Courses in Institute-------------------");
                        showAllCoursesScreen();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 3:
                        //updates in Course structure
                        engine.updateCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 4:
                        //getting particular course details
                        engine.ParticularCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 5:
                        //deletes particular student
                        engine.DeleteStudents();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 6:
                        //deletes existing course only that are not enrolled by any students
                        engine.DeleteCourse();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 7:
                        //modify existing student details
                        engine.UpdateStudent();
                        Console.WriteLine("Action Completed you may Exit....!");
                        break;
                    case 8:
                        //Gives ALL Students Details
                        showAllStudentsScreen();
                        break;

                    default:
                        Console.WriteLine("Enter valid Option....!");
                        break;
                }
                Console.WriteLine("Do you want to continue Admin Screen:Y or N");
                res = Console.ReadLine();
            } while ((res == "Y") || (res == "y"));

        }
        public void showAllStudentsScreen()
        {
            Console.WriteLine("List of All Student Details : ");
            engine.AllStudentDetails();
        }
        public void showStudentRegistrationScreen() // Execute the register method of AppEngine class
        {
            Console.WriteLine("You are Entering into Student Registration form :");
            Console.WriteLine("Enter the Student Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Student DOB:");
            string dob = Console.ReadLine();
            engine.register(new Student(id, name, dob));
        }

        public void introduceNewCourseScreen()
        {
            engine.insertingCourse();
        }
        public void showAllCoursesScreen()
        {
            Console.WriteLine("List of all courses : ");
            engine.AllCoursesLists();
        }
    }
}
