using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateNames();
            Console.ReadKey();
        }
        public void CreateNames()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ADMW46ZLPC1574\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=true");
                SqlCommand cmd = new SqlCommand("create table names(fname varchar(55),lname varchar(55))",con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("query executed");

            }
            catch(Exception e)
            {
                Console.WriteLine("something went wrong" +e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
