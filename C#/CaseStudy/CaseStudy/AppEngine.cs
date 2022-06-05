﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CaseStudy
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static SqlConnection getConnection()
        {
            con = new SqlConnection(@"data source = ADMW46ZLPC1574\SQLEXPRESS; Initial Catalog=casestudy; Integrated Security=True");
            con.Open();
            return con;
        }
        public void introduce(Course course)
        {
            Console.WriteLine(course.Id + " " + course.Name + " " + course.duration + " " + course.fees);
        }

        public void register(Student student)
        {

            Console.WriteLine(student.Id+" "+student.Name+" "+student.DOB);

        }

        public void studentregister(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = getConnection();

                cmd = new SqlCommand("insert into Students values(@StudentId,@SName,@DOB)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.Id);
                cmd.Parameters.AddWithValue("@SName", student.Name);
                cmd.Parameters.AddWithValue("@DOB", student.DOB);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row inserted");
                else
                    Console.WriteLine("Not Inserted");


            }
            catch (SqlException e)
            {
                Console.WriteLine(e); //instead throw user defined exception
            }
            finally
            {

                con.Close();
            }
        }

        public Student[] listOfStudents()
        {
            Student[] students = new Student[3]
            {
                new Student(1,"lokeshr","28/05/2000"),
                new Student(2,"rajesh","23/06/1999"),
                new Student(3,"rakesh","25/08/1972")
            };

            return students;
        }

        /*public List<Student> listOfStudents()
        {
            List<Student> students = new List<Student>()
            {
               new Student(1,"lokehsh","28/05/2000"),
               new Student(2,"rajesh","23/06/1999"),
               new Student(3,"rakesh","25/08/1972")
            };

            return students;
        }*/

        public Course[] listOfCourses()
        {
            Course[] courses = new Course[3]
           {
                new Course(101,"Java",35,15000.00f),
                new Course(102,"DotNet",60,20000.00f),
                new Course(103,"Python",30,12000.00f)
           };
            return courses;
        }

        //public List<Course> listOfCourses()
        //{
        //    List<Course> courses = new List<Course>()
        //   {
        //        new Course(101,"Java",35,15000.00f),
        //        new Course(102,"DotNet",60,20000.00f),
        //        new Course(103,"Python",30,12000.00f)
        //   };
        //    return courses;
        //}

        public void enroll(Student student, Course course)
        {
            Info info = new Info();
            info.display(student);
            info.display(course);
        }

        public Enroll[] listOfEnrollments()
        {
            Enroll[] enroll = new Enroll[3]
            {

              new Enroll(new Student(1, "lokesh", "28/05/2000"), new Course(101, "Java", 30, 15000.00f), Convert.ToDateTime(DateTime.Now)),
              new Enroll(new Student(2, "rajesh", "23/06/1999"), new Course(102, "Dotnet", 60, 20000.00f), Convert.ToDateTime(DateTime.Now)),
              new Enroll(new Student(3, "rakesh", "25/08/1972"), new Course(103, "Python", 30, 12000.00f), Convert.ToDateTime(DateTime.Now))
            };
            return enroll;
        }

        //public List<Enroll> listOfEnrollments()
        //{
        //    List<Enroll> enroll = new List<Enroll>()
        //    {

        //      new Enroll(new Student(1, "lokesh", "28/05/2000"), new Course(101, "Java", 30, 15000.00f), Convert.ToDateTime(DateTime.Now)),
        //      new Enroll(new Student(2, "rajesh", "23/06/1999"), new Course(102, "Dotnet", 60, 20000.00f), Convert.ToDateTime(DateTime.Now)),
        //      new Enroll(new Student(3, "rakesh", "25/08/1972"), new Course(103, "Python", 30, 12000.00f), Convert.ToDateTime(DateTime.Now))
        //    };
        //    return enroll;
        //}

        public void AllStudentDetails()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("Select * from Students", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void UpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter the Student id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Student DOB :");
                string dob = Console.ReadLine();
                con = getConnection();
                cmd = new SqlCommand("update Students set SName=@sname,DOB=@dob where StudentId=@stdId");
                cmd.Parameters.AddWithValue("@stdId", id);
                cmd.Parameters.AddWithValue("@sname", name);
                cmd.Parameters.AddWithValue("@dob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteStudents()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete Students where StudentId=@stdid", con);
                cmd.Parameters.AddWithValue("@stdid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Deleted Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularStudent()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from Students where StudentId =@stdid", con);
                cmd.Parameters.AddWithValue("@stdid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllCoursesLists()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from Courses", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from Courses where CId=@Cid");
                cmd.Parameters.AddWithValue("@cid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void updateCourse()
        {
            try
            {
                Console.WriteLine("Enter the Course id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Duration :");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Fees :");
                float fee = Convert.ToSingle(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("update Courses set Cduration=@cd,Cfees=@fees where CId=@cid");
                cmd.Parameters.AddWithValue("@cid", id);
                cmd.Parameters.AddWithValue("@Cd", duration);
                cmd.Parameters.AddWithValue("@fees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete Courses where CId=@cid", con);
                cmd.Parameters.AddWithValue("@cid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void insertingCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration : ");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Couration Fees : ");
                float fee = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into Courses values(@CId,@CName,@Cduration,@Cfees)", con);
                cmd.Parameters.AddWithValue("@CId", id);
                cmd.Parameters.AddWithValue("CName", name);
                cmd.Parameters.AddWithValue("@Cduration", dur);
                cmd.Parameters.AddWithValue("@Cfees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void EnrollDetailslists()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter the Student Id :");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course id :");
                int cid = Convert.ToInt32(Console.ReadLine());
                DateTime Enrolldate = DateTime.UtcNow;
                cmd = new SqlCommand("insert into EnrollDetails values(@Cid,@StuId,@EnrollDate)", con);
                cmd.Parameters.AddWithValue("@Cid", cid);
                cmd.Parameters.AddWithValue("@StuId", sid);
                cmd.Parameters.AddWithValue("@EnrollDate", Enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted ");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
