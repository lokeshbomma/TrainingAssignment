using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign8
{
    public class Employee
    {
        public int emp_id;
        public string F_name;
        public string L_name;
        public string title;
        public DateTime dob;
        public DateTime doj;
        public string city;
        public Employee(int emp_id, string F_name, String L_name, string title, DateTime dob, DateTime doj, string city)
        {
            this.emp_id = emp_id;
            this.F_name = F_name;
            this.L_name = L_name;
            this.title = title;
            this.dob = dob;
            this.doj = doj;
            this.city = city;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", Convert.ToDateTime("16/11/1984"), DateTime.Parse("8/6/2011"), "Mumbai"));
            emplist.Add(new Employee(1002, "Asdin", " Dhalla", "AsstManager", DateTime.Parse("20/08/1984"), DateTime.Parse("7/7/2012"), "Mumbai"));
            emplist.Add(new Employee(1003, "Madhavi ", "Oza", "Consultant", DateTime.Parse("14/11/1987"), DateTime.Parse("12/4/2015"), "Pune"));
            emplist.Add(new Employee(1004, "Saba", "Shaikh", "SE", DateTime.Parse("3/6/1990"), DateTime.Parse("2/2/2016"), "Pune"));
            emplist.Add(new Employee(1005, "Nazia", "Shaikh", "SE", DateTime.Parse("8/3/1991"), DateTime.Parse("2/2/2016"), "Mumbai"));
            emplist.Add(new Employee(1006, "Amit", "Pathak", "Consultant", DateTime.Parse("7/11/1989"), DateTime.Parse("8/8/2014"), "Chennai"));
            emplist.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant ", DateTime.Parse("2/12/1989"), DateTime.Parse("1/6/2015"), "Mumbai"));
            emplist.Add(new Employee(1008, "Rahul", "Dubey", "Associate", DateTime.Parse("11/11/1993"), DateTime.Parse("6/11/2014"), "Chennai"));
            emplist.Add(new Employee(1009, "Suresh", "Mistry", "Associate", DateTime.Parse("12/8/1992"), DateTime.Parse("3/12/2014"), "Chennai"));
            emplist.Add(new Employee(1010, "Sumit", "Shah", "Manager", DateTime.Parse("12/4/1991"), DateTime.Parse("2/1/2016"), "Pune"));





            Console.WriteLine("list of all the employee whose designation is Consultant and Associate");
            var query2 = from Employee in emplist
                         where Employee.title == "Consultant"
                         select Employee.F_name;
            foreach (var item2 in query2)
            {
                Console.WriteLine(item2);
            }

        }
    }
}
