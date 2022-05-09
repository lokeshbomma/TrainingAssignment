using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1
{
    public delegate string MyDelegate(string str);
    class EventsEg2
    {
        public event MyDelegate MyEvent;



        public EventsEg2()
        {
            this.MyEvent += new MyDelegate(this.WelcomeUser);
            this.MyEvent += new MyDelegate(this.DisplayName);
            this.MyEvent += new MyDelegate(this.DisplayCompany);
        }



        public string WelcomeUser(string ename)
        {
            return "Welcome " + " " + ename + "to the  zensar world  ";
        }



        public string DisplayName(string name)
        {
            return name;
        }

        public string DisplayCompany(string Cname)
        {
            return Cname;
        }



        static void Main()
        {
            EventsEg2 ec2 = new EventsEg2();
            Console.WriteLine("enter the name ");

            Console.WriteLine(ec2.MyEvent(Console.ReadLine()));
            Console.WriteLine(ec2.MyEvent("zensar"));
            Console.Read();
        }
    }    
}
