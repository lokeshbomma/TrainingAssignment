using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_7
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
            emplist.Add(new Employee(1001, "Malcolm", "Daruwalla", "Manager", DateTime.Parse("11/16/1984"), DateTime.Parse("8/6/2011"), "Mumbai"));
            emplist.Add(new Employee(1002, "Asdin", " Dhalla", "AsstManager", DateTime.Parse("08/20/1984"), DateTime.Parse("7/7/2012"), "Mumbai"));
            emplist.Add(new Employee(1003, "Madhavi ", "Oza", "Consultant", DateTime.Parse("11/14/1987") , DateTime.Parse("12/4/2015"), "Pune"));
            emplist.Add(new Employee(1004, "Saba", "Shaikh", "SE", DateTime.Parse("6/3/1990") , DateTime.Parse("2/2/2016"), "Pune"));
            emplist.Add(new Employee(1005, "Nazia", "Shaikh", "SE", DateTime.Parse("3/8/1991"), DateTime.Parse("2/2/2016"), "Mumbai"));
            emplist.Add(new Employee(1006, "Amit", "Pathak", "Consultant", DateTime.Parse("11/7/1989"), DateTime.Parse("8/8/2014"), "Chennai"));
            emplist.Add(new Employee(1007, "Vijay", "Natrajan", "Consultant ", DateTime.Parse("12/2/1989"), DateTime.Parse("1/6/2015"), "Mumbai"));
            emplist.Add(new Employee(1008, "Rahul", "Dubey", "Associate", DateTime.Parse("11/11/1993") , DateTime.Parse("6/11/2014"), "Chennai"));
            emplist.Add(new Employee(1009, "Suresh", "Mistry", "Associate", DateTime.Parse("8/12/1992") , DateTime.Parse("3/12/2014"), "Chennai"));
            emplist.Add(new Employee(1010, "Sumit", "Shah", "Manager", DateTime.Parse("4/12/1991"), DateTime.Parse("2/1/2016"), "Pune"));


            Console.WriteLine("all the employee whose date of birth is after 1/1/1990");
            var query1=from Employee in emplist where Employee.dob>DateTime.Parse("1 / 1 / 1990")
                       select Employee;
            foreach(var item1 in query1)
            {
                Console.WriteLine(item1.F_name + " " + item1.dob);
            }


            Console.WriteLine("\nlist of all the employee whose designation is Consultant and Associate");
            var query2=from Employee in emplist where Employee.title=="Consultant" || Employee.title == "Associate"
                       select Employee ;
            foreach (var item2 in query2)
            {
                Console.WriteLine(item2.F_name + " " + item2.title);
            }

            Console.WriteLine("\nAll the employee details");
            var Query = from Employee in emplist select Employee;
            foreach (var item4 in Query)
            {
                Console.WriteLine(item4.emp_id + " " + item4.F_name + " " + item4.L_name + " " + item4.title + " " + item4.doj + " " + item4.dob + " " + item4.city + " ");
            }

            var query3 = (from Emp in emplist
                          where Emp.city == "Chennai"
                          select Emp).Count();
            Console.WriteLine($"\nDisplay total number of employees belonging to “Chennai”: {query3}");

            
            Console.WriteLine("\ntotal number of employee who have joined after 1/1/2015");
            var query4 = from Employee in emplist where Employee.doj > DateTime.Parse("1 / 1 / 2015")
                       select Employee.F_name+Employee.doj;
            foreach(var item4 in query4)
            {
                Console.WriteLine(item4);
            }

            Console.WriteLine("\ntotal number of employee whose designation is not “Associate”");
            var query5=from Employee in emplist where Employee.title!="Associate"
                       select Employee.F_name + " " + Employee.title;
            foreach(var item5 in query5)
            {
                Console.WriteLine(item5);
            }

            Console.WriteLine("\nDisplay total number of employee who have joined after 1/1/2015 ");
            var query6 = (from Emp in emplist where Emp.doj > DateTime.Parse("1/1/2015")
                          select Emp).Count();
            Console.WriteLine($"{query6}");

            var Query8 = (from Emp in emplist
                          orderby Emp.city
                          select Emp).Count();
            Console.WriteLine($"\nDisplay total number of employee based on City:{Query8}");

            var Query9 = (from Emp in emplist
                          orderby Emp.city
                          orderby Emp.title
                          select Emp).Count();
            Console.WriteLine($"\nDisplay total number of employee based on city and title:{Query9}");

            var Query10 = (emplist.OrderByDescending(A => A.dob).Take(1));
            Console.WriteLine("\nDisplay total number of employee who is youngest in the list");
            foreach (var item6 in Query10)
            {
                Console.WriteLine(item6.doj + " " + item6.F_name);
            }

            Console.ReadLine();
        }

    }
   
    
}
