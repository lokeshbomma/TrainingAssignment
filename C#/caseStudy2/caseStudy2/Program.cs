using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caseStudy2
{
    public class Enroll
    {
        private string student;
        private string course;
        private DateTime enrollmentDate;

        //constructors & getters/setters

        public Enroll(string student, string course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }

        public void setStudent(string student)
        {
            this.student = student;
        }

        public void setCourse(string course)
        {
            this.course = course;
        }

        public void setEnrollmentDate(DateTime enrollmentDate)
        {
            this.enrollmentDate = enrollmentDate;
        }

        public String getStudent()
        {
            return student;
        }

        public String getCourse()
        {
            return course;
        }

        public DateTime getEnrollmentdate()
        {
            return enrollmentDate;
        }

    }

    class AppEngine
    {
        public void introduce(string course) {

        }

      - public void register(string student) {

        }

      - public Student[] listOfStudents() {

        }

      - public Course[] listOfCourses() {

        }

      - public void enroll(string student, string course) {

        }

      - public Enroll[] listOfEnrollments() {

        }
    }
    class App
    {
        static void Main(string[] args)
        {
        }
    }
}
