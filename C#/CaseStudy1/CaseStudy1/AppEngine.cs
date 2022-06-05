using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace caseStudy1
{
    class AppEngine
    {



        public static SqlCommand cmd;
        public static SqlConnection con;
        public static SqlDataReader dr;



        public static SqlConnection getConnection()
        {



            con = new SqlConnection(@"data source = ADMW46ZLPC1574\SQLEXPRESS; Initial Catalog=StudentManagementSystem; Integrated Security=True");
            con.Open();
            return con;
        }

        public void Show_all_registered_Students()
        {



            con = getConnection();
            cmd = new SqlCommand("Select *from Student", con);
            int res = cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Student Details : ");
                Console.WriteLine();
                Console.WriteLine("Student Id : " + " " + dr[0]);
                Console.WriteLine("Student Name :" + " " + dr[1]);
                Console.WriteLine("Student DOB :" + " " + dr[2]);



            }
        }



        public void New_StudentRegistration()
        {
            int n;
            Console.WriteLine("Enter No. Of Student Details you Want to insert...!");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                con = getConnection();
                Console.WriteLine("Enter Student Details StdId,StdName,sDOB");
                int Id;
                string Name;
                DateTime DateOfBirth;
                Id = Convert.ToInt32(Console.ReadLine());
                Name = Console.ReadLine();
                DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                cmd = new SqlCommand("insert into Student values (@StdId,@StdName,@sDOB)", con);
                cmd.Parameters.AddWithValue("@StdId", Id);
                cmd.Parameters.AddWithValue("@StdName", Name);
                cmd.Parameters.AddWithValue("@sDOB", DateOfBirth);
                int res3 = cmd.ExecuteNonQuery();
                if (res3 > 0)
                {
                    Console.WriteLine("Student details inserted Sucessfully");
                }
                else
                    Console.WriteLine("Please enter valid Student details");
            }



        }



        public void Introducing_NewCourse()
        {



            int no_Of_Courses;
            Console.WriteLine("Enter no. of courses you want to add : ");
            no_Of_Courses = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < no_Of_Courses; i++)
            {
                con = getConnection();
                Console.WriteLine("Enter Course Details CourseId,CourseName,Duration,Fee_Structure");
                int CId, Fees, Duration;
                string CName;
                CId = Convert.ToInt32(Console.ReadLine());
                CName = Console.ReadLine();
                Duration = Convert.ToInt32(Console.ReadLine());
                Fees = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("insert into Courses values (@cid,@CName,@dur,@cfee)", con);
                cmd.Parameters.AddWithValue("@cid", CId);
                cmd.Parameters.AddWithValue("@CName", CName);
                cmd.Parameters.AddWithValue("@dur", Duration);
                cmd.Parameters.AddWithValue("@cfee", Fees);
                int res4 = cmd.ExecuteNonQuery();
                if (res4 > 0)
                {
                    Console.WriteLine("Course details inserted Sucessfully");
                }
                else
                    Console.WriteLine("Please enter valid Course details");
            }
        }



        public void Available_Courses()
        {



            con = getConnection();
            cmd = new SqlCommand("Select * from Courses", con);
            int res6 = cmd.ExecuteNonQuery();
            Console.WriteLine("Courses Available In the Institution are...!");
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine("Course Details : ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Course Id : " + " " + dr[0]);
                Console.WriteLine("Course Name :" + " " + dr[1]);
                Console.WriteLine("Course Duration :" + " " + dr[2]);
                Console.WriteLine("Course Fees :" + " " + dr[3]);



            }



        }



        public void enrolling_courses()
        {
            con = getConnection();
            int SId, CID;
            Console.WriteLine("Enter Student Id :");
            SId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Id :");
            CID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Date :");
            DateTime enrolldate = Convert.ToDateTime(Console.ReadLine());
            cmd = new SqlCommand("insert into Enroll values(@Cid,@StdId,@EnrollDate)", con);
            cmd.Parameters.AddWithValue("@Cid", CID);
            cmd.Parameters.AddWithValue("@StdId", SId);
            cmd.Parameters.AddWithValue("@EnrollDate", enrolldate);
            int res5 = cmd.ExecuteNonQuery();
            if (res5 > 0)
            {
                Console.WriteLine("Congrats!! Course Sucessfully Enrolled");
            }
            else
                Console.WriteLine("Please enter valid details");
        }



        public void Student_Screen()
        {
            try
            {



                con = getConnection();
                int SId;
                Console.WriteLine("Enter Student Id");
                SId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from Student where StdId=@StdId", con);
                cmd.Parameters.AddWithValue("@StdId", SId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Details : ");
                    Console.WriteLine();
                    Console.WriteLine("Student Id : " + " " + dr[0]);
                    Console.WriteLine("Student Name :" + " " + dr[1]);
                    Console.WriteLine("Student DOB :" + " " + dr[2]);



                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Students Doesn't Exist...Start New Registration", e.Message);
            }



        }



        public void UpdateStudentData()
        {
            con = getConnection();
            Console.WriteLine("Enter Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Student DOB:");
            string DateOfBirth = Console.ReadLine();
            cmd = new SqlCommand("update Student set Stdname=@S_Name,sDOB=@S_Dob where StdId=@Std_id", con);
            cmd.Parameters.AddWithValue("@Std_id", Id);
            cmd.Parameters.AddWithValue("@S_Name", Name);
            cmd.Parameters.AddWithValue("@S_Dob", DateOfBirth);
            int res7 = cmd.ExecuteNonQuery();
            if (res7 > 0)
            {
                Console.WriteLine("Student details Updated Sucessfully...");
            }
            else
                Console.WriteLine("Please enter valid student details...");
        }



        public void DeleteStudentData()
        {
            con = getConnection();
            Console.WriteLine("Enter Student ID:");
            int Id = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("delete from Student where StdId=@StdId", con);
            cmd.Parameters.AddWithValue("@StdId", Id);
            int res8 = cmd.ExecuteNonQuery();
            if (res8 > 0)
            {
                Console.WriteLine("Student data Deleted Sucessfully");
            }
            else
                Console.WriteLine("Please enter valid student details");
        }
        public void DeleteCourseData()
        {
            con = getConnection();
            int CId;
            Console.WriteLine("Enter Course id:");
            CId = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("Delete from Courses where Cid=@Cid", con);
            cmd.Parameters.AddWithValue("@Cid", CId);
            int res9 = cmd.ExecuteNonQuery();
            if (res9 > 0)
            {
                Console.WriteLine("Course Details Deleted Sucessfully...");
            }
            else
                Console.WriteLine("Please enter valid Course details...");
        }
        public void UpdateCourseData()
        {
            con = getConnection();
            int CId, Fees, Duration;

            Console.WriteLine("Enter Cid:");
            CId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Duration:");
            Duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Fees:");
            Fees = Convert.ToInt32(Console.ReadLine());
            cmd = new SqlCommand("update Courses set dur=@dur,cfee=@cfee where Cid=@Cid", con);
            cmd.Parameters.AddWithValue("@dur", Duration);
            cmd.Parameters.AddWithValue("@cfee", Fees);
            cmd.Parameters.AddWithValue("@Cid", CId);
            int res10 = cmd.ExecuteNonQuery();
            if (res10 > 0)
            {
                Console.WriteLine("Course details Updated Sucessfully...");
            }
            else
                Console.WriteLine("Please enter valid Course details...");
        }




        public void Check_Particular_Course()
        {
            try
            {



                con = getConnection();
                int CId;
                Console.WriteLine("Enter Course Id");
                CId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select *from Courses where Cid=@Cid", con);
                cmd.Parameters.AddWithValue("@Cid", CId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Particular Course Details : ");
                    Console.WriteLine();
                    Console.WriteLine("Course Id : " + " " + dr[0]);
                    Console.WriteLine("Course Name :" + " " + dr[1]);
                    Console.WriteLine("Course Duration :" + " " + dr[2]);
                    Console.WriteLine("Course Fees :" + " " + dr[3]);
                    Console.WriteLine();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Course Doesn't Exist....!", se);
            }



        }
    }
}
