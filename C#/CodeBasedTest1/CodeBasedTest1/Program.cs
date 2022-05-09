using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTest1
{
    internal class Program
    {
        class Passenger
        {
            string name;
            int age;
            DateTime DateofTravel;
            int no_of_tickets;
            public Passenger(string name,int age,DateTime DateofTravel)
            {
                this.name = name;
                this.age = age;
                this.DateofTravel = DateofTravel;
            }
            public void TicketBooking(int no_of_tickets)
            {

                try
                {
                    
                    if (no_of_tickets > 5)
                    {
                        Console.WriteLine("cannot book more than 5 tickets");
                        
                    }
                    else if(no_of_tickets==0)
                    {
                        Console.WriteLine("enter tickets atleast 1");

                    }
                    else
                    {
                        Console.WriteLine("tickets booked succesfully");
                        Console.WriteLine($"the tickets are {no_of_tickets}");
                    }
                    
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine("enter no_of_tickets in integers only");
                }

            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                try
                {
                    Passenger passenger = new Passenger("lokesh", 22, Convert.ToDateTime("5/5/2022"));
                    Console.WriteLine("enter the number of tickets you want to book: ");
                    passenger.TicketBooking(int.Parse(Console.ReadLine()));
                }catch (FormatException ex)
                {
                    Console.WriteLine("not a valid imput");
                }

                Console.ReadLine();

            }
        }
        
    }
}
