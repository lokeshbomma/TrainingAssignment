using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;




namespace ConsoleApp2
{
    public class Program
    {
        
       /* public static void insertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ADMW46ZLPC1574\\SQLEXPRESS;Initial Catalog=Fb;Integrated Security=True");
                //SqlCommand cm = new SqlCommand("insert into student (id, name, email, join_date) values ('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);
                SqlCommand cmd = new SqlCommand("insert into employee(id,name,desig) values (1,'lokesh','jr')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("inserted");
            }
            catch(Exception e)
            {
                Console.WriteLine("oops");
            }
            finally
            {
                con.Close();
            }
        }*/
        public static void  dispData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=ADMW46ZLPC1574\\SQLEXPRESS;Initial Catalog=Fb;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from employee",con);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["id"]+""+dr["name"]+""+dr["desig"]);
                }

                Console.WriteLine("done");

            }catch(Exception e)
            {
                Console.WriteLine("wrongs");
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            dispData();
            //insertData();
            Console.ReadLine();
        }
    }
}
