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
                    Console.WriteLine($"name is {name} has booked  with DateofTravel {DateofTravel}");
                    if (no_of_tickets > 5)
                    {
                        Console.WriteLine("cannot book more than 5 tickets");
                    }
                    else
                    {
                        Console.WriteLine("Ticket Booked Successfully");
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
